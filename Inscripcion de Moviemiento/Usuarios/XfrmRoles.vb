Imports System.Data.OracleClient
Public Class XfrmRoles

    Private Sub XfrmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTUsers.IM_OPCIONES' table. You can move, or remove it, as needed.
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        ActualizarGrid()
        'TODO: This line of code loads data into the 'DTUsers.IM_ROLES' table. You can move, or remove it, as needed.
        Me.IM_ROLESTableAdapter.Fill(Me.DTUsers.IM_ROLES)
        Me.IMROLESBindingSource.AddNew()
    End Sub



    Sub nuevo()
        Me.IMROLESBindingSource.CancelEdit()
        Me.IMROLESBindingSource.AddNew()
    End Sub

    Sub guardar()
        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMROLESBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DTUsers.IM_ROLESRow In DTUsers.IM_ROLES
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
            Me.IM_ROLESTableAdapter.Update(Me.DTUsers.IM_ROLES)
            'GuardarOpciones(CType(Me.CODIGO_ROLSpinEdit.EditValue, Integer))
            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarGrid()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub

    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DTUsers.TA_ROLES' table. You can move, or remove it, as needed.
        Me.TA_ROLESTableAdapter.Fill(Me.DTUsers.TA_ROLES)
    End Sub


    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_ROLESTableAdapter.FillBy(DTUsers.IM_ROLES, CType(cellValue, Integer))
            'MostarOpciones(CType(cellValue, Integer))


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    'Sub MostarOpciones(ByVal codigoRol As Integer)
    '    Dim i As Integer = 0
    '    'COMPROBAR TODOS LOS ITEMS
    '    Do While Not Me.CheckedListBoxControl1.GetItem(i) Is Nothing
    '        'CONEXION A LA BASE DE DATOS
    '        Dim oradb As String = Configuracion.verconfig
    '        Dim conn As New OracleConnection()
    '        conn.ConnectionString = oradb
    '        conn.Open()

    '        Dim sql As String = "SELECT CODIGO_OPCION, CODIGO_ROL "
    '        sql &= "FROM IM_OPERACIONES_POR_ROL "
    '        sql &= "WHERE CODIGO_ROL =" & codigoRol
    '        sql &= " AND CODIGO_OPCION=" & CType(Me.CheckedListBoxControl1.GetItemValue(i), Integer)

    '        Dim cmd As New OracleCommand(sql, conn)
    '        Dim chek As OracleDataReader = cmd.ExecuteReader
    '        'RECORRIENDO TODOS LOS DATOS PARA MOTRAR LOS DATOS
    '        While chek.Read
    '            'If chek.Read Then
    '            'SI EXISTE LO CHEKEA
    '            CheckedListBoxControl1.SetItemCheckState(i, (CheckState.Checked))
    '            'Else
    '            'SI NO EXISTE LO DESMARCA
    '            'CheckedListBoxControl1.SetItemCheckState(i, (CheckState.Unchecked))

    '            'End If
    '        End While

    '        i += 1
    '        conn.Close()
    '    Loop
    'End Sub

    Public Function comprobarbase(ByVal CodigoRol As Integer, ByVal CodigoOpcion As Integer) As Boolean
        Try
            'CONEXION A LA BASE DE DATOS
            Dim oradb As String = Configuracion.verconfig
            Dim conn As New OracleConnection()
            conn.ConnectionString = oradb
            conn.Open()

            'CONSULTA
            Dim sql As String = "SELECT CODIGO_OPCION, CODIGO_ROL "
            sql &= "FROM IM_OPERACIONES_POR_ROL "
            sql &= "WHERE CODIGO_ROL =" & CodigoRol
            sql &= " and CODIGO_OPCION=" & CodigoOpcion


            Dim cmd As New OracleCommand(sql, conn)
            Dim chek As OracleDataReader = cmd.ExecuteReader
            If chek.Read Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
    'Sub GuardarOpciones(ByVal codigoRol As Integer)
    '    Dim i As Integer = 0
    '    'COMPROBAR TODOS LOS ITEMS
    '    Do While Not Me.CheckedListBoxControl1.GetItem(i) Is Nothing
    '        'SI UN ITEM ESTA CHECADO
    '        If Me.CheckedListBoxControl1.GetItemCheckState(i) = CheckState.Checked Then
    '            'COMPROBAMOS SI EXISTE EN LA BASE
    '            If comprobarbase(codigoRol, CType(Me.CheckedListBoxControl1.GetItemValue(i).ToString, Integer)) = False Then
    '                'agregue
    '                Dim fecha As String = DateTime.Now.Day.ToString & "/" & DateTime.Now.Month.ToString & "/" & DateTime.Now.Year.ToString
    '                Dim sql As String = "INSERT INTO IM_OPERACIONES_POR_ROL (CODIGO_OPCION,CODIGO_ROL,ADICIONADO_POR,FECHA_ADICION) "
    '                sql &= "VALUES("
    '                sql &= CType(Me.CheckedListBoxControl1.GetItemValue(i), Integer) & ","
    '                sql &= codigoRol & ",'" & usuario & "'," & "TO_DATE('" & fecha & "', 'DD/MM/YYYY'))"
    '                COracle.ejecutarconsulta(sql)
    '            End If

    '        ElseIf Me.CheckedListBoxControl1.GetItemCheckState(i) = CheckState.Unchecked Then
    '            If comprobarbase(codigoRol, CType(Me.CheckedListBoxControl1.GetItemValue(i).ToString, Integer)) = True Then
    '                Dim sql As String = "DELETE  FROM IM_OPERACIONES_POR_ROL"
    '                sql &= " WHERE CODIGO_OPCION=" & CType(Me.CheckedListBoxControl1.GetItemValue(i), Integer)
    '                sql &= " AND CODIGO_ROL=" & codigoRol & ";"

    '                COracle.ejecutarconsulta(sql)
    '            End If

    '        End If



    '        i += 1
    '    Loop



    'Me.CheckedListBoxControl1.GetItemValue(i)

    'If Me.CheckedListBoxControl1.GetItemCheckState(i) = CheckState.Unchecked Then
    '    MsgBox(Me.CheckedListBoxControl1.GetItemValue(i).ToString)
    'End If


    'Try
    'For i = 1 To Me.CheckedListBoxControl1.Items.Count
    '    If Me.CheckedListBoxControl1.Items(i).CheckState = CheckState.Checked Then
    '        MsgBox(Me.CheckedListBoxControl1.Items(i).Value.ToString)
    '        'Dim foundRows() As DTUsers.IM_OPERACIONES_POR_ROLRow
    '        'foundRows = DTUsers.Tables("IM_OPERACIONES_POR_ROL").Select("CODIGO_OPCION=" & Me.CheckedListBoxControl1.Items(i).Value 


    '    End If
    'Next

    'OBTIENE EL VALOR DE TODOS LOS ELEMENTOS SELECCIONADOS
    'For Each _view As DataRowView In CheckedListBoxControl1.CheckedItems

    '    MsgBox(_view(CheckedListBoxControl1.ValueMember).ToString())

    'Next

    'OBTIENE EL VALOR DE TODOS LOS ELEMENTOS DESELECCIONADOS

    'Dim i As Integer = 0
    'Do While Not Me.CheckedListBoxControl1.GetItem(i) Is Nothing

    '    If Me.CheckedListBoxControl1.GetItemCheckState(i) = CheckState.Unchecked Then
    '        MsgBox(Me.CheckedListBoxControl1.GetItemValue(i).ToString)
    '    End If

    'If True.Equals(CheckedListBoxControl1.GetItemValue(i)) Then
    '    CheckedListBoxControl1.SetItemCheckState(i, (CheckState.Unchecked))
    'Else
    '    CheckedListBoxControl1.SetItemCheckState(i, (CheckState.Checked))
    'End If
    '    i += 1
    '    Loop
    'Catch ex As Exception
    '    MsgBox(ex.Message)
    'End Try





    'Dim opcion As Integer
    'Dim rol As Integer
    'For Each _datar As DTUsers.IM_OPERACIONES_POR_ROLRow In DTUsers.IM_OPERACIONES_POR_ROL

    '    If _datar.CODIGO_OPCION = opcion And _datar.CODIGO_ROL = rol Then


    '    End If
    'Next



    'End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

   


    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub CODIGO_ROLSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_ROLSpinEdit.EditValueChanged

    End Sub

    Private Sub CODIGO_ROLSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_ROLSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub
End Class