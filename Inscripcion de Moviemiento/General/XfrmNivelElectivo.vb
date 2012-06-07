Public Class XfrmNivelElectivo 

    Private Sub XfrmNivelElectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DataSet1.IM_NIVEL_ELECTIVO)
        ActualizarGrid()
        Me.IMNIVELELECTIVOBindingSource.AddNew()
    End Sub



    Sub ActualizarGrid()
        Me.TA_NIVEL_ELECTIVOTableAdapter.Fill(Me.DataSet1.TA_NIVEL_ELECTIVO)

    End Sub
    Sub guardar()



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
            ActualizarGrid()
            Mensajes.MensajeGuardar()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
       




        
    End Sub

    Sub nuevo()

        Me.IMNIVELELECTIVOBindingSource.CancelEdit()
        Me.IMNIVELELECTIVOBindingSource.AddNew()
      
    End Sub

    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_NIVEL_ELECTIVOTableAdapter.FillBy(Me.DataSet1.IM_NIVEL_ELECTIVO, CType(cellValue, Integer))
            'writedata = False


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

   

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub
End Class