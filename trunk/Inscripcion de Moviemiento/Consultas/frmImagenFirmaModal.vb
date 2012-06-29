
Public Class frmImagenFirmaModal
    Private _codigoPartido As Integer
    Private _codigoMovimiento As Integer
    Private _codigoCandidato As Integer
    Private _codigoRequisito As Integer

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

    Public WriteOnly Property codigoCandidato() As Integer
        Set(ByVal value As Integer)
            _codigoCandidato = value
        End Set
    End Property

    Public WriteOnly Property codigoRequisito() As Integer
        Set(ByVal value As Integer)
            _codigoRequisito = value
        End Set
    End Property

    Public WriteOnly Property Titulo() As String
        Set(ByVal value As String)
            Me.Text = value
        End Set
    End Property

    Private Sub frmImagenModal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ImagenRequisitoTableAdapter.FillBy(Me.DSConsultas.imagenRequisito, _codigoCandidato, _codigoPartido, _codigoMovimiento, _codigoRequisito)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class