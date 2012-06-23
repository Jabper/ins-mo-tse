Imports System.Data.OracleClient
Imports DevExpress.XtraGrid.Views.Grid
Public Class xfrmRegCandidatos
    Dim vi As Integer = 0
    Dim depto As Integer = 0
    Dim muni As Integer = 0
    Public id_partido As Integer
    Public id_movimiento As Integer
    Dim estado_candidato As String = "I"
    Dim validarfila As Integer = 0
    Dim contadorInconsistencias As Integer


    Sub AgregarFilasGrid(ByVal NumeroCeldas As Integer)
        Me.DSInsCandidatos.DUAL.Rows.Clear()

        For i = 1 To CType(NumeroCeldas, Integer)
            GridView1.AddNewRow()

        Next
        Me.GCBusqueda.Focus()
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText

        If (e.Column.FieldName = "Fila") Then

            If e.RowHandle < 0 Then
                e.DisplayText = vi + 1

            Else
                e.DisplayText = e.RowHandle + 1
                vi = e.RowHandle + 1
            End If

        End If


        Dim view As GridView = GridView1
        Dim I As Integer = e.RowHandle

        'If (e.Column.FieldName = "CONS_VECINDAD") Then
        '    If view.GetRowCellValue(I, "CONSTANCIA DE VECINDAD") Then
        '        view.SetRowCellValue(I, "CONS_VECINDAD", False)
        '    End If
        'End If


    End Sub

    Private Sub xfrmRegCandidatos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim view As GridView = GridView1
        If view.FocusedColumn.FieldName = "IDENTIDAD" Then
            VControles.solonumeros(e)
        End If
    End Sub
    Private Sub xfrmRegCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO' table. You can move, or remove it, as needed.
        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Fill(Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO)

        Me.MdiParent = XFrmMenuPrincipal
        'TODO: This line of code loads data into the 'DSInsCandidatos.DUAL' table. You can move, or remove it, as needed.
        'Me.DUALTableAdapter.Fill(Me.DSInsCandidatos.DUAL)
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        ' Me.IM_CANDIDATOSTableAdapter.Fill(Me.DSInsCandidatos.IM_CANDIDATOS)
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSInsCandidatos.IM_CARGOS_ELECTIVOS)

        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInsCandidatos.IM_PARTIDOS_POLITICOS)

        Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSInsCandidatos.IM_MUNICIPIOS, 0)
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSInsCandidatos.IM_DEPARTAMENTOS)
        ' AgregarFilasGrid(5)

    End Sub

    Sub guardar()

        Try
            Dim view As GridView = GridView1

            For i = 0 To view.DataRowCount - 1

                Dim identidad1 As String = view.GetRowCellValue(i, "IDENTIDAD")
                Dim nombre1 As String = view.GetRowCellValue(i, "PRIMER_NOMBRE")
                Dim nombre2 As String = view.GetRowCellValue(i, "SEGUNDO_NOMBRE")
                Dim apellido1 As String = view.GetRowCellValue(i, "PRIMER_APELLIDO")
                Dim apellido2 As String = view.GetRowCellValue(i, "SEGUNDO_APELLIDO")

                Dim oradb As String = Configuracion.verconfig

                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                conn.Open()

                Dim myCMD As New OracleCommand()
                myCMD.Connection = conn
                myCMD.CommandText = "IM_P_INSERT_CANDIDATOS"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("PNI_POSICION", OracleType.Number, 2, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "POSICION")
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CARGO_ELECTIVO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.cboCargo.EditValue
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_DEPARTAMENTO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.cboDepartamento.EditValue
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MUNICIPIO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.cboMunicipio.EditValue
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MOVIMIENTO", OracleType.Number, 3, ParameterDirection.Input)).Value = id_movimiento
                myCMD.Parameters.Add(New OracleParameter("PVI_IDENTIDAD", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "IDENTIDAD")
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_PARTIDO", OracleType.Number, 2, ParameterDirection.Input)).Value = id_partido
                myCMD.Parameters.Add(New OracleParameter("PVI_ADICIONADO_POR", OracleType.NVarChar, 11, ParameterDirection.Input)).Value = usuario
                myCMD.Parameters.Add(New OracleParameter("PDI_FECHA_ADICION", OracleType.DateTime, ParameterDirection.Input)).Value = DateTime.Now
                myCMD.Parameters.Add(New OracleParameter("PVO_MENSAJE", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
                myCMD.Parameters.Add(New OracleParameter("PVI_ESTADO", OracleType.NVarChar, 1, ParameterDirection.Input)).Value = estado_candidato
                myCMD.Parameters.Add(New OracleParameter("PVI_PRIMER_NOMBRE", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre1
                myCMD.Parameters.Add(New OracleParameter("PVI_SEGUNDO_NOMBRE", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre2
                myCMD.Parameters.Add(New OracleParameter("PVI_PRIMER_APELLIDO", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido1
                myCMD.Parameters.Add(New OracleParameter("PVI_SEGUNDO_APELLIDO", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido2
                myCMD.ExecuteOracleScalar()


                If myCMD.Parameters("PVO_MENSAJE").Value = "OK" Then
                    'Edicion
                    'GuardarRequisitos()
                    BtnEliminar.Enabled = False

                    For a = 1 To 7
                        ValidarCandidatos(i, a, identidad1, nombre1, nombre2, apellido1, apellido2)
                    Next a
                    'Me.LookUpEdit1.Reset()
                    'ACTUALIZARGRID()

                    Me.DSInsCandidatos.DUAL.Rows.Clear()
                    Mensajes.MensajeGuardar()

                Else
                    Mensajes.MensajeError(myCMD.Parameters("PVO_MENSAJE").Value)
                End If


                conn.Close()
            Next i
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Private Sub cboMunicipio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMunicipio.TextChanged
        Try
            If Me.cboCargo.EditValue = 8 Then



                Dim numFila As Integer
                Dim consulta As String = "SELECT CANTIDAD_REGIDORES   FROM IM_MUNICIPIOS WHERE CODIGO_DEPARTAMENTO = " & Me.cboDepartamento.EditValue & " AND CODIGO_MUNICIPIO  = " & Me.cboMunicipio.EditValue
                numFila = COracle.ObtenerDatos(consulta, "CANTIDAD_REGIDORES")
                AgregarFilasGrid(numFila)
            End If

            'Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInsCandidatos.IM_MUNICIPIOS, Me.cboDepartamento.EditValue)
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboDepartamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartamento.TextChanged
        Try
            If Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Then

                Me.DSInsCandidatos.DUAL.Rows.Clear()

                Dim numFila As Integer
                Dim consulta As String = "select cantidad_diputados from im_departamentos where codigo_departamento = " & Me.cboDepartamento.EditValue
                numFila = COracle.ObtenerDatos(consulta, "cantidad_diputados")
                AgregarFilasGrid(numFila)
            End If

            Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSInsCandidatos.IM_MUNICIPIOS, Me.cboDepartamento.EditValue)
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub
    Sub Val_MUN_DEP()

        Try


            If Me.cboCargo.EditValue = 9 Or Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 2 Or Me.cboCargo.EditValue = 3 Then


                depto = 0
                muni = 0

                Me.cboDepartamento.Enabled = False
                Me.cboMunicipio.Enabled = False

            ElseIf Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Then
                depto = Me.cboDepartamento.EditValue
                muni = 0
                Me.cboMunicipio.Enabled = False
                Me.cboDepartamento.Enabled = True
            Else
                depto = Me.cboDepartamento.EditValue
                muni = Me.cboMunicipio.EditValue
                Me.cboMunicipio.Enabled = True
                Me.cboDepartamento.Enabled = True

            End If


        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboCargo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCargo.EditValueChanged
        Val_MUN_DEP()

        If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Then
            AgregarFilasGrid(1)

        End If
    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If validarfila = 1 Then
            Mensajes.mimensaje("cambio de fila")
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub


    Sub ValidarCandidatos(ByVal fila As Integer, ByVal requisito As Integer, ByVal iden As String, ByVal nombre1 As String, ByVal nombre2 As String, ByVal apellido1 As String, ByVal apellido2 As String)
        Try

            Dim estado_requisto As String
            Dim view As GridView = GridView1

            Dim consulta As String = "select NUMERO_IDENTIDAD  "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & iden & "'"



            If requisito = 1 Then

            ElseIf requisito = 2 Then

                Dim N As String = COracle.ObtenerDatos(consulta, "NUMERO_IDENTIDAD")
                If N = "N" Then
                    Mensajes.mimensaje("Numero de Identidad no existe en el CNE")
                    'GUARDAR REQUISITO "I"
                    estado_requisto = "I"
                Else

                    estado_requisto = "C"
                End If
            ElseIf requisito = 3 Then
                Dim oradb As String = Configuracion.verconfig
                Dim resultado As String

                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                Dim myCMD As New OracleCommand()
                myCMD.Connection = conn
                myCMD.CommandText = "IM_K_VALIDACIONES.IM_P_valida_nombre_en_Censo"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("p_numero_identidad", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = iden
                myCMD.Parameters.Add(New OracleParameter("p_codigo_partido", OracleType.Number, 3, ParameterDirection.Input)).Value = id_partido
                myCMD.Parameters.Add(New OracleParameter("p_codigo_movimiento", OracleType.Number, 3, ParameterDirection.Input)).Value = id_movimiento
                myCMD.Parameters.Add(New OracleParameter("p_nombre1", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre1
                myCMD.Parameters.Add(New OracleParameter("p_nombre2", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre2
                myCMD.Parameters.Add(New OracleParameter("p_Apellido1", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido1
                myCMD.Parameters.Add(New OracleParameter("p_Apellido2", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido2
                myCMD.Parameters.Add(New OracleParameter("P_Error", OracleType.NVarChar, 500)).Direction = ParameterDirection.InputOutput
                myCMD.ExecuteOracleScalar()
                resultado = myCMD.Parameters("P_Error").Value
                If resultado Is Nothing Then
                    'GUARDAR REQUISITO "C"
                    estado_requisto = "C"
                Else
                    'GUARDAR REQUISITO "I"
                    estado_requisto = "I"
                    Mensajes.mimensaje(resultado)
                End If
                conn.Close()
            ElseIf requisito = 4 Or (requisito = 5 And (Me.cboCargo.EditValue = 5 Or Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 3 Or Me.cboCargo.EditValue = 2 Or Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 9)) Or (requisito = 6 And (Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 9)) Then

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                Dim myCMD As New OracleCommand()
                myCMD.Connection = conn
                myCMD.CommandText = "IM_K_VALIDACIONES.IM_P_VALIDA_EDAD"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("p_numero_identidad", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = iden
                myCMD.Parameters.Add(New OracleParameter("p_requisito", OracleType.Number, 3, ParameterDirection.Input)).Value = requisito
                myCMD.Parameters.Add(New OracleParameter("p_estado", OracleType.Char, 1)).Direction = ParameterDirection.InputOutput
                myCMD.ExecuteOracleScalar()
                estado_requisto = myCMD.Parameters("p_estado").Value
                'guardar requisito el valor de vestado
                conn.Close()
            ElseIf requisito = 7 And (Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 7) Then
                If IsDBNull(view.GetRowCellValue(fila, "IMAGEN")) Then
                    estado_requisto = "I"
                Else
                    estado_requisto = "C"
                End If
            ElseIf requisito = 8 And (Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Or Me.cboCargo.EditValue = 8) Then
                If view.GetRowCellValue(fila, "CONS_VECINDAD") = False Then
                    estado_requisto = "I"
                Else
                    estado_requisto = "C"
                End If
            Else
                requisito = 0
            End If



            ''guardando los requisitos

            'Dim vestado As String
            'Dim vCodigo_requisito As Integer


            If requisito = 1 Then

                Dim vcodigo_Candidato As Integer
                Dim consultaq As String = "SELECT MAX(CODIGO_CANDIDATOS) maximo FROM IM_CANDIDATOS"
                vcodigo_Candidato = CType(COracle.ObtenerDatos(consultaq, "maximo"), Integer)

                'Dim view As GridView = GridView1
                'RECORRER EL GRID


                Dim CANDIDATOS As DSInsCandidatos.IM_REQUISITOS_X_CANDIDATORow
                CANDIDATOS = DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.NewIM_REQUISITOS_X_CANDIDATORow

                With CANDIDATOS
                    .CODIGO_REQUISITO = requisito
                    .CODIGO_CANDIDATO = vcodigo_Candidato
                    .CODIGO_PARTIDO = id_partido
                    .CODIGO_MOVIMIENTO = id_movimiento
                    If requisito = 8 Then
                        If IsDBNull(view.GetRowCellValue(fila, "CONS_VECINDAD_IMG")) Then
                        Else
                            .IMAGEN = view.GetRowCellValue(fila, "CONS_VECINDAD_IMG")
                        End If
                    Else
                        If IsDBNull(view.GetRowCellValue(fila, "IMAGEN")) Then
                        Else
                            .IMAGEN = view.GetRowCellValue(fila, "IMAGEN")
                        End If
                    End If


                    .ADICIONADO_POR = usuario
                    .FECHA_ADICION = DateTime.Now
                    .ESTADO = estado_requisto

                End With

                Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.Rows.Add(CANDIDATOS)
                Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Update(Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO)

            End If
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try



    End Sub
End Class