Imports System.Data.OracleClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class XfrmValidarFirmas

    Private Sub XfrmValidarFirmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.IM_V_VALIDAR_FIRMAS' table. You can move, or remove it, as needed.
        'Me.IM_V_VALIDAR_FIRMASTableAdapter.Fill(Me.DSConsultas.IM_V_VALIDAR_FIRMAS)
        'TODO: This line of code loads data into the 'DSConsultas.Municipios' table. You can move, or remove it, as needed.
        Me.MunicipiosTableAdapter.FillBySinTodos(Me.DSConsultas.Municipios)
        'TODO: This line of code loads data into the 'DSConsultas.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.FillBySinTodos(Me.DSConsultas.Departamentos)
        'TODO: This line of code loads data into the 'DSConsultas.Movimientos' table. You can move, or remove it, as needed.
        Me.MovimientosTableAdapter.Fill(Me.DSConsultas.Movimientos)
        'TODO: This line of code loads data into the 'DSConsultas.Partidos' table. You can move, or remove it, as needed.
        Me.PartidosTableAdapter.Fill(Me.DSConsultas.Partidos)
        FillGrid()
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Dim _filter As String = String.Empty

        Me.IM_V_VALIDAR_FIRMASTableAdapter.FillBy(Me.DSConsultas.IM_V_VALIDAR_FIRMAS, Me.cbxPartido.SelectedValue.ToString, Me.cbxMovimiento.SelectedValue.ToString, _
                                                  Me.cbxDepartamento.SelectedValue.ToString, Me.cbxMunicipio.SelectedValue.ToString)
        Me.NavegacionTableAdapter.FillBy(Me.DSConsultas.Navegacion, Me.cbxPartido.SelectedValue.ToString, Me.cbxMovimiento.SelectedValue.ToString, _
                                         Me.cbxDepartamento.SelectedValue.ToString, Me.cbxMunicipio.SelectedValue.ToString)
        If Me.txtFolio.Text <> "0" AndAlso Me.txtFolio.Text <> String.Empty Then _filter = _filter & String.Format("FOLIO={0}", Me.txtFolio.Text)
        If Me.txtPagina.Text <> "0" AndAlso Me.txtPagina.Text <> String.Empty Then _filter = _filter & If(_filter <> String.Empty, " AND ", String.Empty) & String.Format("PAGINA={0}", Me.txtPagina.Text)
        Me.NavegacionBindingSource.Filter = _filter
        setFilter()

    End Sub

    Private Sub txtPagina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPagina.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub setFilter()
        Dim _filter As String = String.Empty
        Dim _drv As DataRowView = NavegacionBindingSource.Current
        Dim _folio As Long = 0
        Dim _pagina As Long = 0
        Dim _maquina As String = String.Empty

        If _drv IsNot Nothing Then
            _folio = _drv.Row.Item("folio").ToString
            _pagina = _drv.Row.Item("pagina").ToString
            _maquina = _drv.Row.Item("maquina").ToString
        End If

        If _folio > 0 Then _filter = _filter & String.Format("FOLIO={0}", _folio)
        If _pagina > 0 Then _filter = _filter & If(_filter <> String.Empty, " AND ", String.Empty) & String.Format("PAGINA={0}", _pagina)
        If _maquina <> String.Empty Then _filter = _filter & If(_filter <> String.Empty, " AND ", String.Empty) & String.Format("MAQUINA='{0}'", _maquina)
        Me.IMVVALIDARFIRMASBindingSource.Filter = _filter

        Me.ImagenesFirmaTableAdapter.FillByMaquina(Me.DSConsultas.ImagenesFirma, Me.cbxPartido.SelectedValue.ToString, Me.cbxMovimiento.SelectedValue.ToString, _folio, _pagina, _maquina)
    End Sub

    Private Sub pbxFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxFirma.Click
        Stop
    End Sub

    Private Sub NavegacionBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NavegacionBindingSource.CurrentChanged
        setFilter()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Dim view As GridView = GridView1

        If view.DataRowCount = 0 Then Exit Sub

        For i = 0 To view.DataRowCount - 1
            Dim cnx As New OracleConnection(Configuracion.verconfig)
            Dim sqlString As String = String.Format("UPDATE TSE.IM_CIUDADANOS_RESPALDAN SET VALIDADO='{0}' WHERE CODIGO_CUIDADANOS_RESPALDAN={1}", _
                                                    view.GetRowCellValue(i, "VALIDADO"), view.GetRowCellValue(i, "CODIGO_CUIDADANOS_RESPALDAN"))
            Try
                Dim cmd As New OracleCommand(sqlString, cnx)

                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
            Catch ex As Exception
                Mensajes.mimensaje(ex.Message)
            End Try
        Next i
        Mensajes.mimensaje("Registros actualizados correctamente.")
    End Sub
End Class