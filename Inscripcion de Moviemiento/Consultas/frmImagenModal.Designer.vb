﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagenModal
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pbxImagen = New System.Windows.Forms.PictureBox
        Me.ImagenRequisitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.ImagenRequisitoTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.imagenRequisitoTableAdapter
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenRequisitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(469, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(53, 35)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.TabStop = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pbxImagen
        '
        Me.pbxImagen.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ImagenRequisitoBindingSource, "IMAGEN", True))
        Me.pbxImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxImagen.Location = New System.Drawing.Point(0, 0)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(645, 540)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxImagen.TabIndex = 1
        Me.pbxImagen.TabStop = False
        '
        'ImagenRequisitoBindingSource
        '
        Me.ImagenRequisitoBindingSource.DataMember = "imagenRequisito"
        Me.ImagenRequisitoBindingSource.DataSource = Me.DSConsultas
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImagenRequisitoTableAdapter
        '
        Me.ImagenRequisitoTableAdapter.ClearBeforeFill = True
        '
        'frmImagenModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(645, 540)
        Me.Controls.Add(Me.pbxImagen)
        Me.Controls.Add(Me.btnCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImagenModal"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imagen"
        Me.TopMost = True
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenRequisitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pbxImagen As System.Windows.Forms.PictureBox
    Friend WithEvents ImagenRequisitoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents ImagenRequisitoTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.imagenRequisitoTableAdapter
End Class
