Public Class XfrmMovimientos 

    Private Sub XfrmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DSPolitico.IM_MOVIMIENTOS)
     
        

    End Sub

    Sub guardar()

        Try
            Me.IMMOVIMIENTOSBindingSource.EndEdit()
            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSPolitico.IM_MOVIMIENTOSRow In DSPolitico.IM_MOVIMIENTOS
                'SI ES UN NUEVO REGITRO
                If _datar.RowState = DataRowState.Added Then
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now
                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                End If
            Next
            Me.IM_MOVIMIENTOSTableAdapter.Update(Me.DSPolitico.IM_MOVIMIENTOS)
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try








    End Sub

    Sub nuevo()
        Me.IMMOVIMIENTOSBindingSource.CancelEdit()
        Me.IMMOVIMIENTOSBindingSource.AddNew()

    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        guardar()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        nuevo()
    End Sub
End Class