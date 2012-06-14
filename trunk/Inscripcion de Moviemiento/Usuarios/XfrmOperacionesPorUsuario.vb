﻿Imports DevExpress.XtraEditors

Public Class XfrmOperacionesPorUsuario
    Dim actualizar As Boolean = False
    Private Sub XfrmOperacionesPorUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTUsuario.DT_OPERACIONES' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DTUsers.IM_OPCIONES' table. You can move, or remove it, as needed.
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        'TODO: This line of code loads data into the 'DTUsers.IM_USUARIOS' table. You can move, or remove it, as needed.
        Me.IM_USUARIOSTableAdapter.Fill(Me.DTUsers.IM_USUARIOS)
        'TODO: This line of code loads data into the 'DTUsuario.IM_OPERACIONES_X_USUARIO' table. You can move, or remove it, as needed.
        Me.IM_OPERACIONES_X_USUARIOTableAdapter.Fill(Me.DTUsuario.IM_OPERACIONES_X_USUARIO)
        Me.DT_OPERACIONESTableAdapter.FillBy(Me.DTUsuario.DT_OPERACIONES, "Null")
        Me.IMOPERACIONESXUSUARIOBindingSource.AddNew()


        If COracle.credenciales("BtnOperacionesUsuarios", "MODIFICAR") = "N" And COracle.credenciales("BtnOperacionesUsuarios", "INSERTAR") = "N" Then
            DxControls.ObtenerCredencial("BtnOperacionesUsuarios", "MODIFICAR", Me.BtnGuardar)
        End If
        DxControls.ObtenerCredencial("BtnOperacionesUsuarios", "INSERTAR", Me.BtnNuevo)
        DxControls.ObtenerCredencial("BtnOperacionesUsuarios", "ELIMINAR", Me.BtnEliminar)

    End Sub


    Sub Nuevo()
        Try
            Me.IMOPERACIONESXUSUARIOBindingSource.CancelEdit()
            Me.IMOPERACIONESXUSUARIOBindingSource.AddNew()
            actualizar = False
            Me.BtnEliminar.Enabled = False
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Sub guardar()
        Try
            Me.IMOPERACIONESXUSUARIOBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DTUsuario.IM_OPERACIONES_X_USUARIORow In DTUsuario.IM_OPERACIONES_X_USUARIO
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
            Me.IM_OPERACIONES_X_USUARIOTableAdapter.Update(Me.DTUsuario.IM_OPERACIONES_X_USUARIO)


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
            Me.IMOPERACIONESXUSUARIOBindingSource.AddNew()
            actualizar = False
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub
    Sub MostrarDatos()
        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim idcodigo As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            Dim iduser As String = Data.CapturarDatoGrid(Me.GridView1, 1)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA

            Me.IM_OPERACIONES_X_USUARIOTableAdapter.FillBy(DTUsuario.IM_OPERACIONES_X_USUARIO, CType(idcodigo, Integer), iduser)
            actualizar = True
            BtnEliminar.Enabled = True

        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
        Me.DT_OPERACIONESTableAdapter.FillBy(Me.DTUsuario.DT_OPERACIONES, Me.CODIGO_USUARIOTextEdit.EditValue)
    End Sub

    

    Private Sub CODIGO_USUARIOTextEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CODIGO_USUARIOTextEdit.TextChanged
        Me.DT_OPERACIONESTableAdapter.FillBy(Me.DTUsuario.DT_OPERACIONES, Me.CODIGO_USUARIOTextEdit.EditValue)
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        MostrarDatos()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            If actualizar = True And COracle.credenciales("BtnOperacionesUsuarios", "MODIFICAR") = "S" Then
                guardar()
            ElseIf actualizar = True And COracle.credenciales("BtnOperacionesUsuarios", "MODIFICAR") <> "S" Then
                Mensajes.MensajeError("El ususario no tiene permisos de Modificacion en esta pantalla")
            ElseIf actualizar = False And COracle.credenciales("BtnOperacionesUsuarios", "INSERTAR") = "S" Then
                guardar()
            ElseIf actualizar = False And COracle.credenciales("BtnOperacionesUsuarios", "INSERTAR") <> "S" Then
                Mensajes.MensajeError("El ususario no tiene permisos de Inserción en esta pantalla")
            End If
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
        
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        eliminar()
    End Sub
    Sub eliminar()

    End Sub
End Class