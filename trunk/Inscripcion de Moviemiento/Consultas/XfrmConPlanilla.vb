Public Class XfrmConPlanilla 

    Private Sub XfrmConPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.IM_V_PLANILLA_REQUISITO' table. You can move, or remove it, as needed.
        Me.IM_V_PLANILLA_REQUISITOTableAdapter.Fill(Me.DSConsultas.IM_V_PLANILLA_REQUISITO)
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

    End Sub

    Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs)
        Dim rw As DataRowView = GridView1.GetRow(e.RowHandle)

        If rw IsNot Nothing Then

            If (e.Column.ColumnHandle = 0 AndAlso Not IsDBNull(rw.Row.Item(0)) OrElse e.Column.ColumnHandle = 1 AndAlso Not IsDBNull(rw.Row.Item(1))) AndAlso (e.Column.ColumnHandle = 0 OrElse e.Column.ColumnHandle = 1) Then
                frmImagenModal.codigoPartido = rw.Row.Item(19)
                frmImagenModal.codigoMovimiento = rw.Row.Item(20)
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
End Class