
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class XfrmDepartamentos
    

    Private Sub XfrmDepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DSDeptoMuni.TA_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.TA_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.TA_DEPARTAMENTOS)
       
        ActualizarGrid()
       
        Me.IMDEPARTAMENTOSBindingSource.AddNew()
    End Sub

    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_DEPARTAMENTOS1' table. You can move, or remove it, as needed.
        Me.TA_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.TA_DEPARTAMENTOS)
    End Sub
    Sub guardar()



        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMDEPARTAMENTOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSDeptoMuni.IM_DEPARTAMENTOSRow In DSDeptoMuni.IM_DEPARTAMENTOS
                'SI ES UN NUEVO REGITRO
                If _datar.RowState = DataRowState.Added Then
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now
                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                End If
            Next

            'AGREGANDO LA INFORMACION A LA BASE DE DATOS
            Me.IM_DEPARTAMENTOSTableAdapter.Update(Me.DSDeptoMuni.IM_DEPARTAMENTOS)

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarGrid()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub
    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMDEPARTAMENTOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMDEPARTAMENTOSBindingSource.AddNew()
        Catch ex As Exception

        End Try

    End Sub
    Sub Eliminar()


        Try
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)

            Dim Deptosrow As DSDeptoMuni.IM_DEPARTAMENTOSRow

            Deptosrow = Me.DSDeptoMuni.IM_DEPARTAMENTOS.FindByCODIGO_DEPARTAMENTO(cellValue)

            Deptosrow.Delete()

            Me.IM_DEPARTAMENTOSTableAdapter.Update(Me.DSDeptoMuni.IM_DEPARTAMENTOS)
            ActualizarGrid()
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try


    End Sub



    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub



    Private Sub BteBusqueda_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BteBusqueda.EditValueChanged
        'FILTRO DE BUSQUEDA DE LOS DATOS
        Me.TA_DEPARTAMENTOSTableAdapter.FillBy(Me.DSDeptoMuni.TA_DEPARTAMENTOS, Me.BteBusqueda.Text)
    End Sub



    Sub MostrarDatos()
        Try
            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_DEPARTAMENTOSTableAdapter.FillBy(Me.DSDeptoMuni.IM_DEPARTAMENTOS, cellValue)
            'writedata = False


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub







    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub GCDepartamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCDepartamento.Click

    End Sub
End Class