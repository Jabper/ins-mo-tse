﻿Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base

Public Class XfrmConsultaFirmas


    Dim vi As Integer = 1
    Dim errores As Integer = 0
    Public iddepto As Integer
    Public idmuni As Integer
    Public idpartido As Integer
    Public idmovimiento As Integer
    Public folio As String
    Dim booleanerror As Boolean = False
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub



    Private Sub GridView1_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
        e.ExceptionMode = ExceptionMode.DisplayError
        e.WindowCaption = "Valor Inválido"
        e.ErrorText = "El campo no puede estar vacío"
        GridView1.HideEditor()

    End Sub



    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (XtraMessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As GridView = CType(sender, GridView)
            Dim consulta As String
            consulta = "delete from IM_CIUDADANOS_RESPALDAN where "
            consulta &= "CODIGO_CUIDADANOS_RESPALDAN=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_CUIDADANOS_RESPALDAN")
            consulta &= " and CODIGO_PARTIDO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_PARTIDO")
            consulta &= " and CODIGO_MOVIMIENTO=" & view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_MOVIMIENTO")
            Try
                COracle.ejecutarconsulta(consulta)
                view.DeleteRow(view.FocusedRowHandle)
            Catch ex As Exception
                Mensajes.mimensaje("No se pudo eliminar el registro seleccionado")
            End Try


        End If
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

    Private Sub XfrmCiudadanos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '******************Ventana de espera
        Dim waitDialog As New WaitDialogForm("Obteniendo Información", "Por favor espere..")
        Me.IM_CIUDADANOS_RESPALDAN1TableAdapter.Fill(Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1)
        waitDialog.Caption = "finalizando..."
        waitDialog.Close()


        Me.TA_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.TA_DEPARTAMENTOS)
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)


    End Sub

    Sub establecer()
        'Partido
        Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idpartido)
        CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)
        Try
            Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, idpartido)

        Catch ex As Exception

        End Try
        'Movimiento
        Dim m As Integer = Me.CmbMovimiento.Properties.GetDataSourceRowIndex(Me.CmbMovimiento.Properties.Columns("CODIGO_MOVIMIENTO"), idmovimiento)
        Me.CmbMovimiento.EditValue = Me.CmbMovimiento.Properties.GetDataSourceValue(Me.CmbMovimiento.Properties.ValueMember, m)
        'Departamento
        Dim d As Integer = Me.CmbDepartamento.Properties.GetDataSourceRowIndex(Me.CmbDepartamento.Properties.Columns("CODIGO_DEPARTAMENTO"), iddepto)
        Me.CmbDepartamento.EditValue = Me.CmbDepartamento.Properties.GetDataSourceValue(Me.CmbDepartamento.Properties.ValueMember, d)
        Try
            Me.TA_MUNICIPIOSTableAdapter.FillBy1(Me.DSDeptoMuni.TA_MUNICIPIOS, CmbDepartamento.EditValue)

        Catch ex As Exception

        End Try
        'Municipio
        Dim mn As Integer = Me.CmbMunicipio.Properties.GetDataSourceRowIndex(Me.CmbMunicipio.Properties.Columns("CODIGO_MUNICIPIO"), idmuni)
        Me.CmbMunicipio.EditValue = Me.CmbMunicipio.Properties.GetDataSourceValue(Me.CmbMunicipio.Properties.ValueMember, mn)


    End Sub
    Private Sub CmbPartido_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPartido.EditValueChanged
        Try
            Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, CmbPartido.EditValue)

        Catch ex As Exception

        End Try
    End Sub



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        'Me.GridView1.ExportToXls("E:\test.xls")
        'validarFilas()
    End Sub


    'Sub validarFilas(ByVal i As Integer)
    '    errores = 0

    '    Try
    '        Dim view As GridView = GridView1


    '        'VERIFICAR QUE EL CAMPO IDENTIDAD NO ESTE VACIO
    '        If IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or view.GetRowCellValue(i, "IDENTIDAD").ToString Is Nothing Then
    '            'CONTAR ERRORES
    '            errores += 1
    '            'Mostar icono de Error

    '            'VERIFICAR QUE EL NOMBRE NO ESTE VACIO
    '        ElseIf IsDBNull(view.GetRowCellValue(i, "PRIMER_NOMBRE_PAPELETA")) Or view.GetRowCellValue(i, "PRIMER_NOMBRE_PAPELETA").ToString Is Nothing Then
    '            'CONTAR ERRORES
    '            errores += 1
    '            'Mostar icono de Error

    '            'VERIFICAR QUE EL APELLIDO NO ESTE VACIO
    '        ElseIf IsDBNull(view.GetRowCellValue(i, "PRIMER_APELLIDO_PAPELETA")) Or view.GetRowCellValue(i, "PRIMER_APELLIDO_PAPELETA").ToString Is Nothing Then
    '            'CONTAR ERRORES
    '            errores += 1
    '            'Mostar icono de Error


    '        ElseIf Not IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or Not IsDBNull(view.GetRowCellValue(i, "PRIMER_NOMBRE_PAPELETA")) Or Not IsDBNull(view.GetRowCellValue(i, "PRIMER_APELLIDO_PAPELETA")) Then
    '            Dim identidad As String = view.GetRowCellValue(i, "IDENTIDAD")
    '            Dim nombre As String = view.GetRowCellValue(i, "PRIMER_NOMBRE_PAPELETA")
    '            Dim apellido As String = view.GetRowCellValue(i, "PRIMER_APELLIDO_PAPELETA")
    '            If (identidad = Nothing Or identidad = "") Or (nombre = Nothing Or nombre = "") Or (apellido = Nothing Or apellido = "") Then
    '                errores += 1

    '            Else

    '            End If


    '        End If




    '        If errores = 0 Then
    '            errores = 0
    '            'guardar(i)

    '        Else
    '            Dim mensaje As String = "Errores encontrados: " & errores
    '            mensaje &= vbCrLf & "Para poder guardar los registros verifique:" & vbCrLf & "1.Que el número de identidad no se encuentre en blanco"
    '            mensaje &= vbCrLf & "2. El primer nombre y primer apellido no estén en blanco"
    '            'Dim view2 As ColumnView = CType(GCBusqueda.FocusedView, ColumnView)
    '            'If view2.IsEditing Then view.HideEditor()
    '            'view.CancelUpdateCurrentRow()
    '            Mensajes.mimensaje(mensaje)
    '            'view.CancelUpdateCurrentRow()

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub



    Private Sub CmbDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDepartamento.EditValueChanged
        Try
            Me.TA_MUNICIPIOSTableAdapter.FillBy1(Me.DSDeptoMuni.TA_MUNICIPIOS, CmbDepartamento.EditValue)

        Catch ex As Exception

        End Try
    End Sub

    Sub guardar(ByVal i As Integer)
        Dim NombreIgual As String = "S"
        Dim NombreP As String = ""
        Dim inconsistente As String = "N"
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
                    inconsistente = "S"
                    NombreIgual = "N"
                    Observacion &= "El primer nombre no coincide con el del padrón electoral "
                    'COMPROBANDO EL SEGUNDO NOMBRE

                ElseIf papellido <> COracle.ObtenerDatos(consulta, "PRIMER_APELLIDO") Then
                    inconsistente = "S"
                    NombreIgual = "N"
                    Observacion &= "El primer apellido no coincide con el del padrón electoral "
                    'COMPROBANDO EL SEGUNDO NOMBRE

                End If

                'COMPROBANDO INGRESO NULO DE SEGUNDO NOMBRE Y APELLIDO
                Dim SNOMBRE As String = view.GetRowCellValue(i, "SEGUNDO_NOMBRE_PAPELETA").ToString.Trim
                Dim SAPELLIDO As String = view.GetRowCellValue(i, "SEGUNDO_APELLIDO_PAPELETA").ToString.Trim

                If COracle.ObtenerDatos(consulta, "SEGUNDO_NOMBRE") = SNOMBRE Then
                Else
                    inconsistente = "S"
                    NombreIgual = "N"
                    Observacion &= "El segundo nombre no coincide con el del padrón electoral "
                End If

                If COracle.ObtenerDatos(consulta, "SEGUNDO_APELLIDO") = SAPELLIDO Then
                Else
                    inconsistente = "S"
                    NombreIgual = "N"
                    Observacion &= "El segundo apellido no coincide con el del padrón electoral "
                End If
            Else
                inconsistente = "S"
                Observacion = "Identidad no encontrada en el padrón electoral"
                NombreIgual = ""

            End If



        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub




    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MsgBox(GridView1.GetRowCellValue(2, "FIRMA").ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        GridView1.ActiveFilter.Clear()

        
        If ChkMovimientos.CheckState = CheckState.Checked Then

            'Me.CODIGO_PARTIDO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CODIGO_PARTIDO= '" & Me.CmbPartido.EditValue & "'")
            'Me.CODIGO_MOVIMIENTO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CODIGO_MOVIMIENTO= '" & Me.CmbMovimiento.EditValue & "'")

        End If

        If ChkGeografica.CheckState = CheckState.Checked Then
            If ChkDepto.CheckState = CheckState.Checked Then
                Me.colCODIGO_DEPARTAMENTO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(Me.CmbDepartamento.EditValue)

            End If

            If ChkMuni.CheckState = CheckState.Checked Then
                Me.colCODIGO_MUNICIPIO.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(Me.CmbMunicipio.EditValue)

            End If
        End If
       
        If Me.CmbFiltro.SelectedIndex = 0 Then
            ' Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'N' or CONSISTENTE= 'S'")
        ElseIf Me.CmbFiltro.SelectedIndex = 1 Then
            Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'S'")

        ElseIf Me.CmbFiltro.SelectedIndex = 2 Then
            Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'N'")

        End If

    End Sub


    'If Me.CheckEdit1.CheckState = CheckState.Checked Then
    '       Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'N'")
    '   Else
    '       Me.colCONSISTENTE.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CONSISTENTE= 'S'")


    '   End If


    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        Dim view As GridView = TryCast(sender, GridView)
        booleanerror = False
        If view.FocusedColumn.FieldName = "PRIMER_NOMBRE_PAPELETA" Or view.FocusedColumn.FieldName = "PRIMER_APELLIDO_PAPELETA" Or view.FocusedColumn.FieldName = "IDENTIDAD" Then
            e.Valid = e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)

        End If

    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Try

            'Me.Validate()
            'Me.IM_CIUDADANOS_RESPALDAN1BindingSource.EndEdit()
            'Me.IM_CIUDADANOS_RESPALDAN1TableAdapter.Update(DSCiudadanos.IM_CIUDADANOS_RESPALDAN1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReestablecer.Click
        GridView1.ActiveFilter.Clear()
        Me.ChkMovimientos.CheckState = CheckState.Unchecked
        Me.ChkGeografica.CheckState = CheckState.Unchecked
    End Sub

    Private Sub CmbFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFiltro.SelectedIndexChanged

    End Sub

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub ChkMovimientos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMovimientos.CheckedChanged
        If ChkMovimientos.CheckState = CheckState.Checked Then
            Me.CmbPartido.Enabled = True
            Me.CmbMovimiento.Enabled = True
        Else
            Me.CmbPartido.Enabled = False
            Me.CmbMovimiento.Enabled = False
        End If
    End Sub

    Private Sub ChkGeografica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGeografica.CheckedChanged
        If ChkGeografica.CheckState = CheckState.Checked Then
            Me.CmbDepartamento.Enabled = True
            Me.CmbMunicipio.Enabled = True
            Me.ChkDepto.CheckState = CheckState.Unchecked
            Me.ChkMuni.CheckState = CheckState.Unchecked
            Me.ChkDepto.Enabled = True
            Me.ChkMuni.Enabled = True
        Else
            Me.CmbDepartamento.Enabled = False
            Me.CmbMunicipio.Enabled = False
            Me.ChkDepto.CheckState = CheckState.Unchecked
            Me.ChkMuni.CheckState = CheckState.Unchecked
            Me.ChkDepto.Enabled = False
            Me.ChkMuni.Enabled = False
        End If
    End Sub
End Class