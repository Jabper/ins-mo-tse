Imports DevExpress.XtraEditors

Public Class xfrmRequisitosFinales




    Dim actualizar As Boolean = False
    Dim id As Integer

    Private Sub xfrmRequisitosFinales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRequisitos.TA_REQUISITOS' table. You can move, or remove it, as needed.
        Me.TA_REQUISITOSTableAdapter.Fill(Me.DSRequisitos.TA_REQUISITOS)
        'TODO: This line of code loads data into the 'DSRequisitos.IM_REQUISITOS' table. You can move, or remove it, as needed.
        Me.IM_REQUISITOSTableAdapter.Fill(Me.DSRequisitos.IM_REQUISITOS)

        If COracle.credenciales("BtnDepartamento", "MODIFICAR") = "N" And COracle.credenciales("BtnDepartamento", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnDepartamento", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnDepartamento", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnDepartamento", "ELIMINAR", Me.BtnEliminar)

    End Sub

    Sub ActualizarGrid()

        'TODO: This line of code loads data into the 'Me.DSRequisitos .IM_REQUISITOS1' table. You can move, or remove it, as needed.
        Me.TA_REQUISITOSTableAdapter.Fill(Me.DSRequisitos.TA_REQUISITOS)
    End Sub
    Sub guardar()



        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMREQUISITOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSRequisitos.IM_REQUISITOSRow In Me.DSRequisitos.IM_REQUISITOS
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
            Me.IM_REQUISITOSTableAdapter.Update(Me.DSRequisitos.IM_REQUISITOS)

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
            Me.IMREQUISITOSBindingSource.AddNew()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub
    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMREQUISITOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMREQUISITOSBindingSource.AddNew()
            Me.BtnEliminar.Enabled = False
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub
    Sub Eliminar()

        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try


                Dim Deptosrow As DSRequisitos.IM_REQUISITOSRow

                Deptosrow = Me.DSRequisitos.IM_REQUISITOS.FindByCODIGO(id)

                Deptosrow.Delete()

                Me.IM_REQUISITOSTableAdapter.Update(Me.DSRequisitos.IM_REQUISITOS)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMREQUISITOSBindingSource.AddNew()
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
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_REQUISITOSTableAdapter.FillBy(Me.DSRequisitos.IM_REQUISITOS, cellValue)
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


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnDepartamento", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnDepartamento", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnDepartamento", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnDepartamento", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
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

    Private Sub CODIGOTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGOTextEdit.KeyPress
        VControles.solonumeros(e)
    End Sub
End Class