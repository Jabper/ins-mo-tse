
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports System.Data.OracleClient
Public Class xfrmSustituciondeCandidatos
    Dim mensajeerror As String = ""
    Sub limpiarLabels()
        'LIMPIA LOS LABELES DE INFORMACION EN CASO DE NO ENCONTRAR DATA Y SI ENCUENTRA MUESTRA LA INFORMACION DEL CANDIDATO
        If GridView1.DataRowCount <= 0 Then
            lblidentidad.Text = "--"
            lblnombre.Text = "--"
            MsgBox("Ningún Candidato encontrado")
        Else
            Dim view As GridView = GridView1

            Me.lblnombre.Text = view.GetRowCellValue(view.FocusedRowHandle, "NOMBRE") & " " & view.GetRowCellValue(view.FocusedRowHandle, "APELLIDO")
            Me.lblidentidad.Text = Me.btnbusqueda.Text
            'Return

        End If
    End Sub
    Private Sub xfrmSustituciondeCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DT_Renuncia.IM_MOTIVO_SUSTITUCION' table. You can move, or remove it, as needed.
        Me.IM_MOTIVO_SUSTITUCIONTableAdapter.Fill(Me.DT_Renuncia.IM_MOTIVO_SUSTITUCION)
        'TODO: This line of code loads data into the 'DT_Renuncia.IM_SUSTITUCIONES' table. You can move, or remove it, as needed.
        'Me.IM_SUSTITUCIONESTableAdapter.Fill(Me.DT_Renuncia.IM_SUSTITUCIONES)
        'TODO: This line of code loads data into the 'DT_Renuncia.IM_RENUNCIAS' table. You can move, or remove it, as needed.
        'Me.IM_RENUNCIASTableAdapter.Fill(Me.DT_Renuncia.IM_RENUNCIAS)
        'TODO: This line of code loads data into the 'DT_Renuncia.IM_MOTIVOS_RENUNCIA' table. You can move, or remove it, as needed.
        'Me.IM_MOTIVOS_RENUNCIATableAdapter.Fill(Me.DT_Renuncia.IM_MOTIVOS_RENUNCIA)

    End Sub





    Function TotalFilas() As Integer

        Dim view As GridView = GridView1
        Return view.DataRowCount - 1
    End Function


    Sub ValidarFilas()
        Dim contador As Integer = 0
        Dim view As GridView = GridView1
        If view.DataRowCount > 0 Then
            If MsgBox("¿Desea aplicar los cambios a los registros seleccionados? una vez iniciado el proceso, NO podrá cancelar las operaciones" & vbCrLf & "Este proceso borrará al candidato de las planillas seleccionadas y realizará la operación solicitada", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


                Try
                    For i = 0 To TotalFilas()

                        'MsgBox(view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO").ToString)

                        ''GUARDAR RENUNCIAS
                        'If view.GetRowCellValue(i, "RENUNCIA").ToString = "S" And Not view.GetRowCellValue(i, "MOTIVO").Equals(String.Empty) Then
                        '    contador += 1
                        '    GuardarEnBase(i)

                        'End If

                        'GUARDAR SUSTITUCIONES
                        If view.GetRowCellValue(i, "Sustituido").ToString = "S" And Not view.GetRowCellValue(i, "MOTIVO").Equals(String.Empty) Then
                            contador += 1
                            GuardarSustitucion(i)

                        End If


                    Next

                    Me.IM_V_CANDIDATO_RENUNCIATableAdapter.Fill(Me.DT_Renuncia.IM_V_CANDIDATO_RENUNCIA, Me.btnbusqueda.Text)
                    limpiarLabels()
                    Mensajes.MensajeGuardar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            MsgBox("No existe ningun registro que actualizar")
        End If
    End Sub
    Function Cheked(ByVal contador As Integer)
        If (contador - 1) = (TotalFilas() - 1) Then

        Else

            'Mensajes.mimensaje("Debe Seleccionar ")
        End If
    End Function

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'Dim view As GridView = GridView1

        'If view.GetRowCellValue(view.FocusedRowHandle, "RENUNCIA").ToString = "N" Then


        '    view.SetRowCellValue(view.FocusedRowHandle, "MOTIVO", RepositoryItemLookUpEdit1.NullText = "Seleccione")
        'End If

    End Sub

    

    Private Sub GridView1_ColumnChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.ColumnChanged
       
    End Sub

    Private Sub GridView1_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
        e.ExceptionMode = ExceptionMode.DisplayError
        e.WindowCaption = "Error"
        e.ErrorText = mensajeerror
        GridView1.HideEditor()
    End Sub

    Private Sub GridView1_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
     
    End Sub



    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim view As GridView = TryCast(sender, GridView)

        'If view.FocusedColumn.FieldName = "RENUNCIA" Then

        If view.GetRowCellValue(view.FocusedRowHandle, "Sustituido").ToString = "S" And IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO")) Then
            mensajeerror = "Seleccione el motivo de la sustitución"
            e.Valid = False

        End If

        'If view.GetRowCellValue(view.FocusedRowHandle, "RENUNCIA").ToString = "S" And view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO").ToString = "99" Then
        '    mensajeerror = "Motivo no válido para la renuncia"
        '    e.Valid = False

        'End If

        'If view.GetRowCellValue(view.FocusedRowHandle, "RENUNCIA").ToString = "S" And view.GetRowCellValue(view.FocusedRowHandle, "Sustituido").ToString = "S" Then
        '    mensajeerror = "Solo puede seleccionar una opción"
        '    e.Valid = False

        'End If

        'If view.GetRowCellValue(view.FocusedRowHandle, "Sustituido").ToString = "S" And view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO").ToString <> "99" Then
        '    mensajeerror = "Motivo no válido para la sustitución"
        '    e.Valid = False

        'End If

        'End If
    End Sub



    Private Sub btnbusqueda_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnbusqueda.ButtonClick
        Me.IM_V_CANDIDATO_RENUNCIATableAdapter.Fill(Me.DT_Renuncia.IM_V_CANDIDATO_RENUNCIA, Me.btnbusqueda.Text)
        limpiarLabels()

    End Sub


    Private Sub btnbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnbusqueda.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.btnbusqueda.Text = ""

        End If

        If (e.KeyCode = Keys.Enter) Then
            Me.IM_V_CANDIDATO_RENUNCIATableAdapter.Fill(Me.DT_Renuncia.IM_V_CANDIDATO_RENUNCIA, Me.btnbusqueda.Text)
            limpiarLabels()
        End If
    End Sub


    Sub GuardarEnBase(ByVal i As Integer)
        Try


            Dim ciudadanos As DT_Renuncia.IM_RENUNCIASRow
            ciudadanos = DT_Renuncia.IM_RENUNCIAS.NewIM_RENUNCIASRow
            With ciudadanos
                .CODIGO_CANDIDATO = GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString
                .CODIGO_PARTIDO = GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString
                .CODIGO_MOVIMIENTO = GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
                .POSICION = GridView1.GetRowCellValue(i, "POSICION").ToString
                .CODIGO_CARGO_ELECTIVO = GridView1.GetRowCellValue(i, "CODIGO_CARGO_ELECTIVO").ToString
                .CODIGO_DEPARTAMENTO = GridView1.GetRowCellValue(i, "CODIGO_DEPARTAMENTO").ToString
                .CODIGO_MUNICIPIO = GridView1.GetRowCellValue(i, "CODIGO_MUNICIPIO").ToString
                .IDENTIDAD = GridView1.GetRowCellValue(i, "IDENTIDAD").ToString
                .CODIGO_MOTIVO = GridView1.GetRowCellValue(i, "MOTIVO").ToString
                .ADICIONADO_POR = usuario
                .FECHA_ADICION = DateTime.Now
                '--------------------------
                Dim consulta As String = "select primer_nombre,segundo_nombre,primer_apellido,segundo_apellido from  im_candidatos where identidad='" & GridView1.GetRowCellValue(i, "IDENTIDAD").ToString & "'"
                .PRIMER_NOMBRE = COracle.ObtenerDatos(consulta, "PRIMER_NOMBRE")
                .SEGUNDO_NOMBRE = COracle.ObtenerDatos(consulta, "SEGUNDO_NOMBRE")
                .PRIMER_APELLIDO = COracle.ObtenerDatos(consulta, "PRIMER_APELLIDO")
                .SEGUNDO_APELLIDO = COracle.ObtenerDatos(consulta, "SEGUNDO_APELLIDO")
                If IsDBNull(GridView1.GetRowCellValue(i, "Imagen_firma")) Then

                Else
                    .IMAGEN_RENUNCIA = GridView1.GetRowCellValue(i, "Imagen_firma")
                End If

            End With
            Me.DT_Renuncia.IM_RENUNCIAS.Rows.Add(ciudadanos)

            Me.IM_RENUNCIASTableAdapter.Update(Me.DT_Renuncia.IM_RENUNCIAS)
            'CREANDO RESPALDO DE REQUITOS
            Dim BKrequisitos As String = "insert into im_requisitos_renuncia select * from im_requisitos_x_candidato WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            COracle.ejecutarconsulta(BKrequisitos)

            'ELIMINANDO REQUITOS DE LA TABLA PRINCIPAL
            Dim requisitos As String = "DELETE IM_REQUISITOS_X_CANDIDATO WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            COracle.ejecutarconsulta(requisitos)

            'ELIMINANDO CANDIDATO DE LA TABLA PRINCIPAL
            Dim sql As String = "DELETE IM_CANDIDATOS WHERE CODIGO_CANDIDATOS=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            COracle.ejecutarconsulta(sql)
           


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub GuardarSustitucion(ByVal i As Integer)
        Try


            Dim ciudadanos As DT_Renuncia.IM_SUSTITUCIONESRow
            ciudadanos = DT_Renuncia.IM_SUSTITUCIONES.NewIM_SUSTITUCIONESRow
            With ciudadanos
                .CODIGO_CANDIDATO = GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString
                .CODIGO_PARTIDO = GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString
                .CODIGO_MOVIMIENTO = GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
                .POSICION = GridView1.GetRowCellValue(i, "POSICION").ToString
                .CODIGO_CARGO_ELECTIVO = GridView1.GetRowCellValue(i, "CODIGO_CARGO_ELECTIVO").ToString
                .CODIGO_DEPARTAMENTO = GridView1.GetRowCellValue(i, "CODIGO_DEPARTAMENTO").ToString
                .CODIGO_MUNICIPIO = GridView1.GetRowCellValue(i, "CODIGO_MUNICIPIO").ToString
                .IDENTIDAD = GridView1.GetRowCellValue(i, "IDENTIDAD").ToString
                .CODIGO_MOTIVO = GridView1.GetRowCellValue(i, "MOTIVO").ToString
                .ADICIONADO_POR = usuario
                .FECHA_ADICION = DateTime.Now
                '--------------------------
                Dim consulta As String = "select primer_nombre,segundo_nombre,primer_apellido,segundo_apellido from  im_candidatos where identidad='" & GridView1.GetRowCellValue(i, "IDENTIDAD").ToString & "'"

                .PRIMER_NOMBRE = COracle.ObtenerDatos(consulta, "PRIMER_NOMBRE")
                .SEGUNDO_NOMBRE = COracle.ObtenerDatos(consulta, "SEGUNDO_NOMBRE")
                .PRIMER_APELLIDO = COracle.ObtenerDatos(consulta, "PRIMER_APELLIDO")
                .SEGUNDO_APELLIDO = COracle.ObtenerDatos(consulta, "SEGUNDO_APELLIDO")
                If IsDBNull(GridView1.GetRowCellValue(i, "Imagen_firma")) Then

                Else
                    .IMAGEN = GridView1.GetRowCellValue(i, "Imagen_firma")
                End If

            End With
            Me.DT_Renuncia.IM_SUSTITUCIONES.Rows.Add(ciudadanos)

            Me.IM_SUSTITUCIONESTableAdapter.Update(Me.DT_Renuncia.IM_SUSTITUCIONES)

            'CREANDO RESPALDO DE REQUITOS
            Dim BKrequisitos As String = "insert into im_requisitos_renuncia select * from im_requisitos_x_candidato WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            COracle.ejecutarconsulta(BKrequisitos)

            'ELIMINANDO REQUITOS DE LA TABLA PRINCIPAL
            Dim requisitos As String = "DELETE IM_REQUISITOS_X_CANDIDATO WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            COracle.ejecutarconsulta(requisitos)

            'ELIMINANDO CANDIDATO DE LA TABLA PRINCIPAL
            Dim sql As String = "DELETE IM_CANDIDATOS WHERE CODIGO_CANDIDATOS=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            COracle.ejecutarconsulta(sql)

            mostrarpantalla(i)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub mostrarpantalla(ByVal i As Integer)
        Dim mensaje As String
        mensaje = "A continuación Ingrese la Información de la persona que sustituirá al candidato con esta información:"
        mensaje &= vbCrLf & "Cargo: " & GridView1.GetRowCellValue(i, "CARGO")
        mensaje &= vbCrLf & "Partido: " & GridView1.GetRowCellValue(i, "PARTIDO")
        mensaje &= vbCrLf & "Movimiento: " & GridView1.GetRowCellValue(i, "NOMBRE_MOVIMIENTO")
        mensaje &= vbCrLf & "Departamento: " & GridView1.GetRowCellValue(i, "DEPARTAMENTO")
        mensaje &= vbCrLf & "Municipio: " & GridView1.GetRowCellValue(i, "MUNICIPIO")

        MsgBox(mensaje, MsgBoxStyle.Information)
        Dim Candidatos As xfrmRegCandidatos2 = New xfrmRegCandidatos2

        With Candidatos

            Dim cons As String = String.Format("SELECT NOMBRE FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO = {0}", GridView1.GetRowCellValue(i, "CODIGO_PARTIDO"))
            Dim con As String = String.Format("SELECT NOMBRE_MOVIMIENTO FROM IM_MOVIMIENTOS WHERE CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1}", GridView1.GetRowCellValue(i, "CODIGO_PARTIDO"), GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO"))

            .lblMovimiento.Text = COracle.ObtenerDatos(con, "NOMBRE_MOVIMIENTO")
            .lblPartido.Text = COracle.ObtenerDatos(cons, "NOMBRE")
            .lblidpartido.Text = GridView1.GetRowCellValue(i, "CODIGO_PARTIDO")
            .lblidmovimiento.Text = GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO")
            .IdentidadDelCandidato = GridView1.GetRowCellValue(i, "IDENTIDAD")
            .mostrarimg()
            .CodigoDelCandidato = GridView1.GetRowCellValue(i, "CODIGO_CANDIDATOS")
            .Establecer(GridView1.GetRowCellValue(i, "CODIGO_DEPARTAMENTO"), GridView1.GetRowCellValue(i, "CODIGO_MUNICIPIO"), GridView1.GetRowCellValue(i, "CODIGO_CARGO_ELECTIVO"), GridView1.GetRowCellValue(i, "POSICION"))
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Candidatos.ShowDialog(Me)
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        ValidarFilas()
    End Sub


    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        'Dim view As GridView = TryCast(sender, GridView)
        'If view.FocusedColumn.FieldName = "Sustituido" Then
        '    If e.Value.ToString = "S" Then
        '        view.SetRowCellValue(view.FocusedRowHandle, "RENUNCIA", "N")
        '        view.SetRowCellValue(view.FocusedRowHandle, "MOTIVO", 99)
        '    End If

        '    If e.Value.ToString = "N" Then

        '        view.SetRowCellValue(view.FocusedRowHandle, "MOTIVO", 0)
        '    End If
        'End If

        'If view.FocusedColumn.FieldName = "RENUNCIA" Then
        '    If e.Value.ToString = "S" Then
        '        view.SetRowCellValue(view.FocusedRowHandle, "Sustituido", "N")
        '        'view.SetRowCellValue(view.FocusedRowHandle, "MOTIVO", 0)
        '    End If

        '    If e.Value.ToString = "N" Then

        '        view.SetRowCellValue(view.FocusedRowHandle, "MOTIVO", 0)
        '    End If
        'End If

    End Sub
End Class