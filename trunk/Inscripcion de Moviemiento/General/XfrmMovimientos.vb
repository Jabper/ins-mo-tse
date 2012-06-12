Imports System.IO
Public Class XfrmMovimientos
    Public UrlInsignia As String
    Public UrlEmblema As String
    Dim idmov As Integer
    Dim idpartido As Integer


    Private Sub XfrmMovimientos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
    End Sub

    Private Sub XfrmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DSPolitico.IM_MOVIMIENTOS)
        Me.IMMOVIMIENTOSBindingSource.AddNew()
        ActualizarGrid()

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
                    _datar.INSIGNIA = Data.ConvertImageToByteArray(Me.INSIGNIAPictureEdit.Image)
                    _datar.EMBLEMA = Data.ConvertImageToByteArray(Me.EMBLEMAPictureEdit.Image)
                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                    _datar.INSIGNIA = Data.ConvertImageToByteArray(Me.INSIGNIAPictureEdit.Image)
                    _datar.EMBLEMA = Data.ConvertImageToByteArray(Me.EMBLEMAPictureEdit.Image)

                End If
            Next

            Me.IM_MOVIMIENTOSTableAdapter.Update(Me.DSPolitico.IM_MOVIMIENTOS)

            Dim ThumImgIn As String = Application.StartupPath.ToString & "\Img\In" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"
            Dim ThumImgEm As String = Application.StartupPath.ToString & "\Img\Em" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"

            If File.Exists(UrlInsignia) Then
                Data.CopiarArchivo(UrlInsignia, ThumImgIn)
            End If

            If File.Exists(UrlEmblema) Then
                Data.CopiarArchivo(UrlEmblema, ThumImgEm)
            End If

            ActualizarGrid()
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
    End Sub


    Sub ActualizarGrid()
        Me.TA_MOVIMIENTOTableAdapter.Fill(Me.DSPolitico.TA_MOVIMIENTO)
    End Sub

    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSPolitico.IM_MOVIMIENTOS, CType(cellValue, Integer))

            'OBTENEMOS LA INFORMACION PARA LA BUSQUEDA DE LA IMAGEN
            UrlInsignia = Application.StartupPath.ToString & "\Img\In" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"
            UrlEmblema = Application.StartupPath.ToString & "\Img\Em" & CODIGO_MOVIMIENTOSpinEdit.EditValue.ToString & NOMBRE_MOVIMIENTOTextEdit.EditValue.ToString & ".jpg"

            If File.Exists(UrlInsignia) Then
                'SI EL ARCHIVO EXISTE MOSTRAMOS LA IMAGEN
                DxControls.CargarImagen(Me.INSIGNIAPictureEdit, UrlInsignia)
            Else
                'SI NO SE ENCUENTRA LIMPIAMOS EL PICTURE EDIT
                Me.INSIGNIAPictureEdit.EditValue = Nothing
            End If

            If File.Exists(UrlEmblema) Then
                'SI EL ARCHIVO EXISTE MOSTRAMOS LA IMAGEN
                DxControls.CargarImagen(Me.EMBLEMAPictureEdit, UrlEmblema)
            Else
                'SI NO SE ENCUENTRA LIMPIAMOS EL PICTURE EDIT
                Me.EMBLEMAPictureEdit.EditValue = Nothing
            End If

        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try

    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        guardar()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        nuevo()
    End Sub

    Private Sub BtnInsignia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsignia.Click
        'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
        OFDInsignia.ShowDialog()
        'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
        UrlInsignia = OFDInsignia.FileName

        DxControls.CargarImagen(Me.INSIGNIAPictureEdit, UrlInsignia)
    End Sub



    Private Sub BtnEmblema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmblema.Click
        'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
        OFDEmblema.ShowDialog()
        'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
        UrlEmblema = OFDEmblema.FileName
        DxControls.CargarImagen(Me.EMBLEMAPictureEdit, UrlEmblema)
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CODIGO_MOVIMIENTOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_MOVIMIENTOSpinEdit.EditValueChanged

    End Sub

    Private Sub CODIGO_MOVIMIENTOSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_MOVIMIENTOSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub NOMBRE_MOVIMIENTOTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOMBRE_MOVIMIENTOTextEdit.EditValueChanged
        VControles.Mayuscula(NOMBRE_MOVIMIENTOTextEdit)
    End Sub
End Class