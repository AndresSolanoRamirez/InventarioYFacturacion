<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarDatos
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.kgbDatos = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.kdgvDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        CType(Me.kgbDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgbDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgbDatos.Panel.SuspendLayout()
        Me.kgbDatos.SuspendLayout()
        CType(Me.kdgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbContainer
        '
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.kgbDatos)
        Me.grbContainer.Size = New System.Drawing.Size(916, 474)
        '
        'kgbDatos
        '
        Me.kgbDatos.Location = New System.Drawing.Point(18, 99)
        Me.kgbDatos.Name = "kgbDatos"
        '
        'kgbDatos.Panel
        '
        Me.kgbDatos.Panel.Controls.Add(Me.kdgvDatos)
        Me.kgbDatos.Size = New System.Drawing.Size(886, 332)
        Me.kgbDatos.TabIndex = 3
        Me.kgbDatos.Text = "Vista previa de datos"
        Me.kgbDatos.Values.Heading = "Vista previa de datos"
        '
        'kdgvDatos
        '
        Me.kdgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.kdgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kdgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kdgvDatos.Location = New System.Drawing.Point(0, 0)
        Me.kdgvDatos.Name = "kdgvDatos"
        Me.kdgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.kdgvDatos.Size = New System.Drawing.Size(882, 308)
        Me.kdgvDatos.TabIndex = 0
        '
        'frmImportarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 474)
        Me.Name = "frmImportarDatos"
        Me.Text = "Importar Datos"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        CType(Me.kgbDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbDatos.Panel.ResumeLayout(False)
        CType(Me.kgbDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbDatos.ResumeLayout(False)
        CType(Me.kdgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kgbDatos As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kdgvDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
