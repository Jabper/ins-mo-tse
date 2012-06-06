Public Class XfrmNivelElectivo 

    Private Sub XfrmNivelElectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         'TODO: This line of code loads data into the 'DataSet1.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DataSet1.IM_NIVEL_ELECTIVO)

    End Sub

    Sub guardar()
        Dim usuario As Integer = 2


        Try
            Me.IMNIVELELECTIVOBindingSource.EndEdit()
            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DataSet1.IM_NIVEL_ELECTIVORow In DataSet1.IM_NIVEL_ELECTIVO
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

            Me.IM_NIVEL_ELECTIVOTableAdapter.Update(Me.DataSet1.IM_NIVEL_ELECTIVO)
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
       




        
    End Sub

    Sub nuevo()

        Me.IMNIVELELECTIVOBindingSource.CancelEdit()
        Me.IMNIVELELECTIVOBindingSource.AddNew()
        Me.GCNivelElectivo.Enabled = False

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.IMNIVELELECTIVOBindingSource.CancelEdit()

        Me.GCNivelElectivo.Enabled = True
    End Sub
End Class