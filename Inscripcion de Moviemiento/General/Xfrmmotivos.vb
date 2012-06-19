Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class Xfrmmotivos
    Dim actualizar As Boolean = False
    Dim id As String

    Private Sub Xfrmmotivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Motivos.TA_MOTIVOS_INHABILITACION' table. You can move, or remove it, as needed.



        Me.TA_MOTIVOS_INHABILITACIONTableAdapter.Fill(Me.DS_Motivos.TA_MOTIVOS_INHABILITACION)
        'TODO: This line of code loads data into the 'DS_Motivos.IM_MOTIVOS_INHABILITACION' table. You can move, or remove it, as needed.
        Me.IM_MOTIVOS_INHABILITACIONTableAdapter.Fill(Me.DS_Motivos.IM_MOTIVOS_INHABILITACION)
        ActualizarGrid()
        Me.IMMOTIVOSINHABILITACIONBindingSource.AddNew()
        If COracle.credenciales("BtnMotivo", "MODIFICAR") = "N" And COracle.credenciales("BtnMotivo", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnMotivo", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnMotivo", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnMotivo", "ELIMINAR", Me.BtnEliminar)


    End Sub

    Sub Nuevo()

        Try
            Me.IMMOTIVOSINHABILITACIONBindingSource.CancelEdit()

            Me.IMMOTIVOSINHABILITACIONBindingSource.AddNew()

            Me.BtnEliminar.Enabled = False
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Sub guardar()
        Try
            Me.IMMOTIVOSINHABILITACIONBindingSource.EndEdit()

            For Each _datar As DS_Motivos.IM_MOTIVOS_INHABILITACIONRow In Me.DS_Motivos.IM_MOTIVOS_INHABILITACION

                If _datar.RowState = DataRowState.Added Then
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now

                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                End If
            Next

            Me.IM_MOTIVOS_INHABILITACIONTableAdapter.Update(Me.DS_Motivos.IM_MOTIVOS_INHABILITACION)

            ActualizarGrid()
            actualizaeliminar()

            BtnEliminar.Enabled = False
            If actualizar = True Then
                Mensajes.MensajeActualizar()
                actualizar = False
            Else
                Mensajes.MensajeGuardar()
            End If

            Me.IMMOTIVOSINHABILITACIONBindingSource.AddNew()
        Catch ex As Exception

            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

 
    Public Sub ActualizarGrid()
        Me.IM_MOTIVOS_INHABILITACIONTableAdapter.Fill(Me.DS_Motivos.IM_MOTIVOS_INHABILITACION)
    End Sub
    Public Sub actualizaeliminar()
        Me.TA_MOTIVOS_INHABILITACIONTableAdapter.Fill(Me.DS_Motivos.TA_MOTIVOS_INHABILITACION)
    End Sub

    Sub Eliminar()

        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim ciudrow As DS_Motivos.IM_MOTIVOS_INHABILITACIONRow = Me.DS_Motivos.IM_MOTIVOS_INHABILITACION.FindByCODIGO_MOTIVO(id)

                ciudrow.Delete()

                Me.IM_MOTIVOS_INHABILITACIONTableAdapter.Update(Me.DS_Motivos.IM_MOTIVOS_INHABILITACION)

                ActualizarGrid()
                actualizaeliminar()
                Mensajes.MensajeEliminar()

                Me.IMMOTIVOSINHABILITACIONBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try
            ActualizarGrid()
        End If

    End Sub

    Private Sub GCBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarDatos()

    End Sub
    Sub MostrarDatos()
        Try

            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)

            Me.IM_MOTIVOS_INHABILITACIONTableAdapter.FillBy(Me.DS_Motivos.IM_MOTIVOS_INHABILITACION, cellValue)

            actualizar = True
            id = cellValue
            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnMotivo", "MODIFICAR") = "S" Then
            guardar()
            ' actualizaeliminar()
        ElseIf actualizar = True And COracle.credenciales("BtnMotivo", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnMotivo", "INSERTAR") = "S" Then
            guardar()
            ' actualizaeliminar()
        ElseIf actualizar = False And COracle.credenciales("BtnMotivo", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
        ' actualizaeliminar()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub
End Class