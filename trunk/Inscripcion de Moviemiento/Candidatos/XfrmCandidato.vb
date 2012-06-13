Public Class XfrmCandidato 
    Dim actualizar As Boolean = False
    Private Sub XfrmCandidato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSPolitico.IM_CARGOS_ELECTIVOS)
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)

        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        Me.IMCANDIDATOSBindingSource.AddNew()
        ActualizarGrid()

        If COracle.credenciales("BtnCandidatos", "MODIFICAR") = "N" And COracle.credenciales("BtnCandidatos", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnCandidatos", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnCandidatos", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnCandidatos", "ELIMINAR", Me.BtnEliminar)
    End Sub

    Private Sub CODIGO_DEPARTAMENTOTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_DEPARTAMENTOTextEdit.EditValueChanged
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_MUNICIPIOS' table. You can move, or remove it, as needed.

        Try

            Me.IM_MUNICIPIOSTableAdapter.FillBy1(Me.DSDeptoMuni.IM_MUNICIPIOS, Me.CODIGO_DEPARTAMENTOTextEdit.EditValue)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOSpinEdit.EditValueChanged
        'TODO: This line of code loads data into the 'DSPolitico.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Try
            Me.IM_MOVIMIENTOSTableAdapter.FillBy2(Me.DSPolitico.IM_MOVIMIENTOS, CType(Me.CODIGO_PARTIDOSpinEdit.EditValue, Integer))

        Catch ex As Exception

        End Try
       
    End Sub



    Sub Nuevo()
        Me.IMCANDIDATOSBindingSource.CancelEdit()
        Me.IMCANDIDATOSBindingSource.AddNew()

    End Sub

    Sub guardar()
       
        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMCANDIDATOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSCandidato.IM_CANDIDATOSRow In DSCandidato.IM_CANDIDATOS
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
            Me.IM_CANDIDATOSTableAdapter.Update(Me.DSCandidato.IM_CANDIDATOS)

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
            Me.IM_CANDIDATOSTableAdapter.FillBy(Me.DSCandidato.IM_CANDIDATOS, CType(cellValue, Integer))

        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        Me.DT_CANDIDATOTableAdapter.Fill(Me.DSCandidato.DT_CANDIDATO)

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnCandidatos", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnCandidatos", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnCandidatos", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnCandidatos", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub
End Class