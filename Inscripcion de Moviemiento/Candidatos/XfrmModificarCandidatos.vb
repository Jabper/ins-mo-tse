Imports System.Data.OracleClient
Public Class XfrmModificarCandidatos

    Dim codigo_candidato As Integer = 112
    Dim identidad As String = "0615198900415"
    Dim movimiento As Integer = 1
    Dim partido As Integer = 1
    Private Sub XfrmModificarCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO' table. You can move, or remove it, as needed.
        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_MUNICIPIOS' table. You can move, or remove it, as needed.
        'Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_MUNICIPIOS)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_CARGOS_ELECTIVOS)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        'Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_MOVIMIENTOS)
        'TODO: This line of code loads data into the 'DSInscripcionCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInscripcionCandidatos.IM_PARTIDOS_POLITICOS)

        Me.DataTable1TableAdapter.Fill(Me.DSInscripcionCandidatos.DataTable1, codigo_candidato, partido, movimiento)
        cargar_datos()
    End Sub

    Private Sub cargar_datos()
        Dim POSICION As Integer
        Dim CODIGO_CARGO_ELECTIVO As Integer
        Dim CODIGO_DEPARTAMENTO As Integer
        Dim CODIGO_MUNICIPIO As Integer
        Dim CODIGO_MOVIMIENTO_im_candidatos As Integer
        Dim CODIGO_PARTIDO_im_candidatos As Integer
        Dim ESTADO As String
        Dim PRIMER_NOMBRE As String
        Dim SEGUNDO_NOMBRE As String
        Dim PRIMER_APELLIDO As String
        Dim SEGUNDO_APELLIDO As String

        Dim oradb1 As String = Configuracion.verconfig
        Dim conn1 As New OracleConnection()
        Dim myCMD1 As New OracleCommand()
        conn1.ConnectionString = oradb1
        conn1.Open()
        Try
            myCMD1.Connection = conn1
            myCMD1.CommandText = "select POSICION, CODIGO_CARGO_ELECTIVO, CODIGO_DEPARTAMENTO, " _
            & "CODIGO_MUNICIPIO, CODIGO_MOVIMIENTO, CODIGO_PARTIDO, ESTADO, PRIMER_NOMBRE, SEGUNDO_NOMBRE, " _
            & "PRIMER_APELLIDO, SEGUNDO_APELLIDO " _
            & "from im_candidatos where identidad = '" & identidad & "' and codigo_candidatos = " & codigo_candidato
            myCMD1.CommandType = CommandType.Text            
            myCMD1.ExecuteOracleScalar()

            Dim chek As OracleDataReader = myCMD1.ExecuteReader()
            If chek.Read Then                
                POSICION = chek.Item("POSICION")
                CODIGO_CARGO_ELECTIVO = chek.Item("CODIGO_CARGO_ELECTIVO")
                CODIGO_DEPARTAMENTO = chek.Item("CODIGO_DEPARTAMENTO")
                CODIGO_MUNICIPIO = chek.Item("CODIGO_MUNICIPIO")
                CODIGO_MOVIMIENTO_im_candidatos = chek.Item("CODIGO_MOVIMIENTO")
                CODIGO_PARTIDO_im_candidatos = chek.Item("CODIGO_PARTIDO")
                ESTADO = chek.Item("ESTADO")
                If Not IsDBNull(chek.Item("PRIMER_NOMBRE")) Then
                    PRIMER_NOMBRE = chek.Item("PRIMER_NOMBRE")
                Else
                    PRIMER_NOMBRE = ""
                End If
                If Not IsDBNull(chek.Item("SEGUNDO_NOMBRE")) Then
                    SEGUNDO_NOMBRE = chek.Item("SEGUNDO_NOMBRE")
                Else
                    SEGUNDO_NOMBRE = ""
                End If
                If Not IsDBNull(chek.Item("PRIMER_APELLIDO")) Then
                    PRIMER_APELLIDO = chek.Item("PRIMER_APELLIDO")
                Else
                    PRIMER_APELLIDO = ""
                End If
                If Not IsDBNull(chek.Item("SEGUNDO_APELLIDO")) Then
                    SEGUNDO_APELLIDO = chek.Item("SEGUNDO_APELLIDO")
                Else
                    SEGUNDO_APELLIDO = ""
                End If
            End If
            TxtIdentidad.EditValue = identidad
            TxtPosicion.EditValue = POSICION

            Dim indice As Integer = Me.LovCargo.Properties.GetDataSourceRowIndex(Me.LovCargo.Properties.Columns("CODIGO_CARGO_ELECTIVO"), CODIGO_CARGO_ELECTIVO)
            Me.LovCargo.EditValue = Me.LovCargo.Properties.GetDataSourceValue(Me.LovCargo.Properties.ValueMember, indice)

            indice = Me.LovDepartamento.Properties.GetDataSourceRowIndex(Me.LovDepartamento.Properties.Columns("CODIGO_DEPARTAMENTO"), CODIGO_DEPARTAMENTO)
            Me.LovDepartamento.EditValue = Me.LovDepartamento.Properties.GetDataSourceValue(Me.LovDepartamento.Properties.ValueMember, indice)

            Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MUNICIPIOS, Me.LovDepartamento.EditValue)
            indice = Me.LovMunicipio.Properties.GetDataSourceRowIndex(Me.LovMunicipio.Properties.Columns("CODIGO_MUNICIPIO"), CODIGO_MUNICIPIO)
            Me.LovMunicipio.EditValue = Me.LovMunicipio.Properties.GetDataSourceValue(Me.LovMunicipio.Properties.ValueMember, indice)

            indice = Me.LovPartido.Properties.GetDataSourceRowIndex(Me.LovPartido.Properties.Columns("CODIGO_PARTIDO"), partido)
            Me.LovPartido.EditValue = Me.LovPartido.Properties.GetDataSourceValue(Me.LovPartido.Properties.ValueMember, indice)

            Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MOVIMIENTOS, Me.LovPartido.EditValue)
            indice = Me.LovMovimiento.Properties.GetDataSourceRowIndex(Me.LovMovimiento.Properties.Columns("CODIGO_MOVIMIENTO"), movimiento)
            Me.LovMovimiento.EditValue = Me.LovMovimiento.Properties.GetDataSourceValue(Me.LovMovimiento.Properties.ValueMember, indice)


            If ESTADO = "I" Then
                LblEstado.ForeColor = Color.Red
                LblEstado.Text = "CANDIDATO INHABILITADO"
            ElseIf ESTADO = "C" Then
                LblEstado.ForeColor = Color.Green
                LblEstado.Text = "CANDIDATO HABILITADO"
            End If
        Catch ex As Exception
            conn1.Close()
            Mensajes.MensajeError(ex.Message)
        End Try
        conn1.Close()
    End Sub

    Private Sub LookUpEdit1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LovPartido.TextChanged
        Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MOVIMIENTOS, Me.LovPartido.EditValue)
    End Sub

    Private Sub LovDepartamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LovDepartamento.TextChanged
        Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInscripcionCandidatos.IM_MUNICIPIOS, Me.LovDepartamento.EditValue)
    End Sub


    Private Sub GridView5_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView5.FocusedRowChanged
        MsgBox("hola")
        'codigo_candidato()        
        'partido()
        'movimiento()
        Dim rw As DataRowView = GridView5.GetRow(e.FocusedRowHandle)
        If rw IsNot Nothing Then
            Dim requisito As Integer = rw.Row.Item("CODIGO")
            Me.IM_REQUISITOS_X_CANDIDATO1TableAdapter1.Fill(Me.DSInscripcionCandidatos.IM_REQUISITOS_X_CANDIDATO1, codigo_candidato, partido, movimiento, requisito)

            '            Me.ImagenesCiudadanosRespaldanTableAdapter.FillBy(Me.DSConsultas.ImagenesCiudadanosRespaldan, codCiuRes, codPar, codMov)
        End If
    End Sub

End Class