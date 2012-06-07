Public Class XfrmRoles 

    Private Sub XfrmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            'writedata = False


        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub
End Class