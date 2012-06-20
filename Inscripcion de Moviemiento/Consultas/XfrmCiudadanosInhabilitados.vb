Imports System.Data.OracleClient

Public Class XfrmCiudadanosInhabilitados

    Private Sub XfrmCiudadanosInhabilitados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DSConsultas.IM_CIUDADANOS_INHABILITADOS' table. You can move, or remove it, as needed.
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.Fill(Me.DSConsultas.IM_CIUDADANOS_INHABILITADOS)
        'TODO: This line of code loads data into the 'DSConsultas.IM_MOTIVOS_INHABILITACION' table. You can move, or remove it, as needed.
        Me.IM_MOTIVOS_INHABILITACIONTableAdapter.Fill(Me.DSConsultas.IM_MOTIVOS_INHABILITACION)
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Me.IMMOTIVOSINHABILITACIONBindingSource.Filter = String.Format("NOMBRES LIKE '%{0}%'", Me.txtNombres.Text)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class