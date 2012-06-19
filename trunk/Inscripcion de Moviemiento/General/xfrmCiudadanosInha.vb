Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class xfrmCiudadanosInha
    Dim actualizar As Boolean = False
    Dim id As String
    Dim nid As String
    Dim cellValue2 As Integer


    Private Sub xfrmCiudadanosInha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_CIUDADANOS_INH.IM_MOTIVOS_INHABILITACION' table. You can move, or remove it, as needed.
        Me.IM_MOTIVOS_INHABILITACIONTableAdapter.Fill(Me.DS_CIUDADANOS_INH.IM_MOTIVOS_INHABILITACION)
        'TODO: This line of code loads data into the 'DS_CIUDADANOS_INH.TA_CIUDADANOS_INHABILITADOS' table. You can move, or remove it, as needed.
        Me.TA_CIUDADANOS_INHABILITADOSTableAdapter.Fill(Me.DS_CIUDADANOS_INH.TA_CIUDADANOS_INHABILITADOS)

        ActualizarGrid()
        ''Me.IMCIUDADANOSINHABILITADOSBindingSource.AddNew()

        If COracle.credenciales("BtnInhabilitado", "MODIFICAR") = "N" And COracle.credenciales("BtnInhabilitado", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnInhabilitado", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnInhabilitado", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnInhabilitado", "ELIMINAR", Me.BtnEliminar)
    End Sub
    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_DEPARTAMENTOS1' table. You can move, or remove it, as needed.
        ''actualiza el grid 
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.Fill(Me.DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS)

    End Sub
    Sub actualizaeliminar()
        Me.TA_CIUDADANOS_INHABILITADOSTableAdapter.Fill(Me.DS_CIUDADANOS_INH.TA_CIUDADANOS_INHABILITADOS)
    End Sub

    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMCIUDADANOSINHABILITADOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMCIUDADANOSINHABILITADOSBindingSource.AddNew()
            Me.BtnEliminar.Enabled = False
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub
    Sub Eliminar()

        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim ciudrow As DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOSRow = Me.DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS.FindByNUMERO_IDENTIFICACIONCODIGO_MOTIVO(id, cellValue2)

                ciudrow.Delete()

                Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.Update(Me.DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS)

                ActualizarGrid()
                actualizaeliminar()
                Mensajes.MensajeEliminar()

                Me.IMCIUDADANOSINHABILITADOSBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try
            ActualizarGrid()
        End If

    End Sub


    Sub MostrarDatos()
        Try
            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            cellValue2 = Data.CapturarDatoGrid(Me.GridView1, 6)

            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.FillBy(Me.DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS, cellValue)
            actualizar = True
            id = cellValue
            BtnEliminar.Enabled = True
        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub
    Sub guardar()
        Try
            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMCIUDADANOSINHABILITADOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOSRow In DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS

                'SI ES UN NUEVO REGITRO
                If _datar.RowState = DataRowState.Added Then
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now
                    If Me.HABILITADOTextEdit.Checked Then
                        _datar.FECHA_HABILITACION = _datar.FECHA_ADICION
                        actualizaeliminar()
                    End If
                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                    If Me.HABILITADOTextEdit.Checked Then
                        _datar.FECHA_HABILITACION = _datar.FECHA_ADICION
                        actualizaeliminar()
                    End If
                End If
            Next

            'AGREGANDO LA INFORMACION A LA BASE DE DATOS
            Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.Update(Me.DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS)

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarGrid()
            actualizaeliminar()
            'Edicion
            BtnEliminar.Enabled = False
            If actualizar = True Then
                Mensajes.MensajeActualizar()
                actualizar = False
            Else
                Mensajes.MensajeGuardar()
            End If
            Me.IMCIUDADANOSINHABILITADOSBindingSource.AddNew()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close() '' salir de la pantalla de inhabilitacion.
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo() ''crear 
    End Sub
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub


    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnInhabilitado", "MODIFICAR") = "S" Then
            guardar()
            actualizaeliminar()
        ElseIf actualizar = True And COracle.credenciales("BtnInhabilitado", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnInhabilitado", "INSERTAR") = "S" Then
            guardar()
            actualizaeliminar()
        ElseIf actualizar = False And COracle.credenciales("BtnInhabilitado", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
        actualizaeliminar()
    End Sub
    Private Sub NUMERO_IDENTIFICACIONTextEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NUMERO_IDENTIFICACIONTextEdit.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE nombre, PRIMER_APELLIDO apellido, SEGUNDO_APELLIDO sapellido "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & Me.NUMERO_IDENTIFICACIONTextEdit.EditValue & "'"
            Dim N As String = COracle.ObtenerDatos(consulta, "NOMBRE")
            Dim A As String = COracle.ObtenerDatos(consulta, "APELLIDO")
            Dim S As String = COracle.ObtenerDatos(consulta, "SAPELLIDO")

            If N = "N" Then
                Me.NOMBRESTextEdit.EditValue = ""
                Me.PRIMER_APELLIDOTextEdit.EditValue = ""
                Me.SEGUNDO_APELLIDOTextEdit.EditValue = ""


                'Mensajes.mimensaje("NUMERO DE IDENTIDAD NO EXISTE EN CNE")
            Else
                Me.NOMBRESTextEdit.EditValue = N
                Me.PRIMER_APELLIDOTextEdit.EditValue = A
                Me.SEGUNDO_APELLIDOTextEdit.EditValue = S
                Return
            End If
        End If
    End Sub
    Private Sub NUMERO_IDENTIFICACIONTextEdit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NUMERO_IDENTIFICACIONTextEdit.LostFocus
        Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE nombre, PRIMER_APELLIDO apellido, SEGUNDO_APELLIDO sapellido "
        consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & Me.NUMERO_IDENTIFICACIONTextEdit.EditValue & "'"
        Dim N As String = COracle.ObtenerDatos(consulta, "NOMBRE")
        Dim A As String = COracle.ObtenerDatos(consulta, "APELLIDO")
        Dim S As String = COracle.ObtenerDatos(consulta, "SAPELLIDO")
        If N = "N" Then
            Me.NOMBRESTextEdit.EditValue = ""
            Me.PRIMER_APELLIDOTextEdit.EditValue = ""
            Me.SEGUNDO_APELLIDOTextEdit.EditValue = ""
            'Mensajes.mimensaje("NUMERO DE IDENTIDAD NO EXISTE EN CNE")
        Else
            Me.NOMBRESTextEdit.EditValue = N
            Me.PRIMER_APELLIDOTextEdit.EditValue = A
            Me.SEGUNDO_APELLIDOTextEdit.EditValue = S
            Return
        End If


    End Sub
End Class