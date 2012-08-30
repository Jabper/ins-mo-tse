Partial Class DT_Renuncia
    Partial Class IM_RENUNCIASDataTable

        Private Sub IM_RENUNCIASDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MODIFICADO_PORColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class IM_V_CANDIDATO_RENUNCIADataTable

    End Class

End Class
