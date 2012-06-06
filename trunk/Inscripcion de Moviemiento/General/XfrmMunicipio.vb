Public Class Municipios


    Private Sub XfrmMunicipio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSet1.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DataSet1.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DataSet1.IM_MUNICIPIOS' table. You can move, or remove it, as needed.
        Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DataSet1.IM_MUNICIPIOS)

        Me.IMMUNICIPIOSBindingSource.AddNew()
    End Sub

    Sub ActualizarBusqueda()
        'TODO: This line of code loads data into the 'DataSet1.TA_DEPTOSMUNI' table. You can move, or remove it, as needed.
        Me.TA_DEPTOSMUNITableAdapter.Fill(Me.DataSet1.TA_DEPTOSMUNI)
    End Sub
    Sub nuevo()
        Me.IMMUNICIPIOSBindingSource.CancelEdit()
        Me.IMMUNICIPIOSBindingSource.AddNew()
    End Sub
    Sub guardar()



        Try
            Me.IMMUNICIPIOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DataSet1.IM_MUNICIPIOSRow In DataSet1.IM_MUNICIPIOS
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
            Me.IM_MUNICIPIOSTableAdapter.Update(Me.DataSet1.IM_MUNICIPIOS)


            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarBusqueda()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub
End Class