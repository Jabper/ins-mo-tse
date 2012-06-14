Imports System.Data.OracleClient
Imports DevExpress.XtraEditors

Public Class XfrmRoles
    Dim actualizar As Boolean = False
    Private Sub XfrmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTUsers.IM_OPCIONES' table. You can move, or remove it, as needed.
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        ActualizarGrid()
        'TODO: This line of code loads data into the 'DTUsers.IM_ROLES' table. You can move, or remove it, as needed.
        Me.IM_ROLESTableAdapter.Fill(Me.DTUsers.IM_ROLES)
        Me.IMROLESBindingSource.AddNew()

        If COracle.credenciales("BtnRoles", "MODIFICAR") = "N" And COracle.credenciales("BtnRoles", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnRoles", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnRoles", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnRoles", "ELIMINAR", Me.BtnEliminar)
       

    End Sub



    Sub nuevo()
        Try
            Me.IMROLESBindingSource.CancelEdit()
            Me.IMROLESBindingSource.AddNew()
            actualizar = False
            Me.BtnEliminar.Enabled = False
        Catch ex As Exception

        End Try

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

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarGrid()

            'Edicion
            BtnEliminar.Enabled = False
            If actualizar = True Then
                Mensajes.MensajeActualizar()
                actualizar = False
            Else
                Mensajes.MensajeGuardar()
            End If
            Me.IMROLESBindingSource.AddNew()
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

            actualizar = True
            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub


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


    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub



    Private Sub CODIGO_ROLSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_ROLSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub



    Private Sub DESCRIPCIONTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DESCRIPCIONTextEdit.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            DESCRIPCIONTextEdit.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnRoles", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnRoles", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnRoles", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnRoles", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub


    Sub eliminar()


        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
                Dim Drow As DTUsers.IM_ROLESRow
                Drow = Me.DTUsers.IM_ROLES.FindByCODIGO_ROL(CType(cellValue, Integer))

                Drow.Delete()

                Me.IM_ROLESTableAdapter.Update(Me.DTUsers.IM_ROLES)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMROLESBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try

        End If
    End Sub

    Private Sub DESCRIPCIONTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DESCRIPCIONTextEdit.EditValueChanged

    End Sub
End Class