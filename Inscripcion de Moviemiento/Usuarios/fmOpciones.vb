Imports DevExpress.XtraEditors

Public Class fmOpcion
    Dim actualizar As Boolean = False
    Private Sub XfmOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
        'TODO: This line of code loads data into the 'DTUsers.IM_OPCIONES' table. You can move, or remove it, as needed.
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        Me.IMOPCIONESBindingSource.AddNew()
        If COracle.credenciales("BtnOpciones", "MODIFICAR") = "N" And COracle.credenciales("BtnOpciones", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnOpciones", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnOpciones", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnOpciones", "ELIMINAR", Me.BtnEliminar)
    End Sub
    Sub correlativo()
        CODIGO_OPCIONSpinEdit.EditValue = COracle.FUN_EJECUTAR_SEQ("IM_SQ1_REQUISITOS")
    End Sub
    Sub nuevo()
        Try
            Me.IMOPCIONESBindingSource.CancelEdit()
            Me.IMOPCIONESBindingSource.AddNew()
            BtnEliminar.Enabled = False
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Sub guardar()
        Try
            If actualizar = False Then
                correlativo()
            End If
            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMOPCIONESBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DTUsers.IM_OPCIONESRow In DTUsers.IM_OPCIONES
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
            Me.IM_OPCIONESTableAdapter.Update(Me.DTUsers.IM_OPCIONES)

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
            Me.IMOPCIONESBindingSource.AddNew()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub

    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DTUsers.TA_OPCIONES' table. You can move, or remove it, as needed.
        Me.TA_OPCIONESTableAdapter.Fill(Me.DTUsers.TA_OPCIONES)
    End Sub


    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_OPCIONESTableAdapter.FillBy(Me.DTUsers.IM_OPCIONES, CType(cellValue, Integer))
            'writedata = False

            actualizar = True
            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub




    Private Sub CODIGO_OPCIONSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_OPCIONSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If actualizar = True And COracle.credenciales("BtnOpciones", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnOpciones", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnOpciones", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnOpciones", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Private Sub DESCRIPCIONTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DESCRIPCIONTextEdit.EditValueChanged

    End Sub

    Private Sub DESCRIPCIONTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DESCRIPCIONTextEdit.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            DESCRIPCIONTextEdit.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub



    Sub eliminar()


        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
                Dim Drow As DTUsers.IM_OPCIONESRow

                Drow = Me.DTUsers.IM_OPCIONES.FindByCODIGO_OPCION(CType(cellValue, Integer))

                Drow.Delete()

                Me.IM_OPCIONESTableAdapter.Update(Me.DTUsers.IM_OPCIONES)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMOPCIONESBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub
End Class