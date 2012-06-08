Public Class XfrmParametros 

    Private Sub XfrmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSParametros.IM_PARAMETROS_GENERALES' table. You can move, or remove it, as needed.
        Me.IM_PARAMETROS_GENERALESTableAdapter.Fill(Me.DSParametros.IM_PARAMETROS_GENERALES)
        'Me.IMPARAMETROSGENERALESBindingSource.AddNew()

    End Sub

    Sub guardar()
        Try
            'TEXTO ENLAZADO
            Me.txtfecha.Visible = True
            Me.txtfecha.Text = DateTime.Now

            Me.IMPARAMETROSGENERALESBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSParametros.IM_PARAMETROS_GENERALESRow In DSParametros.IM_PARAMETROS_GENERALES
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

            Me.IM_PARAMETROS_GENERALESTableAdapter.Update(Me.DSParametros.IM_PARAMETROS_GENERALES)
            Me.txtfecha.Visible = False
            Mensajes.MensajeActualizar()

        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.IMPARAMETROSGENERALESBindingSource.CancelEdit()
        Me.IMPARAMETROSGENERALESBindingSource.AddNew()
    End Sub
End Class