Imports DevExpress.XtraEditors

Public Class XfrmNivelElectivo
    Dim actualizar As Boolean = False
    Private Sub XfrmNivelElectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.TA_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.TA_NIVEL_ELECTIVOTableAdapter.Fill(Me.DSPolitico.TA_NIVEL_ELECTIVO)
        'TODO: This line of code loads data into the 'DSPolitico.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DSPolitico.IM_NIVEL_ELECTIVO)

        ActualizarGrid()
        Me.IMNIVELELECTIVOBindingSource.AddNew()
    End Sub



    Sub ActualizarGrid()
        Me.TA_NIVEL_ELECTIVOTableAdapter.Fill(Me.DSPolitico.TA_NIVEL_ELECTIVO)

    End Sub
    Sub guardar()



        Try
            Me.IMNIVELELECTIVOBindingSource.EndEdit()
            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSPolitico.IM_NIVEL_ELECTIVORow In DSPolitico.IM_NIVEL_ELECTIVO
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

            Me.IM_NIVEL_ELECTIVOTableAdapter.Update(Me.DSPolitico.IM_NIVEL_ELECTIVO)
            ActualizarGrid()


            'Edicion
            BtnEliminar.Enabled = False
            If actualizar = True Then
                Mensajes.MensajeActualizar()
                actualizar = False
            Else
                Mensajes.MensajeGuardar()
            End If
            Me.IMNIVELELECTIVOBindingSource.AddNew()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try






    End Sub

    Sub nuevo()
        Try
            Me.IMNIVELELECTIVOBindingSource.CancelEdit()
            Me.IMNIVELELECTIVOBindingSource.AddNew()
            Me.BtnEliminar.Enabled = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_NIVEL_ELECTIVOTableAdapter.FillBy(Me.DSPolitico.IM_NIVEL_ELECTIVO, CType(cellValue, Integer))
            actualizar = True
            BtnEliminar.Enabled = True


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub





    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        Me.TA_NIVEL_ELECTIVOTableAdapter.FillBy(Me.DSPolitico.TA_NIVEL_ELECTIVO, Me.ButtonEdit1.Text)
    End Sub

    Private Sub ButtonEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit1.EditValueChanged
        Me.TA_NIVEL_ELECTIVOTableAdapter.FillBy(Me.DSPolitico.TA_NIVEL_ELECTIVO, Me.ButtonEdit1.Text)
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub
    Sub eliminar()


        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
                Dim Drow As DSPolitico.IM_NIVEL_ELECTIVORow

                Drow = Me.DSPolitico.IM_NIVEL_ELECTIVO.FindByCODIGO_NIVEL_ELECTIVO(CType(cellValue, Integer))

                Drow.Delete()

                Me.IM_NIVEL_ELECTIVOTableAdapter.Update(Me.DSPolitico.IM_NIVEL_ELECTIVO)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMNIVELELECTIVOBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If



    End Sub

    Private Sub CODIGO_NIVEL_ELECTIVOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_NIVEL_ELECTIVOSpinEdit.EditValueChanged

    End Sub

    Private Sub CODIGO_NIVEL_ELECTIVOSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_NIVEL_ELECTIVOSpinEdit.KeyPress
        VControles.solonumeros(e)
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

    


    Private Sub ButtonEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ButtonEdit1.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            DESCRIPCIONTextEdit.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
End Class