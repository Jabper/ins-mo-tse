Public Class XfrmSubirSistExterno 

    Private Sub XfrmSubirSistExterno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BtnCandidatos.Height = Me.BtnCandidatos.Height + 15
        Me.BtnCandidatos.Width = Me.BtnCandidatos.Width + 15
        Dim punto As Point = New Point(Me.BtnCandidatos.Location.X - 7.5, Me.BtnCandidatos.Location.Y - 7.5)
        Me.BtnCandidatos.Location = punto
    End Sub

    Private Sub BtnCandidatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCandidatos.Click
        Me.BtnCandidatos.Height = Me.BtnCandidatos.Height - 15
        Me.BtnCandidatos.Width = Me.BtnCandidatos.Width - 15
        Dim punto As Point = New Point(Me.BtnCandidatos.Location.X + 7.5, Me.BtnCandidatos.Location.Y + 7.5)
        Me.BtnCandidatos.Location = punto
        Me.BtnCandidatos.Enabled = False

        Me.BtnCandidatosRepetidos.Enabled = True
        Me.BtnCandidatosRepetidos.Height = Me.BtnCandidatosRepetidos.Height + 15
        Me.BtnCandidatosRepetidos.Width = Me.BtnCandidatosRepetidos.Width + 15
        punto = New Point(Me.BtnCandidatosRepetidos.Location.X - 7.5, Me.BtnCandidatosRepetidos.Location.Y - 7.5)
        Me.BtnCandidatosRepetidos.Location = punto
    End Sub

    Private Sub BtnRequisitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRequisitos.Click
        Me.BtnRequisitos.Height = Me.BtnRequisitos.Height - 15
        Me.BtnRequisitos.Width = Me.BtnRequisitos.Width - 15
        Dim punto As Point = New Point(Me.BtnRequisitos.Location.X + 7.5, Me.BtnRequisitos.Location.Y + 7.5)
        Me.BtnRequisitos.Location = punto
        Me.BtnRequisitos.Enabled = False

        Me.BtnFirmas.Enabled = True
        Me.BtnFirmas.Height = Me.BtnFirmas.Height + 15
        Me.BtnFirmas.Width = Me.BtnFirmas.Width + 15
        punto = New Point(Me.BtnFirmas.Location.X - 7.5, Me.BtnFirmas.Location.Y - 7.5)
        Me.BtnFirmas.Location = punto
    End Sub

    Private Sub BtnCandidatosRepetidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCandidatosRepetidos.Click
        Me.BtnCandidatosRepetidos.Height = Me.BtnCandidatosRepetidos.Height - 15
        Me.BtnCandidatosRepetidos.Width = Me.BtnCandidatosRepetidos.Width - 15
        Dim punto As Point = New Point(Me.BtnCandidatosRepetidos.Location.X + 7.5, Me.BtnCandidatosRepetidos.Location.Y + 7.5)
        Me.BtnCandidatosRepetidos.Location = punto
        Me.BtnCandidatosRepetidos.Enabled = False

        Me.BtnRequisitos.Enabled = True
        Me.BtnRequisitos.Height = Me.BtnRequisitos.Height + 15
        Me.BtnRequisitos.Width = Me.BtnRequisitos.Width + 15
        punto = New Point(Me.BtnRequisitos.Location.X - 7.5, Me.BtnRequisitos.Location.Y - 7.5)
        Me.BtnRequisitos.Location = punto
    End Sub

    Private Sub BtnFirmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirmas.Click
        Me.BtnFirmas.Height = Me.BtnFirmas.Height - 15
        Me.BtnFirmas.Width = Me.BtnFirmas.Width - 15
        Dim punto As Point = New Point(Me.BtnFirmas.Location.X + 7.5, Me.BtnFirmas.Location.Y + 7.5)
        Me.BtnFirmas.Location = punto
        Me.BtnFirmas.Enabled = False

        Me.BtnMovimiento.Enabled = True
        Me.BtnMovimiento.Height = Me.BtnMovimiento.Height + 15
        Me.BtnMovimiento.Width = Me.BtnMovimiento.Width + 15
        punto = New Point(Me.BtnMovimiento.Location.X - 7.5, Me.BtnMovimiento.Location.Y - 7.5)
        Me.BtnMovimiento.Location = punto
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class