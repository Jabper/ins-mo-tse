Imports System.IO
Imports DevExpress.XtraEditors


Public Class XfrmCargoElectivo
    Dim actualizar As Boolean = False
    Private Sub XfrmCargoElectivo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DSPolitico.IM_NIVEL_ELECTIVO)
        Me.TA_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSPolitico.TA_CARGOS_ELECTIVOS)
    End Sub

    Private Sub XfrmCargoElectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.TA_CARGOS' table. You can move, or remove it, as needed.
        Me.TA_CARGOSTableAdapter.Fill(Me.DSPolitico.TA_CARGOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DSPolitico.IM_NIVEL_ELECTIVO)
        'TODO: This line of code loads data into the 'DSPolitico.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSPolitico.IM_CARGOS_ELECTIVOS)
        Me.TA_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSPolitico.TA_CARGOS_ELECTIVOS)
        ActualizarGrid()
        Me.IMCARGOSELECTIVOSBindingSource.AddNew()

        If COracle.credenciales("BtnCargos", "MODIFICAR") = "N" And COracle.credenciales("BtnCargos", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnCargos", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnCargos", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnCargos", "ELIMINAR", Me.BtnEliminar)
    End Sub

    Sub nuevo()
        Try
            Me.IMCARGOSELECTIVOSBindingSource.CancelEdit()
            Me.IMCARGOSELECTIVOSBindingSource.AddNew()
            Me.BtnEliminar.Enabled = False
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
        
    End Sub
    Sub guardar()

        Try
            Me.IMCARGOSELECTIVOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSPolitico.IM_CARGOS_ELECTIVOSRow In DSPolitico.IM_CARGOS_ELECTIVOS
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
            Me.IM_CARGOS_ELECTIVOSTableAdapter.Update(Me.DSPolitico.IM_CARGOS_ELECTIVOS)


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
            Me.IMCARGOSELECTIVOSBindingSource.AddNew()

        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Sub ActualizarGrid()
        Me.TA_CARGOSTableAdapter.Fill(Me.DSPolitico.TA_CARGOS)

    End Sub

    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_CARGOS_ELECTIVOSTableAdapter.FillBy(Me.DSPolitico.IM_CARGOS_ELECTIVOS, cellValue)
            actualizar = True
            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Public Shared Function ConvertImageToByteArray(ByVal imageIn As System.Drawing.Image) As Byte()
        Dim ms As New IO.MemoryStream()
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Return ms.ToArray()
    End Function

    Public Shared Function ConvertByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New IO.MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function



    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnCargos", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnCargos", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnCargos", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnCargos", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub CODIGO_CARGO_ELECTIVOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_CARGO_ELECTIVOSpinEdit.EditValueChanged

    End Sub

    Private Sub CODIGO_CARGO_ELECTIVOSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_CARGO_ELECTIVOSpinEdit.KeyPress
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


    Sub eliminar()


        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
                Dim Drow As DSPolitico.IM_CARGOS_ELECTIVOSRow

                Drow = Me.DSPolitico.IM_CARGOS_ELECTIVOS.FindByCODIGO_CARGO_ELECTIVO(CType(cellValue, Integer))

                Drow.Delete()

                Me.IM_CARGOS_ELECTIVOSTableAdapter.Update(Me.DSPolitico.IM_CARGOS_ELECTIVOS)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMCARGOSELECTIVOSBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If

    End Sub

    Private Sub ButtonEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit1.EditValueChanged
        Me.TA_CARGOSTableAdapter.FillBy(Me.DSPolitico.TA_CARGOS, Me.ButtonEdit1.Text)
    End Sub

    Private Sub ButtonEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ButtonEdit1.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            ButtonEdit1.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub
End Class