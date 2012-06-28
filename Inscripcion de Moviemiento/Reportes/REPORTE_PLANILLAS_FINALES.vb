Public Class REPORTE_PLANILLAS_FINALES

    Public Sub Validarleyendas()
        Dim cdesignados As String = 0
        cdesignados = COracle.ObtenerDatos("SELECT CANTIDAD_CARGO  FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 9", "CANTIDAD_CARGO")
        Me.XrLabel3.Text = "FF" 'cdesignados.ToString

    End Sub

    Private Sub REPORTE_PLANILLAS_FINALES_DesignerLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs) Handles Me.DesignerLoaded
        Validarleyendas()
       
    End Sub
End Class