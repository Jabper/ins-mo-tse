Public Class XfrmPartidosPoliticos 

    Private Sub XfrmPartidosPoliticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        'TODO: This line of code loads data into the 'DataSet1.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DataSet1.IM_PARTIDOS_POLITICOS)

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub


    Sub guardar()

        Dim usuario As Integer = 2

        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMPARTIDOSPOLITICOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DataSet1.IM_PARTIDOS_POLITICOSRow In DataSet1.IM_PARTIDOS_POLITICOS

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

            'AGREGANDO LA INFORMACION A LA BASE DE DATOS
            Me.IM_PARTIDOS_POLITICOSTableAdapter.Update(Me.DataSet1.IM_PARTIDOS_POLITICOS)

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION

        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMPARTIDOSPOLITICOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()

        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub
End Class