Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.OracleClient


Public Class XfrmConsultaFirmas


    Dim vi As Integer = 1
    Dim errores As Integer = 0
    Public iddepto As Integer
    Public idmuni As Integer
    Public idpartido As Integer
    Public idmovimiento As Integer
    Public folio As String
    Dim booleanerror As Boolean = False
    Dim mensajeerror As String
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Sub actualizarimagen()
        Try

            Dim cnx As New OracleConnection(Configuracion.verconfig)
            Dim view As GridView = GridView1
            'Data.ConvertImageToByteArray(Me.Imgimagen.EditValue)

            Dim sqlstring As String
            sqlstring = "UPDATE IM_IMAGENES_FIRMAS set  IMAGEN=:ft where CODIGO_PARTIDO=:idp and CODIGO_MOVIMIENTO=:idmov and PAGINA=:pagina"
            Dim cmd As New OracleCommand(sqlstring, cnx)
            cmd.Parameters.Add(":ft", OracleType.Blob).Value = Data.ConvertImageToByteArray(Me.img.Image)
            cmd.Parameters.Add(":idp", OracleType.Number).Value = CType((view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO")), Integer)
            cmd.Parameters.Add(":idmov", OracleType.Number).Value = CType(view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO"), Integer)
            cmd.Parameters.Add(":pagina", OracleType.Number).Value = CType(view.GetRowCellValue(view.FocusedRowHandle, "PAGINA"), Integer)
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
            Mensajes.mimensaje("Imágen Actualizada Correctamente")
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim view As GridView = GridView1
        Dim sq As String = "SELECT IMAGEN FROM IM_IMAGENES_FIRMAS where  CODIGO_PARTIDO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO") & " and CODIGO_MOVIMIENTO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO") & " and PAGINA=" & view.GetRowCellValue(view.FocusedRowHandle, "PAGINA")
        If COracle.ObtenerImagen(sq, "IMAGEN") Is Nothing Then
            Me.img.Image = Nothing
        Else
            Me.img.Image = COracle.ObtenerImagen(sq, "IMAGEN")
        End If
    End Sub

    Private Sub GridView1_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
        e.ExceptionMode = ExceptionMode.DisplayError
        e.WindowCaption = "error"
        e.ErrorText = mensajeerror
        GridView1.HideEditor()

    End Sub


    Sub estadistico(ByVal idp As Integer, ByVal idmov As Integer)
        CREstadistico.AsignarVariables(idp, idmov)
        CREstadistico.calcular()
        Me.lblconsistentes.Text = Math.Round(CREstadistico.Firmasmovimiento, 0)
        Me.lblporcentaje.Text = Math.Round(CREstadistico.porcentaje, 2) & "%"
        Me.lblfirmasnecesarias.Text = Math.Round(CREstadistico.TotalFirmas, 0)
        Me.lblinconsistentes.Text = Math.Round(CREstadistico.FirmasInconsistentes, 0)
        lbltodos.Text = Math.Round((CREstadistico.Firmasmovimiento + CREstadistico.FirmasInconsistentes), 0)
    End Sub


    Sub salir()
        Me.Close()
    End Sub



    Private Sub XfrmCiudadanos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        '   PERMITIR EL INGRESO DE SOLO CARACTERES NUMERALES
        Dim view As GridView = GridView1
        If view.FocusedColumn.FieldName = "IDENTIDAD" Then
            VControles.solonumeros(e)
        End If
    End Sub
    Sub limpiar()
        CmbPartido.EditValue = DBNull.Value
        CmbDepartamento.EditValue = DBNull.Value
        CmbMunicipio.EditValue = DBNull.Value
        CmbMovimiento.EditValue = DBNull.Value

    End Sub

    Sub ActivarFiltros()
        If ActivarOpciones.PEstado = "PDO" Then
            Dim idp As String = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")
            Me.CmbPartido.Enabled = False


            'Partido
            Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)
            Try
                Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, idp)
                CmbMovimiento.EditValue = DBNull.Value
            Catch ex As Exception

            End Try

        ElseIf ActivarOpciones.PEstado = "MOV" Then
            Dim idp As String = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")
            Dim idmov As String = COracle.ObtenerDatos("SELECT CODIGO_MOVIMIENTO FROM IM_PARAMETROS_GENERALES", "CODIGO_MOVIMIENTO")

            Me.CmbPartido.Enabled = False
            Me.CmbMovimiento.Enabled = False

            'Partido
            Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)
            Try
                Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, idp)

            Catch ex As Exception

            End Try

            'Movimiento
            Dim m As Integer = Me.CmbMovimiento.Properties.GetDataSourceRowIndex(Me.CmbMovimiento.Properties.Columns("CODIGO_MOVIMIENTO"), idmov)
            Me.CmbMovimiento.EditValue = Me.CmbMovimiento.Properties.GetDataSourceValue(Me.CmbMovimiento.Properties.ValueMember, m)
            '******************Ventana de espera
            Dim waitDialog As New WaitDialogForm("Obteniendo Información", "Por favor espere..")

            Me.MOSTRAR_FIRMASTableAdapter.FillBy(Me.DSCiudadanos.MOSTRAR_FIRMAS, idp, idmov)
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
            estadistico(idp, idmov)
        Else
            limpiar()
        End If
    End Sub





    Private Sub XfrmCiudadanos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'idmovimiento = COracle.ObtenerDatos("SELECT * FROM IM_PARAMETROS_GENERALES", "CODIGO_MOVIMIENTO")

        'Dim ip As String = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")

        'Me.CODIGO_PARTIDO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CODIGO_PARTIDO=" & ip)
        'Me.CODIGO_MOVIMIENTO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CODIGO_MOVIMIENTO=" & idmovimiento)
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
        ActivarFiltros()
        Me.TA_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.TA_DEPARTAMENTOS)


    End Sub


    Private Sub CmbPartido_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, CmbPartido.EditValue)

        Catch ex As Exception

        End Try
    End Sub



    Sub guardar(ByVal i As Integer)
        Dim NombreIgual As String = "S"
        Dim NombreP As String = ""
        Dim inconsistente As String = "S"
        Dim Observacion As String = ""
        Try



            Dim view As GridView = GridView1
            'RECORRER EL GRID

            'COMPROBAR  SI LA IDENTIDAD EXISTE
            Dim a As String = view.GetRowCellValue(i, "IDENTIDAD").ToString.Trim
            Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & a & "'"
            'VERIFICAR IDENTIDAD
            If COracle.ObtenerDatos(consulta, "NUMERO_IDENTIDAD") <> "N" Then
                'SI LA IDENTIDAD EXISTE SE PREOCEDE A COMPROBAR LOS NOMBRES
                'NombreP = COracle.ObtenerDatos(consulta, "NOMBRE")

                'COMPROBANDO EL PRIMER NOMBRE
                Dim pnombre As String = view.GetRowCellValue(i, "PRIMER_NOMBRE_PAPELETA").ToString.Trim
                Dim papellido As String = view.GetRowCellValue(i, "PRIMER_APELLIDO_PAPELETA").ToString.Trim

                If pnombre <> COracle.ObtenerDatos(consulta, "PRIMER_NOMBRE") Then
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El primer nombre no coincide con el del padrón electoral "
                    'COMPROBANDO EL SEGUNDO NOMBRE

                ElseIf papellido <> COracle.ObtenerDatos(consulta, "PRIMER_APELLIDO") Then
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El primer apellido no coincide con el del padrón electoral "
                    'COMPROBANDO EL SEGUNDO NOMBRE

                End If

                'COMPROBANDO INGRESO NULO DE SEGUNDO NOMBRE Y APELLIDO
                Dim SNOMBRE As String = view.GetRowCellValue(i, "SEGUNDO_NOMBRE_PAPELETA").ToString.Trim
                Dim SAPELLIDO As String = view.GetRowCellValue(i, "SEGUNDO_APELLIDO_PAPELETA").ToString.Trim

                If COracle.ObtenerDatos(consulta, "SEGUNDO_NOMBRE") = SNOMBRE Then
                Else
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El segundo nombre no coincide con el del padrón electoral "
                End If

                If COracle.ObtenerDatos(consulta, "SEGUNDO_APELLIDO") = SAPELLIDO Then
                Else
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El segundo apellido no coincide con el del padrón electoral "
                End If


                If view.GetRowCellValue(view.FocusedRowHandle, "FIRMA") Is Nothing Or IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "FIRMA")) Or view.GetRowCellValue(view.FocusedRowHandle, "FIRMA").ToString = "N" Then
                    inconsistente = "N"

                    Observacion &= " No presenta firma"
                End If

                If view.GetRowCellValue(view.FocusedRowHandle, "HUELLA") Is Nothing Or IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "HUELLA")) Or view.GetRowCellValue(view.FocusedRowHandle, "HUELLA").ToString = "N" Then
                    inconsistente = "N"

                    Observacion &= " No presenta huella"
                End If

                If view.GetRowCellValue(view.FocusedRowHandle, "DIRECCION") Is Nothing Or IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "DIRECCION")) Or view.GetRowCellValue(view.FocusedRowHandle, "DIRECCION").ToString = "N" Then
                    inconsistente = "N"

                    Observacion &= " No presenta dirección"
                End If
            Else
                inconsistente = "N"
                Observacion = " Identidad no encontrada en el padrón electoral"
                NombreIgual = ""

            End If
            GuardarEnBase(i, NombreIgual, inconsistente, Observacion)
            estadistico(Me.CmbPartido.EditValue, Me.CmbMovimiento.EditValue)
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Sub GuardarEnBase(ByVal i As Integer, ByVal NombreIgual As String, ByVal inconsistente As String, ByVal Observacion As String)
        'Guardar Informacion
        Try
            Dim view As GridView = GridView1
            Dim idciudadano = GridView1.GetRowCellValue(i, "CODIGO_CUIDADANOS_RESPALDAN")
            Dim consulta As String
            consulta = "update IM_CIUDADANOS_RESPALDAN set FIRMA='" & GridView1.GetRowCellValue(i, "FIRMA").ToString & "', "
            consulta &= "HUELLA='" & GridView1.GetRowCellValue(i, "HUELLA").ToString & "', DIRECCION='" & GridView1.GetRowCellValue(i, "DIRECCION").ToString & "', "
            consulta &= "IDENTIDAD='" & GridView1.GetRowCellValue(i, "IDENTIDAD").ToString.Trim & "',NOMBRE_IGUAL='" & NombreIgual & "', "
            consulta &= "CONSISTENTE='" & inconsistente & "',OBSERVACION='" & Observacion & "', "
            consulta &= "PRIMER_NOMBRE_PAPELETA='" & GridView1.GetRowCellValue(i, "PRIMER_NOMBRE_PAPELETA").ToString.Trim & "', "
            consulta &= "SEGUNDO_NOMBRE_PAPELETA='" & GridView1.GetRowCellValue(i, "SEGUNDO_NOMBRE_PAPELETA").ToString.Trim & "', "
            consulta &= "PRIMER_APELLIDO_PAPELETA='" & GridView1.GetRowCellValue(i, "PRIMER_APELLIDO_PAPELETA").ToString.Trim & "', "
            consulta &= "SEGUNDO_APELLIDO_PAPELETA='" & GridView1.GetRowCellValue(i, "SEGUNDO_APELLIDO_PAPELETA").ToString.Trim & "', "
            consulta &= "MODIFICADO_POR='" & usuario & "', FECHA_MODIFICACION =sysdate"
            If folio <> "" Then
                consulta &= ", FOLIO=" & GridView1.GetRowCellValue(i, "FOLIO")

            End If
            'If Not IsDBNull(GridView1.GetRowCellValue(i, "IMAGEN_FIRMA")) Then

            '    Try

            '        Dim cnx As New OracleConnection(Configuracion.verconfig)
            '        '
            '        Dim bo As Byte() = view.GetRowCellValue(view.FocusedRowHandle, "IMAGEN_FIRMA") 'Data.ConvertImageToByteArray(Me.Imgimagen.EditValue)
            '        Dim idc As Integer = CType(GridView1.GetRowCellValue(i, "CODIGO_CUIDADANOS_RESPALDAN"), Integer)
            '        Dim sqlstring As String
            '        sqlstring = "UPDATE IM_CIUDADANOS_RESPALDAN SET IMAGEN_FIRMA=:ft WHERE CODIGO_CUIDADANOS_RESPALDAN=:cod AND CODIGO_PARTIDO=:cp AND CODIGO_MOVIMIENTO=:cm"
            '        Dim cmd As New OracleCommand(sqlstring, cnx)
            '        cmd.Parameters.Add(":ft", OracleType.Blob).Value = bo
            '        cmd.Parameters.Add(":cod", OracleType.Number, 8).Value = idc
            '        cmd.Parameters.Add(":cp", OracleType.Number, 2).Value = CType((GridView1.GetRowCellValue(i, "CODIGO_PARTIDO")), Integer)
            '        cmd.Parameters.Add(":cm", OracleType.Number, 3).Value = CType(GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO"), Integer)
            '        cnx.Open()
            '        cmd.ExecuteNonQuery()
            '        cnx.Close()

            '    Catch ex As Exception
            '        Mensajes.mimensaje(ex.Message)
            '    End Try

            'Else
            '    consulta &= ", IMAGEN_FIRMA=NULL "
            'End If

            consulta &= " WHERE CODIGO_CUIDADANOS_RESPALDAN=" & GridView1.GetRowCellValue(i, "CODIGO_CUIDADANOS_RESPALDAN")
            consulta &= " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO") & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO")
            COracle.ejecutarconsulta(consulta)
            view.SetRowCellValue(i, "CONSISTENTE", inconsistente)
            view.SetRowCellValue(i, "OBSERVACION", Observacion)
            Mensajes.MensajeActualizar()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub


    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MsgBox(GridView1.GetRowCellValue(2, "FIRMA").ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim view As GridView = GridView1
        Dim sq As String = "SELECT IMAGEN FROM IM_IMAGENES_FIRMAS where  CODIGO_PARTIDO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO") & " and CODIGO_MOVIMIENTO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO") & " and PAGINA=" & view.GetRowCellValue(view.FocusedRowHandle, "PAGINA")
        If COracle.ObtenerImagen(sq, "IMAGEN") Is Nothing Then
            Me.img.Image = Nothing
        Else
            Me.img.Image = COracle.ObtenerImagen(sq, "IMAGEN")
        End If
    End Sub

    Private Sub GridView1_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Try
            Dim view As GridView = GridView1
            Dim sq As String = "SELECT IMAGEN FROM IM_IMAGENES_FIRMAS where  CODIGO_PARTIDO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO") & " and CODIGO_MOVIMIENTO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO") & " and PAGINA=" & view.GetRowCellValue(view.FocusedRowHandle, "PAGINA")
            If COracle.ObtenerImagen(sq, "IMAGEN") Is Nothing Then
                Me.img.Image = Nothing
            Else
                Me.img.Image = COracle.ObtenerImagen(sq, "IMAGEN")
            End If
        Catch ex As Exception

        End Try
      

    End Sub







    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        Dim view As GridView = TryCast(sender, GridView)
        booleanerror = False
        If view.FocusedColumn.FieldName = "PRIMER_NOMBRE_PAPELETA" Or view.FocusedColumn.FieldName = "PRIMER_APELLIDO_PAPELETA" Or view.FocusedColumn.FieldName = "IDENTIDAD" Then
            e.Valid = e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)

        End If

        If view.FocusedColumn.FieldName = "IDENTIDAD" Then

            If e.Value.ToString.Length <> 13 Then
                mensajeerror = "El número de digitos en el campo Identidad es incorrecto debe de ser igual a 13 digitos"
                e.Valid = False

            End If

            If IsNumeric(e.Value) = False Then
                mensajeerror = "El valor del número de indentidad debe de ser un valor numérico"
                e.Valid = False
            End If

            'Dim a As String = "select IDENTIDAD from IM_CIUDADANOS_RESPALDAN where IDENTIDAD='" & e.Value.ToString & "' and CODIGO_PARTIDO=" & idpartido & " and CODIGO_MOVIMIENTO=" & idmovimiento
            'If COracle.ObtenerDatos(a, "IDENTIDAD") <> "N" Then
            '    mensajeerror = "Este firmante ya existe en su lista"
            '    e.Valid = False
            'End If

        End If

    End Sub






    Private Sub ChkMuni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMuni.CheckedChanged
        If ChkDepto.CheckState = CheckState.Checked Then
            Me.CmbMunicipio.Enabled = True
        Else
            Me.CmbMunicipio.Enabled = False

        End If
    End Sub

    Private Sub ChkDepto_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDepto.CheckedChanged
        If ChkDepto.CheckState = CheckState.Checked Then
            Me.CmbDepartamento.Enabled = True
        Else
            Me.CmbDepartamento.Enabled = False

        End If
    End Sub

    'Private Sub ChkGeografica_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGeografica.CheckedChanged
    '    If ChkGeografica.CheckState = CheckState.Checked Then
    '        Me.CmbDepartamento.Enabled = False
    '        Me.CmbMunicipio.Enabled = False
    '        Me.ChkDepto.CheckState = CheckState.Unchecked
    '        Me.ChkMuni.CheckState = CheckState.Unchecked
    '        Me.ChkDepto.Enabled = True
    '        Me.ChkMuni.Enabled = True
    '    Else

    '        Me.ChkDepto.CheckState = CheckState.Unchecked
    '        Me.ChkMuni.CheckState = CheckState.Unchecked
    '        Me.ChkDepto.Enabled = False
    '        Me.ChkMuni.Enabled = False
    '    End If
    'End Sub




    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If ActivarOpciones.PEstado = "PDO" Then

            If Me.CmbMovimiento.EditValue Is Nothing Or IsDBNull(Me.CmbMovimiento.EditValue) Or Me.CmbMovimiento.Text = "Seleccione" Then
                Mensajes.mimensaje("Para filtrar la información primero seleccione un movimiento")
            Else

                filtroGrid()
            End If

        ElseIf ActivarOpciones.PEstado = "MOV" Then
            filtroGrid()

        ElseIf ActivarOpciones.PEstado = "TSE" Then
            If Me.CmbPartido.EditValue Is Nothing Or IsDBNull(Me.CmbPartido.EditValue) Or Me.CmbPartido.Text = "Seleccione" Then
                Mensajes.mimensaje("Para filtrar la información primero seleccione un Partido Político")

            ElseIf Me.CmbMovimiento.EditValue Is Nothing Or IsDBNull(Me.CmbMovimiento.EditValue) Or Me.CmbMovimiento.Text = "Seleccione" Then
                Mensajes.mimensaje("Para filtrar la información primero seleccione un movimiento")
            Else
                filtroGrid()

            End If

        End If





    End Sub

    Sub filtroGrid()
        GridView1.ActiveFilter.Clear()


        If txtidentidad.Text = Nothing Or txtidentidad.Text = "" Then
        Else

            Me.colIDENTIDAD.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("IDENTIDAD LIKE '%" & Me.txtidentidad.Text & "%'")

        End If

        'Dim ip As String = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")

        'Me.CODIGO_PARTIDO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CODIGO_PARTIDO=" & ip)
        'Me.CODIGO_MOVIMIENTO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CODIGO_MOVIMIENTO=" & idmovimiento)


        If ChkDepto.CheckState = CheckState.Checked Then
            Me.colCODIGO_DEPARTAMENTO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(Me.CmbDepartamento.EditValue)

        End If

        If ChkMuni.CheckState = CheckState.Checked Then
            Me.colCODIGO_MUNICIPIO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(Me.CmbMunicipio.EditValue)

        End If

        If Me.txtfolio.Text = Nothing Or Me.txtfolio.Text = "" Then

        Else
            Me.colFOLIO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("FOLIO=" & Me.txtfolio.Text)

        End If

        If Me.txtpagina.Text = Nothing Or Me.txtpagina.Text = "" Then

        Else
            Me.colPAGINA.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("PAGINA=" & Me.txtpagina.Text)

        End If

        If Me.CmbFiltro.SelectedIndex = 0 Then
            ' Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'N' or CONSISTENTE= 'S'")
        ElseIf Me.CmbFiltro.SelectedIndex = 1 Then
            Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'S'")

        ElseIf Me.CmbFiltro.SelectedIndex = 2 Then
            Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'N'")

        End If


    End Sub


    Private Sub BtnReestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReestablecer.Click
        GridView1.ActiveFilter.Clear()

        Me.ChkDepto.CheckState = CheckState.Unchecked


    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try


            If (XtraMessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As GridView = GridView1
            Dim consulta As String
            consulta = "delete from IM_CIUDADANOS_RESPALDAN where "
            consulta &= "CODIGO_CUIDADANOS_RESPALDAN=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_CUIDADANOS_RESPALDAN")
            consulta &= " and CODIGO_PARTIDO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO")
            consulta &= " and CODIGO_MOVIMIENTO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO")
            Try
                COracle.ejecutarconsulta(consulta)
                view.DeleteRow(view.FocusedRowHandle)
                estadistico(Me.CmbPartido.EditValue, Me.CmbMovimiento.EditValue)
            Catch ex As Exception
                Mensajes.mimensaje("No se pudo eliminar el registro seleccionado")
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            If (XtraMessageBox.Show("¿Desea actualizar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

                Dim view As GridView = GridView1
                guardar(view.FocusedRowHandle)
            Else
                Dim view As GridView = CType(sender, GridView)
                view.CancelUpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub






    Private Sub CmbPartido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPartido.TextChanged
        Try
            TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, Me.CmbPartido.EditValue)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub CmbDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDepartamento.EditValueChanged

    End Sub

    Private Sub CmbDepartamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbDepartamento.TextChanged
        Try
            TA_MUNICIPIOSTableAdapter.FillBy1(Me.DSDeptoMuni.TA_MUNICIPIOS, Me.CmbDepartamento.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbMovimiento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMovimiento.EditValueChanged
        Try
            If CmbMovimiento.Text = "Seleccione" Or CmbMovimiento.EditValue Is Nothing Then

            Else
                If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "TSE" Then
                    Dim waitDialog As New WaitDialogForm("Obteniendo Información", "Por favor espere..")

                    Me.MOSTRAR_FIRMASTableAdapter.FillBy(Me.DSCiudadanos.MOSTRAR_FIRMAS, Me.CmbPartido.EditValue, Me.CmbMovimiento.EditValue)
                    waitDialog.Caption = "finalizando..."
                    waitDialog.Close()
                    estadistico(Me.CmbPartido.EditValue, Me.CmbMovimiento.EditValue)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
            OpenFileDialog1.ShowDialog()
            'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
            Dim UrlImagen As String = OpenFileDialog1.FileName
            Me.img.Image = Image.FromFile(UrlImagen)
        Catch ex As Exception
            Me.img.Image = Nothing
        End Try
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If Me.img.Image Is Nothing Then
            Mensajes.mimensaje("Seleccione una imagen")
        Else
            Dim view As GridView = GridView1
            Dim sq As String = "SELECT PAGINA FROM IM_IMAGENES_FIRMAS where  CODIGO_PARTIDO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO") & " and CODIGO_MOVIMIENTO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO") & " and PAGINA=" & view.GetRowCellValue(view.FocusedRowHandle, "PAGINA")
            If COracle.ObtenerDatos(sq, "PAGINA") <> "N" Then
                actualizarimagen()
            Else
                guardarimagen()
            End If

        End If
    End Sub

    Sub guardarimagen()
        Try
            If img Is Nothing Then
            Else
                Dim cnx As New OracleConnection(Configuracion.verconfig)
                '
                'Data.ConvertImageToByteArray(Me.Imgimagen.EditValue)
                Dim view As GridView = GridView1
                Dim sqlstring As String
                sqlstring = "INSERT INTO IM_IMAGENES_FIRMAS ( CODIGO_PARTIDO,CODIGO_MOVIMIENTO,PAGINA,FOLIO,IMAGEN) VALUES(:idp,:idmov,:pag,:folio,:imagen)"
                Dim cmd As New OracleCommand(sqlstring, cnx)
                cmd.Parameters.Add(":idp", OracleType.Number, 2).Value = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO")
                cmd.Parameters.Add(":idmov", OracleType.Number, 3).Value = view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO")
                cmd.Parameters.Add(":pag", OracleType.Number).Value = view.GetRowCellValue(view.FocusedRowHandle, "PAGINA")
                If IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "folio")) Or view.GetRowCellValue(view.FocusedRowHandle, "FOLIO") Is Nothing Or view.GetRowCellValue(view.FocusedRowHandle, "FOLIO").ToString = "" Then
                    cmd.Parameters.Add(":folio", OracleType.Number).Value = DBNull.Value
                Else
                    cmd.Parameters.Add(":folio", OracleType.Number).Value = view.GetRowCellValue(view.FocusedRowHandle, "FOLIO")
                End If
                cmd.Parameters.Add(":imagen", OracleType.Blob).Value = Data.ConvertImageToByteArray(Me.img.Image)
                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
                Mensajes.mimensaje("Imágen Almacenada Correctamente")
            End If
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try


    End Sub

    Private Sub GCBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCBusqueda.Click

    End Sub
End Class