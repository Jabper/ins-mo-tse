﻿Imports System.Data.OracleClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

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
    Dim mensajeerror As String
    Dim EJECUTAR As Boolean
    Dim load As Boolean
    Dim id As String
    Dim permitir_up As Integer = 0
    Dim ingreso_hombre As Integer


    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.KeyPreview = True
    End Sub

    Sub mostrarimg()
        Dim consulta As String = "SELECT IMAGEN FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & CType(Me.lblidpartido.Text, Integer)
        Me.imgpartido.Image = COracle.ObtenerImagen(consulta, "IMAGEN")
        Dim consulta2 As String = "SELECT * FROM IM_MOVIMIENTOS WHERE CODIGO_MOVIMIENTO=" & CType(Me.lblidmovimiento.Text, Integer)
        Me.imgmov.Image = COracle.ObtenerImagen(consulta2, "INSIGNIA")
    End Sub
    Sub AgregarFilasGrid(ByVal NumeroCeldas As Integer)
        'Me.DSInsCandidatos.IM_CANDIDATOS.Rows.Clear()
        load = True
        For i = 1 To CType(NumeroCeldas, Integer)
            load = True
            GridView1.AddNewRow()
        Next
        Me.GCBusqueda.Focus()

        GCBusqueda.ForceInitialize()
        Dim view As GridView = GridView1
        view.FocusedRowHandle = 0 'DevExpress.XtraGrid.GridControl.NewItemRowHandle

        view.FocusedColumn = colPOSICION
        view.ShowEditor()

    End Sub

    Private Sub xfrmRegCandidatos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        mostrarimg()
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
        Try

            Me.MdiParent = XFrmMenuPrincipal
            'TryCast(Me.GCBusqueda.ViewCollection(0), DevExpress.XtraGrid.Views.Grid.GridView).Columns("CONS_VECINDAD_IMG").AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            'TryCast(Me.GCBusqueda.ViewCollection(0), DevExpress.XtraGrid.Views.Grid.GridView).Columns("CONS_VECINDAD").AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap

            limpiar()


            ' Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter.Fill(Me.DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2)
            'TODO: This line of code loads data into the 'DSInsCandidatos.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
            Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSInsCandidatos.IM_CARGOS_ELECTIVOS)


            'TODO: This line of code loads data into the 'DSInsCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
            'Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInsCandidatos.IM_PARTIDOS_POLITICOS)

            Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSInsCandidatos.IM_MUNICIPIOS, 0)
            'TODO: This line of code loads data into the 'DSInsCandidatos.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
            Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSInsCandidatos.IM_DEPARTAMENTOS)
            ' AgregarFilasGrid(5)
            load = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
        e.ExceptionMode = ExceptionMode.DisplayError
        e.WindowCaption = "Error"
        e.ErrorText = mensajeerror
        GridView1.HideEditor()
    End Sub
    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        Dim view As GridView = TryCast(sender, GridView)
        'Dim view1 As GridView = GridView1

        If view.FocusedColumn.FieldName = "IDENTIDAD" Then

            If e.Value.ToString.Length <> 13 Then
                mensajeerror = "El número de digitos en el campo Identidad es incorrecto debe de ser igual a 13 digitos"
                e.Valid = False
                view.FocusedColumn.FieldName = "IDENTIDAD"
                Exit Sub
            End If

            If IsNumeric(e.Value) = False Then
                mensajeerror = "El valor del número de indentidad debe de ser un valor numérico"
                e.Valid = False
                view.FocusedColumn.FieldName = "IDENTIDAD"
                Exit Sub
            End If

            If (e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)) = False Then
                mensajeerror = "Valor inválido"
                e.Valid = False
                view.FocusedColumn.FieldName = "IDENTIDAD"
                Exit Sub

            End If

            Dim a As String = "select NUMERO_IDENTIDAD,SEXO from IM_PADRON_ELECTORAL where NUMERO_IDENTIDAD='" & e.Value.ToString & "'"

            If COracle.ObtenerDatos(a, "NUMERO_IDENTIDAD") = "N" Then
                mensajeerror = "Candidato No Existe en el Padron Electoral"
                e.Valid = False
                view.FocusedColumn.FieldName = "IDENTIDAD"
            Else

                COracle.GetName(e.Value)

                view.SetRowCellValue(view.FocusedRowHandle, "PRIMER_NOMBRE", Primer_Nombre)
                view.SetRowCellValue(view.FocusedRowHandle, "SEGUNDO_NOMBRE", Segundo_Nombre)
                view.SetRowCellValue(view.FocusedRowHandle, "PRIMER_APELLIDO", Primer_Apellido)
                view.SetRowCellValue(view.FocusedRowHandle, "SEGUNDO_APELLIDO", Segundo_Apellido)

                If ingreso_hombre = 0 Then
                    Dim SEXO As String = COracle.ObtenerDatos(a, "SEXO")
                    If SEXO = "1" Then
                        mensajeerror = "NO PUEDE POSTULAR MAS HOMBRES A ESTA PLANILLA"
                        e.Valid = False
                        view.FocusedColumn.FieldName = "IDENTIDAD"
                    End If
                End If
            End If
        End If

        If view.FocusedColumn.FieldName = "POSICION" Then
            If (e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)) = False Then
                mensajeerror = "Valor inválido"
                e.Valid = False
                view.FocusedColumn.FieldName = "POSICION"
                Exit Sub

            End If
            If IsNumeric(e.Value) = False Then
                mensajeerror = "El valor de la posicion debe de ser un valor numérico"
                e.Valid = False
                view.FocusedColumn.FieldName = "POSICION"
                Exit Sub
            End If

        End If


    End Sub

    Sub Actualizar(ByVal i As Integer)

        Try

            Dim estado_requisito As String
            Dim view As GridView = GridView1
            Dim oradb As String = Configuracion.verconfig

            Dim conn As New OracleConnection()
            conn.ConnectionString = oradb
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
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
                apellido2 = view.GetRowCellValue(i, "SEGUNDO_APELLIDO")
            End If

            Dim myCMD As New OracleCommand()
            myCMD.Connection = conn
            myCMD.CommandText = "IM_P_UPDATE_CANDIDATOS"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CANDIDATO", OracleType.Number, 6, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "CODIGO_CANDIDATOS")
            myCMD.Parameters.Add(New OracleParameter("PNI_POSICION", OracleType.Number, 2, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "POSICION")
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CARGO_ELECTIVO", OracleType.Number, 3, ParameterDirection.Input)).Value = Me.cboCargo.EditValue
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_DEPARTAMENTO", OracleType.Number, 2, ParameterDirection.Input)).Value = depto
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MUNICIPIO", OracleType.Number, 2, ParameterDirection.Input)).Value = muni
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MOVIMIENTO", OracleType.Number, 3, ParameterDirection.Input)).Value = id_movimiento
            myCMD.Parameters.Add(New OracleParameter("PVI_IDENTIDAD", OracleType.NVarChar, 13, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "IDENTIDAD")
            myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_PARTIDO", OracleType.Number, 2, ParameterDirection.Input)).Value = id_partido
            myCMD.Parameters.Add(New OracleParameter("PVI_MODIFICADO_POR", OracleType.NVarChar, 10, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "POSICION")
            myCMD.Parameters.Add(New OracleParameter("PDI_FECHA_MODIFICACION", OracleType.DateTime, ParameterDirection.Input)).Value = DateTime.Now
            myCMD.Parameters.Add(New OracleParameter("PVI_PRIMER_NOMBRE", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre1
            myCMD.Parameters.Add(New OracleParameter("PVI_SEGUNDO_NOMBRE", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre2
            myCMD.Parameters.Add(New OracleParameter("PVI_PRIMER_APELLIDO", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido1
            myCMD.Parameters.Add(New OracleParameter("PVI_SEGUNDO_APELLIDO", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido2
            myCMD.Parameters.Add(New OracleParameter("PVI_ESTADO", OracleType.NVarChar, 2, ParameterDirection.Input)).Value = "H"
            myCMD.Parameters.Add(New OracleParameter("PVO_MENSAJE", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()

            Dim mensaje As String = myCMD.Parameters("PVO_MENSAJE").Value
            conn.Close()

            If mensaje = "N" Then


                For a = 7 To 8
                    Dim permitido As Integer
                    If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 4 Then
                        permitido = 1
                    ElseIf a = 8 And (Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Or Me.cboCargo.EditValue = 8) Then
                        permitido = 1
                    End If

                    'Dim view As GridView = GridView1
                    'RECORRER EL GRID

                    If permitido = 1 Then


                        Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.Clear()
                        'Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.Rows.Clear()

                        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Update(Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO)


                        Dim CANDIDATOS As DSInsCandidatos.IM_REQUISITOS_X_CANDIDATORow
                        CANDIDATOS = DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.NewIM_REQUISITOS_X_CANDIDATORow

                        With CANDIDATOS
                            .CODIGO_REQUISITO = a
                            .CODIGO_CANDIDATO = view.GetRowCellValue(i, "CODIGO_CANDIDATOS")
                            .CODIGO_PARTIDO = id_partido
                            .CODIGO_MOVIMIENTO = id_movimiento
                            If a = 8 Then

                                Dim oradb1 As String = Configuracion.verconfig
                                Dim conn1 As New OracleConnection()
                                conn1.ConnectionString = oradb
                                If conn1.State = ConnectionState.Open Then
                                    conn1.Close()
                                End If
                                conn1.Open()

                                Dim myCMD1 As New OracleCommand()
                                myCMD1.Connection = conn1
                                myCMD1.CommandText = "IM_P_VALIDA_CONSTACIA_VECINDAD"
                                myCMD1.CommandType = CommandType.StoredProcedure
                                myCMD1.Parameters.Add(New OracleParameter("PVI_IDENTIDAD", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "IDENTIDAD")
                                myCMD1.Parameters.Add(New OracleParameter("PNI_DEPTO", OracleType.Number, 2, ParameterDirection.Input)).Value = depto
                                myCMD1.Parameters.Add(New OracleParameter("PNI_MUNI", OracleType.Number, 2, ParameterDirection.Input)).Value = muni
                                myCMD1.Parameters.Add(New OracleParameter("PNI_CODIGO_CARGO_ELECTIVO", OracleType.Number, 3, ParameterDirection.Input)).Value = Me.cboCargo.EditValue
                                myCMD1.Parameters.Add(New OracleParameter("PVO_ESTADO", OracleType.Char, 1)).Direction = ParameterDirection.InputOutput
                                myCMD1.ExecuteOracleScalar()

                                estado_requisito = myCMD1.Parameters("PVO_ESTADO").Value
                                conn1.Close()

                                If estado_requisito = "C" Then
                                    contadorrequisitos += 1

                                Else
                                    If view.GetRowCellValue(a, "CONS_VECINDAD") = "I" Then
                                        contadorInconsistencias += 1
                                        contadorrequisitos += 1
                                        estado_requisito = "I"
                                    End If
                                End If


                                estado_requisito = view.GetRowCellValue(i, "CONS_VECINDAD")
                                If estado_requisito = "C" Then
                                    If IsDBNull(view.GetRowCellValue(i, "CONS_VECINDAD_IMAGEN")) Or view.GetRowCellValue(i, "CONS_VECINDAD_IMAGEN") Is Nothing Then
                                    Else
                                        .IMAGEN = view.GetRowCellValue(i, "CONS_VECINDAD_IMAGEN")
                                    End If

                                Else
                                    estado_requisito = "I"
                                End If
                            ElseIf a = 7 Then
                                If IsDBNull(view.GetRowCellValue(i, "IMAGEN")) Or view.GetRowCellValue(i, "IMAGEN") Is Nothing Then
                                    estado_requisito = "I"
                                Else
                                    .IMAGEN = view.GetRowCellValue(i, "IMAGEN")
                                    estado_requisito = "C"
                                End If
                            End If


                            .ADICIONADO_POR = usuario
                            .FECHA_ADICION = DateTime.Now
                            .ESTADO = estado_requisito

                        End With


                        'Me.GCBusqueda.DataSource = Nothing


                        Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.Rows.Add(CANDIDATOS)
                        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Update(Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO)

                    End If
                    permitido = 0
                Next a

                Mensajes.MensajeActualizar()
                Validarleyendas()
            Else
                Mensajes.MensajeError(mensaje)
            End If
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub

    Sub guardar(ByVal I As Integer)

        Try
            Val_MUN_DEP()

            Dim view As GridView = GridView1


            If (IsDBNull(view.GetRowCellValue(I, "IDENTIDAD")) Or view.GetRowCellValue(I, "IDENTIDAD") Is Nothing) _
            And (IsDBNull(view.GetRowCellValue(I, "PRIMER_NOMBRE")) Or view.GetRowCellValue(I, "PRIMER_NOMBRE") Is Nothing) _
            And (IsDBNull(view.GetRowCellValue(I, "PRIMER_APELLIDO")) Or view.GetRowCellValue(I, "PRIMER_APELLIDO") Is Nothing) _
            And (IsDBNull(view.GetRowCellValue(I, "Posicion")) Or view.GetRowCellValue(I, "Posicion")) Is Nothing Then
                Return
            ElseIf IsDBNull(view.GetRowCellValue(I, "IDENTIDAD")) Or view.GetRowCellValue(I, "IDENTIDAD") Is Nothing Then
                Mensajes.MensajeError("Ingrese el Número de Identidad")
                Return
            ElseIf IsDBNull(view.GetRowCellValue(I, "PRIMER_NOMBRE")) Or view.GetRowCellValue(I, "PRIMER_NOMBRE") Is Nothing Then
                Mensajes.MensajeError("Ingrese el Primer Nombre")
                Return
            ElseIf IsDBNull(view.GetRowCellValue(I, "PRIMER_APELLIDO")) Or view.GetRowCellValue(I, "PRIMER_APELLIDO") Is Nothing Then
                Mensajes.MensajeError("Ingrese el Primer Apellido")
                Return
            ElseIf IsDBNull(view.GetRowCellValue(I, "POSICION")) Or view.GetRowCellValue(I, "POSICION") Is Nothing Then
                Mensajes.MensajeError("Ingrese La posicion del Candidato")
                Return
            Else

                Dim identidad1 As String = view.GetRowCellValue(I, "IDENTIDAD")
                Dim nombre1 As String = view.GetRowCellValue(I, "PRIMER_NOMBRE")
                Dim nombre2 As String
                Dim apellido1 As String = view.GetRowCellValue(I, "PRIMER_APELLIDO")
                Dim apellido2 As String
                If view.GetRowCellValue(I, "SEGUNDO_NOMBRE") Is Nothing Or IsDBNull(view.GetRowCellValue(I, "SEGUNDO_NOMBRE")) Then
                    nombre2 = ""
                Else
                    nombre2 = view.GetRowCellValue(I, "SEGUNDO_NOMBRE")
                End If

                If view.GetRowCellValue(I, "SEGUNDO_APELLIDO") Is Nothing Or IsDBNull(view.GetRowCellValue(I, "SEGUNDO_APELLIDO")) Then
                    apellido2 = ""
                Else
                    apellido2 = view.GetRowCellValue(I, "SEGUNDO_APELLIDO")
                End If


                Dim oradb As String = Configuracion.verconfig

                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                conn.Open()

                Dim myCMD As New OracleCommand()
                myCMD.Connection = conn
                myCMD.CommandText = "IM_P_INSERT_CANDIDATOS"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("PNI_POSICION", OracleType.Number, 2, ParameterDirection.Input)).Value = view.GetRowCellValue(I, "POSICION")
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CARGO_ELECTIVO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.cboCargo.EditValue
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_DEPARTAMENTO", OracleType.Number, 2, ParameterDirection.Input)).Value = depto
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MUNICIPIO", OracleType.Number, 2, ParameterDirection.Input)).Value = muni
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MOVIMIENTO", OracleType.Number, 3, ParameterDirection.Input)).Value = id_movimiento
                myCMD.Parameters.Add(New OracleParameter("PVI_IDENTIDAD", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = view.GetRowCellValue(I, "IDENTIDAD")
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


                If CType(myCMD.Parameters("PVO_MENSAJE").Value, String) = "OK" Then
                    'Edicion
                    'GuardarRequisitos()
                    BtnEliminariold.Enabled = False

                    For a = 1 To 9
                        ValidarCandidatos(I, a, identidad1, nombre1, nombre2, apellido1, apellido2)
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
                        COracle.ejecutarconsulta("UPDATE IM_CANDIDATOS SET ESTADO = 'H' WHERE CODIGO_CANDIDATOS = " & vcodigo)
                    End If

                    'Mensajes.MensajeGuardar()
                    Validarleyendas()

                Else
                    Mensajes.MensajeError(myCMD.Parameters("PVO_MENSAJE").Value)
                End If

                conn.Close()
            End If

            If enviarguardar = 1 Then

                Me.DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2.Rows.Clear()
            End If
            enviarguardar = 0
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Private Sub cboMunicipio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMunicipio.TextChanged
        Try

            Me.DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2.Rows.Clear()
            Validarleyendas()

            'Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInsCandidatos.IM_MUNICIPIOS, Me.cboDepartamento.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDepartamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartamento.TextChanged
        Try

            Me.DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2.Rows.Clear()



            Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSInsCandidatos.IM_MUNICIPIOS, Me.cboDepartamento.EditValue)
            Validarleyendas()
        Catch ex As Exception

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
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub

    Private Sub cboCargo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCargo.EditValueChanged

        Try

            Val_MUN_DEP()
            Me.DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2.Rows.Clear()
            Validarleyendas()



        Catch ex As Exception

        End Try            'If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Then
        '    ' AgregarFilasGrid(1)

        'End If
    End Sub

    Sub ValidarCandidatos(ByVal fila As Integer, ByVal requisito As Integer, ByVal iden As String, ByVal nombre1 As String, ByVal nombre2 As String, ByVal apellido1 As String, ByVal apellido2 As String)
        Try

            Dim view As GridView = GridView1

            Dim estado_requisto As String
            'Dim view As GridView = GridView1

            Dim vcodigo_Candidato As Integer
            Dim consultaq As String = "SELECT MAX(CODIGO_CANDIDATOS) maximo FROM IM_CANDIDATOS"
            vcodigo_Candidato = CType(COracle.ObtenerDatos(consultaq, "maximo"), Integer)

            Dim consulta As String = "select NUMERO_IDENTIDAD  "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & iden & "'"

            If requisito = 1 Then

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                Dim myCMD As New OracleCommand()
                myCMD.Connection = conn
                myCMD.CommandText = "IM_K_VALIDACIONES.im_p_valida_nacionalyvecindad"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("p_identidad", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = iden
                myCMD.Parameters.Add(New OracleParameter("p_codepto", OracleType.Number, 3, ParameterDirection.Input)).Value = depto
                myCMD.Parameters.Add(New OracleParameter("p_municipio", OracleType.Number, 3, ParameterDirection.Input)).Value = muni
                myCMD.Parameters.Add(New OracleParameter("p_cargo", OracleType.Number, 3, ParameterDirection.Input)).Value = Me.cboCargo.EditValue
                myCMD.Parameters.Add(New OracleParameter("p_requisito", OracleType.Number, 3, ParameterDirection.Input)).Value = requisito
                myCMD.Parameters.Add(New OracleParameter("p_tipo_validacion", OracleType.NVarChar, 1, ParameterDirection.Input)).Value = "P"
                myCMD.Parameters.Add(New OracleParameter("p_codigo_partido", OracleType.Number, 3, ParameterDirection.Input)).Value = id_partido
                myCMD.Parameters.Add(New OracleParameter("p_codigo_movimiento", OracleType.Number, 3, ParameterDirection.Input)).Value = id_movimiento
                myCMD.Parameters.Add(New OracleParameter("p_codigo_candidato", OracleType.Number, 3, ParameterDirection.Input)).Value = vcodigo_Candidato
                myCMD.Parameters.Add(New OracleParameter("p_estado", OracleType.Char, 1)).Direction = ParameterDirection.InputOutput
                myCMD.Parameters.Add(New OracleParameter("P_Error", OracleType.NVarChar, 500)).Direction = ParameterDirection.InputOutput
                myCMD.ExecuteOracleScalar()

                estado_requisto = myCMD.Parameters("p_estado").Value
                If estado_requisto = "I" Then
                    'GUARDAR REQUISITO "C"
                    Mensajes.MensajeError(CType(myCMD.Parameters("P_Error").Value, String))
                    contadorInconsistencias += 1
                    contadorrequisitos += 1

                Else

                    contadorrequisitos += 1
                    'GUARDAR REQUISITO "I"

                End If

            ElseIf requisito = 2 Then

                Dim N As String = COracle.ObtenerDatos(consulta, "NUMERO_IDENTIDAD")
                If N = "N" Then
                    Mensajes.MensajeError("Numero de Identidad no existe en el Censo Nacional Electoral")
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
                'Dim resultado As String

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
                myCMD.Parameters.Add(New OracleParameter("p_numero_identidad", OracleType.NVarChar, 13, ParameterDirection.Input)).Value = iden
                myCMD.Parameters.Add(New OracleParameter("p_codigo_partido", OracleType.Number, 3, ParameterDirection.Input)).Value = id_partido
                myCMD.Parameters.Add(New OracleParameter("p_codigo_movimiento", OracleType.Number, 3, ParameterDirection.Input)).Value = id_movimiento
                myCMD.Parameters.Add(New OracleParameter("p_nombre1", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre1
                myCMD.Parameters.Add(New OracleParameter("p_nombre2", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre2
                myCMD.Parameters.Add(New OracleParameter("p_Apellido1", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido1
                myCMD.Parameters.Add(New OracleParameter("p_Apellido2", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido2
                myCMD.Parameters.Add(New OracleParameter("P_Estado", OracleType.NVarChar, 1)).Direction = ParameterDirection.InputOutput
                myCMD.Parameters.Add(New OracleParameter("P_Error", OracleType.NVarChar, 500)).Direction = ParameterDirection.InputOutput
                myCMD.ExecuteOracleScalar()
                estado_requisto = myCMD.Parameters("P_Estado").Value
                If estado_requisto = "I" Then
                    'GUARDAR REQUISITO "C"
                    Mensajes.MensajeError(myCMD.Parameters("P_Error").Value)
                    contadorInconsistencias += 1
                    contadorrequisitos += 1
                Else

                    contadorrequisitos += 1
                    'GUARDAR REQUISITO "I"

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

                If estado_requisto = "I" Then
                    contadorInconsistencias += 1
                    contadorrequisitos += 1
                Else
                    contadorrequisitos += 1
                End If
                'guardar requisito el valor de vestado
                conn.Close()
            ElseIf requisito = 7 And (Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 6) Then
                If IsDBNull(view.GetRowCellValue(fila, "IMAGEN")) Or view.GetRowCellValue(fila, "IMAGEN") Is Nothing Then
                    estado_requisto = "I"
                    contadorInconsistencias += 1
                    contadorrequisitos += 1
                Else
                    contadorrequisitos += 1
                    estado_requisto = "C"
                End If
            ElseIf requisito = 8 And (Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Or Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Or Me.cboCargo.EditValue = 8) Then

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                Dim myCMD As New OracleCommand()
                myCMD.Connection = conn
                myCMD.CommandText = "IM_P_VALIDA_CONSTACIA_VECINDAD"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("PVI_IDENTIDAD", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = iden
                myCMD.Parameters.Add(New OracleParameter("PNI_DEPTO", OracleType.Number, 2, ParameterDirection.Input)).Value = depto
                myCMD.Parameters.Add(New OracleParameter("PNI_MUNI", OracleType.Number, 2, ParameterDirection.Input)).Value = muni
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CARGO_ELECTIVO", OracleType.Number, 3, ParameterDirection.Input)).Value = Me.cboCargo.EditValue
                myCMD.Parameters.Add(New OracleParameter("PVO_ESTADO", OracleType.Char, 1)).Direction = ParameterDirection.InputOutput
                myCMD.ExecuteOracleScalar()
                estado_requisto = myCMD.Parameters("PVO_ESTADO").Value

                If estado_requisto = "C" Then
                    contadorrequisitos += 1

                Else

                    estado_requisto = view.GetRowCellValue(fila, "CONS_VECINDAD")

                    If estado_requisto = "I" Then
                        contadorInconsistencias += 1
                        contadorrequisitos += 1
                    Else
                        contadorrequisitos += 1
                    End If

                End If

                conn.Close()

            ElseIf requisito = 9 Then
                    estado_requisto = "C"
            Else
                    requisito = 0
            End If

            ''guardando los requisitos

            'Dim vestado As String
            'Dim vCodigo_requisito As Integer

            If requisito > 0 Then

                'insercion por problemas de constrains

                Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.Clear()
                'Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.Rows.Clear()

                Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Update(Me.DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO)


                Dim CANDIDATOS As DSInsCandidatos.IM_REQUISITOS_X_CANDIDATORow
                CANDIDATOS = DSInsCandidatos.IM_REQUISITOS_X_CANDIDATO.NewIM_REQUISITOS_X_CANDIDATORow

                With CANDIDATOS
                    .CODIGO_REQUISITO = requisito
                    .CODIGO_CANDIDATO = vcodigo_Candidato
                    .CODIGO_PARTIDO = id_partido
                    .CODIGO_MOVIMIENTO = id_movimiento
                    If requisito = 8 Then
                        If IsDBNull(view.GetRowCellValue(fila, "CONS_VECINDAD_IMAGEN")) Then
                        Else
                            .IMAGEN = view.GetRowCellValue(fila, "CONS_VECINDAD_IMAGEN")
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
            Mensajes.MensajeError(ex.Message)
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
    Sub Validarleyendas()
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

        Dim mujeres_ingresadas As String
        Dim mujeres_necesarias As String

        Dim hombres_permitidos As Integer
        Dim hombres_ingresados As Integer

        id_partido = CInt(Me.lblidpartido.Text)
        id_movimiento = CInt(Me.lblidmovimiento.Text)

        Me.DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2.Rows.Clear()
        Val_MUN_DEP()


        presidente = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 1 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        designados = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 9 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        dip_pp = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 2 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        dip_ps = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 3 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} ", id_partido, id_movimiento), "TOTAL")
        dip_CN = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 4 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2}", id_partido, id_movimiento, depto), "TOTAL")
        dip_CNS = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 5 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2}", id_partido, id_movimiento, depto), "TOTAL")
        alcalde = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 6 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2} AND CODIGO_MUNICIPIO= {3} ", id_partido, id_movimiento, depto, muni), "TOTAL")
        vice = COracle.ObtenerDatos(String.Format("SELECT COUNT(*) TOTAL  FROM IM_CANDIDATOS WHERE CODIGO_CARGO_ELECTIVO = 7 AND CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1} AND CODIGO_DEPARTAMENTO= {2} AND CODIGO_MUNICIPIO= {3} ", id_partido, id_movimiento, depto, muni), "TOTAL")
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

        lblcnr1.Text = String.Format("{0} / {1}", dip_CN, cdip_CN)
        lblcnr2.Text = String.Format("{0} / {1}", dip_CNS, cdip_CNS)
        lblalcalde.Text = alcalde
        lblvice.Text = vice
        lblregidores.Text = String.Format("{0} / {1}", regidores, cregidores)

        load = True
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter.FillBY(Me.DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2, id_movimiento, id_partido, muni, depto, Me.cboCargo.EditValue)

        If Me.cboCargo.EditValue = 1 Then
            permitir_up = 1
            AgregarFilasGrid(CInt(1 - presidente))
        ElseIf Me.cboCargo.EditValue = 6 Then
            permitir_up = 1
            AgregarFilasGrid(CInt(1 - alcalde))
        ElseIf Me.cboCargo.EditValue = 7 Then
            permitir_up = 1
            AgregarFilasGrid(CInt(1 - vice))
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
            AgregarFilasGrid(CInt(cdesignados) - CInt(designados))

        End If

        'VAlIDACIONES PARTICIPACION FEMENINA 
        If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 9 Then

            mujeres_ingresadas = COracle.ObtenerDatos(String.Format("SELECT NVL(COUNT(*),  0) MUJERES FROM    im_candidatos ic, im_padron_electoral IP WHERE  ic.codigo_cargo_electivo IN (1,9)  AND  IC.CODIGO_PARTIDO = {0} AND IC.CODIGO_MOVIMIENTO = {1} AND  ic.identidad = ip.numero_identidad AND ip.sexo  = 2", id_partido, id_movimiento), "MUJERES")
            mujeres_necesarias = COracle.ObtenerDatos("SELECT CANTIDAD_MUJERES FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO =9", "CANTIDAD_MUJERES")

            Dim faltan As String = mujeres_necesarias - mujeres_ingresadas
            If faltan < 0 Then
                faltan = 0
            End If

            Me.lblmujeres.Text = String.Format("Necesarias {0} entre Presidente y Designados Faltan {1}", mujeres_necesarias, (faltan))

        ElseIf Me.cboCargo.EditValue = 2 Then
            Dim S As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                               "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                                "WHERE  iC.codigo_departamento = " & depto & _
                                " AND      iC.codigo_municipio = " & muni & _
                                " AND      im.codigo_departamento = ic.codigo_departamento " & _
                                " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                                " AND      ic.codigo_cargo_electivo = 2" & _
                                " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                                " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                                " AND      ic.identidad = ip.numero_identidad " & _
                                " AND      ip.sexo= 2"

            mujeres_ingresadas = COracle.ObtenerDatos(S, "MUJERES")
            mujeres_necesarias = COracle.ObtenerDatos("SELECT CANTIDAD_MUJERES FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO =2", "CANTIDAD_MUJERES")


            Dim faltan As String = mujeres_necesarias - mujeres_ingresadas
            If faltan < 0 Then
                faltan = 0
            End If

            Me.lblmujeres.Text = String.Format("Necesarias {0} Faltan {1}", mujeres_necesarias, (faltan))

        ElseIf Me.cboCargo.EditValue = 3 Then
            Dim S As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                              "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                               "WHERE  iC.codigo_departamento = " & depto & _
                               " AND      iC.codigo_municipio = " & muni & _
                               " AND      im.codigo_departamento = ic.codigo_departamento " & _
                               " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                               " AND      ic.codigo_cargo_electivo = 3" & _
                               " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                               " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                               " AND      ic.identidad = ip.numero_identidad " & _
                               " AND      ip.sexo= 2"

            mujeres_ingresadas = COracle.ObtenerDatos(S, "MUJERES")
            mujeres_necesarias = COracle.ObtenerDatos("SELECT CANTIDAD_MUJERES FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO =3", "CANTIDAD_MUJERES")

            Dim faltan As String = mujeres_necesarias - mujeres_ingresadas
            If faltan < 0 Then
                faltan = 0
            End If

            Me.lblmujeres.Text = String.Format("Necesarias {0} Faltan {1}", mujeres_necesarias, (faltan))

        ElseIf Me.cboCargo.EditValue = 4 Then

            Dim S As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                              "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                               "WHERE  iC.codigo_departamento = " & depto & _
                               " AND      iC.codigo_municipio = " & muni & _
                               " AND      im.codigo_departamento = ic.codigo_departamento " & _
                               " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                               " AND      ic.codigo_cargo_electivo = 4" & _
                               " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                               " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                               " AND      ic.identidad = ip.numero_identidad " & _
                               " AND      ip.sexo= 2"



            If depto = 10 Or depto = 12 Then

                Dim S1 As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                  "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                   "WHERE  iC.codigo_departamento = " & depto & _
                   " AND      iC.codigo_municipio = " & muni & _
                   " AND      im.codigo_departamento = ic.codigo_departamento " & _
                   " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                   " AND      ic.codigo_cargo_electivo in (4,5)" & _
                   " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                   " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                   " AND      ic.identidad = ip.numero_identidad " & _
                   " AND      ip.sexo= 2"

                mujeres_ingresadas = COracle.ObtenerDatos(S1, "MUJERES")


                Dim faltan As String = 3 - mujeres_ingresadas
                If faltan < 0 Then
                    faltan = 0
                End If
                Me.lblmujeres.Text = "Necesita Minimo 3 Mujeres entre Propietarias y Suplentes, Faltan " & (faltan)

            ElseIf depto = 9 Or depto = 11 Then

                Dim S1 As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                  "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                   "WHERE  iC.codigo_departamento = " & depto & _
                   " AND      iC.codigo_municipio = " & muni & _
                   " AND      im.codigo_departamento = ic.codigo_departamento " & _
                   " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                   " AND      ic.codigo_cargo_electivo in (4,5)" & _
                   " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                   " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                   " AND      ic.identidad = ip.numero_identidad " & _
                   " AND      ip.sexo= 2"

                mujeres_ingresadas = COracle.ObtenerDatos(S1, "MUJERES")

                Dim faltan As String = 1 - mujeres_ingresadas
                If faltan < 0 Then
                    faltan = 0
                End If

                Me.lblmujeres.Text = "Necesita Minimo 1 Mujer entre Propietarias y Suplentes, Faltan " & (faltan)


            Else

                mujeres_ingresadas = COracle.ObtenerDatos(S, "MUJERES")
                mujeres_necesarias = COracle.ObtenerDatos("select cantidad_mujeres from im_departamentos where codigo_departamento = " & depto, "cantidad_mujeres")

                Dim faltan As String = mujeres_necesarias - mujeres_ingresadas
                If faltan < 0 Then
                    faltan = 0
                End If



                Me.lblmujeres.Text = String.Format("Necesarias {0} Faltan {1}", mujeres_necesarias, (faltan))
            End If

        ElseIf Me.cboCargo.EditValue = 5 Then

            If depto = 10 Or depto = 12 Then

                Dim S1 As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                  "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                   "WHERE  iC.codigo_departamento = " & depto & _
                   " AND      iC.codigo_municipio = " & muni & _
                   " AND      im.codigo_departamento = ic.codigo_departamento " & _
                   " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                   " AND      ic.codigo_cargo_electivo in (4,5)" & _
                   " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                   " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                   " AND      ic.identidad = ip.numero_identidad " & _
                   " AND      ip.sexo= 2"

                mujeres_ingresadas = COracle.ObtenerDatos(S1, "MUJERES")


                Dim faltan As String = 3 - mujeres_ingresadas
                If faltan < 0 Then
                    faltan = 0
                End If
                Me.lblmujeres.Text = "Necesita Minimo 3 Mujeres entre Propietarias y Suplentes, Faltan " & (faltan)

            ElseIf depto = 9 Or depto = 11 Then

                Dim S1 As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                  "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                   "WHERE  iC.codigo_departamento = " & depto & _
                   " AND      iC.codigo_municipio = " & muni & _
                   " AND      im.codigo_departamento = ic.codigo_departamento " & _
                   " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                   " AND      ic.codigo_cargo_electivo in (4,5)" & _
                   " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                   " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                   " AND      ic.identidad = ip.numero_identidad " & _
                   " AND      ip.sexo= 2"

                mujeres_ingresadas = COracle.ObtenerDatos(S1, "MUJERES")

                Dim faltan As String = 1 - mujeres_ingresadas
                If faltan < 0 Then
                    faltan = 0
                End If

                Me.lblmujeres.Text = "Necesita Minimo 1 Mujer entre Propietarias y Suplentes, Faltan " & (faltan)


            Else
                Dim S As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                                  "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                                   "WHERE  iC.codigo_departamento = " & depto & _
                                   " AND      iC.codigo_municipio = " & muni & _
                                   " AND      im.codigo_departamento = ic.codigo_departamento " & _
                                   " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                                   " AND      ic.codigo_cargo_electivo = 5" & _
                                   " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                                   " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                                   " AND      ic.identidad = ip.numero_identidad " & _
                                   " AND      ip.sexo= 2"

                mujeres_ingresadas = COracle.ObtenerDatos(S, "MUJERES")
                mujeres_necesarias = COracle.ObtenerDatos("select cantidad_mujeres from im_departamentos where codigo_departamento = " & depto, "cantidad_mujeres")


                Dim faltan As String = mujeres_necesarias - mujeres_ingresadas
                If faltan < 0 Then
                    faltan = 0
                End If

                Me.lblmujeres.Text = String.Format("Necesarias {0} Faltan {1}", mujeres_necesarias, (mujeres_necesarias - mujeres_ingresadas))
            End If
        ElseIf Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Or Me.cboCargo.EditValue = 8 Then
                Dim S As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                                  "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                                   "WHERE  iC.codigo_departamento = " & depto & _
                                   " AND      iC.codigo_municipio = " & muni & _
                                   " AND      im.codigo_departamento = ic.codigo_departamento " & _
                                   " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                                   " AND      ic.codigo_cargo_electivo in (6,7,8) " & _
                                   " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                                   " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                                   " AND      ic.identidad = ip.numero_identidad " & _
                                   " AND      ip.sexo= 2"

                mujeres_ingresadas = COracle.ObtenerDatos(S, "MUJERES")
                mujeres_necesarias = COracle.ObtenerDatos("select cantidad_mujeres from im_municipios where codigo_departamento = " & depto & " and codigo_municipio =" & muni, "cantidad_mujeres")

                Dim faltan As String = mujeres_necesarias - mujeres_ingresadas
                If faltan < 0 Then
                    faltan = 0
                End If

                Me.lblmujeres.Text = String.Format("Necesarias {0} Faltan {1}", mujeres_necesarias, (faltan))

            End If

            If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 9 Then
                hombres_ingresados += 1
            End If

            Dim cargo As String

            If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 9 Then
                cargo = "IN (1,9) "
            ElseIf Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 9 Then
                cargo = "IN (6,7,8) "
            Else
                cargo = " = " & Me.cboCargo.EditValue
            End If

            Dim ax As String = "SELECT NVL(COUNT(*),  0) MUJERES " & _
                                  "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                                   "WHERE  iC.codigo_departamento = " & depto & _
                                   " AND      iC.codigo_municipio = " & muni & _
                                   " AND      im.codigo_departamento = ic.codigo_departamento " & _
                                   " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                                   " AND      ic.codigo_cargo_electivo  " & cargo & _
                                   " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                                   " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                                   " AND      ic.identidad = ip.numero_identidad " & _
                                   " AND      ip.sexo= 1"

            hombres_ingresados = CInt(COracle.ObtenerDatos(ax, "MUJERES"))


            If Me.cboCargo.EditValue = 1 Or Me.cboCargo.EditValue = 9 Then
                hombres_permitidos = (cdesignados + 1) - mujeres_necesarias

                If hombres_permitidos = hombres_ingresados Then
                    ingreso_hombre = 0
                Else
                    ingreso_hombre = 1
                End If

            ElseIf Me.cboCargo.EditValue = 2 Then

                hombres_permitidos = (cdip_pp) - mujeres_necesarias

                If hombres_permitidos = hombres_ingresados Then
                    ingreso_hombre = 0
                Else
                    ingreso_hombre = 1
                End If

            ElseIf Me.cboCargo.EditValue = 3 Then

                hombres_permitidos = (cdip_ps) - mujeres_necesarias

                If hombres_permitidos = hombres_ingresados Then
                    ingreso_hombre = 0
                Else
                    ingreso_hombre = 1
                End If

            ElseIf Me.cboCargo.EditValue = 4 Then

                If depto = 10 Or depto = 12 Then

                    Dim con1 As String = "SELECT NVL(COUNT(*),  0) HOMBRES " & _
                          "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                           "WHERE  iC.codigo_departamento = " & depto & _
                           " AND      iC.codigo_municipio = " & muni & _
                           " AND      im.codigo_departamento = ic.codigo_departamento " & _
                           " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                           " AND      ic.codigo_cargo_electivo = 4 " & _
                           " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                           " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                           " AND      ic.identidad = ip.numero_identidad " & _
                           " AND      ip.sexo= 1"

                    Dim con2 As String = "SELECT NVL(COUNT(*),  0) HOMBRES " & _
                          "FROM    im_candidatos ic, im_padron_electoral ip, im_municipios im " & _
                           "WHERE  iC.codigo_departamento = " & depto & _
                           " AND      iC.codigo_municipio = " & muni & _
                           " AND      im.codigo_departamento = ic.codigo_departamento " & _
                           " AND      im.codigo_municipio       = ic.codigo_municipio " & _
                           " AND      ic.codigo_cargo_electivo = 5 " & _
                           " AND      IC.CODIGO_PARTIDO =  " & id_partido & _
                           " AND      IC.CODIGO_MOVIMIENTO = " & id_movimiento & _
                           " AND      ic.identidad = ip.numero_identidad " & _
                           " AND      ip.sexo= 1"

                    Dim homP As Integer = COracle.ObtenerDatos(con1, "HOMBRES")
                    Dim homS As Integer = COracle.ObtenerDatos(con2, "HOMBRES")

                    If (homP + homS) <= 3 And (homP < 3 And homS) Then
                        ingreso_hombre = 0
                    Else
                        ingreso_hombre = 1
                    End If

                ElseIf depto = 9 Or depto = 11 Then

                    hombres_permitidos = (cdip_CN + cdip_CNS) - mujeres_necesarias

                    If hombres_permitidos = hombres_ingresados Then
                        ingreso_hombre = 0
                    Else
                        ingreso_hombre = 1
                    End If
                End If

                hombres_permitidos = (cdip_CN) - mujeres_necesarias

                If hombres_permitidos = hombres_ingresados Then
                    ingreso_hombre = 0
                Else
                    ingreso_hombre = 1
                End If
            ElseIf Me.cboCargo.EditValue = 5 Then
                hombres_permitidos = (cdip_CNS) - mujeres_necesarias

                If hombres_permitidos = hombres_ingresados Then
                    ingreso_hombre = 0
                Else
                    ingreso_hombre = 1
                End If
            ElseIf Me.cboCargo.EditValue = 6 Or Me.cboCargo.EditValue = 7 Or Me.cboCargo.EditValue = 8 Then
                hombres_permitidos = (2 + cregidores) - mujeres_necesarias

                If hombres_permitidos = hombres_ingresados Then
                    ingreso_hombre = 0
                Else
                    ingreso_hombre = 1
                End If
            End If


    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    'DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs

    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow


        Dim view As GridView = GridView1

        If e.RowHandle < 0 Then
            Return
        ElseIf (IsDBNull(view.GetRowCellValue(e.RowHandle, "IDENTIDAD")) Or view.GetRowCellValue(e.RowHandle, "IDENTIDAD") Is Nothing) _
        And (IsDBNull(view.GetRowCellValue(e.RowHandle, "PRIMER_NOMBRE")) Or view.GetRowCellValue(e.RowHandle, "PRIMER_NOMBRE") Is Nothing) _
        And (IsDBNull(view.GetRowCellValue(e.RowHandle, "PRIMER_APELLIDO")) Or view.GetRowCellValue(e.RowHandle, "PRIMER_APELLIDO") Is Nothing) _
        And (IsDBNull(view.GetRowCellValue(e.RowHandle, "Posicion")) Or view.GetRowCellValue(e.RowHandle, "Posicion")) Is Nothing Then

            Return
        ElseIf IsDBNull(view.GetRowCellValue(e.RowHandle, "IDENTIDAD")) Or view.GetRowCellValue(e.RowHandle, "IDENTIDAD") Is Nothing Then
            Mensajes.MensajeError("Ingrese el Número de Identidad")
            Exit Sub
        ElseIf IsDBNull(view.GetRowCellValue(e.RowHandle, "PRIMER_NOMBRE")) Or view.GetRowCellValue(e.RowHandle, "PRIMER_NOMBRE") Is Nothing Then
            Mensajes.MensajeError("Ingrese el Primer Nombre")
            Return
        ElseIf IsDBNull(view.GetRowCellValue(e.RowHandle, "PRIMER_APELLIDO")) Or view.GetRowCellValue(e.RowHandle, "PRIMER_APELLIDO") Is Nothing Then
            Mensajes.MensajeError("Ingrese el Primer Apellido")
            Return
        ElseIf IsDBNull(view.GetRowCellValue(e.RowHandle, "POSICION")) Or view.GetRowCellValue(e.RowHandle, "POSICION") Is Nothing Then
            Mensajes.MensajeError("Ingrese La posicion del Candidato")
            Return
        Else

            If Me.cboCargo.EditValue = 1 And Not IsDBNull(view.GetRowCellValue(e.RowHandle, "IDENTIDAD")) Then
                permitir_up = 1

            ElseIf Me.cboCargo.EditValue = 6 And Not IsDBNull(view.GetRowCellValue(e.RowHandle, "IDENTIDAD")) Then
                permitir_up = 1

            ElseIf Me.cboCargo.EditValue = 7 And Not IsDBNull(view.GetRowCellValue(e.RowHandle, "IDENTIDAD")) Then
                permitir_up = 1
            Else
                permitir_up = 0
            End If

            Dim _row = CType(DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2.Rows(IMVMOSTRARCANDIDATOS2BindingSource.Position), DSInsCandidatos.IM_V_MOSTRAR_CANDIDATOS2Row)

            If _row.RowState = DataRowState.Added Then
                guardar(e.RowHandle)
            ElseIf _row.RowState = DataRowState.Unchanged Or permitir_up = 1 Then
                Actualizar(e.RowHandle)

            End If

            'If _row.RowState = DataRowState.Added And permitir_up = 0 Then
            '    guardar(e.RowHandle)
            'ElseIf _row.RowState = DataRowState.Unchanged Or permitir_up = 1 Then
            '    Actualizar(e.RowHandle)

            'End If

            End If


    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress

        Dim view As GridView = GridView1
        If view.FocusedColumn.FieldName = "IDENTIDAD" Then
            VControles.solonumeros(e)
        End If
        If view.FocusedColumn.FieldName = "POSICION" Then
            VControles.solonumeros(e)
        End If
    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If load = False Then
            If Not IsDBNull(GridView1.GetFocusedRowCellValue("IDENTIDAD")) Then
                GridView1.Columns("IDENTIDAD").OptionsColumn.AllowEdit = False
            Else
                GridView1.Columns("IDENTIDAD").OptionsColumn.AllowEdit = True
            End If
        End If
        load = False
    End Sub

    Sub Eliminar()

        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim view As GridView = GridView1
                If Not IsDBNull(GridView1.GetRowCellValue(View.FocusedRowHandle, "CODIGO_CANDIDATOS")) Then



                    Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
                    'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
                    id = cellValue
                    BtnEliminar.Enabled = True


                    id = GridView1.GetRowCellValue(view.FocusedRowHandle, "CODIGO_CANDIDATOS")

                    Dim oradb As String = Configuracion.verconfig

                    Dim conn As New OracleConnection()
                    conn.ConnectionString = oradb
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                    conn.Open()
                    Dim identidad1 As String = view.GetRowCellValue(view.FocusedRowHandle, "IDENTIDAD")


                    Dim myCMD As New OracleCommand()
                    myCMD.Connection = conn
                    myCMD.CommandText = "IM_P_DELETE_CANDIDATO"
                    myCMD.CommandType = CommandType.StoredProcedure
                    myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CANDIDATO", OracleType.Number, 6, ParameterDirection.Input)).Value = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_CANDIDATOS")
                    myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MOVIMIENTO", OracleType.Number, 3, ParameterDirection.Input)).Value = id_movimiento
                    myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_PARTIDO", OracleType.Number, 2, ParameterDirection.Input)).Value = id_partido
                    myCMD.Parameters.Add(New OracleParameter("PVO_MENSAJE", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
                    myCMD.ExecuteScalar()

                    If myCMD.Parameters("PVO_MENSAJE").Value = "OK" Then
                        Mensajes.MensajeEliminar()
                        Validarleyendas()
                    Else
                        Mensajes.MensajeError(myCMD.Parameters("PVO_MENSAJE").Value)
                    End If
                Else
                    Mensajes.mimensaje("No se puede Eliminar el Candidato Verifique que este Guardado")
                End If
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If

    End Sub


    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Validarleyendas()
    End Sub

End Class