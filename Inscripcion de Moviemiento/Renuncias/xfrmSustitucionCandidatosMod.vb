
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports System.Data.OracleClient
Public Class xfrmSustitucionCandidatosMod
    Dim mensajeerror As String = ""
    Sub limpiarLabels()
        'LIMPIA LOS LABELES DE INFORMACION EN CASO DE NO ENCONTRAR DATA Y SI ENCUENTRA MUESTRA LA INFORMACION DEL CANDIDATO
        If GridView1.DataRowCount <= 0 Then
            lblidentidad.Text = "--"
            lblnombre.Text = "--"
            MsgBox("Ningún Candidato encontrado")
        Else
            Dim view As GridView = GridView1

            Me.lblnombre.Text = view.GetRowCellValue(view.FocusedRowHandle, "PRIMER_NOMBRE") & " " & view.GetRowCellValue(view.FocusedRowHandle, "SEGUNDO_NOMBRE") & " " & view.GetRowCellValue(view.FocusedRowHandle, "PRIMER_APELLIDO") & " " & view.GetRowCellValue(view.FocusedRowHandle, "SEGUNDO_APELLIDO")
            Me.lblidentidad.Text = Me.btnbusqueda.Text
            'Return

        End If
    End Sub
    Private Sub xfrmSustitucionCandidatosMod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DT_Renuncia.SUSTITUCIONES' table. You can move, or remove it, as needed.
        'Me.SUSTITUCIONESTableAdapter.Fill(Me.DT_Renuncia.SUSTITUCIONES)
        'TODO: This line of code loads data into the 'DT_Renuncia.IM_MOTIVO_SUSTITUCION' table. You can move, or remove it, as needed.
        Me.IM_MOTIVO_SUSTITUCIONTableAdapter.Fill(Me.DT_Renuncia.IM_MOTIVO_SUSTITUCION)
        'TODO: This line of code loads data into the 'DT_Renuncia.RENUNCIAS' table. You can move, or remove it, as needed.
        
        'TODO: This line of code loads data into the 'DT_Renuncia.IM_RENUNCIAS' table. You can move, or remove it, as needed.
        'Me.IM_RENUNCIASTableAdapter.Fill(Me.DT_Renuncia.IM_RENUNCIAS)
        'TODO: This line of code loads data into the 'DT_Renuncia.IM_MOTIVOS_RENUNCIA' table. You can move, or remove it, as needed.
        'Me.IM_MOTIVOS_RENUNCIATableAdapter.FillBy1(Me.DT_Renuncia.IM_MOTIVOS_RENUNCIA)

    End Sub





    Function TotalFilas() As Integer

        Dim view As GridView = GridView1
        Return view.DataRowCount - 1
    End Function


    Sub ValidarFilas()
        Dim contador As Integer = 0
        Dim view As GridView = GridView1
        If view.DataRowCount > 0 Then
            If MsgBox("¿Desea Modificar la información?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


                Try
                    For i = 0 To TotalFilas()

                        'MsgBox(view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO").ToString)
                        If view.GetRowCellValue(i, "REESTABLECER").ToString = "S" Then
                            contador += 1
                            Restablecer(i)
                        Else
                            GuardarEnBase(i)
                        End If

                        'If view.GetRowCellValue(i, "REESTABLECER").ToString = "S" Then
                        'contador += 1


                        'End If

                    Next

                    Me.SUSTITUCIONESTableAdapter.FillBy(Me.DT_Renuncia.SUSTITUCIONES, Me.btnbusqueda.Text)
                    limpiarLabels()
                    Mensajes.MensajeActualizar()
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

        'If view.GetRowCellValue(view.FocusedRowHandle, "RENUNCIA").ToString = "S" And IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "MOTIVO")) Then
        '    mensajeerror = "Seleccione el motivo de la renuncia"
        '    e.Valid = False

        'End If
        'End If
    End Sub



    Private Sub btnbusqueda_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnbusqueda.ButtonClick
        Me.SUSTITUCIONESTableAdapter.FillBy(Me.DT_Renuncia.SUSTITUCIONES, Me.btnbusqueda.Text)
        limpiarLabels()
    End Sub


    Private Sub btnbusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnbusqueda.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.btnbusqueda.Text = ""

        End If

        If (e.KeyCode = Keys.Enter) Then
            Me.SUSTITUCIONESTableAdapter.FillBy(Me.DT_Renuncia.SUSTITUCIONES, Me.btnbusqueda.Text)
            limpiarLabels()
        End If
    End Sub


    Sub GuardarEnBase(ByVal i As Integer)
        Try
            '  Dim campos1 As String = "CODIGO_CANDIDATOS, POSICION, CODIGO_CARGO_ELECTIVO, " _
            '& "CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, CODIGO_MOVIMIENTO, IDENTIDAD, CODIGO_PARTIDO, " _
            ' & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, Primer_Nombre," _
            ' & "Segundo_Nombre,PRIMER_APELLIDO, SEGUNDO_APELLIDO"

            '  Dim campos As String = "CODIGO_CANDIDATO, POSICION, CODIGO_CARGO_ELECTIVO, " _
            ' & "CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, CODIGO_MOVIMIENTO, IDENTIDAD, CODIGO_PARTIDO, " _
            '  & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, Primer_Nombre," _
            '  & "Segundo_Nombre,PRIMER_APELLIDO, SEGUNDO_APELLIDO"


            '  '***REESTABLECIENDO CANDIDATO AL MOVIMIENTO
            '  Dim BKcandidatos As String = "insert into im_candidatos (" & campos1 & ") select " & campos & " from im_renuncias WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            '  COracle.ejecutarconsulta(BKcandidatos)

            '  '***ACTUALIZAR INSERT DEL INSERT ANTERIOR AGREGADO POR Y FECHA
            '  Dim candidatosUPD As String = "update  im_candidatos set adicionado_por='" & usuario & "' , fecha_adicion=to_date('" & DateTime.Now.Date & "','dd/mm/yyyy') WHERE CODIGO_CANDIDATOS=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            '  COracle.ejecutarconsulta(candidatosUPD)

            '  '***REESTABLECIENDO REQUISITOS DEL CANDIDATO 
            '  Dim BKrequisitos As String = "insert into IM_REQUISITOS_X_CANDIDATO select * from im_requisitos_renuncia WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            '  COracle.ejecutarconsulta(BKrequisitos)

            '  '***ACTUALIZAR INSERT DEL INSERT ANTERIOR AGREGADO POR Y FECHA


            '  'BORRAR REGISTROS DE BACKUP DE REQUISITOS
            '  Dim requisitos As String = "DELETE im_requisitos_renuncia WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            '  COracle.ejecutarconsulta(requisitos)

            '  'BORRAR REGISTROS DE RENUNCIAS
            '  Dim sql As String = "DELETE im_renuncias WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            '  COracle.ejecutarconsulta(sql)



            Dim cnx As New OracleConnection(Configuracion.verconfig)

            'Data.ConvertImageToByteArray(Me.Imgimagen.EditValue)

            Dim sqlstring As String
            sqlstring = "update im_sustituciones set codigo_motivo= :mtv, imagen= :ft, modificado_por= :md, fecha_modificacion= :fm where CODIGO_PARTIDO= :idp and CODIGO_MOVIMIENTO= :idmov and CODIGO_CANDIDATO= :cc"

            Dim cmd As New OracleCommand(sqlstring, cnx)
            cmd.Parameters.Add(":mtv", OracleType.Number).Value = GridView1.GetRowCellValue(i, "CODIGO_MOTIVO").ToString
            If IsDBNull(GridView1.GetRowCellValue(i, "IMAGEN")) Then
                cmd.Parameters.Add(":ft", OracleType.Blob).Value = DBNull.Value
            Else
                cmd.Parameters.Add(":ft", OracleType.Blob).Value = GridView1.GetRowCellValue(i, "IMAGEN")
            End If
            cmd.Parameters.Add(":md", OracleType.VarChar).Value = usuario
            cmd.Parameters.Add(":fm", OracleType.DateTime).Value = DateTime.Now.Date
            cmd.Parameters.Add(":idp", OracleType.Number).Value = GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString
            cmd.Parameters.Add(":idmov", OracleType.Number).Value = GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
            cmd.Parameters.Add(":cc", OracleType.Number).Value = GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString

            cnx.Close()
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
        

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        ValidarFilas()
    End Sub


    Private Sub PanelControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub btnbusqueda_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusqueda.EditValueChanged

    End Sub
    Sub Restablecer(ByVal i As Integer)
        Try

            Dim sqlvalida As String
            sqlvalida = "select * from im_candidatos" _
        & "where codigo_partido='" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & "' " _
        & "and codigo_movimiento='" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString & "' " _
        & "and codigo_departamento='" & GridView1.GetRowCellValue(i, "CODIGO_DEPARTAMENTO").ToString & "' " _
        & "and codigo_municipio='" & GridView1.GetRowCellValue(i, "CODIGO_MUNICIPIO").ToString & "' " _
        & "and codigo_cargo_electivo='" & GridView1.GetRowCellValue(i, "CODIGO_CARGO_ELECTIVO").ToString & "' " _
        & "and posicion='" & GridView1.GetRowCellValue(i, "POSICION").ToString & "' " _
        & "and identidad='" & GridView1.GetRowCellValue(i, "IDENTIDAD").ToString & "' "


            If COracle.ObtenerDatos(sqlvalida, "identidad") <> "N" Then


                Dim campos1 As String = "CODIGO_CANDIDATOS, POSICION, CODIGO_CARGO_ELECTIVO, " _
              & "CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, CODIGO_MOVIMIENTO, IDENTIDAD, CODIGO_PARTIDO, " _
               & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, Primer_Nombre," _
               & "Segundo_Nombre,PRIMER_APELLIDO, SEGUNDO_APELLIDO"

                Dim campos As String = "CODIGO_CANDIDATO, POSICION, CODIGO_CARGO_ELECTIVO, " _
               & "CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, CODIGO_MOVIMIENTO, IDENTIDAD, CODIGO_PARTIDO, " _
                & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, Primer_Nombre," _
                & "Segundo_Nombre,PRIMER_APELLIDO, SEGUNDO_APELLIDO"


                '***REESTABLECIENDO CANDIDATO AL MOVIMIENTO
                Dim BKcandidatos As String = "insert into im_candidatos (" & campos1 & ") select " & campos & " from im_renuncias WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
                COracle.ejecutarconsulta(BKcandidatos)

                '***ACTUALIZAR INSERT DEL INSERT ANTERIOR AGREGADO POR Y FECHA
                Dim candidatosUPD As String = "update  im_candidatos set adicionado_por='" & usuario & "' , fecha_adicion=to_date('" & DateTime.Now.Date & "','dd/mm/yyyy') WHERE CODIGO_CANDIDATOS=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
                COracle.ejecutarconsulta(candidatosUPD)

                '***REESTABLECIENDO REQUISITOS DEL CANDIDATO 
                Dim BKrequisitos As String = "insert into IM_REQUISITOS_X_CANDIDATO select * from im_requisitos_renuncia WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
                COracle.ejecutarconsulta(BKrequisitos)

                '***ACTUALIZAR INSERT DEL INSERT ANTERIOR AGREGADO POR Y FECHA


                'BORRAR REGISTROS DE BACKUP DE REQUISITOS
                Dim requisitos As String = "DELETE im_requisitos_renuncia WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
                COracle.ejecutarconsulta(requisitos)

                'BORRAR REGISTROS DE RENUNCIAS
                Dim sql As String = "DELETE im_sustituciones WHERE CODIGO_CANDIDATO=" & GridView1.GetRowCellValue(i, "CODIGO_CANDIDATO").ToString & " AND CODIGO_PARTIDO=" & GridView1.GetRowCellValue(i, "CODIGO_PARTIDO").ToString & " AND CODIGO_MOVIMIENTO=" & GridView1.GetRowCellValue(i, "CODIGO_MOVIMIENTO").ToString
                COracle.ejecutarconsulta(sql)
            Else
                Dim mensaje As String
                mensaje = "No se puede revertir este candidato por que ya existe alguien ocupando el puesto con la siguiente información: "
                mensaje &= vbCrLf & "Cargo: " & GridView1.GetRowCellValue(i, "CARGO")
                mensaje &= vbCrLf & "Partido: " & GridView1.GetRowCellValue(i, "PARTIDO")
                mensaje &= vbCrLf & "Movimiento: " & GridView1.GetRowCellValue(i, "NOMBRE_MOVIMIENTO")
                mensaje &= vbCrLf & "Departamento: " & GridView1.GetRowCellValue(i, "DEPARTAMENTO")
                mensaje &= vbCrLf & "Municipio: " & GridView1.GetRowCellValue(i, "MUNICIPIO")
                mensaje &= vbCrLf
                MsgBox(mensaje & vbCrLf & "Elimine manualmente al candidato en esta posición para poder realizar los cambios", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class