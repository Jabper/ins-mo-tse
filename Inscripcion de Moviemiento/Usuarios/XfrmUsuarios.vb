Imports DevExpress.Utils
Imports System.Threading

Public Class XfrmUsuarios
    Dim actualizar As Boolean = False
    Private Sub XfrmUsuarios_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        'Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        Me.TA_ROLESTableAdapter.Fill(Me.DTUsers.TA_ROLES)
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
    End Sub

    Private Sub XfrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '******************************************
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
        Me.DT_USUARIOSTableAdapter.Fill(Me.DTUsers.DT_USUARIOS)
        'Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.TA_ROLESTableAdapter.Fill(Me.DTUsers.TA_ROLES)
        PreguntasDeSeguridad()
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
        Try
            Me.IMUSUARIOSBindingSource.CancelEdit()
            Me.IMUSUARIOSBindingSource.AddNew()
            actualizar = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

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


            If actualizar = True Then
                Mensajes.MensajeActualizar()
                actualizar = False
            Else
                Mensajes.MensajeGuardar()
            End If
            Me.IMUSUARIOSBindingSource.AddNew()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
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

    End Sub

    Private Sub CODIGO_PARTIDOSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODIGO_PARTIDOSpinEdit.EditValueChanged
        Try
            Me.IM_MOVIMIENTOSTableAdapter.FillBy2(Me.DSPolitico.IM_MOVIMIENTOS, Me.CODIGO_PARTIDOSpinEdit.EditValue)

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

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        MostrarDatos()
    End Sub

  
    Private Sub CODIGO_USUARIOSpinEdit_InvalidValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles CODIGO_USUARIOSpinEdit.InvalidValue
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
End Class