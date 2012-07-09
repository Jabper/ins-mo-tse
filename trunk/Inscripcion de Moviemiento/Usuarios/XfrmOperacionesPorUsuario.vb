Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class XfrmOperacionesPorUsuario
    Dim actualizar As Boolean = False
    Dim idcodigo As String
    Dim iduser As String
    Private Sub XfrmOperacionesPorUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTUsuario.DT_OPERACIONES' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DTUsers.IM_OPCIONES' table. You can move, or remove it, as needed.
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        'TODO: This line of code loads data into the 'DTUsers.IM_USUARIOS' table. You can move, or remove it, as needed.
        Me.IM_USUARIOSTableAdapter.Fill(Me.DTUsers.IM_USUARIOS)
        'TODO: This line of code loads data into the 'DTUsuario.IM_OPERACIONES_X_USUARIO' table. You can move, or remove it, as needed.
        'Me.IM_OPERACIONES_X_USUARIOTableAdapter.Fill(Me.DTUsuario.IM_OPERACIONES_X_USUARIO)
        'Me.DT_OPERACIONESTableAdapter.Fill(Me.DTUsuario.DT_OPERACIONES)
        Me.IMOPERACIONESXUSUARIOBindingSource.AddNew()

        Me.ChkInsertar.Checked = False
        Me.ChkModificar.Checked = False
        Me.ChkEliminar.Checked = False
        If COracle.credenciales("BtnOperacionesUsuarios", "MODIFICAR") = "N" And COracle.credenciales("BtnOperacionesUsuarios", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnOperacionesUsuarios", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnOperacionesUsuarios", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnOperacionesUsuarios", "ELIMINAR", Me.BtnEliminar)

    End Sub


    Sub Nuevo()
        Try
            Me.IMOPERACIONESXUSUARIOBindingSource.CancelEdit()
            Me.IMOPERACIONESXUSUARIOBindingSource.AddNew()
            actualizar = False
            Me.BtnEliminar.Enabled = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Sub guardar()
        Try
            Me.IMOPERACIONESXUSUARIOBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DTUsuario.IM_OPERACIONES_X_USUARIORow In DTUsuario.IM_OPERACIONES_X_USUARIO
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
            Me.IM_OPERACIONES_X_USUARIOTableAdapter.Update(Me.DTUsuario.IM_OPERACIONES_X_USUARIO)


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
            Me.IMOPERACIONESXUSUARIOBindingSource.AddNew()
            actualizar = False
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub
    Sub MostrarDatos()
        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim view As GridView = GridView1
            idcodigo = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_OPCION") 'Data.CapturarDatoGrid(Me.GridView1, 0)
            iduser = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_USUARIO") 'Data.CapturarDatoGrid(Me.GridView1, 1)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA

            Me.IM_OPERACIONES_X_USUARIOTableAdapter.FillBy(DTUsuario.IM_OPERACIONES_X_USUARIO, idcodigo, iduser)
            actualizar = True
            BtnEliminar.Enabled = True

        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        Me.DT_OPERACIONESTableAdapter.FillBy(Me.DTUsuario.DT_OPERACIONES, Me.CODIGO_USUARIOTextEdit.EditValue)
    End Sub



    Private Sub CODIGO_USUARIOTextEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_USUARIOTextEdit.TextChanged
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        '        MostrarDatos()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            If actualizar = True And COracle.credenciales("BtnOperacionesUsuarios", "MODIFICAR") = "S" Then
                guardar()
            ElseIf actualizar = True And COracle.credenciales("BtnOperacionesUsuarios", "MODIFICAR") <> "S" Then
                Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
            ElseIf actualizar = False And COracle.credenciales("BtnOperacionesUsuarios", "INSERTAR") = "S" Then
                guardar()
            ElseIf actualizar = False And COracle.credenciales("BtnOperacionesUsuarios", "INSERTAR") <> "S" Then
                Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
            End If
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub
    Sub eliminar()
        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim view As GridView = GridView1
                'idcodigo = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_OPCION") 'Data.CapturarDatoGrid(Me.GridView1, 0)
                'iduser = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_USUARIO") 'Data.CapturarDatoGrid(Me.GridView1, 1)

                'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
                'Me.IM_OPERACIONES_X_USUARIOTableAdapter.FillBy(DTUsuario.IM_OPERACIONES_X_USUARIO, CType(idcodigo, Integer), iduser)
                Dim Drow As DTUsuario.IM_OPERACIONES_X_USUARIORow

                Drow = DTUsuario.IM_OPERACIONES_X_USUARIO.FindByCODIGO_OPCIONCODIGO_USUARIO(Me.CODIGO_OPCIONSpinEdit.EditValue, Me.CODIGO_USUARIOTextEdit.EditValue)

                Drow.Delete()

                Me.IM_OPERACIONES_X_USUARIOTableAdapter.Update(Me.DTUsuario.IM_OPERACIONES_X_USUARIO)
                Me.DT_OPERACIONESTableAdapter.Fill(Me.DTUsuario.DT_OPERACIONES)

                Mensajes.MensajeEliminar()
                Me.IMOPERACIONESXUSUARIOBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If
    End Sub

    Private Sub GCBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCBusqueda.Click
        MostrarDatos()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CODIGO_USUARIOTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_USUARIOTextEdit.EditValueChanged
        Me.DT_OPERACIONESTableAdapter.FillBy(Me.DTUsuario.DT_OPERACIONES, Me.CODIGO_USUARIOTextEdit.EditValue)

    End Sub
End Class