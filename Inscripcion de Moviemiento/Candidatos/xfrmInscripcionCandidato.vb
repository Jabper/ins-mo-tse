Imports System.Data.OracleClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class xfrmInscripcionCandidato
    Dim actualizar As Boolean = False
    Dim id As Integer
    Dim rEstado As String

    Sub VerificarRequisitos()
        Try

            Dim view2 As GridView = GridView5
            'RECORRER EL GRID
            Dim vestado As String
            For i = 0 To view2.DataRowCount - 1
                If view2.GetRowCellValue(i, "CODIGO_REQUISITO") = 4 Or view2.GetRowCellValue(i, "CODIGO_REQUISITO") = 5 Or view2.GetRowCellValue(i, "CODIGO_REQUISITO") = 6 Then

                    Dim oradb As String = Configuracion.verconfig

                    Dim conn As New OracleConnection()
                    conn.ConnectionString = oradb
                    conn.Open()

                    Dim myCMD As New OracleCommand()
                    myCMD.Connection = conn
                    myCMD.CommandText = "IM_K_VALIDACIONES.IM_P_VALIDA_EDAD"
                    myCMD.CommandType = CommandType.StoredProcedure
                    myCMD.Parameters.Add(New OracleParameter("p_numero_identidad", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = Me.IDENTIDADTextEdit.EditValue
                    myCMD.Parameters.Add(New OracleParameter("p_requisito", OracleType.Number, 3, ParameterDirection.Input)).Value = view2.GetRowCellValue(i, "CODIGO_REQUISITO")
                    myCMD.Parameters.Add(New OracleParameter("p_estado", OracleType.Char, 1)).Direction = ParameterDirection.InputOutput
                    myCMD.ExecuteOracleScalar()
                    vestado = myCMD.Parameters("p_estado").Value
                    view2.SetRowCellValue(i, "ESTADO", vestado)

                    conn.Close()
                Else
                    vestado = "C"
                    view2.SetRowCellValue(i, "ESTADO", vestado)
                End If
            Next i


        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Sub GuardarRequisitos()

        Try

            Dim vestado As String
            Dim vCodigo_requisito As Integer


            Dim vcodigo_Candidato As Integer
            Dim consulta As String = "SELECT MAX(CODIGO_CANDIDATOS) maximo FROM IM_CANDIDATOS"
            vcodigo_Candidato = CType(COracle.ObtenerDatos(consulta, "maximo"), Integer)

            Dim view As GridView = GridView3
            'RECORRER EL GRID

            For i = 0 To view.DataRowCount - 1

                view.SetRowCellValue(i, "ESTADO", "C")
                'Return

                vCodigo_requisito = view.GetRowCellValue(i, "CODIGO_REQUISITO")
                vestado = view.GetRowCellValue(i, "ESTADO")

                Dim CANDIDATOS As DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATORow
                CANDIDATOS = DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO.NewIM_REQUISITOS_X_CANDIDATORow

                With CANDIDATOS
                    .CODIGO_REQUISITO = vCodigo_requisito
                    .CODIGO_CANDIDATO = vcodigo_Candidato
                    .CODIGO_PARTIDO = IdPartidoPolitico
                    .CODIGO_MOVIMIENTO = IdMovimientoPolitico
                    If IsDBNull(view.GetRowCellValue(i, "IMAGEN")) Then
                    Else
                        .IMAGEN = view.GetRowCellValue(i, "IMAGEN")
                    End If

                    .ADICIONADO_POR = usuario
                    .FECHA_ADICION = DateTime.Now
                    .ESTADO = vestado

                End With

                Me.DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO.Rows.Add(CANDIDATOS)
                Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Update(Me.DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO)


            Next i




            Dim view2 As GridView = GridView5
            'RECORRER EL GRID

            For i = 0 To view2.DataRowCount - 1

                'view.SetRowCellValue(i, "ESTADO", "C")
                'Return

                vCodigo_requisito = view2.GetRowCellValue(i, "CODIGO_REQUISITO")
                view2.SetRowCellValue(i, "ESTADO1", "C")
                vestado = view2.GetRowCellValue(i, "ESTADO1")

                Dim CANDIDATOS As DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATORow
                CANDIDATOS = DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO.NewIM_REQUISITOS_X_CANDIDATORow

                With CANDIDATOS
                    .CODIGO_REQUISITO = vCodigo_requisito
                    .CODIGO_CANDIDATO = vcodigo_Candidato
                    .CODIGO_PARTIDO = IdPartidoPolitico
                    .CODIGO_MOVIMIENTO = IdMovimientoPolitico
                    If IsDBNull(view.GetRowCellValue(i, "IMAGEN1")) Then
                    Else
                        .IMAGEN = view.GetRowCellValue(i, "IMAGEN1")
                    End If

                    .ADICIONADO_POR = usuario
                    .FECHA_ADICION = DateTime.Now
                    .ESTADO = vestado

                End With

                Me.DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO.Rows.Add(CANDIDATOS)
                Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Update(Me.DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO)


            Next i

        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Sub guardar()

        Try
            Dim oradb As String = Configuracion.verconfig

            Dim conn As New OracleConnection()
            conn.ConnectionString = oradb
            conn.Open()

            Dim myCMD As New OracleCommand()
            myCMD.Connection = conn
            myCMD.CommandText = "IM_P_INSERT_CANDIDATOS"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("PVI_NOMBRE", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = Me.NOMBRETextEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("PNI_POSICION", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.POSICIONSpinEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CARGO_ELECTIVO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("PVI_APELLIDO", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = Me.APELLIDOTextEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_DEPARTAMENTO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MUNICIPIO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.CODIGO_MUNICIPIOLookUpEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MOVIMIENTO", OracleType.Number, 3, ParameterDirection.Input)).Value = IdMovimientoPolitico
            myCMD.Parameters.Add(New OracleParameter("PVI_IDENTIDAD", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = Me.IDENTIDADTextEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_PARTIDO", OracleType.Number, 2, ParameterDirection.Input)).Value = IdPartidoPolitico
            myCMD.Parameters.Add(New OracleParameter("PVI_ADICIONADO_POR", OracleType.NVarChar, 11, ParameterDirection.Input)).Value = usuario
            myCMD.Parameters.Add(New OracleParameter("PDI_FECHA_ADICION", OracleType.DateTime, ParameterDirection.Input)).Value = DateTime.Now
            myCMD.Parameters.Add(New OracleParameter("PVO_MENSAJE", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.Parameters.Add(New OracleParameter("PVI_ESTADO", OracleType.NVarChar, 1, ParameterDirection.Input)).Value = "I"
            myCMD.ExecuteOracleScalar()


            If myCMD.Parameters("PVO_MENSAJE").Value = "OK" Then
                'Edicion
                GuardarRequisitos()
                BtnEliminar.Enabled = False
                If actualizar = True Then
                    Mensajes.MensajeActualizar()
                    actualizar = False
                Else
                    Me.DSInscripcionCandidatos.IM_REQUISITOS.Rows.Clear()
                    Me.DSInscripcionCandidatos.IM_REQUISITOS1.Rows.Clear()
                    Mensajes.MensajeGuardar()
                End If

                Me.NOMBRETextEdit.EditValue = Nothing
                Me.APELLIDOTextEdit.EditValue = Nothing
                Me.POSICIONSpinEdit.EditValue = Nothing
                Me.IDENTIDADTextEdit.EditValue = Nothing
                Me.POSICIONSpinEdit.Enabled = True
                'Me.LookUpEdit1.Reset()
                'ACTUALIZARGRID()

            Else
                Mensajes.MensajeError(myCMD.Parameters("PVO_MENSAJE").Value)
            End If


            conn.Close()

        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub


    Sub Nuevo()
        'PARTIDO

        Try

            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMCANDIDATOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMCANDIDATOSBindingSource.AddNew()
            Me.LookUpEdit1.EditValue = Nothing
            Me.BtnEliminar.Enabled = False
            Me.POSICIONSpinEdit.Enabled = True
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

        Dim p As Integer = Me.CODIGO_PARTIDOLookUpEdit.Properties.GetDataSourceRowIndex(Me.CODIGO_PARTIDOLookUpEdit.Properties.Columns("CODIGO_PARTIDO"), IdPartidoPolitico)
        Me.CODIGO_PARTIDOLookUpEdit.EditValue = Me.CODIGO_PARTIDOLookUpEdit.Properties.GetDataSourceValue(Me.CODIGO_PARTIDOLookUpEdit.Properties.ValueMember, p)
        'Movimiento
        Try
            Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MOVIMIENTOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue)


        Catch ex As Exception

        End Try
        Dim m As Integer = Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.GetDataSourceRowIndex(Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.Columns("CODIGO_MOVIMIENTO"), IdMovimientoPolitico)
        Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue = Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.GetDataSourceValue(Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.ValueMember, m)

        Me.CODIGO_PARTIDOLookUpEdit.Enabled = False
        Me.CODIGO_MOVIMIENTOLookUpEdit.Enabled = False
    End Sub
    Private Sub xfrmInscripcionCandidato_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        ActualizarLOV()
    End Sub
    'Sub ACTUALIZARGRID()


    '    Me.TA_CANDIDATOSTableAdapter.FillBycargo(Me.DSInscripcionCandidatos.TA_CANDIDATOS, 9999, _
    '                                                     9999, 9999)

    '    If Me.LookUpEdit1.EditValue = 1 Then
    '        If Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing Then
    '        Else
    '            Me.TA_CANDIDATOSTableAdapter.FillBycargo(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
    '                                                     Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, 1) 'SE PONE 1 POR EL CODIGO DEL PRESIDENTE

    '        End If
    '    ElseIf Me.LookUpEdit1.EditValue = 2 Then
    '        If Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing Or _
    '        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue Is Nothing Then
    '        Else
    '            Me.TA_CANDIDATOSTableAdapter.FillBydepto(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
    '                                                     Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, _
    '                                                  Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue)

    '        End If
    '    ElseIf Me.LookUpEdit1.EditValue = 3 Then
    '        'actualizar el grid segun el municipio
    '        If Me.CODIGO_MUNICIPIOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue Is Nothing Or _
    '        Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing Then

    '        Else
    '            Me.TA_CANDIDATOSTableAdapter.FillBymuni(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
    '                                              Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, _
    '                                           Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue, Me.CODIGO_MUNICIPIOLookUpEdit.EditValue)
    '        End If

    '    End If
    'End Sub

    Private Sub xfrmInscripcionCandidato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO' table. You can move, or remove it, as needed.
        'Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        Me.IM_CANDIDATOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_CANDIDATOS)
        Me.IDENTIDADTextEdit.EditValue = ""

        Nuevo()

        DxControls.ObtenerCredencial("BtnCandidatos", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnCandidatos", "MODIFICAR", Me.BtnGuardar)
        DxControls.ObtenerCredencial("BtnCandidatos", "ELIMINAR", Me.BtnEliminar)
    End Sub

    Sub ActualizarLOV()
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_DEPARTAMENTOS)
        Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MUNICIPIOS, 0)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        ' Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_PARTIDOS_POLITICOS)

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        VerificarRequisitos()

        'Dim view2 As GridView = GridView5
        ''RECORRER EL GRID
        'Dim vestado As String = "C"
        'For i = 0 To view2.DataRowCount - 1

        '    view2.SetRowCellValue(i, "ESTADO", vestado)

        'Next i

        'Dim view1 As GridView = GridView3
        ''RECORRER EL GRID

        'For i = 0 To view2.DataRowCount - 1

        '    view1.SetRowCellValue(i, "ESTADO", vestado)

        'Next i



        'Me.Close()

    End Sub


    Private Sub IDENTIDADTextEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IDENTIDADTextEdit.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE nombre, PRIMER_APELLIDO || ' ' || SEGUNDO_APELLIDO apellido "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & Me.IDENTIDADTextEdit.EditValue & "'"
            Dim N As String = COracle.ObtenerDatos(consulta, "NOMBRE")
            Dim A As String = COracle.ObtenerDatos(consulta, "APELLIDO")
            If N = "N" Then
                Me.NOMBRETextEdit.EditValue = ""
                Me.APELLIDOTextEdit.EditValue = ""
                Return
                'Mensajes.mimensaje("NUMERO DE IDENTIDAD NO EXISTE EN CNE")
            Else
                Me.NOMBRETextEdit.EditValue = N
                Me.APELLIDOTextEdit.EditValue = A

            End If
            Try
                Me.IM_REQUISITOSTableAdapter.FillBY(Me.DSInscripcionCandidatos.IM_REQUISITOS, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, "N")
                Me.IM_REQUISITOS1TableAdapter.FillBY(Me.DSInscripcionCandidatos.IM_REQUISITOS1, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, "S")
                VerificarRequisitos()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub IDENTIDADTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IDENTIDADTextEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub IDENTIDADTextEdit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IDENTIDADTextEdit.LostFocus
        Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE nombre, PRIMER_APELLIDO || ' ' || SEGUNDO_APELLIDO apellido "
        consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & Me.IDENTIDADTextEdit.EditValue & "'"
        Dim N As String = COracle.ObtenerDatos(consulta, "NOMBRE")
        Dim A As String = COracle.ObtenerDatos(consulta, "APELLIDO")
        If N = "N" Then
            Me.NOMBRETextEdit.EditValue = ""
            Me.APELLIDOTextEdit.EditValue = ""
            Return
            'Mensajes.mimensaje("NUMERO DE IDENTIDAD NO EXISTE EN CNE")
        Else
            Me.NOMBRETextEdit.EditValue = N
            Me.APELLIDOTextEdit.EditValue = A

        End If

        Try
            Me.IM_REQUISITOSTableAdapter.FillBY(Me.DSInscripcionCandidatos.IM_REQUISITOS, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, "N")
            Me.IM_REQUISITOS1TableAdapter.FillBY(Me.DSInscripcionCandidatos.IM_REQUISITOS1, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, "S")
            VerificarRequisitos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub POSICIONSpinEdit_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles POSICIONSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub btnActualizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DSInscripcionCandidatos.TA_CANDIDATOS.Rows.Clear()
    End Sub

    Private Sub CODIGO_PARTIDOLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOLookUpEdit.TextChanged
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        'Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MOVIMIENTOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue)
    End Sub

    Private Sub CODIGO_MOVIMIENTOLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_MOVIMIENTOLookUpEdit.TextChanged
        Try
            If IsDBNull(Me.CODIGO_PARTIDOLookUpEdit.EditValue) Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing Or _
            IsDBNull(Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue) Or Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Then
            Else
                'actualizar el grid segun el movimiento
                Me.TA_CANDIDATOSTableAdapter.FillBymovimiento(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
                                                              Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue)
                'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
                Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_NIVEL_ELECTIVO)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LookUpEdit1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookUpEdit1.TextChanged
        Try
            'If IsDBNull(Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue) Or Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Then
            'Else

            'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
            Me.IM_CARGOS_ELECTIVOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_CARGOS_ELECTIVOS, Me.LookUpEdit1.EditValue)

            If Me.LookUpEdit1.EditValue = 1 Then
                'LE ASIGNO EL VALOR DEL CAMPO 0 AL LOOKUPEDIT
                Dim r As Integer = Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.GetDataSourceRowIndex(Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.Columns("CODIGO_DEPARTAMENTO"), "0")
                Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue = Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.GetDataSourceValue(Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.ValueMember, r)
                Dim V As Integer = Me.CODIGO_MUNICIPIOLookUpEdit.Properties.GetDataSourceRowIndex(Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.Columns("CODIGO_DEPARTAMENTO"), "0")
                Me.CODIGO_MUNICIPIOLookUpEdit.EditValue = Me.CODIGO_MUNICIPIOLookUpEdit.Properties.GetDataSourceValue(Me.CODIGO_MUNICIPIOLookUpEdit.Properties.ValueMember, V)

                Me.CODIGO_DEPARTAMENTOLookUpEdit.Enabled = False
                Me.CODIGO_MUNICIPIOLookUpEdit.Enabled = False

                ' ACTUALIZARGRID()

            ElseIf Me.LookUpEdit1.EditValue = 2 Then
                Dim V As Integer = Me.CODIGO_MUNICIPIOLookUpEdit.Properties.GetDataSourceRowIndex(Me.CODIGO_MUNICIPIOLookUpEdit.Properties.Columns("CODIGO_MUNICIPIO"), "0")
                Me.CODIGO_MUNICIPIOLookUpEdit.EditValue = Me.CODIGO_MUNICIPIOLookUpEdit.Properties.GetDataSourceValue(Me.CODIGO_MUNICIPIOLookUpEdit.Properties.ValueMember, V)

                Me.CODIGO_DEPARTAMENTOLookUpEdit.Enabled = True
                Me.CODIGO_MUNICIPIOLookUpEdit.Enabled = False
                'ACTUALIZARGRID()

            ElseIf Me.LookUpEdit1.EditValue = 3 Then

                Me.CODIGO_DEPARTAMENTOLookUpEdit.Enabled = True
                Me.CODIGO_MUNICIPIOLookUpEdit.Enabled = True
                'ACTUALIZARGRID()
            Else

                Me.CODIGO_DEPARTAMENTOLookUpEdit.Enabled = True
                Me.CODIGO_MUNICIPIOLookUpEdit.Enabled = True
            End If
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CODIGO_DEPARTAMENTOLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_DEPARTAMENTOLookUpEdit.TextChanged
        Try
            If Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue Is Nothing Or IsDBNull(Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue) Then
            Else
                'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_MUNICIPIOS' table. You can move, or remove it, as needed.
                Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MUNICIPIOS, Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue)


                Me.TA_CANDIDATOSTableAdapter.FillBydepto(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
                                                            Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, _
                                                         Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CODIGO_CARGO_ELECTIVOLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_CARGO_ELECTIVOLookUpEdit.TextChanged
        Me.POSICIONSpinEdit.EditValue = ""
        Me.POSICIONSpinEdit.Enabled = True
        Try
            If Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue Is Nothing _
            Or IsDBNull(Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue) Then

            Else

                If Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue = 1 Or Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue = 6 Or Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue = 7 Then
                    Me.POSICIONSpinEdit.EditValue = 1
                    Me.POSICIONSpinEdit.Enabled = False
                End If


                Me.TA_CANDIDATOSTableAdapter.FillBycargo(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
                                                        Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue)
            End If
            Me.IDENTIDADTextEdit.Focus()
            Me.CODIGO_DEPARTAMENTOLookUpEdit.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CODIGO_MUNICIPIOLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_MUNICIPIOLookUpEdit.TextChanged
        'actualizar el grid segun el cargo
        Try

            If Me.CODIGO_MOVIMIENTOLookUpEdit.Enabled = False Then
                'actualizar el grid segun el municipio
                If Me.CODIGO_MUNICIPIOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue Is Nothing Or _
                Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing _
                Or Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue Is Nothing Then
                Else
                    Me.TA_CANDIDATOSTableAdapter.FillBymuni(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
                                                      Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, _
                                                   Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue, Me.CODIGO_MUNICIPIOLookUpEdit.EditValue)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        'Dim view2 As GridView = GridView3

        'If (e.Column.FieldName = "Cumplido") Then
        '    If e.Value = True Then
        '        view2.SetRowCellValue(e.RowHandle, "ESTADO", "C")
        '    ElseIf e.Value = False Then
        '        view2.SetRowCellValue(e.RowHandle, "ESTADO", "I")
        '    End If

        'End If
    End Sub

    Private Sub chkCumplido_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCumplido.EditValueChanged
        Dim view2 As GridView = GridView3

        'If view2.GetRowCellValue(i, "CODIGO_REQUISITO") = Then

        'End If


    End Sub

    Private Sub CODIGO_PARTIDOLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOLookUpEdit.EditValueChanged

    End Sub
End Class