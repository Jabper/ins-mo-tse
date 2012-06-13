
Public Class XfrmParametros

    Private Sub XfrmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSParametros.IM_PARAMETROS_GENERALES' table. You can move, or remove it, as needed.
        Me.IM_PARAMETROS_GENERALESTableAdapter.Fill(Me.DSParametros.IM_PARAMETROS_GENERALES)
        'Me.IMPARAMETROSGENERALESBindingSource.AddNew()
        AgregarElecciiones()

        Dim modificar As String = COracle.credenciales("BtnParametros", "MODIFICAR")

        If modificar = "N" Then
            BtnGuardar.Visible = False
        ElseIf modificar = "S" Then
            BtnGuardar.Visible = True
        End If        
    End Sub

    Sub guardar()
        Try
            'TEXTO ENLAZADO
            Me.txtfecha.Visible = True
            Me.txtfecha.Text = DateTime.Now

            Me.IMPARAMETROSGENERALESBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSParametros.IM_PARAMETROS_GENERALESRow In DSParametros.IM_PARAMETROS_GENERALES
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

            Me.IM_PARAMETROS_GENERALESTableAdapter.Update(Me.DSParametros.IM_PARAMETROS_GENERALES)
            Me.txtfecha.Visible = False
            Mensajes.MensajeActualizar()

        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.IMPARAMETROSGENERALESBindingSource.CancelEdit()
        Me.IMPARAMETROSGENERALESBindingSource.AddNew()
    End Sub


    Sub AgregarElecciiones()
        Dim tbl As New DataTable()
        'SE CREAN LAS COLUMNAS DEL DATA TABLE
        tbl.Columns.Add("Id", GetType(Integer))
        tbl.Columns.Add("Tipo Elecciones", GetType(String))
        'SE AGREGAN LAS FILAS CON LA INFORMACION
        tbl.Rows.Add(1, "Primarias")
        tbl.Rows.Add(2, "Generales")

        'SE ENLAZA EL DATATABLE CREADO PARA MOSTRARLO EN EL CONTROL
        With TIPO_ELECCIONESSpinEdit
            .Properties.DataSource = tbl
            .Properties.ValueMember = "Id"
            .Properties.DisplayMember = "Tipo Elecciones"
            'SE PREPARA EL CONTROL PARA OCULTAR COLUMNAS
            .Properties.ForceInitialize()
            .Properties.PopulateColumns()
            'SE OCULTA INFORMACION 
            .Properties.Columns(0).Visible = False
            .Properties.Columns(1).Visible = True
        End With
    End Sub




    Private Sub PARTICIPACION_MUJER_PORCENSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PARTICIPACION_MUJER_PORCENSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub



    Private Sub FIRMAS_REPETIDAS_PORCENSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FIRMAS_REPETIDAS_PORCENSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub



    Private Sub FORMULAS_MUNICIPIO_MINSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FORMULAS_MUNICIPIO_MINSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub


    Private Sub FORMULAS_DEPART_MINSpinEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FORMULAS_DEPART_MINSpinEdit.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub PARTICIPACION_MUJER_PORCENSpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARTICIPACION_MUJER_PORCENSpinEdit.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class