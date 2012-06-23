Imports DevExpress.XtraEditors
Imports System.Data.OracleClient

Public Class XfrmPartidos
    Dim id As Integer
    Dim actualizar As Boolean = False
    Public UrlImagen As String
    Private Sub XfrmPartidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.TA_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        'Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        ActualizarGrid()
        Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()

        If COracle.credenciales("BtnPartidos", "MODIFICAR") = "N" And COracle.credenciales("BtnPartidos", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnPartidos", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnPartidos", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnPartidos", "ELIMINAR", Me.BtnEliminar)

    End Sub




    Sub guardar()

        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMPARTIDOSPOLITICOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSPolitico.IM_PARTIDOS_POLITICOSRow In DSPolitico.IM_PARTIDOS_POLITICOS

                'SI ES UN NUEVO REGITRO
                If _datar.RowState = DataRowState.Added Then
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now
                    _datar.IMAGEN = Data.ConvertImageToByteArray(Me.IMAGENPictureEdit.Image)
                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                    'ACtualizar Imagen
                   
                    '_datar.IMAGEN = Data.ConvertImageToByteArray(Me.IMAGENPictureEdit.Image)

                End If
            Next

            'AGREGANDO LA INFORMACION A LA BASE DE DATOS
            Me.IM_PARTIDOS_POLITICOSTableAdapter.Update(Me.DSPolitico.IM_PARTIDOS_POLITICOS)

            'Dim ThumImg As String = Application.StartupPath.ToString & "\Img\" & CODIGO_PARTIDOSpinEdit.EditValue.ToString & NOMBRETextEdit.EditValue.ToString & ".jpg"

            'If File.Exists(UrlImagen) Then
            '    Data.CopiarArchivo(UrlImagen, ThumImg)
            'End If

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
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
            Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()
            Me.IMAGENPictureEdit.Image = Nothing
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub
    Sub actualizarimagen()
        Try

            Dim cnx As New OracleConnection(Configuracion.verconfig)
            Dim sqlstring As String
            sqlstring = "UPDATE IM_PARTIDOS_POLITICOS SET IMAGEN=:ft WHERE CODIGO_PARTIDO=:cod"
            Dim cmd As New OracleCommand(sqlstring, cnx)
            cmd.Parameters.Add(":ft", OracleType.Blob).Value = Data.ConvertImageToByteArray(Me.IMAGENPictureEdit.Image)
            cmd.Parameters.Add(":cod", OracleType.Number, 8).Value = Me.CODIGO_PARTIDOSpinEdit.EditValue
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()

        Catch ex As Exception

        End Try
    End Sub
    Sub limpiarValidador()
        DxValidationProvider1.RemoveControlError(Me.IMAGENPictureEdit)
    End Sub

    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMPARTIDOSPOLITICOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()
            '   LIMPIAR EL LA IMAGEN
            IMAGENPictureEdit.EditValue = Nothing
            Me.BtnEliminar.Enabled = False
            actualizar = False
            limpiarValidador()
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub




    Sub MostrarDatos()

        Try
            limpiarValidador()
            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            IMAGENPictureEdit.EditValue = Nothing
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_PARTIDOS_POLITICOSTableAdapter.FillBy(Me.DSPolitico.IM_PARTIDOS_POLITICOS, CType(cellValue, Integer))

            'OBTENEMOS LA INFORMACION PARA LA BUSQUEDA DE LA IMAGEN
            Dim consulta As String = "SELECT IMAGEN FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & CODIGO_PARTIDOSpinEdit.EditValue
            Me.IMAGENPictureEdit.Image = COracle.ObtenerImagen(consulta, "IMAGEN")
           
            actualizar = True
            id = cellValue
            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
    End Sub

    Sub Eliminar()
        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)


                Dim deptosrow As DSPolitico.IM_PARTIDOS_POLITICOSRow

                deptosrow = Me.DSPolitico.IM_PARTIDOS_POLITICOS.FindByCODIGO_PARTIDO(cellValue)

                deptosrow.Delete()

                Me.IM_PARTIDOS_POLITICOSTableAdapter.Update(Me.DSPolitico.IM_PARTIDOS_POLITICOS)

                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()
                Me.IMAGENPictureEdit.Image = Nothing
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try
        End If



    End Sub

    Sub cargarimagen() ' MUESTRA LA IMAGEN SELECCIONADA EN EL PICUTURE EDIT

        Me.IMAGENPictureEdit.Image = Image.FromFile(UrlImagen)

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnPartidos", "MODIFICAR") = "S" Then
            If DxValidationProvider1.Validate = True Then
                guardar()
            End If
        ElseIf actualizar = True And COracle.credenciales("BtnPartidos", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnPartidos", "INSERTAR") = "S" Then
            If DxValidationProvider1.Validate = True Then
                guardar()
            End If
        ElseIf actualizar = False And COracle.credenciales("BtnPartidos", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOSpinEdit.EditValueChanged

    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_PARTIDOSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub CANTIDAD_FIRMASSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANTIDAD_FIRMASSpinEdit.EditValueChanged

    End Sub

    Private Sub CANTIDAD_FIRMASSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CANTIDAD_FIRMASSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        Me.TA_PARTIDOS_POLITICOSTableAdapter.FillBy(DSPolitico.TA_PARTIDOS_POLITICOS, Me.ButtonEdit1.Text)
    End Sub

    Private Sub ButtonEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit1.EditValueChanged
        Me.TA_PARTIDOS_POLITICOSTableAdapter.FillBy(DSPolitico.TA_PARTIDOS_POLITICOS, Me.ButtonEdit1.Text)
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
            OpenFileDialog1.ShowDialog()
            'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
            UrlImagen = OpenFileDialog1.FileName

            cargarimagen()
        Catch ex As Exception

        End Try
    End Sub
End Class