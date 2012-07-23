Imports DevExpress.XtraEditors

Public Class XfrmOperacionesPorRol
    Dim idop As Integer
    Dim idrol As Integer
    Dim actualizar As Boolean = False

    Private Sub XfrmOperacionesPorRol_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.IM_ROLESTableAdapter.Fill(Me.DTUsers.IM_ROLES)
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
    End Sub
    Sub setchek()
        ChkModificar.CheckState = CheckState.Unchecked
        ChkEliminar.CheckState = CheckState.Unchecked
        ChkInsertar.CheckState = CheckState.Unchecked

    End Sub
    Private Sub XfrmOperacionesPorRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IM_ROLESTableAdapter.Fill(Me.DTUsers.IM_ROLES)
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        'TODO: This line of code loads data into the 'DTUsers.IM_OPERACIONES_POR_ROL' table. You can move, or remove it, as needed.
        Me.IM_OPERACIONES_POR_ROLTableAdapter.Fill(Me.DTUsers.IM_OPERACIONES_POR_ROL)
        Me.IMOPERACIONESPORROLBindingSource.AddNew()
        Me.DT_OPCIONES_X_ROLTableAdapter.Fill(Me.DTUsers.DT_OPCIONES_X_ROL)

        Me.ChkInsertar.Checked = False
        Me.ChkModificar.Checked = False
        Me.ChkEliminar.Checked = False
        If COracle.credenciales("BtnOperaciones", "MODIFICAR") = "N" And COracle.credenciales("BtnOperaciones", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnOperaciones", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnOperaciones", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnOperaciones", "ELIMINAR", Me.BtnEliminar)
        setchek()
    End Sub

    Sub Nuevo()
        Try
            Me.IMOPERACIONESPORROLBindingSource.CancelEdit()
            Me.IMOPERACIONESPORROLBindingSource.AddNew()
            actualizar = False
            Me.BtnEliminar.Enabled = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
        setchek()
    End Sub

    Sub guardar()
        Try
            Me.IMOPERACIONESPORROLBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DTUsers.IM_OPERACIONES_POR_ROLRow In DTUsers.IM_OPERACIONES_POR_ROL
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
            Me.IM_OPERACIONES_POR_ROLTableAdapter.Update(Me.DTUsers.IM_OPERACIONES_POR_ROL)


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
            Me.IMOPERACIONESPORROLBindingSource.AddNew()
            actualizar = False
            setchek()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub
    Sub MostrarDatos()
        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            idop = Data.CapturarDatoGrid(Me.GridView1, 0)
            idrol = Data.CapturarDatoGrid(Me.GridView1, 1)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_OPERACIONES_POR_ROLTableAdapter.FillBy(DTUsers.IM_OPERACIONES_POR_ROL, idop, idrol)

            actualizar = True
            BtnEliminar.Enabled = True

        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        Try
            Me.DT_OPCIONES_X_ROLTableAdapter.FillBy(Me.DTUsers.DT_OPCIONES_X_ROL, Me.CODIGO_ROLSpinEdit.EditValue)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub CODIGO_ROLSpinEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_ROLSpinEdit.TextChanged
        Try
            Me.DT_OPCIONES_X_ROLTableAdapter.FillBy(Me.DTUsers.DT_OPCIONES_X_ROL, Me.CODIGO_ROLSpinEdit.EditValue)
        Catch ex As Exception

        End Try
    End Sub


    Sub eliminar()
        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try


                'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
                'Me.IM_OPERACIONES_POR_ROLTableAdapter.FillBy(DTUsers.IM_OPERACIONES_POR_ROL, idop, idrol)

                Dim Drow As DTUsers.IM_OPERACIONES_POR_ROLRow

                Drow = DTUsers.IM_OPERACIONES_POR_ROL.FindByCODIGO_OPCIONCODIGO_ROL(Me.CODIGO_OPCIONSpinEdit.EditValue, Me.CODIGO_ROLSpinEdit.EditValue)

                Drow.Delete()

                Me.IM_OPERACIONES_POR_ROLTableAdapter.Update(Me.DTUsers.IM_OPERACIONES_POR_ROL)
                Try
                    Me.DT_OPCIONES_X_ROLTableAdapter.Fill(Me.DTUsers.DT_OPCIONES_X_ROL)
                Catch ex As Exception

                End Try
                'ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMOPERACIONESPORROLBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub

   
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnOperaciones", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnOperaciones", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnOperaciones", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnOperaciones", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        'MostrarDatos()
    End Sub

    Private Sub GCBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCBusqueda.Click
        MostrarDatos()
    End Sub
End Class