Public Class XfrmUsuarios 

    Private Sub XfrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPolitico.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
       Me.TA_ROLESTableAdapter.Fill(Me.DTUsers.TA_ROLES)

        Me.IMUSUARIOSBindingSource.AddNew()
        PreguntasDeSeguridad()
    End Sub
    Sub PreguntasDeSeguridad() 'SE CREA UN DATA TABLE PARA ENLAZARLO AL CONTROL Y MOSTRAR LAS PREGUNTAS DE SEGURIDAD
        Dim tbl As New DataTable()
        'SE CREAN LAS COLUMNAS DEL DATA TABLE
        tbl.Columns.Add("Id", GetType(Integer))
        tbl.Columns.Add("Pregunta", GetType(String))
        'SE AGREGAN LAS FILAS CON LA INFORMACION
        tbl.Rows.Add(1, "¿Nombre de mi mascosta?")
        tbl.Rows.Add(2, "¿Lugar de Nacimiento?")

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


    Sub Nuevo()
        Me.IMUSUARIOSBindingSource.CancelEdit()
        Me.IMUSUARIOSBindingSource.AddNew()
    End Sub

    Sub guardar()
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
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub
    Sub MostrarDatos()

    End Sub

    Sub ActualizarGrid()

    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOSpinEdit.EditValueChanged
        Try
            Me.IM_MOVIMIENTOSTableAdapter.FillBy1(Me.DSPolitico.IM_MOVIMIENTOS, Me.CODIGO_PARTIDOSpinEdit.EditValue)

        Catch ex As Exception

        End Try
    End Sub
   


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub
End Class