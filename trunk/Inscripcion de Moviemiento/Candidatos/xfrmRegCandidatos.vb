Imports System.Data.OracleClient
Imports DevExpress.XtraGrid.Views.Grid
Public Class xfrmRegCandidatos
    Dim vi As Integer = 0
    Dim depto As Integer = 0
    Dim muni As Integer = 0
    Dim estado_candidato As String = "I"


    Sub AgregarFilasGrid(ByVal NumeroCeldas As Integer)
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



    End Sub
    Private Sub xfrmRegCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cons As String = "SELECT NOMBRE FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO = " & IdPartidoPolitico
        Dim con As String = "SELECT NOMBRE_MOVIMIENTO FROM IM_MOVIMIENTOS WHERE CODIGO_PARTIDO = " & IdPartidoPolitico & " AND CODIGO_MOVIMIENTO = " & IdMovimientoPolitico

        Me.lblMovimiento.Text = COracle.ObtenerDatos(con, "NOMBRE_MOVIMIENTO")
        Me.lblPartido.Text = COracle.ObtenerDatos(con, "NOMBRE")
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
        AgregarFilasGrid(5)

    End Sub

    Sub guardar()

        Try
            Dim view As GridView = GridView1

            For i = 0 To view.DataRowCount - 1


                Dim nombre As String = String.Format("{0} {1}", view.GetRowCellValue(i, "PRIMER_NOMBRE"), view.GetRowCellValue(i, "SEGUNDO_NOMBRE"))
                Dim apellido As String = String.Format("{0} {1}", view.GetRowCellValue(i, "PRIMER_APELLIDO"), view.GetRowCellValue(i, "SEGUNDO_APELLIDO"))
                Dim oradb As String = Configuracion.verconfig
                Dim opcion As Integer
                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                conn.Open()

                Dim myCMD As New OracleCommand()
                myCMD.Connection = conn
                myCMD.CommandText = "IM_P_INSERT_CANDIDATOS"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("PVI_NOMBRE", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = nombre
                myCMD.Parameters.Add(New OracleParameter("PNI_POSICION", OracleType.Number, 2, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "POSICION")
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_CARGO_ELECTIVO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.cboCargo.EditValue
                myCMD.Parameters.Add(New OracleParameter("PVI_APELLIDO", OracleType.NVarChar, 100, ParameterDirection.Input)).Value = apellido
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_DEPARTAMENTO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.cboDepartamento.EditValue
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MUNICIPIO", OracleType.Number, 2, ParameterDirection.Input)).Value = Me.cboMunicipio.EditValue
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_MOVIMIENTO", OracleType.Number, 3, ParameterDirection.Input)).Value = IdMovimientoPolitico
                myCMD.Parameters.Add(New OracleParameter("PVI_IDENTIDAD", OracleType.NVarChar, 15, ParameterDirection.Input)).Value = view.GetRowCellValue(i, "POSICION")
                myCMD.Parameters.Add(New OracleParameter("PNI_CODIGO_PARTIDO", OracleType.Number, 2, ParameterDirection.Input)).Value = IdPartidoPolitico
                myCMD.Parameters.Add(New OracleParameter("PVI_ADICIONADO_POR", OracleType.NVarChar, 11, ParameterDirection.Input)).Value = usuario
                myCMD.Parameters.Add(New OracleParameter("PDI_FECHA_ADICION", OracleType.DateTime, ParameterDirection.Input)).Value = DateTime.Now
                myCMD.Parameters.Add(New OracleParameter("PVO_MENSAJE", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
                myCMD.Parameters.Add(New OracleParameter("PVI_ESTADO", OracleType.NVarChar, 1, ParameterDirection.Input)).Value = estado_candidato
                myCMD.ExecuteOracleScalar()


                If myCMD.Parameters("PVO_MENSAJE").Value = "OK" Then
                    'Edicion
                    'GuardarRequisitos()
                    BtnEliminar.Enabled = False

                    Me.DSInsCandidatos.DUAL.Rows.Clear()
                    Mensajes.MensajeGuardar()

                    'Me.LookUpEdit1.Reset()
                    'ACTUALIZARGRID()

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


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' AgregarFilasGrid(Me.TextEdit1.EditValue)

    End Sub


    Private Sub cboMunicipio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMunicipio.TextChanged
        Try
            If Me.cboCargo.EditValue = 8 Then

                Me.DSInsCandidatos.DUAL.Rows.Clear()

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
                Me.cboMunicipio.EditValue = False

            ElseIf Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Then
                depto = Me.cboDepartamento.EditValue
                muni = 0
                Me.cboMunicipio.EditValue = False
                Me.cboDepartamento.Enabled = True
            Else
                depto = Me.cboDepartamento.EditValue
                muni = Me.cboMunicipio.EditValue
                Me.cboMunicipio.Enabled = True
                Me.cboDepartamento.Enabled = True

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCargo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCargo.EditValueChanged
        Val_MUN_DEP()

    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Mensajes.mimensaje("cambio de fila")
    End Sub
End Class