
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class XfrmDepartamentos
    
    Dim actualizar As Boolean = False
    Dim id As Integer
    Private Sub XfrmDepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DSDeptoMuni.TA_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.TA_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.TA_DEPARTAMENTOS)
       
        ActualizarGrid()
       
        Me.IMDEPARTAMENTOSBindingSource.AddNew()
        DxControls.ObtenerCredencial("BtnDepartamento", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnDepartamento", "MODIFICAR", Me.BtnGuardar)
        DxControls.ObtenerCredencial("BtnDepartamento", "ELIMINAR", Me.BtnEliminar)
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

            'Edicion
            BtnEliminar.Enabled = False
            If actualizar = True Then
                Mensajes.MensajeActualizar()
                actualizar = False
            Else
                Mensajes.MensajeGuardar()
            End If
            Me.IMDEPARTAMENTOSBindingSource.AddNew()
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
            Me.BtnEliminar.Enabled = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub
    Sub Eliminar()

        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try


                Dim Deptosrow As DSDeptoMuni.IM_DEPARTAMENTOSRow

                Deptosrow = Me.DSDeptoMuni.IM_DEPARTAMENTOS.FindByCODIGO_DEPARTAMENTO(id)

                Deptosrow.Delete()

                Me.IM_DEPARTAMENTOSTableAdapter.Update(Me.DSDeptoMuni.IM_DEPARTAMENTOS)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMDEPARTAMENTOSBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If
        


        

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
            actualizar = True
            id = cellValue
            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub







    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

   

    

    Private Sub CODIGO_DEPARTAMENTOSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_DEPARTAMENTOSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub CANTIDAD_DIPUTADOSSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANTIDAD_DIPUTADOSSpinEdit.EditValueChanged

    End Sub

    Private Sub CANTIDAD_DIPUTADOSSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CANTIDAD_DIPUTADOSSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    
    
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class