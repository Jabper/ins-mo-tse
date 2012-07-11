Public Class REPORTE_RAZONADO

    Private Sub REPORTE_RAZONADO_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        'carga de datos de parametros generales 
        Me.presidente.Text = "1"
        Me.parlacenp.Text = "1"
        Me.parlacens.Text = "1"
        Me.congresop.Text = "10"
        Me.congresos.Text = "10"
        Me.corporacionm.Text = "150"


    End Sub
End Class