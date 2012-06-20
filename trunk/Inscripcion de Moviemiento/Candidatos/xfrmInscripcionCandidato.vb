Imports System.Data.OracleClient
Public Class xfrmInscripcionCandidato
    Dim actualizar As Boolean = False
    Dim id As Integer

    Sub guardar()

        Try
            Dim oradb As String = Configuracion.verconfig
            Dim opcion As Integer
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
            myCMD.ExecuteOracleScalar()

            If myCMD.Parameters("PVO_MENSAJE").Value = "OK" Then
                'Edicion
                BtnEliminar.Enabled = False
                If actualizar = True Then
                    Mensajes.MensajeActualizar()
                    actualizar = False
                Else
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



        Dim m As Integer = Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.GetDataSourceRowIndex(Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.Columns("CODIGO_MOVIMIENTO"), IdMovimientoPolitico)
        Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue = Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.GetDataSourceValue(Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.ValueMember, m)

        
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
        Me.CODIGO_PARTIDOLookUpEdit.Enabled = False
        Me.CODIGO_MOVIMIENTOLookUpEdit.Enabled = False
    End Sub
    Private Sub xfrmInscripcionCandidato_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        ActualizarLOV()
    End Sub
    Sub ACTUALIZARGRID()


        Me.TA_CANDIDATOSTableAdapter.FillBycargo(Me.DSInscripcionCandidatos.TA_CANDIDATOS, 9999, _
                                                         9999, 9999)

        If Me.LookUpEdit1.EditValue = 1 Then
            If Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing Then
            Else
                Me.TA_CANDIDATOSTableAdapter.FillBycargo(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
                                                         Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, 1) 'SE PONE 1 POR EL CODIGO DEL PRESIDENTE

            End If
        ElseIf Me.LookUpEdit1.EditValue = 2 Then
            If Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing Or _
            Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue Is Nothing Then
            Else
                Me.TA_CANDIDATOSTableAdapter.FillBydepto(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
                                                         Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, _
                                                      Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue)

            End If
        ElseIf Me.LookUpEdit1.EditValue = 3 Then
            'actualizar el grid segun el municipio
            If Me.CODIGO_MUNICIPIOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue Is Nothing Or _
            Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue Is Nothing Or Me.CODIGO_PARTIDOLookUpEdit.EditValue Is Nothing Then

            Else
                Me.TA_CANDIDATOSTableAdapter.FillBymuni(Me.DSInscripcionCandidatos.TA_CANDIDATOS, Me.CODIGO_PARTIDOLookUpEdit.EditValue, _
                                                  Me.CODIGO_MOVIMIENTOLookUpEdit.EditValue, Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue, _
                                               Me.CODIGO_DEPARTAMENTOLookUpEdit.EditValue, Me.CODIGO_MUNICIPIOLookUpEdit.EditValue)
            End If

        End If
    End Sub
    Private Sub xfrmInscripcionCandidato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.Close()
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
                'Mensajes.mimensaje("NUMERO DE IDENTIDAD NO EXISTE EN CNE")
            Else
                Me.NOMBRETextEdit.EditValue = N
                Me.APELLIDOTextEdit.EditValue = A
                Return
            End If
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
            'Mensajes.mimensaje("NUMERO DE IDENTIDAD NO EXISTE EN CNE")
        Else
            Me.NOMBRETextEdit.EditValue = N
            Me.APELLIDOTextEdit.EditValue = A
            Return
        End If

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

                ACTUALIZARGRID()

            ElseIf Me.LookUpEdit1.EditValue = 2 Then
                Dim V As Integer = Me.CODIGO_MUNICIPIOLookUpEdit.Properties.GetDataSourceRowIndex(Me.CODIGO_MUNICIPIOLookUpEdit.Properties.Columns("CODIGO_MUNICIPIO"), "0")
                Me.CODIGO_MUNICIPIOLookUpEdit.EditValue = Me.CODIGO_MUNICIPIOLookUpEdit.Properties.GetDataSourceValue(Me.CODIGO_MUNICIPIOLookUpEdit.Properties.ValueMember, V)

                Me.CODIGO_DEPARTAMENTOLookUpEdit.Enabled = True
                Me.CODIGO_MUNICIPIOLookUpEdit.Enabled = False
                ACTUALIZARGRID()

            ElseIf Me.LookUpEdit1.EditValue = 3 Then

                Me.CODIGO_DEPARTAMENTOLookUpEdit.Enabled = True
                Me.CODIGO_MUNICIPIOLookUpEdit.Enabled = True
                ACTUALIZARGRID()
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


End Class