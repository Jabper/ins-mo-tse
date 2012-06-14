Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class Municipios

    Dim actualizar As Boolean = False
    Dim id As Integer
    Dim iddepto As Integer

    Private Sub Municipios_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.IM_DEPARTAMENTOS)
    End Sub
    Private Sub XfrmMunicipio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DSDeptoMuni.IM_MUNICIPIOS' table. You can move, or remove it, as needed.
        Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSDeptoMuni.IM_MUNICIPIOS)
        'TODO: This line of code loads data into the 'DSDeptoMuni.TA_MUNICIPIOS' table. You can move, or remove it, as needed.
        Me.TA_MUNICIPIOSTableAdapter.Fill(Me.DSDeptoMuni.TA_MUNICIPIOS)

        ActualizarGrid()
        Me.IMMUNICIPIOSBindingSource.AddNew()

        If COracle.credenciales("BtnMunicipio", "MODIFICAR") = "N" And COracle.credenciales("BtnMunicipio", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnMunicipio", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnMunicipio", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnMunicipio", "ELIMINAR", Me.BtnEliminar)
  
    End Sub

    Sub ActualizarGrid()
        Me.TA_MUNICIPIOSTableAdapter.Fill(Me.DSDeptoMuni.TA_MUNICIPIOS)
    End Sub
    Sub nuevo()
        Try
            Me.IMMUNICIPIOSBindingSource.CancelEdit()
            Me.IMMUNICIPIOSBindingSource.AddNew()
            Me.BtnEliminar.Enabled = False
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub
    Sub guardar()



        Try
            Me.IMMUNICIPIOSBindingSource.EndEdit()
            Dim _data As DSDeptoMuni.IM_MUNICIPIOSDataTable = DSDeptoMuni.IM_MUNICIPIOS

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSDeptoMuni.IM_MUNICIPIOSRow In DSDeptoMuni.IM_MUNICIPIOS
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
            Me.IM_MUNICIPIOSTableAdapter.Update(Me.DSDeptoMuni.IM_MUNICIPIOS)


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
            Me.IMMUNICIPIOSBindingSource.AddNew()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    

    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSDeptoMuni.IM_MUNICIPIOS, cellValue)
            actualizar = True
            id = cellValue
            iddepto = Data.CapturarDatoGrid(GridView1, 1)
            BtnEliminar.Enabled = True


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    
    Sub Eliminar()
        If XtraMessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try


                Dim Drow As DSDeptoMuni.IM_MUNICIPIOSRow

                Drow = Me.DSDeptoMuni.IM_MUNICIPIOS.FindByCODIGO_MUNICIPIOCODIGO_DEPARTAMENTO(id, iddepto)

                Drow.Delete()

                Me.IM_MUNICIPIOSTableAdapter.Update(Me.DSDeptoMuni.IM_MUNICIPIOS)
                ActualizarGrid()
                Mensajes.MensajeEliminar()
                Me.IMMUNICIPIOSBindingSource.AddNew()
                Me.BtnEliminar.Enabled = False
                actualizar = False
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
            End Try
        End If

      
    End Sub


    Private Sub CODIGO_MUNICIPIOSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CODIGO_MUNICIPIOSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    

    Private Sub CANTIDAD_REGIDORESSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CANTIDAD_REGIDORESSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub ButtonEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit1.EditValueChanged
        Me.TA_MUNICIPIOSTableAdapter.FillBy(Me.DSDeptoMuni.TA_MUNICIPIOS, ButtonEdit1.Text)
    End Sub

   
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If actualizar = True And COracle.credenciales("BtnMunicipio", "MODIFICAR") = "S" Then
            guardar()
        ElseIf actualizar = True And COracle.credenciales("BtnMunicipio", "MODIFICAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
        ElseIf actualizar = False And COracle.credenciales("BtnMunicipio", "INSERTAR") = "S" Then
            guardar()
        ElseIf actualizar = False And COracle.credenciales("BtnMunicipio", "INSERTAR") <> "S" Then
            Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
        End If
    End Sub

    
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Eliminar()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub TextEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit1.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TextEdit1.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub


    Private Sub CODIGO_MUNICIPIOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_MUNICIPIOSpinEdit.EditValueChanged

    End Sub
End Class