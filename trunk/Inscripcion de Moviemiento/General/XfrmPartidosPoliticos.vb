Imports System.IO
Imports System.Drawing.Imaging
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class XfrmPartidosPoliticos

    Public UrlImagen As String
    Private Sub XfrmPartidosPoliticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        'TODO: This line of code loads data into the 'DSPolitico.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.IM_PARTIDOS_POLITICOS)
        ActualizarGrid()
        Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub


    Sub guardar()

        Try

            'INDICACION QUE HA TERMINADO LA EDICION
            Me.IMPARTIDOSPOLITICOSBindingSource.EndEdit()

            'AGREGAR INFORMACION DE AUDITORIA (MODIFICA EL REGISTRO ANTES DE AGREGARLO A LA BASE )
            For Each _datar As DSPolitico.IM_PARTIDOS_POLITICOSRow In DSPolitico.IM_PARTIDOS_POLITICOS

                'SI ES UN NUEVO REGITRO
                If _datar.RowState = DataRowState.Added Then
                    _datar.ADICIONADO_POR = usuario
                    _datar.FECHA_ADICION = DateTime.Now
                    _datar.IMAGEN = Data.ConvertImageToByteArray(Me.IMAGENPictureEdit.Image)
                    'SI EL REGISTRO SE MODIFICA
                ElseIf _datar.RowState = DataRowState.Modified Then
                    _datar.MODIFICADO_POR = usuario
                    _datar.FECHA_MODIFICACION = DateTime.Now
                    _datar.IMAGEN = Data.ConvertImageToByteArray(Me.IMAGENPictureEdit.Image)

                End If
            Next

            'AGREGANDO LA INFORMACION A LA BASE DE DATOS
            Me.IM_PARTIDOS_POLITICOSTableAdapter.Update(Me.DSPolitico.IM_PARTIDOS_POLITICOS)

            Dim ThumImg As String = Application.StartupPath.ToString & "\Img\" & CODIGO_PARTIDOSpinEdit.EditValue.ToString & NOMBRETextEdit.EditValue.ToString & ".jpg"

            If File.Exists(ThumImg) Then
                Data.CopiarArchivo(UrlImagen, ThumImg)
            End If

            'ACTUALIZANDO EL GRID DE BUSQUEDA Y EDICION
            ActualizarGrid()
        Catch ex As Exception
            'CONTROL DE ERRORES
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Sub Nuevo()

        Try
            'CANCELA LA EDICION EN CASO DE QUE NO QUIERA GUARDAR
            Me.IMPARTIDOSPOLITICOSBindingSource.CancelEdit()

            'LIMPIA LOS CONTROLES PARA AGREGAR UN NUEVO REGISTRO
            Me.IMPARTIDOSPOLITICOSBindingSource.AddNew()
            '   LIMPIAR EL LA IMAGEN
            IMAGENPictureEdit.EditValue = Nothing
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Sub MostrarDatos()

        Try

            'SE LE ASIGNA A UNA VARIABLE EL VALOR DE LA CELDA QUE SE DESEA
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GridView1, 0)
            'UNA VEZ OBTENIENDO EL ID SE MUESTRA LA DATA ENCONTRADA
            Me.IM_PARTIDOS_POLITICOSTableAdapter.FillBy(Me.DSPolitico.IM_PARTIDOS_POLITICOS, CType(cellValue, Integer))

            'OBTENEMOS LA INFORMACION PARA LA BUSQUEDA DE LA IMAGEN
            UrlImagen = Application.StartupPath.ToString & "\Img\" & CODIGO_PARTIDOSpinEdit.EditValue.ToString & NOMBRETextEdit.EditValue.ToString & ".jpg"

            If File.Exists(UrlImagen) Then
                'SI EL ARCHIVO EXISTE MOSTRAMOS LA IMAGEN
                cargarimagen()
            Else
                'SI NO SE ENCUENTRA LIMPIAMOS EL PICTURE EDIT
                IMAGENPictureEdit.EditValue = Nothing
            End If

        Catch ex As System.Exception
            Mensajes.MensajeError("Seleccione una Fila con Datos para Realizar la Edición")
        End Try
    End Sub

    Sub ActualizarGrid()
         Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
    End Sub

    Sub Eliminar()

        Try
            Dim cellValue As String = Data.CapturarDatoGrid(Me.GCPartidos_Politicos, 0)


            Dim deptosrow As DSPolitico.IM_PARTIDOS_POLITICOSRow

            deptosrow = Me.DSPolitico.IM_PARTIDOS_POLITICOS.FindByCODIGO_PARTIDO(cellValue)

            deptosrow.Delete()

            Me.IM_PARTIDOS_POLITICOSTableAdapter.Update(Me.DSPolitico.IM_PARTIDOS_POLITICOS)

            ActualizarGrid()
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'ABRE EL EXPLORADOR PARA CAPTURAR LA DIRECCION DE LA IMAGEN
        OpenFileDialog1.ShowDialog()
        'LA VARIABLE URLIMAGEN CAPTURA LA DIRECCION DE LA IMAGEN
        UrlImagen = OpenFileDialog1.FileName

        cargarimagen()
    End Sub
    Sub cargarimagen() ' MUESTRA LA IMAGEN SELECCIONADA EN EL PICUTURE EDIT

        Me.IMAGENPictureEdit.Image = Image.FromFile(UrlImagen)

    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        MostrarDatos()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

      
    End Sub
End Class