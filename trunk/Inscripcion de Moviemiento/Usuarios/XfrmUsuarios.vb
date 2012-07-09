Imports DevExpress.Utils
Imports System.Threading
Imports System.Data.OracleClient

Public Class XfrmUsuarios
    Dim actualizar As Boolean = False
    Private Sub XfrmUsuarios_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        'Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
     End Sub

    Private Sub XfrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.TA_MOVIMIENTO' table. You can move, or remove it, as needed.

        '******************************************
        ActualizarGrid()

        'Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        If RolUsuario = "1" Then
            Me.TA_ROLESTableAdapter.Fill(Me.DTUsers.TA_ROLES)
        ElseIf RolUsuario = "2" Then
            Me.TA_ROLESTableAdapter.FillBy(Me.DTUsers.TA_ROLES)
        ElseIf RolUsuario = "3" Then
            Me.TA_ROLESTableAdapter.FillBy1(Me.DTUsers.TA_ROLES)

        End If


        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)

        PreguntasDeSeguridad()
        niveles()
        Me.IMUSUARIOSBindingSource.AddNew()
        '*******************************************

        ESTADOTextEdit.Checked = False
        If COracle.credenciales("BtnUsuarios", "MODIFICAR") = "N" And COracle.credenciales("BtnUsuarios", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnUsuarios", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnUsuarios", "INSERTAR", Me.BtnNuevo)


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
        tbl.Rows.Add(4, "¿Nombre de mi abuela materna?")
        tbl.Rows.Add(5, "¿Nombre de mi amigo de la infancia?")
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

    Sub niveles()
        Dim tblniveles As New DataTable()
        'SE CREAN LAS COLUMNAS DEL DATA TABLE
        tblniveles.Columns.Add("Id", GetType(Integer))
        tblniveles.Columns.Add("Nivel", GetType(String))
        'SE AGREGAN LAS FILAS CON LA INFORMACION
        Select Case NivelUsuario
            Case 3
                tblniveles.Rows.Add(3, "3")
            Case 2
                tblniveles.Rows.Add(2, "2")
                tblniveles.Rows.Add(3, "3")
            Case 1
                tblniveles.Rows.Add(1, "1")
                tblniveles.Rows.Add(2, "2")
                tblniveles.Rows.Add(3, "3")

        End Select

        'SE ENLAZA EL DATATABLE CREADO PARA MOSTRARLO EN EL CONTROL
        With NIVELSpinEdit
            .Properties.DataSource = tblniveles
            .Properties.ValueMember = "Id"
            .Properties.DisplayMember = "Nivel"
            'SE PREPARA EL CONTROL PARA OCULTAR COLUMNAS
            .Properties.ForceInitialize()
            .Properties.PopulateColumns()
            'SE OCULTA INFORMACION 
            .Properties.Columns(0).Visible = False
            .Properties.Columns(1).Visible = True
        End With



    End Sub
    Sub Nuevo()
        Try
            Me.IMUSUARIOSBindingSource.CancelEdit()
            Me.IMUSUARIOSBindingSource.AddNew()
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Sub guardar()
        If COracle.ObtenerDatos("select * from IM_PADRON_ELECTORAL WHERE NUMERO_IDENTIDAD='" & Me.IDENTIDADTextEdit.Text & "'", "NUMERO_IDENTIDAD") <> "N" Then


            Try
                Me.IMUSUARIOSBindingSource.EndEdit()

                'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
                For Each _datar As DTUsers.IM_USUARIOSRow In DTUsers.IM_USUARIOS
                    'SI ES UN NUEVO REGITRO
                    If _datar.RowState = DataRowState.Added Then
                        _datar.ADICIONADO_POR = usuario
                        _datar.FECHA_ADICION = DateTime.Now
                        'SI EL REGISTRO SE MODIFICA
                    ElseIf _datar.RowState = DataRowState.Modified Then
                        _datar.MODIFICADO_POR = usuario
                        _datar.FECHA_MODIFICACION = DateTime.Now
                    End If
                Next

                'AGREGANDO LA INFORMACION A LA BASE DE DATOS
                Me.IM_USUARIOSTableAdapter.Update(Me.DTUsers.IM_USUARIOS)


                'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
                ActualizarGrid()


                If actualizar = True Then
                    Mensajes.MensajeActualizar()
                    actualizar = False
                Else
                    asignarroles()
                    Mensajes.MensajeGuardar()
                End If
                Me.IMUSUARIOSBindingSource.AddNew()
            Catch ex As Exception
                'CONTROL DE ERRORES
                Mensajes.MensajeError(ex.Message)
            End Try
        Else
            Mensajes.mimensaje("El número de Identidad Ingresado es incorrecto o no existe")
        End If
    End Sub
    Sub MostrarDatos()
        Try
            actualizar = True
            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_USUARIOSTableAdapter.FillBy(Me.DTUsers.IM_USUARIOS, cellValue)

            'OBTENEMOS LA INFORMACION PARA LA BUSQUEDA DE LA IMAGEN

        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()

        Select Case NivelUsuario
            Case 3
                Me.DT_USUARIOSTableAdapter.Nivel3(Me.DTUsers.DT_USUARIOS)
            Case 2
                Me.DT_USUARIOSTableAdapter.Nivel2(Me.DTUsers.DT_USUARIOS)
            Case 1
                Me.DT_USUARIOSTableAdapter.Fill(Me.DTUsers.DT_USUARIOS)

        End Select
    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOSpinEdit.EditValueChanged
        Try
            Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, Me.CODIGO_PARTIDOSpinEdit.EditValue)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnUsuarios", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnUsuarios", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnUsuarios", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnUsuarios", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub


    Private Sub CODIGO_USUARIOSpinEdit_InvalidValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles CODIGO_USUARIOSpinEdit.InvalidValue
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub


    Private Sub IDENTIDADTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IDENTIDADTextEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOSpinEdit.TextChanged
       
    End Sub


    Sub asignarroles()
        Try
            Dim cnx As New OracleConnection(Configuracion.verconfig)

            cnx.Open()
            Dim myCMD As New OracleCommand()
            myCMD.Connection = cnx
            myCMD.CommandText = "IM_P_OPERACIONES_X_USUARIO"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("pni_rol", OracleType.Number, ParameterDirection.Input)).Value = CODIGO_ROLSpinEdit.EditValue
            myCMD.Parameters.Add(New OracleParameter("pvi_usuario", OracleType.NVarChar, 32767, ParameterDirection.Input)).Value = CODIGO_USUARIOSpinEdit.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_usuario_creador", OracleType.NVarChar, 32767, ParameterDirection.Input)).Value = usuario
            myCMD.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()
            If CType(myCMD.Parameters("PVO_MENSAJE").Value, String) = "OK" Then

            Else

            End If
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub CODIGO_USUARIOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_USUARIOSpinEdit.EditValueChanged

    End Sub

    Private Sub CODIGO_USUARIOSpinEdit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_USUARIOSpinEdit.LostFocus
        CODIGO_USUARIOSpinEdit.Text = VControles.SafeSqlLikeClauseLiteral(CODIGO_USUARIOSpinEdit.Text)
    End Sub

    Private Sub CONTRASENATextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTRASENATextEdit.EditValueChanged

    End Sub

    Private Sub CONTRASENATextEdit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CONTRASENATextEdit.LostFocus
        CONTRASENATextEdit.Text = CONTRASENATextEdit.Text.Replace("'", "")
    End Sub
End Class