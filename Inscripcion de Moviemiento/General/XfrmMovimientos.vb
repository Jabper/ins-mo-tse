Imports System.IO
Imports DevExpress.XtraEditors
Imports System.Data.OracleClient

Public Class XfrmMovimientos
    Public UrlInsignia As String
    Public UrlEmblema As String
    Dim idmov As Integer
    Dim idpartido As Integer
    Dim actualizar As Boolean = False

    Private Sub XfrmMovimientos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
    End Sub

    Private Sub XfrmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        'Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DSPolitico.IM_MOVIMIENTOS)
        'TODO: This line of code loads data into the 'DSPolitico.TA_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.

        'Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        ''TODO: This line of code loads data into the 'DSPolitico.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        'Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DSPolitico.IM_MOVIMIENTOS)
        Me.IMMOVIMIENTOSBindingSource.AddNew()
        ActualizarGrid()

        If COracle.credenciales("BtnMovimeintos", "MODIFICAR") = "N" And COracle.credenciales("BtnMovimientos", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnMovimeintos", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnMovimientos", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnMovimientos", "ELIMINAR", Me.BtnEliminar)
    End Sub
    Sub limpiarValidador()
        DxValidationProvider1.RemoveControlError(Me.INSIGNIAPictureEdit)
        DxValidationProvider1.RemoveControlError(Me.EMBLEMAPictureEdit)
    End Sub
    Sub guardar()

        Try
            Me.IMMOVIMIENTOSBindingSource.EndEdit()
            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSPolitico.IM_MOVIMIENTOSRow In DSPolitico.IM_MOVIMIENTOS
                'SI ES UN NUEVO REGITRO
                If _datar.RowState = DataRowState.Added Then
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now
                    Dim consultaim As String = "SELECT IMAGEN FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & CODIGO_PARTIDOSpinEdit.EditValue
                    _datar.INSIGNIA = Data.ConvertImageToByteArray(COracle.ObtenerImagen(consultaim, "IMAGEN"))

                    _datar.EMBLEMA = Data.ConvertImageToByteArray(Me.EMBLEMAPictureEdit.Image)  'Data.ConvertImageToByteArray(Me.EMBLEMAPictureEdit.Image)

                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                    '_datar.INSIGNIA = Data.ConvertImageToByteArray(Me.INSIGNIAPictureEdit.Image)
                    '_datar.EMBLEMA = Data.ConvertImageToByteArray(Me.EMBLEMAPictureEdit.Image)

                End If
            Next

            Me.IM_MOVIMIENTOSTableAdapter.Update(Me.DSPolitico.IM_MOVIMIENTOS)

            'Dim ThumImgIn As String = Application.StartupPath.ToString & "\Img\In" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"
            'Dim ThumImgEm As String = Application.StartupPath.ToString & "\Img\Em" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"

            'If File.Exists(UrlInsignia) Then
            '    Data.CopiarArchivo(UrlInsignia, ThumImgIn)
            'End If

            'If File.Exists(UrlEmblema) Then
            '    Data.CopiarArchivo(UrlEmblema, ThumImgEm)
            'End If

            ActualizarGrid()

            'Edicion
            BtnEliminar.Enabled = False
            If actualizar = True Then
                actualizarimagen()
                Mensajes.MensajeActualizar()
                actualizar = False
            Else
                Mensajes.MensajeGuardar()
            End If
            Me.IMMOVIMIENTOSBindingSource.AddNew()
            Me.INSIGNIAPictureEdit.EditValue = Nothing
            Me.EMBLEMAPictureEdit.EditValue = Nothing
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try


    End Sub

    Sub nuevo()
        Me.IMMOVIMIENTOSBindingSource.CancelEdit()
        Me.IMMOVIMIENTOSBindingSource.AddNew()
        Me.INSIGNIAPictureEdit.EditValue = Nothing
        Me.EMBLEMAPictureEdit.EditValue = Nothing
        BtnEliminar.Enabled = False
        actualizar = False
        limpiarValidador()
    End Sub


    Sub ActualizarGrid()
        Me.TA_MOVIMIENTOTableAdapter.Fill(Me.DSPolitico.TA_MOVIMIENTO)
    End Sub

   
    Sub MostrarDatos()

        Try
            limpiarValidador()
            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim idmov As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            Dim idpart As String = Data.CapturarDatoGrid(Me.GridView1, 2)
            EMBLEMAPictureEdit.EditValue = Nothing
            INSIGNIAPictureEdit.EditValue = Nothing
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Try
                Me.IM_MOVIMIENTOSTableAdapter.FillBy1(Me.DSPolitico.IM_MOVIMIENTOS, CType(idmov, Integer), CType(idpart, Integer))

            Catch ex As Exception

            End Try
            
            Dim consulta As String = "SELECT INSIGNIA FROM IM_MOVIMIENTOS WHERE CODIGO_MOVIMIENTO=" & CODIGO_MOVIMIENTOSpinEdit.EditValue
            Me.INSIGNIAPictureEdit.Image = COracle.ObtenerImagen(consulta, "INSIGNIA")
            Dim consulta2 As String = "SELECT EMBLEMA FROM IM_MOVIMIENTOS WHERE CODIGO_MOVIMIENTO=" & CODIGO_MOVIMIENTOSpinEdit.EditValue
            Me.EMBLEMAPictureEdit.Image = COracle.ObtenerImagen(consulta2, "EMBLEMA")
            'OBTENEMOS LA INFORMACION PARA LA BUSQUEDA DE LA IMAGEN
            'UrlInsignia = Application.StartupPath.ToString & "\Img\In" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"
            'UrlEmblema = Application.StartupPath.ToString & "\Img\Em" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"

            'If File.Exists(UrlInsignia) Then
            '    'SI EL ARCHIVO EXISTE MOSTRAMOS LA IMAGEN
            '    DxControls.CargarImagen(Me.INSIGNIAPictureEdit, UrlInsignia)
            'Else
            '    'SI NO SE ENCUENTRA LIMPIAMOS EL PICTURE EDIT
            '    Me.INSIGNIAPictureEdit.EditValue = Nothing
            'End If

            'If File.Exists(UrlEmblema) Then
            '    'SI EL ARCHIVO EXISTE MOSTRAMOS LA IMAGEN
            '    DxControls.CargarImagen(Me.EMBLEMAPictureEdit, UrlEmblema)
            'Else
            '    'SI NO SE ENCUENTRA LIMPIAMOS EL PICTURE EDIT
            '    Me.EMBLEMAPictureEdit.EditValue = Nothing
            'End If

            actualizar = True

            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try

    End Sub

    Sub actualizarimagen()
        Try

            Dim cnx As New OracleConnection(Configuracion.verconfig)
            Dim sqlstring As String
            sqlstring = "UPDATE IM_MOVIMIENTOS SET INSIGNIA=:ft, EMBLEMA=:em WHERE CODIGO_MOVIMIENTO=:cod"
            Dim cmd As New OracleCommand(sqlstring, cnx)
            cmd.Parameters.Add(":ft", OracleType.Blob).Value = Data.ConvertImageToByteArray(Me.INSIGNIAPictureEdit.Image)
            cmd.Parameters.Add(":em", OracleType.Blob).Value = Data.ConvertImageToByteArray(Me.EMBLEMAPictureEdit.Image)
            cmd.Parameters.Add(":cod", OracleType.Number, 8).Value = Me.CODIGO_MOVIMIENTOSpinEdit.EditValue
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnInsignia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
        OFDInsignia.ShowDialog()
        'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
        UrlInsignia = OFDInsignia.FileName

        DxControls.CargarImagen(Me.INSIGNIAPictureEdit, UrlInsignia)
    End Sub

    Private Sub BtnEmblema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmblema.Click
        Try
            'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
            OFDEmblema.ShowDialog()
            'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
            UrlEmblema = OFDEmblema.FileName
            DxControls.CargarImagen(Me.EMBLEMAPictureEdit, UrlEmblema)
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub CODIGO_MOVIMIENTOSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_MOVIMIENTOSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub NOMBRE_MOVIMIENTOTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VControles.Mayuscula(NOMBRE_MOVIMIENTOTextEdit)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnMovimeintos", "MODIFICAR") = "S" Then
            If DxValidationProvider1.Validate = True Then
                guardar()
            End If
        ElseIf actualizar = True And COracle.credenciales("BtnMovimeintos", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnMovimeintos", "INSERTAR") = "S" Then
            If DxValidationProvider1.Validate = True Then
                guardar()
            End If
        ElseIf actualizar = False And COracle.credenciales("BtnMovimeintos", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Sub eliminar()
        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim idmov As String = Data.CapturarDatoGrid(Me.GridView1, 0)
                Dim idpartido As String = Data.CapturarDatoGrid(Me.GridView1, 2)

                Dim drow As DSPolitico.IM_MOVIMIENTOSRow

                drow = Me.DSPolitico.IM_MOVIMIENTOS.FindByCODIGO_MOVIMIENTOCODIGO_PARTIDO(CType(idmov, Integer), CType(idpartido, Integer))

                drow.Delete()

                Me.IM_MOVIMIENTOSTableAdapter.Update(Me.DSPolitico.IM_MOVIMIENTOS)

                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMMOVIMIENTOSBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                Me.INSIGNIAPictureEdit.EditValue = Nothing
                Me.EMBLEMAPictureEdit.EditValue = Nothing
                actualizar = False
                limpiarValidador()
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        Me.TA_MOVIMIENTOTableAdapter.FillBy(DSPolitico.TA_MOVIMIENTO, Me.ButtonEdit1.Text)
    End Sub

    Private Sub ButtonEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit1.EditValueChanged
        Me.TA_MOVIMIENTOTableAdapter.FillBy(DSPolitico.TA_MOVIMIENTO, Me.ButtonEdit1.Text)
    End Sub

    Private Sub NOMBRE_MOVIMIENTOTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            NOMBRE_MOVIMIENTOTextEdit.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    
End Class