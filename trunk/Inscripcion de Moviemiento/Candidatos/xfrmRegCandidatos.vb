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
    Public contadorrequisitos As Integer
    Dim enviarguardar As Integer = 0



    Sub AgregarFilasGrid(ByVal NumeroCeldas As Integer)
        Me.DSInsCandidatos.DUAL.Rows.Clear()

        For i = 1 To CType(NumeroCeldas, Integer)
            GridView1.AddNewRow()

        Next
        Me.GCBusqueda.Focus()
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        'vi = 0
        If (e.Column.FieldName = "Fila") Then

            If e.RowHandle < 0 Then
                e.DisplayText = vi + 1

            Else
                e.DisplayText = e.RowHandle + 1
                vi = e.RowHandle + 1
            End If

        End If


        'Dim view As GridView = GridView1
        'Dim I As Integer = e.RowHandle

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
        If view.FocusedColumn.FieldName = "POSICION" Then
            VControles.solonumeros(e)
        End If
    End Sub
    Private Sub xfrmRegCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblpresidnete.Text = ""
        lbldesignados.Text = ""
        lblparlacen1.Text = ""
        lblparlacen2.Text = ""
        lblcnr1.Text = ""
        lblcnr2.Text = ""
        lblalcalde.Text = ""
        lblvice.Text = ""
        lblregidores.Text = ""

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
            Val_MUN_DEP()

            Dim view As GridView = GridView1

            For i = 0 To view.DataRowCount - 1


                If (IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or view.GetRowCellValue(i, "IDENTIDAD") Is Nothing) _
                And (IsDBNull(view.GetRowCellValue(i, "PRIMER_NOMBRE")) Or view.GetRowCellValue(i, "PRIMER_NOMBRE") Is Nothing) _
                And (IsDBNull(view.GetRowCellValue(i, "PRIMER_APELLIDO")) Or view.GetRowCellValue(i, "PRIMER_APELLIDO") Is Nothing) _
                And (IsDBNull(view.GetRowCellValue(i, "Posicion")) Or view.GetRowCellValue(i, "Posicion")) Is Nothing Then
                    Return
                ElseIf IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or view.GetRowCellValue(i, "IDENTIDAD") Is Nothing Then
                    Mensajes.mimensaje("Ingrese el Número de Identidad")
                    Return
                ElseIf IsDBNull(view.GetRowCellValue(i, "PRIMER_NOMBRE")) Or view.GetRowCellValue(i, "PRIMER_NOMBRE") Is Nothing Then
                    Mensajes.mimensaje("Ingrese el Primer Nombre")
                    Return
                ElseIf IsDBNull(view.GetRowCellValue(i, "PRIMER_APELLIDO")) Or view.GetRowCellValue(i, "PRIMER_APELLIDO") Is Nothing Then
                    Mensajes.mimensaje("Ingrese el Primer Apellido")
                    Return
                ElseIf IsDBNull(view.GetRowCellValue(i, "POSICION")) Or view.GetRowCellValue(i, "POSICION") Is Nothing Then
                    Mensajes.mimensaje("Ingrese La posicion del Candidato")
                    Return
                Else

                    Dim identidad1 As String = view.GetRowCellValue(i, "IDENTIDAD")
                    Dim nombre1 As String = view.GetRowCellValue(i, "PRIMER_NOMBRE")
                    Dim nombre2 As String
                    Dim apellido1 As String = view.GetRowCellValue(i, "PRIMER_APELLIDO")
                    Dim apellido2 As String
                    If view.GetRowCellValue(i, "SEGUNDO_NOMBRE") Is Nothing Or IsDBNull(view.GetRowCellValue(i, "SEGUNDO_NOMBRE")) Then
                        nombre2 = ""
                    Else
                        nombre2 = view.GetRowCellValue(i, "SEGUNDO_NOMBRE")
                    End If

                    If view.GetRowCellValue(i, "SEGUNDO_APELLIDO") Is Nothing Or IsDBNull(view.GetRowCellValue(i, "SEGUNDO_APELLIDO")) Then
                        apellido2 = ""
                    Else
                        apellido2 = view.GetRowCellValue(i, "SEGUNDO_NOMBRE")
                    End If
                    

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
                    myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_DEPARTAMENTO", OracleType.Number, 2, ParameterDirection.Input)).Value = depto
                    myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MUNICIPIO", OracleType.Number, 2, ParameterDirection.Input)).Value = muni
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
                        BtnEliminariold.Enabled = False

                        For a = 1 To 7
                            ValidarCandidatos(i, a, identidad1, nombre1, nombre2, apellido1, apellido2)
                        Next a
                        'Me.LookUpEdit1.Reset()
                        'ACTUALIZARGRID()
                        If contadorInconsistencias > 0 Then
                            Dim cons As String = "SELECT MAX(CODIGO_CANDIDATOS) maximo FROM IM_CANDIDATOS"
                            Dim vcodigo As Integer = CType(COracle.ObtenerDatos(cons, "maximo"), Integer)
                            COracle.ejecutarconsulta("UPDATE IM_CANDIDATOS SET ESTADO = 'I' WHERE CODIGO_CANDIDATOS = " & vcodigo)
                        Else
                            Dim cons As String = "SELECT MAX(CODIGO_CANDIDATOS) maximo FROM IM_CANDIDATOS"
                            Dim vcodigo As Integer = CType(COracle.ObtenerDatos(cons, "maximo"), Integer)
                            COracle.ejecutarconsulta("UPDATE IM_CANDIDATOS SET ESTADO = 'C' WHERE CODIGO_CANDIDATOS = " & vcodigo)
                        End If

                        enviarguardar = 1

                    Else
                        Mensajes.MensajeError(myCMD.Parameters("PVO_MENSAJE").Value)
                    End If

                    conn.Close()
                End If
            Next i
            If enviarguardar = 1 Then
                Mensajes.MensajeGuardar()
                Me.DSInsCandidatos.DUAL.Rows.Clear()
            End If
            enviarguardar = 0
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Private Sub cboMunicipio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMunicipio.TextChanged
        Try

            Me.DSInsCandidatos.DUAL.Rows.Clear()
            'If Me.cboCargo.EditValue = 8 Then



            '    Dim numFila As Integer
            '    Dim consulta As String = "SELECT CANTIDAD_REGIDORES   FROM IM_MUNICIPIOS WHERE CODIGO_DEPARTAMENTO = " & Me.cboDepartamento.EditValue & " AND CODIGO_MUNICIPIO  = " & Me.cboMunicipio.EditValue
            '    numFila = COracle.ObtenerDatos(consulta, "CANTIDAD_REGIDORES")
            '    'AgregarFilasGrid(numFila)
            'End If

            'Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInsCandidatos.IM_MUNICIPIOS, Me.cboDepartamento.EditValue)
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboDepartamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartamento.TextChanged
        Try

            Me.DSInsCandidatos.DUAL.Rows.Clear()
            'If Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Then
            '    Dim numFila As Integer
            '    Dim consulta As String = "select cantidad_diputados from im_departamentos where codigo_departamento = " & Me.cboDepartamento.EditValue
            '    numFila = COracle.ObtenerDatos(consulta, "cantidad_diputados")
            '    ' AgregarFilasGrid(numFila)
            'End If

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
        Me.DSInsCandidatos.DUAL.Rows.Clear()

        'If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Then
        '    ' AgregarFilasGrid(1)

        'End If
    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If validarfila = 1 Then
            Mensajes.mimensaje("cambio de fila")
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarold.Click
        guardar()
    End Sub


    Sub ValidarCandidatos(ByVal fila As Integer, ByVal requisito As Integer, ByVal iden As String, ByVal nombre1 As String, ByVal nombre2 As String, ByVal apellido1 As String, ByVal apellido2 As String)
        Try

           

            Dim view As GridView = GridView1

            Dim estado_requisto As String
            'Dim view As GridView = GridView1

            Dim consulta As String = "select NUMERO_IDENTIDAD  "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & iden & "'"




            If requisito = 1 Then
                
            ElseIf requisito = 2 Then

                Dim N As String = COracle.ObtenerDatos(consulta, "NUMERO_IDENTIDAD")
                If N = "N" Then
                    Mensajes.mimensaje("Numero de Identidad no existe en el CNE")
                    'GUARDAR REQUISITO "I"
                    estado_requisto = "I"
                    contadorInconsistencias += 1
                    contadorrequisitos += 1

                Else
                    contadorrequisitos += 1
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

                If myCMD.Parameters("P_Error").Value Is Nothing Or IsDBNull(myCMD.Parameters("P_Error").Value) Then
                    'GUARDAR REQUISITO "C"
                    estado_requisto = "I"
                    'Mensajes.mimensaje(myCMD.Parameters("P_Error").Value)
                    contadorInconsistencias += 1
                    contadorrequisitos += 1

                Else

                    contadorrequisitos += 1
                    'GUARDAR REQUISITO "I"
                    estado_requisto = "C"

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
                'estado_requisto = myCMD.Parameters("p_estado").Value

                If estado_requisto = "I" Then
                    contadorInconsistencias += 1
                    contadorrequisitos += 1
                Else
                    contadorrequisitos += 1
                End If
                'guardar requisito el valor de vestado
                conn.Close()
            ElseIf requisito = 7 And (Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 7) Then
                If IsDBNull(view.GetRowCellValue(fila, "IMAGEN")) Or view.GetRowCellValue(fila, "IMAGEN") Is Nothing Then
                    estado_requisto = "I"
                    contadorInconsistencias += 1
                    contadorrequisitos += 1
                Else
                    contadorrequisitos += 1
                    estado_requisto = "C"
                End If
            ElseIf requisito = 8 And (Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Or Me.cboCargo.EditValue = 8) Then
                If view.GetRowCellValue(fila, "CONS_VECINDAD") = False Then
                    contadorInconsistencias += 1
                    contadorrequisitos += 1
                    estado_requisto = "I"
                Else
                    contadorrequisitos += 1
                    estado_requisto = "C"
                End If
            Else
                requisito = 0
            End If



            ''guardando los requisitos

            'Dim vestado As String
            'Dim vCodigo_requisito As Integer


            If requisito > 0 Then

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
                    ElseIf requisito = 7 Then
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

    Sub limpiar()
        lblpresidnete.Text = ""
        lbldesignados.Text = ""
        lblparlacen1.Text = ""
        lblparlacen2.Text = ""
        lblcnr1.Text = ""
        lblcnr2.Text = ""
        lblalcalde.Text = ""
        lblvice.Text = ""
        lblregidores.Text = ""
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dip_CNS As String = 0
        Dim dip_CN As String = 0
        Dim dip_pp As String = 0
        Dim dip_ps As String = 0
        Dim presidente As String = 0
        Dim alcalde As String = 0
        Dim vice As String = 0
        Dim regidores As String = 0
        Dim designados As String = 0

        Dim cdip_CNS As String = 0
        Dim cdip_CN As String = 0
        Dim cdip_pp As String = 0
        Dim cdip_ps As String = 0
        Dim cregidores As String = 0
        Dim cdesignados As String = 0



        Me.DSInsCandidatos.DUAL.Rows.Clear()
        Val_MUN_DEP()

        presidente = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 1 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        designados = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 9 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        dip_pp = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 2 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        dip_ps = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 3 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        dip_CN = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 4 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2}", id_partido, id_movimiento, depto), "TOTAL")
        dip_CNS = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 5 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2}", id_partido, id_movimiento, depto), "TOTAL")
        alcalde = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 6 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2} AND CODIGO_MUNICIPIO= {3} ", id_partido, id_movimiento, depto, muni), "TOTAL")
        vice = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 6 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2} AND CODIGO_MUNICIPIO= {3} ", id_partido, id_movimiento, depto, muni), "TOTAL")
        regidores = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 8 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2} AND CODIGO_MUNICIPIO= {3} ", id_partido, id_movimiento, depto, muni), "TOTAL")


        cdesignados = COracle.ObtenerDatos("SELECT CANTIDAD_CARGO  FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 9", "CANTIDAD_CARGO")
        cdip_pp = COracle.ObtenerDatos("SELECT CANTIDAD_CARGO  FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 2", "CANTIDAD_CARGO")
        cdip_ps = COracle.ObtenerDatos("SELECT CANTIDAD_CARGO  FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 3", "CANTIDAD_CARGO")
        cdip_CN = COracle.ObtenerDatos(String.Format("SELECT CANTIDAD_DIPUTADOS FROM IM_DEPARTAMENTOS WHERE   CODIGO_DEPARTAMENTO =  {0}", depto), "CANTIDAD_DIPUTADOS")
        cdip_CNS = COracle.ObtenerDatos(String.Format("SELECT CANTIDAD_DIPUTADOS FROM IM_DEPARTAMENTOS WHERE   CODIGO_DEPARTAMENTO =  {0}", depto), "CANTIDAD_DIPUTADOS")
        cregidores = COracle.ObtenerDatos(String.Format("SELECT CANTIDAD_REGIDORES FROM IM_MUNICIPIOS WHERE   CODIGO_DEPARTAMENTO= {0} AND CODIGO_MUNICIPIO= {1} ", depto, muni), "CANTIDAD_REGIDORES")

        lblpresidnete.Text = presidente
        lbldesignados.Text = String.Format("{0} / {1}", designados, cdesignados)
        lblparlacen1.Text = String.Format("{0} / {1}", dip_pp, cdip_pp)
        lblparlacen2.Text = String.Format("{0} / {1}", dip_ps, cdip_ps)
        lblcnr1.Text = String.Format("{0} / {1}", dip_CN, cdip_CN)
        lblcnr2.Text = String.Format("{0} / {1}", dip_CNS, cdip_CNS)
        lblalcalde.Text = alcalde
        lblvice.Text = vice
        lblregidores.Text = String.Format("{0} / {1}", regidores, cregidores)

        If Me.cboCargo.EditValue = 1 Then
            AgregarFilasGrid(1 - CInt(presidente))
        ElseIf Me.cboCargo.EditValue = 6 Then
            AgregarFilasGrid(1 - CInt(alcalde))
        ElseIf Me.cboCargo.EditValue = 7 Then
            AgregarFilasGrid(1 - CInt(vice))
        ElseIf Me.cboCargo.EditValue = 2 Then
            AgregarFilasGrid(CInt(cdip_pp) - CInt(dip_pp))
        ElseIf Me.cboCargo.EditValue = 3 Then
            AgregarFilasGrid(CInt(cdip_ps) - CInt(dip_ps))
        ElseIf Me.cboCargo.EditValue = 4 Then
            AgregarFilasGrid(CInt(cdip_CN) - CInt(dip_CN))
        ElseIf Me.cboCargo.EditValue = 5 Then
            AgregarFilasGrid(CInt(cdip_CNS) - CInt(dip_CNS))
        ElseIf Me.cboCargo.EditValue = 8 Then
            AgregarFilasGrid(CInt(cregidores) - CInt(regidores))
        ElseIf Me.cboCargo.EditValue = 9 Then
            AgregarFilasGrid(CInt(cdesignados) - CInt(cdesignados))

        End If



    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalirold.Click
        Me.Close()
    End Sub
End Class