Public Class XfrmRequisitos 

    Private Sub XfrmRequisitos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSPolitico.IM_CARGOS_ELECTIVOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_REQUISITOS' table. You can move, or remove it, as needed.
        Me.IM_REQUISITOSTableAdapter.Fill(Me.DSCandidato.IM_REQUISITOS)
        Me.IMREQUISITOSBindingSource.AddNew()
        ActualizarGrid()
    End Sub

    Sub Nuevo()
        Me.IMREQUISITOSBindingSource.CancelEdit()
        Me.IMREQUISITOSBindingSource.AddNew()
    End Sub

    Sub guardar()
        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMREQUISITOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSCandidato.IM_REQUISITOSRow In DSCandidato.IM_REQUISITOS
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
            Me.IM_REQUISITOSTableAdapter.Update(Me.DSCandidato.IM_REQUISITOS)

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarGrid()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub
    Sub MostrarDatos()
        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_REQUISITOSTableAdapter.FillBy(Me.DSCandidato.IM_REQUISITOS, cellValue)
            'writedata = False


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DSCandidato.TA_REQUISITOS' table. You can move, or remove it, as needed.
        Me.TA_REQUISITOSTableAdapter.Fill(Me.DSCandidato.TA_REQUISITOS)

    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub
End Class