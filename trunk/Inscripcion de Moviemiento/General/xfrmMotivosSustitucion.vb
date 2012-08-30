
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class xfrmMotivosSustitucion
    Dim actualizar As Boolean = False
    Dim id As Integer
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub xfrmMotivosSustitucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        ActualizarGrid()


        If COracle.credenciales("BtnMotivoSustitucion", "MODIFICAR") = "N" And COracle.credenciales("BtnMotivoSustitucion", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnMotivoSustitucion", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnMotivoSustitucion", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnMotivoSustitucion", "ELIMINAR", Me.BtnEliminar)
    End Sub
    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_DEPARTAMENTOS1' table. You can move, or remove it, as needed.
        Me.IM_MOTIVO_SUSTITUCION1TableAdapter.Fill(Me.DT_Renuncia.IM_MOTIVO_SUSTITUCION1)
    End Sub

    Sub guardar()



        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IM_MOTIVOS_SUSTITUCION.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DT_Renuncia.IM_MOTIVO_SUSTITUCIONRow In DT_Renuncia.IM_MOTIVO_SUSTITUCION
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
            Me.IM_MOTIVO_SUSTITUCIONTableAdapter.Update(Me.DT_Renuncia.IM_MOTIVO_SUSTITUCION)

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
            Me.IM_MOTIVOS_SUSTITUCION.AddNew()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub
    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IM_MOTIVOS_SUSTITUCION.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IM_MOTIVOS_SUSTITUCION.AddNew()
            Me.BtnEliminar.Enabled = False
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub
    Sub Eliminar()

        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try


                Dim Deptosrow As DT_Renuncia.IM_MOTIVO_SUSTITUCIONRow

                Deptosrow = Me.DT_Renuncia.IM_MOTIVO_SUSTITUCION.FindByCODIGO_MOTIVO(id)

                Deptosrow.Delete()

                Me.IM_MOTIVO_SUSTITUCIONTableAdapter.Update(Me.DT_Renuncia.IM_MOTIVO_SUSTITUCION)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IM_MOTIVOS_SUSTITUCION.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If





    End Sub

    Sub MostrarDatos()
        Try
            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_MOTIVO").ToString  'Data.CapturarDatoGrid(Me.GridView1, 1)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_MOTIVO_SUSTITUCIONTableAdapter.FillBy(Me.DT_Renuncia.IM_MOTIVO_SUSTITUCION, cellValue)
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

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnMotivoSustitucion", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnMotivoSustitucion", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnMotivoSustitucion", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnMotivoSustitucion", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    

    Private Sub CODIGO_MOTIVOTextEdit_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        VControles.solonumeros(e)
    End Sub
End Class