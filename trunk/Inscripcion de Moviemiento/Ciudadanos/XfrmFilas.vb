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

    Private Sub XfrmFilas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.TA_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)

        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
        Me.TA_DEPARTAMENTOSTableAdapter.NoCeros(Me.DSDeptoMuni.TA_DEPARTAMENTOS)
        limpiar()
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
End Class