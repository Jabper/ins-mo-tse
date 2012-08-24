
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports System.Data.OracleClient
Public Class xfrmRenunciaCandidatos

    Private Sub xfrmRenunciaCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnbusqueda_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnbusqueda.ButtonClick
        ''REALIZAR BUSQUEDA
    End Sub

    Private Sub btnbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnbusqueda.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.btnbusqueda.Text = ""

        End If

        If (e.KeyCode = Keys.Enter) Then
            ''REALIZAR BUSQUEDA
        End If
    End Sub

    Function TotalFilas() As Integer

        Dim view As GridView = GridView1
        Return view.DataRowCount - 1
    End Function


    Sub ValidarFilas()
        Dim contador As Integer = 0
        Dim view As GridView = GridView1
        Try
            For i = 0 To TotalFilas()
                If view.GetRowCellValue(i, "Renuncia") = "S" Then
                    contador += 1


                End If

            Next

            

        Catch ex As Exception

        End Try
    End Sub
    Function Cheked(ByVal contador As Integer)
        If (contador - 1) = (TotalFilas() - 1) Then

        Else

            'Mensajes.mimensaje("Debe Seleccionar ")
        End If
    End Function

End Class