Public Class XfrmFilas 



    Private Sub TxtFilas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFilas.KeyPress
        VControles.solonumeros(e)
    End Sub

    Sub establecer()
        
        'Dim r As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), "2")
        'CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, r)
        

    End Sub
    Sub limpiar()
        CmbPartido.EditValue = DBNull.Value
        CmbDepartamento.EditValue = DBNull.Value
        CmbMunicipio.EditValue = DBNull.Value
        CmbMovimiento.EditValue = DBNull.Value
        Me.TxtFilas.Text = Nothing
        Me.TxtFolio.Text = Nothing
    End Sub

    Sub ActivarFiltros()
        If activaropciones.PEstado = "PDO" Then
            Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO") 'COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")
            Me.CmbPartido.Enabled = False


            'Partido
            Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)
            Try
                Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, idp)

            Catch ex As Exception

            End Try
            Me.CmbMovimiento.Enabled = True

        ElseIf activaropciones.PEstado = "MOV" Then
            'Dim idp As String = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")
            'Dim idmov As String = COracle.ObtenerDatos("SELECT CODIGO_MOVIMIENTO FROM IM_PARAMETROS_GENERALES", "CODIGO_MOVIMIENTO")
            Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
            Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")

            Me.CmbPartido.Enabled = False
            Me.CmbMovimiento.Enabled = False

            'Partido
            Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)
            Try
                Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, idp)

            Catch ex As Exception

            End Try
            'Movimiento
            Dim m As Integer = Me.CmbMovimiento.Properties.GetDataSourceRowIndex(Me.CmbMovimiento.Properties.Columns("CODIGO_MOVIMIENTO"), idmov)
            Me.CmbMovimiento.EditValue = Me.CmbMovimiento.Properties.GetDataSourceValue(Me.CmbMovimiento.Properties.ValueMember, m)

        Else
            limpiar()
        End If
    End Sub




    Private Sub XfrmFilas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DSPolitico.TA_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)

        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
        Me.TA_DEPARTAMENTOSTableAdapter.NoCeros(Me.DSDeptoMuni.TA_DEPARTAMENTOS)

      
        ActivarFiltros()

    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub BtnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrear.Click
        If Me.DxValidationProvider1.Validate = True Then
            If CType(Me.TxtFilas.Text, Integer) = 0 Or CType(Me.TxtFilas.Text, Integer) > 50 Then
                Mensajes.mimensaje("Valor de rango de filas inválido")
                Me.TxtFilas.Focus()
            Else
                mostrar()
            End If


        End If
    End Sub
    Sub mostrar()

        If VControles.ComprobarFormAbierto(XfrmCiudadanos) Then

            XfrmCiudadanos.Close()
        End If

        XfrmCiudadanos.Show()
        With XfrmCiudadanos
            .idpartido = Me.CmbPartido.EditValue
            .iddepto = Me.CmbDepartamento.EditValue
            .idmovimiento = Me.CmbMovimiento.EditValue
            .idmuni = Me.CmbMunicipio.EditValue
            .AgregarFilasGrid(CType(Me.TxtFilas.Text, Integer))
            .folio = Me.TxtFolio.Text
            .establecer()
            .estadistico()
            .img = Me.PictureEdit2.Image
            .mostrarimg()
        End With
        Me.Close()


    End Sub

 

    Private Sub CmbDepartamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbDepartamento.TextChanged
        Try
            Me.TA_MUNICIPIOSTableAdapter.DeptoNoCero(Me.DSDeptoMuni.TA_MUNICIPIOS, CmbDepartamento.EditValue)

        Catch ex As Exception

        End Try
    End Sub

    

    Private Sub CmbPartido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPartido.TextChanged
        Try
            Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, CmbPartido.EditValue)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
            OpenFileDialog1.ShowDialog()
            'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
            Dim UrlImagen As String = OpenFileDialog1.FileName
            Me.PictureEdit2.Image = Image.FromFile(UrlImagen)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDepartamento.EditValueChanged

    End Sub
End Class