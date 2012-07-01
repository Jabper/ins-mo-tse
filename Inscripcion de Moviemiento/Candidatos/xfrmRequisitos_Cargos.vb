Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class xfrmRequisitos_Cargos
    Dim actualizar As Boolean = False
    Private Sub xfrmRequisitos_Cargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(DSRequisitos.IM_CARGOS_ELECTIVOS)
        'TODO: This line of code loads data into the 'DSRequisitos.IM_REQUISITOS' table. You can move, or remove it, as needed.
        Me.IM_REQUISITOSTableAdapter.Fill(Me.DSRequisitos.IM_REQUISITOS)
        'TODO: This line of code loads data into the 'DSRequisitos.TA_REQUISITOS_X_CARGO' table. You can move, or remove it, as needed.
        Me.TA_REQUISITOS_X_CARGOTableAdapter.Fill(Me.DSRequisitos.TA_REQUISITOS_X_CARGO)

        ''TODO: This line of code loads data into the 'DSRequisitos.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        'Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSRequisitos.IM_CARGOS_ELECTIVOS)
        ''TODO: This line of code loads data into the 'DSRequisitos.IM_REQUISITOS_X_CARGOS' table. You can move, or remove it, as needed.
        'Me.IM_REQUISITOS_X_CARGOSTableAdapter.Fill(Me.DSRequisitos.IM_REQUISITOS_X_CARGOS)


        Me.IMREQUISITOSXCARGOSBindingSource.AddNew()
        'Me.TA_REQUISITOS_X_CARGOTableAdapter.Fill(Me.DSRequisitos.TA_REQUISITOS_X_CARGO)

        If COracle.credenciales("BtnRequisitos", "MODIFICAR") = "N" And COracle.credenciales("BtnRequisitos", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnRequisitos", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnRequisitos", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnRequisitos", "ELIMINAR", Me.BtnEliminar)
    End Sub
    Sub Nuevo()

        Me.IMREQUISITOSXCARGOSBindingSource.CancelEdit()
        Me.IMREQUISITOSXCARGOSBindingSource.AddNew()
        actualizar = False

    End Sub
    Sub MostrarDatos()
        Try
            Dim view As GridView = GridView1

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_REQUISITOS_X_CARGOSTableAdapter.FillBy(Me.DSRequisitos.IM_REQUISITOS_X_CARGOS, view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_REQUISITO"), view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_CARGO_ELECTIVO"))

            actualizar = True


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        'TODO: This line of code loads data into the 'DSCandidato.TA_REQUISITOS' table. You can move, or remove it, as needed.
        Me.TA_REQUISITOS_X_CARGOTableAdapter.Fill(Me.DSRequisitos.TA_REQUISITOS_X_CARGO)

    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub
    Sub correlativo()
        CODIGO_REQUISITOTextEdit.EditValue = CType(COracle.ObtenerDatos("SELECT MAX(CODIGO_REQUISITO)+1 MAXIMO FROM IM_REQUISITOS", "MAXIMO"), Integer)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Sub eliminar()
        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim view As GridView = GridView1


                'Dim cellvalue As String = Data.CapturarDatoGrid(Me.GridView1, 0)

                Dim DROW As DSRequisitos.IM_REQUISITOS_X_CARGOSRow

                
                DROW = Me.DSRequisitos.IM_REQUISITOS_X_CARGOS.FindByCODIGO_REQUISITOCODIGO_CARGO_ELECTIVO(view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_REQUISITO"), view.GetRowCellValue(view.FocusedRowHandle, "CODIGO_CARGO_ELECTIVO"))
                DROW.Delete()

                Me.IM_REQUISITOS_X_CARGOSTableAdapter.Update(Me.DSRequisitos.IM_REQUISITOS_X_CARGOS)

                ActualizarGrid()
                Mensajes.MensajeEliminar()
                
                Me.IMREQUISITOSXCARGOSBindingSource.AddNew()

                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try
        End If

    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnRequisitos", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnRequisitos", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnRequisitos", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnRequisitos", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    Sub guardar()
        Try
            'If actualizar = False Then
            '    correlativo()
            'End If
            'INDICACION QUE HA TERMINADO LA EDICION

            Me.IMREQUISITOSXCARGOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSRequisitos.IM_REQUISITOS_X_CARGOSRow In DSRequisitos.IM_REQUISITOS_X_CARGOS
                'SI ES UN NUEVO REGITRO
                If _datar.RowState = DataRowState.Added Then
                    'Dim a As String = COracle.ObtenerDatos("select codigo from im_requisitos where descripcion = '" & Me.DESCRIPCIONTextEdit.EditValue & "'", "codigo")
                    '_datar.CODIGO_REQUISITO = CInt(a)
                    '_datar.DESCRIPCION = Me.DESCRIPCIONTextEdit.EditValue
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now
                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    'Dim a As String = COracle.ObtenerDatos("select codigo from im_requisitos where descripcion = '" & Me.DESCRIPCIONTextEdit.EditValue & "'", "codigo")
                    '_datar.CODIGO_REQUISITO = CInt(a)
                    '_datar.DESCRIPCION = Me.DESCRIPCIONTextEdit.EditValue
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                End If
            Next

            'AGREGANDO LA INFORMACION A LA BASE DE DATOS
            Me.IM_REQUISITOS_X_CARGOSTableAdapter.Update(Me.DSRequisitos.IM_REQUISITOS_X_CARGOS)

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

            Me.IMREQUISITOSXCARGOSBindingSource.AddNew()

        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub CODIGO_REQUISITOTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_REQUISITOTextEdit.KeyPress
        VControles.solonumeros(e)
    End Sub


    Private Sub CANTIDADTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CANTIDADTextEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub CODIGO_REQUISITOTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_REQUISITOTextEdit.EditValueChanged
        Me.DESCRIPCIONTextEdit.Text = COracle.ObtenerDatos("select descripcion from im_requisitos where codigo =" & Me.CODIGO_REQUISITOTextEdit.EditValue, "descripcion")
    End Sub
End Class