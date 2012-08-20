Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.OracleClient

Public Class XfrmConPlanilla

    Private Sub XfrmConPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.Cargos' table. You can move, or remove it, as needed.
        Me.CargosTableAdapter.Fill(Me.DSConsultas.Cargos)
        'TODO: This line of code loads data into the 'DSConsultas.Niveles' table. You can move, or remove it, as needed.
        Me.NivelesTableAdapter.Fill(Me.DSConsultas.Niveles)
        'TODO: This line of code loads data into the 'DSConsultas.Municipios' table. You can move, or remove it, as needed.
        Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)
        'TODO: This line of code loads data into the 'DSConsultas.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.DSConsultas.Departamentos)
        'TODO: This line of code loads data into the 'DSConsultas.Movimientos' table. You can move, or remove it, as needed.
        Me.MovimientosTableAdapter.Fill(Me.DSConsultas.Movimientos)
        'TODO: This line of code loads data into the 'DSConsultas.Partidos' table. You can move, or remove it, as needed.
        Me.PartidosTableAdapter.Fill(Me.DSConsultas.Partidos)
        Dim fTodos3 As Integer = Me.cbxNivel.FindStringExact("NINGUNO")
        If fTodos3 > 0 Then Me.cbxNivel.SelectedIndex = fTodos3
        Me.cbxDepartamento.Enabled = False
        Me.cbxMunicipio.Enabled = False

        Filtrar()
        ActivarOpciones.ReestriccionUsuarios(cbxPartido, cbxMovimiento)
    End Sub

    Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim rw As DataRowView = GridView1.GetRow(e.RowHandle)

        If rw IsNot Nothing Then

            If (e.Column.ColumnHandle = 0 AndAlso Not IsDBNull(rw.Row.Item(0)) OrElse e.Column.ColumnHandle = 1 AndAlso Not IsDBNull(rw.Row.Item(1))) AndAlso (e.Column.ColumnHandle = 0 OrElse e.Column.ColumnHandle = 1) Then
                frmImagenModal.codigoPartido = rw.Row.Item(18)
                frmImagenModal.codigoMovimiento = rw.Row.Item(19)
                frmImagenModal.codigoCandidato = rw.Row.Item(24)
                frmImagenModal.codigoRequisito = If(e.Column.ColumnHandle = 0, 7, 8)
                frmImagenModal.Titulo = String.Format("{0} {1} {2} {3}", rw.Row.Item(4), rw.Row.Item(5), rw.Row.Item(6), rw.Row.Item(7))
                frmImagenModal.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        Filtrar()
    End Sub

    Private Sub Filtrar()
        Me.IM_V_PLANILLA_REQUISITOTableAdapter.FillBy1(Me.DSConsultas.IM_V_PLANILLA_REQUISITO, Me.cbxPartido.SelectedValue, _
                                                  Me.cbxMovimiento.SelectedValue, Me.cbxNivel.SelectedValue, _
                                                  Me.cbxCargo.SelectedValue, Me.cbxDepartamento.SelectedValue, Me.cbxMunicipio.SelectedValue)





        Dim filtro As String = String.Empty

        If Me.cbxDepartamento.Text <> "TODOS" AndAlso Me.cbxDepartamento.Text <> String.Empty Then
            filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_DEPARTAMENTO = {0}", Me.cbxDepartamento.SelectedValue)
        End If

        If Me.cbxMunicipio.Text <> "TODOS" AndAlso Me.cbxMunicipio.Text <> String.Empty Then
            filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_MUNICIPIO = {0}", Me.cbxMunicipio.SelectedValue)
        End If

        If Me.cbxCargo.SelectedValue <> 0 Then
            Me.GridView1.Columns("REC1").Visible = True
            Me.GridView1.Columns("REC1").VisibleIndex = 25
            Me.GridView1.Columns("REC2").Visible = True
            Me.GridView1.Columns("REC2").VisibleIndex = 26
            Me.GridView1.Columns("REC3").Visible = True
            Me.GridView1.Columns("REC3").VisibleIndex = 27
            Me.GridView1.Columns("REC4").Visible = True
            Me.GridView1.Columns("REC4").VisibleIndex = 28
            Select Case Me.cbxCargo.SelectedValue
                Case 1
                    Me.GridView1.Columns("REC5").Visible = True
                    Me.GridView1.Columns("REC5").VisibleIndex = 26
                    Me.GridView1.Columns("REC6").Visible = True
                    Me.GridView1.Columns("REC6").VisibleIndex = 27
                    Me.GridView1.Columns("REC7").Visible = True
                    Me.GridView1.Columns("REC7").VisibleIndex = 28
                    Me.GridView1.Columns("REC8").Visible = False
                Case 2
                    Me.GridView1.Columns("REC5").Visible = True
                    Me.GridView1.Columns("REC5").VisibleIndex = 28
                    Me.GridView1.Columns("REC6").Visible = False
                    Me.GridView1.Columns("REC7").Visible = False
                    Me.GridView1.Columns("REC8").Visible = False
                Case 3
                    Me.GridView1.Columns("REC5").Visible = True
                    Me.GridView1.Columns("REC5").VisibleIndex = 28
                    Me.GridView1.Columns("REC6").Visible = False
                    Me.GridView1.Columns("REC7").Visible = False
                    Me.GridView1.Columns("REC8").Visible = False
                Case 4
                    Me.GridView1.Columns("REC5").Visible = True
                    Me.GridView1.Columns("REC5").VisibleIndex = 26
                    Me.GridView1.Columns("REC6").Visible = False
                    Me.GridView1.Columns("REC7").Visible = True
                    Me.GridView1.Columns("REC7").VisibleIndex = 27
                    Me.GridView1.Columns("REC8").Visible = True
                    Me.GridView1.Columns("REC8").VisibleIndex = 28
                Case 5
                    Me.GridView1.Columns("REC5").Visible = True
                    Me.GridView1.Columns("REC5").VisibleIndex = 27
                    Me.GridView1.Columns("REC6").Visible = False
                    Me.GridView1.Columns("REC7").Visible = False
                    Me.GridView1.Columns("REC8").Visible = True
                    Me.GridView1.Columns("REC8").VisibleIndex = 28
                Case 6
                    Me.GridView1.Columns("REC5").Visible = False
                    Me.GridView1.Columns("REC6").Visible = False
                    Me.GridView1.Columns("REC7").Visible = True
                    Me.GridView1.Columns("REC7").VisibleIndex = 27
                    Me.GridView1.Columns("REC8").Visible = True
                    Me.GridView1.Columns("REC8").VisibleIndex = 28
                Case 7
                    Me.GridView1.Columns("REC5").Visible = False
                    Me.GridView1.Columns("REC6").Visible = False
                    Me.GridView1.Columns("REC7").Visible = False
                    Me.GridView1.Columns("REC8").Visible = True
                    Me.GridView1.Columns("REC8").VisibleIndex = 28
                Case 8
                    Me.GridView1.Columns("REC5").Visible = False
                    Me.GridView1.Columns("REC6").Visible = False
                    Me.GridView1.Columns("REC7").Visible = False
                    Me.GridView1.Columns("REC8").Visible = True
                    Me.GridView1.Columns("REC8").VisibleIndex = 28
                Case 9
                    Me.GridView1.Columns("REC5").Visible = True
                    Me.GridView1.Columns("REC5").VisibleIndex = 27
                    Me.GridView1.Columns("REC6").Visible = True
                    Me.GridView1.Columns("REC6").VisibleIndex = 28
                    Me.GridView1.Columns("REC7").Visible = False
                    Me.GridView1.Columns("REC8").Visible = False
            End Select
            Me.GridView1.Columns("REC9").Visible = True
            Me.GridView1.Columns("REC9").VisibleIndex = 29
        Else
            Me.GridView1.Columns("REC1").Visible = False
            Me.GridView1.Columns("REC2").Visible = False
            Me.GridView1.Columns("REC3").Visible = False
            Me.GridView1.Columns("REC4").Visible = False
            Me.GridView1.Columns("REC5").Visible = False
            Me.GridView1.Columns("REC6").Visible = False
            Me.GridView1.Columns("REC7").Visible = False
            Me.GridView1.Columns("REC8").Visible = False
            Me.GridView1.Columns("REC9").Visible = False
        End If
        Me.GridView1.Columns("VALIDADO").VisibleIndex = 30

        Me.IMVPLANILLAREQUISITOBindingSource.Filter = filtro
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Dim view As GridView = GridView1

        If view.DataRowCount = 0 Then Exit Sub

        For i = 0 To view.DataRowCount - 1
            Dim cnx As New OracleConnection(Configuracion.verconfig)
            Dim sqlString As String = String.Format("UPDATE TSE.IM_CANDIDATOS SET VALIDADO='{0}' WHERE CODIGO_CANDIDATOS={1}", _
                                                    If(view.GetRowCellValue(i, "VALIDADO") = "1", "S", "N"), _
                                                    view.GetRowCellValue(i, "CODIGO_CANDIDATOS"))
            Try
                Dim cmd As New OracleCommand(sqlString, cnx)

                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
            Catch ex As Exception
                Mensajes.mimensaje(ex.Message)
            End Try
        Next i
        Mensajes.mimensaje("Planilla actualizada correctamente.")
    End Sub

    Private Sub cbxNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNivel.SelectedIndexChanged

        Select Case cbxNivel.SelectedValue
            Case 0, 1 'Ninguno, Presidente
                Me.cbxDepartamento.Enabled = False
                Me.cbxMunicipio.Enabled = False
                Me.DepartamentosTableAdapter.Fill(Me.DSConsultas.Departamentos)
                Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)
                Me.cbxDepartamento.SelectedValue = 0
                Me.cbxMunicipio.SelectedValue = 0
            Case 2 'Diputados
                Me.cbxDepartamento.Enabled = True
                Me.cbxMunicipio.Enabled = False
                Me.DepartamentosTableAdapter.FillBySinTodos(Me.DSConsultas.Departamentos)
                Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)
                Me.cbxDepartamento.SelectedValue = 1
                Me.cbxMunicipio.SelectedValue = 0
            Case 3 'Alcaldes
                Me.cbxDepartamento.Enabled = True
                Me.cbxMunicipio.Enabled = True
                Me.DepartamentosTableAdapter.FillBySinTodos(Me.DSConsultas.Departamentos)
                Me.MunicipiosTableAdapter.FillBySinTodos(Me.DSConsultas.Municipios)
                Me.cbxDepartamento.SelectedValue = 1
                Me.cbxMunicipio.SelectedValue = 1
        End Select

    End Sub

    Private Sub cbxCargo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCargo.SelectedIndexChanged

    End Sub
End Class