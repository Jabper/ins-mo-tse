
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class XfrmPartidosPoliticos

    Private Sub XfrmPartidosPoliticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()

        'TODO: This line of code loads data into the 'DataSet1.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DataSet1.IM_PARTIDOS_POLITICOS)
        Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub


    Sub guardar()



        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMPARTIDOSPOLITICOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DataSet1.IM_PARTIDOS_POLITICOSRow In DataSet1.IM_PARTIDOS_POLITICOS

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
            Me.IM_PARTIDOS_POLITICOSTableAdapter.Update(Me.DataSet1.IM_PARTIDOS_POLITICOS)

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION

        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMPARTIDOSPOLITICOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()

        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GCPartidos_Politicos, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            'Me.IM_DEPARTAMENTOSTableAdapter.FillBy(Me.DataSet1.IM_DEPARTAMENTOS, CType(cellValue, Integer))
            'writedata = False


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Private Sub GCPartidos_Politicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCPartidos_Politicos.Click
        MostrarDatos()
    End Sub

    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DataSet1.IM_DEPARTAMENTOS1' table. You can move, or remove it, as needed.
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DataSet1.TA_PARTIDOS_POLITICOS)
    End Sub

    Sub Eliminar()

        Try
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GCPartidos_Politicos, 0)


            Dim deptosrow As DataSet1.IM_PARTIDOS_POLITICOSRow

            deptosrow = Me.DataSet1.IM_PARTIDOS_POLITICOS.FindByCODIGO_PARTIDO(cellValue)

            deptosrow.Delete()

            Me.IM_PARTIDOS_POLITICOSTableAdapter.Update(Me.DataSet1.IM_PARTIDOS_POLITICOS)

            ActualizarGrid()
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub
End Class