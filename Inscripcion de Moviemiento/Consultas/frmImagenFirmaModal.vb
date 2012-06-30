
Public Class frmImagenFirmaModal
    Private _codigoPartido As Integer
    Private _codigoMovimiento As Integer
    Private _folio As Integer
    Private _pagina As Integer
    Private _maquina As String

    Public WriteOnly Property codigoPartido() As Integer
        Set(ByVal value As Integer)
            _codigoPartido = value
        End Set
    End Property

    Public WriteOnly Property codigoMovimiento() As Integer
        Set(ByVal value As Integer)
            _codigoMovimiento = value
        End Set
    End Property

    Public WriteOnly Property folio() As Integer
        Set(ByVal value As Integer)
            _folio = value
        End Set
    End Property

    Public WriteOnly Property pagina() As Integer
        Set(ByVal value As Integer)
            _pagina = value
        End Set
    End Property

    Public WriteOnly Property maquina() As String
        Set(ByVal value As String)
            _maquina = value
        End Set
    End Property

    Public WriteOnly Property Titulo() As String
        Set(ByVal value As String)
            Me.Text = value
        End Set
    End Property

    Private Sub frmImagenModal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _filter As String = String.Empty
        If _folio > 0 Then _filter = _filter & String.Format("FOLIO={0}", _folio)
        Me.ImagenesFirmaTableAdapter.FillByMaquina(Me.DSConsultas.ImagenesFirma, _codigoPartido, _codigoMovimiento, _pagina, _maquina)
        Me.ImagenesFirmaBindingSource.Filter = _filter
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class