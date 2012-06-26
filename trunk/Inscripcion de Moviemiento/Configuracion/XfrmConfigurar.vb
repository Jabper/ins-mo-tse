Imports DevExpress.XtraEditors
Imports System.Data.OracleClient

Public Class XfrmConfigurar
    Dim comprobar As Boolean = False
    Dim cadenaActiva As String = ""
    Dim id As String
    Dim idmov As Integer
    Dim vrol As Integer
    Dim creousuario As Boolean = False
    Dim pasarpagina As Boolean = False

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
    Function conexion() As Boolean

        ORCL.DSoruce = SystemInformation.ComputerName
        ORCL.pass = "TSEORACLE2012"
        ORCL.userid = "TSE"

        If ORCL.ComprobarConexion1 = True Then
            Configuracion.cambiarconfiguracion()
            Return True
        Else

            If ORCL.ComprobarConexion2 = True Then

                Configuracion.cambiarconfiguracion()
                Return True
            Else
                Dim mensaje As String
                mensaje = "Error al accesar a la base de datos" & vbCrLf & "1. Asegurese de que todos los componentes necesarios esten instalados"

                MsgBox(mensaje, MsgBoxStyle.Critical, "Error de Conexión")
                Return False
            End If
        End If
    End Function

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
        XFrmMenuPrincipal.Visible = True
        XFrmMenuPrincipal.Focus()
        XFrmMenuPrincipal.verificaringreso()
        Me.Close()
    End Sub

    Private Sub WizardControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangedEventArgs) Handles WizardControl1.SelectedPageChanged
        If (e.Page.Name = "WizardPage1") And pasarpagina = True Then

            'CompletionWizardPage1.Focus()
            WizardControl1.SetNextPage()
        End If
    End Sub



    Private Sub WizardControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles WizardControl1.SelectedPageChanging
        If (e.Page.Name = "WizardPage1") Then
            'MsgBox(Configuracion.verconfig)
            'If conexion() = True Then
            If ActivarOpciones.PEstado = "MOV" Then



                'MOSTRAR DATOS
                id = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")

                If id = "N" Then
                    e.Cancel = True
                Else
                    Dim consulta As String = "SELECT IMAGEN FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & id
                    Me.INSIGNIAPictureEdit.Image = COracle.ObtenerImagen(consulta, "IMAGEN")
                    lblpartido.Text = COracle.ObtenerDatos("SELECT NOMBRE FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & id, "NOMBRE")
                    idmov = COracle.ObtenerDatos("SELECT CODIGO_MOVIMIENTO FROM IM_PARAMETROS_GENERALES", "CODIGO_MOVIMIENTO")

                    lblmovimiento.Text = COracle.ObtenerDatos("SELECT NOMBRE_MOVIMIENTO FROM IM_MOVIMIENTOS WHERE CODIGO_MOVIMIENTO=" & idmov, "NOMBRE_MOVIMIENTO")

                End If
            Else
                pasarpagina = True
                'Me.WizardControl1.Pages.
                'WizardControl1.SelectedPage = WizardPage2
                'WizardPage2.Focus()
            End If
            'Else
            '    e.Cancel = True

            'End If
        End If


        If (e.Page.Name = "WizardPage2") Then
            If pasarpagina = True Then

                pasarpagina = False

                'Me.WizardControl1.Pages.Remove(Me.WizardPage2)
                'CompletionWizardPage1.Focus()
                'txtusuario.Focus()

            Else

                If DxValidationProvider1.Validate = False Then



                    e.Cancel = True
                Else
                    Try

                        Dim cnx As New OracleConnection(Configuracion.verconfig)
                        Dim sqlstring As String
                        sqlstring = "UPDATE IM_MOVIMIENTOS SET INSIGNIA=:ft WHERE CODIGO_MOVIMIENTO=:cod"
                        Dim cmd As New OracleCommand(sqlstring, cnx)
                        cmd.Parameters.Add(":ft", OracleType.Blob).Value = Data.ConvertImageToByteArray(Me.EMBLEMAPictureEdit.Image)

                        cmd.Parameters.Add(":cod", OracleType.Number).Value = idmov
                        cnx.Open()
                        cmd.ExecuteNonQuery()
                        cnx.Close()



                        Dim file As System.IO.FileStream
                        file = System.IO.File.Create(Application.StartupPath.ToString & "\Cnf.ini")

                    Catch ex As Exception
                        e.Cancel = True
                        Mensajes.mimensaje(ex.Message)
                    End Try
                End If

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
                    If creousuario = False Then
                        If crearusuario() = True Then
                            If asignarroles() = True Then
                            Else
                                e.Cancel = True
                            End If
                        Else
                            e.Cancel = True
                        End If
                    Else
                        If asignarroles() = True Then
                        Else
                            e.Cancel = True
                        End If
                    End If

                End If
            End If


        End If
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

    Function crearusuario() As Boolean
        Try


            Dim Cusuario As DTUsers.IM_USUARIOSRow
            Cusuario = Me.DTUsers.IM_USUARIOS.NewIM_USUARIOSRow

            With Cusuario
                .CODIGO_USUARIO = Me.txtusuario.Text

                .NOMBRE = NOMBRETextEdit.Text
                .IDENTIDAD = IDENTIDADTextEdit.Text
                .CONTRASENA = CONTRASENATextEdit.Text

                .ESTADO = "A"
                If ActivarOpciones.PEstado = "MOV" Then
                    .CODIGO_MOVIMIENTO = idmov
                    .NIVEL = 3
                    .CODIGO_ROL = 3
                    .CODIGO_PARTIDO = id
                    vrol = 3
                ElseIf ActivarOpciones.PEstado = "PDO" Then
                    .CODIGO_PARTIDO = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")
                    .NIVEL = 2
                    .CODIGO_ROL = 2
                    vrol = 2
                ElseIf ActivarOpciones.PEstado = "TSE" Then

                    .CODIGO_PARTIDO = 0
                    .NIVEL = 1
                    .CODIGO_ROL = 1
                    vrol = 1
                End If

                .PREGUNTA_SEGURIDAD = PREGUNTA_SEGURIDADTextEdit.EditValue
                .RESPUESTA_SEGURIDAD = RESPUESTA_SEGURIDADTextEdit.Text

                .ADICIONADO_POR = "TSE"
                .FECHA_ADICION = DateTime.Now
            End With

            Me.DTUsers.IM_USUARIOS.Rows.Add(Cusuario)

            Me.IM_USUARIOSTableAdapter.Update(Me.DTUsers.IM_USUARIOS)
            creousuario = True
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function

    Function asignarroles() As Boolean
        Try
            Dim cnx As New OracleConnection(Configuracion.verconfig)

            cnx.Open()
            Dim myCMD As New OracleCommand()
            myCMD.Connection = cnx
            myCMD.CommandText = "IM_P_OPERACIONES_X_USUARIO"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("pni_rol", OracleType.Number, ParameterDirection.Input)).Value = vrol
            myCMD.Parameters.Add(New OracleParameter("pvi_usuario", OracleType.NVarChar, 32767, ParameterDirection.Input)).Value = Me.txtusuario.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_usuario_creador", OracleType.NVarChar, 32767, ParameterDirection.Input)).Value = "TSE"
            myCMD.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()
            If CType(myCMD.Parameters("PVO_MENSAJE").Value, String) = "OK" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Sub WizardPage2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles WizardPage2.GotFocus
       
    End Sub
End Class