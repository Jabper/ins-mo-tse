Public Class XfrmOperacionesPorRol 
    Dim idop As Integer
    Dim idrol As Integer

    Private Sub XfrmOperacionesPorRol_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.IM_ROLESTableAdapter.Fill(Me.DTUsers.IM_ROLES)
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
    End Sub
    Private Sub XfrmOperacionesPorRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTUsers.DT_OPCIONES_X_ROL' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DTUsers.IM_ROLES' table. You can move, or remove it, as needed.
        Me.IM_ROLESTableAdapter.Fill(Me.DTUsers.IM_ROLES)
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        'TODO: This line of code loads data into the 'DTUsers.IM_OPERACIONES_POR_ROL' table. You can move, or remove it, as needed.
        Me.IM_OPERACIONES_POR_ROLTableAdapter.Fill(Me.DTUsers.IM_OPERACIONES_POR_ROL)
        Me.IMOPERACIONESPORROLBindingSource.AddNew()
    End Sub

    Sub Nuevo()
        Try
            Me.IMOPERACIONESPORROLBindingSource.CancelEdit()
            Me.IMOPERACIONESPORROLBindingSource.AddNew()
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Sub guardar()
        Try
            Me.IMOPERACIONESPORROLBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DTUsers.IM_OPERACIONES_POR_ROLRow In DTUsers.IM_OPERACIONES_POR_ROL
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
            Me.IM_OPERACIONES_POR_ROLTableAdapter.Update(Me.DTUsers.IM_OPERACIONES_POR_ROL)


            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarGrid()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub
    Sub MostrarDatos()
        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            idop = Data.CapturarDatoGrid(Me.GridView1, 0)
            idrol = Data.CapturarDatoGrid(Me.GridView1, 1)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_OPERACIONES_POR_ROLTableAdapter.FillBy(DTUsers.IM_OPERACIONES_POR_ROL, idop, idrol)



        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        Try
            Me.DT_OPCIONES_X_ROLTableAdapter.FillBy(Me.DTUsers.DT_OPCIONES_X_ROL, Me.CODIGO_ROLSpinEdit.EditValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CODIGO_ROLSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_ROLSpinEdit.EditValueChanged
        Me.DT_OPCIONES_X_ROLTableAdapter.FillBy(Me.DTUsers.DT_OPCIONES_X_ROL, Me.CODIGO_ROLSpinEdit.EditValue)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click

    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        MostrarDatos()
    End Sub
End Class