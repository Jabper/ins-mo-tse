Imports DevExpress.XtraEditors
Imports System.Data.OracleClient

Public Class XfrmConfigurar
    Dim comprobar As Boolean = False
    Dim cadenaActiva As String = ""
    Dim id As String
    Dim idmov As Integer
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
    Sub conexion()
        'ORCL.DSoruce = SystemInformation.ComputerName
        'ORCL.pass = "tse"
        'ORCL.userid = "SYSTEM"

        'If ORCL.ComprobarConexion1 = True Then
        '    Configuracion.cambiarconfiguracion()
        '    cadenaActiva = "1"
        '    comprobar = True
        'Else

        '    If ORCL.ComprobarConexion2 = True Then

        '        Configuracion.cambiarconfiguracion()
        '        comprobar = True
        '        cadenaActiva = "2"
        '    Else
        '        Dim mensaje As String
        '        mensaje = "Error al accesar a la base de datos" & vbCrLf & "1. Asegurese de que todos los componentes necesarios esten instalados"
        '        mensaje &= vbCrLf & "2. Revise que la constraseña ingresada este correcta"
        '        MsgBox(mensaje, MsgBoxStyle.Critical, "Error de Conexión")
        '        comprobar = False
        '    End If
        'End If
        ORCL.DSoruce = SystemInformation.ComputerName
        ORCL.pass = "TSEORACLE2012"
        ORCL.userid = "TSE"

        If ORCL.ComprobarConexion1 = True Then
            Configuracion.cambiarconfiguracion()

        Else

            If ORCL.ComprobarConexion2 = True Then

                Configuracion.cambiarconfiguracion()

            Else

            End If
        End If
    End Sub

    Private Sub XfrmConfigurar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim S As String

        S = UCase(e.KeyChar)

        S = ChrW(Asc(S))

        e.KeyChar = S
    End Sub
    Private Sub XfrmConfigurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PreguntasDeSeguridad()
    End Sub

    Private Sub WizardControl1_CancelClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WizardControl1.CancelClick
        Dim pregunta As DialogResult = XtraMessageBox.Show("¿Desea cancelar y salir del asistente de configuración del sistema", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pregunta = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub WizardControl1_FinishClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WizardControl1.FinishClick
        XFrmMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub WizardControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangedEventArgs) Handles WizardControl1.SelectedPageChanged

    End Sub

    Private Sub WizardControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles WizardControl1.SelectedPageChanging
        If (e.Page.Name = "WizardPage1") Then
            'MsgBox(Configuracion.verconfig)
            conexion()
            'MOSTRAR DATOS
            id = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")
            If id = "N" Then
                e.Cancel = True
            Else
                Dim consulta As String = "SELECT IMAGEN FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & id
                Me.INSIGNIAPictureEdit.Image = COracle.ObtenerImagen(consulta, "IMAGEN")
                lblpartido.Text = "Partido Político: " & COracle.ObtenerDatos("SELECT NOMBRE FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & id, "NOMBRE")

            End If


        End If

        If (e.Page.Name = "WizardPage2") Then
            If DxValidationProvider1.Validate = False Then


                NOMBRE_MOVIMIENTOTextEdit.Focus()
                e.Cancel = True
            Else
                Try

                    Dim cnx As New OracleConnection(Configuracion.verconfig)

                    Dim sqlstring As String
                    sqlstring = "INSERT INTO IM_MOVIMIENTOS(CODIGO_MOVIMIENTO,NOMBRE_MOVIMIENTO,CODIGO_PARTIDO,INSIGNIA,EMBLEMA,ADICIONADO_POR,FECHA_ADICION)"
                    sqlstring &= "VALUES (:cod,:nb,:codp,:isg,:emb,:ad,:fecha)"
                    Dim cmd As New OracleCommand(sqlstring, cnx)
                    cmd.Parameters.Add(":cod", OracleType.Number, 3).Value = 40
                    cmd.Parameters.Add(":nb", OracleType.VarChar).Value = NOMBRE_MOVIMIENTOTextEdit.Text
                    cmd.Parameters.Add(":codp", OracleType.Number, 2).Value = id
                    cmd.Parameters.Add(":isg", OracleType.Blob).Value = Data.ConvertImageToByteArray(INSIGNIAPictureEdit.Image)
                    cmd.Parameters.Add(":emb", OracleType.Blob).Value = Data.ConvertImageToByteArray(EMBLEMAPictureEdit.Image)
                    cmd.Parameters.Add(":ad", OracleType.VarChar).Value = "TSE"
                    cmd.Parameters.Add(":fecha", OracleType.DateTime).Value = DateTime.Now

                    cnx.Open()
                    cmd.ExecuteNonQuery()
                    cnx.Close()
                    COracle.ejecutarconsulta("UPDATE IM_PARAMETROS_GENERALES CODIGO_MOVIMIENTO = " & 40)

                    Dim file As System.IO.FileStream
                    file = System.IO.File.Create(Application.StartupPath.ToString & "\Cnf.ini")

                Catch ex As Exception
                    Mensajes.mimensaje(ex.Message)
                End Try
            End If
        End If

        If (e.Page.Name = "CompletionWizardPage1") Then
            If DxValidationProvider3.Validate = False Then
                e.Cancel = True
                Return
            Else
                If DxValidationProvider2.Validate = False Then
                    e.Cancel = True
                    Return

                Else
                    crearusuario()
                End If
            End If

            
        End If
    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
            OpenFileDialog1.ShowDialog()
            'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
            Dim UrlEmblema As String = OpenFileDialog1.FileName
            DxControls.CargarImagen(Me.EMBLEMAPictureEdit, UrlEmblema)
        Catch ex As Exception

        End Try
    End Sub


    Sub PreguntasDeSeguridad() 'SE CREA UN DATA TABLE PARA ENLAZARLO AL CONTROL Y MOSTRAR LAS PREGUNTAS DE SEGURIDAD
        Dim tbl As New DataTable()
        'SE CREAN LAS COLUMNAS DEL DATA TABLE
        tbl.Columns.Add("Id", GetType(Integer))
        tbl.Columns.Add("Pregunta", GetType(String))
        'SE AGREGAN LAS FILAS CON LA INFORMACION
        tbl.Rows.Add(1, "¿Nombre de mi mascosta?")
        tbl.Rows.Add(2, "¿Lugar de Nacimiento?")
        tbl.Rows.Add(3, "¿Color Favorito?")
        tbl.Rows.Add(4, "¿Lugar de nacimiento?")
        tbl.Rows.Add(5, "¿Lugar de nacimiento?")
        'SE ENLAZA EL DATATABLE CREADO PARA MOSTRARLO EN EL CONTROL
        With PREGUNTA_SEGURIDADTextEdit
            .Properties.DataSource = tbl
            .Properties.ValueMember = "Id"
            .Properties.DisplayMember = "Pregunta"
            'SE PREPARA EL CONTROL PARA OCULTAR COLUMNAS
            .Properties.ForceInitialize()
            .Properties.PopulateColumns()
            'SE OCULTA INFORMACION 
            .Properties.Columns(0).Visible = False
            .Properties.Columns(1).Visible = True
        End With


    End Sub

    Private Sub IDENTIDADTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDENTIDADTextEdit.EditValueChanged

    End Sub

    Private Sub IDENTIDADTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IDENTIDADTextEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Sub crearusuario()
        Try


            Dim Cusuario As DTUsers.IM_USUARIOSRow
            Cusuario = Me.DTUsers.IM_USUARIOS.NewIM_USUARIOSRow

            With Cusuario
                .CODIGO_USUARIO = Me.txtusuario.Text
                .CODIGO_ROL = 1
                .NOMBRE = NOMBRETextEdit.Text
                .IDENTIDAD = IDENTIDADTextEdit.Text
                .CONTRASENA = CONTRASENATextEdit.Text
                .CODIGO_PARTIDO = 1 ' CType(id, Integer)
                .ESTADO = "A"
                .CODIGO_MOVIMIENTO = 40
                .PREGUNTA_SEGURIDAD = PREGUNTA_SEGURIDADTextEdit.EditValue
                .RESPUESTA_SEGURIDAD = RESPUESTA_SEGURIDADTextEdit.Text
                .NIVEL = 3
                .ADICIONADO_POR = "TSE"
                .FECHA_ADICION = DateTime.Now
            End With

            Me.DTUsers.IM_USUARIOS.Rows.Add(Cusuario)

            Me.IM_USUARIOSTableAdapter.Update(Me.DTUsers.IM_USUARIOS)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub WizardControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WizardControl1.Click

    End Sub
End Class