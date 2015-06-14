<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizaInsertaSubFamilia
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
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klblFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kcbFamilias = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        CType(Me.kcbFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbContainer
        '
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.kcbFamilias)
        Me.grbContainer.Panel.Controls.Add(Me.klblFamilia)
        Me.grbContainer.Panel.Controls.Add(Me.txtDescripcion)
        Me.grbContainer.Panel.Controls.Add(Me.txtNombre)
        Me.grbContainer.Panel.Controls.Add(Me.lblDescripcion)
        Me.grbContainer.Panel.Controls.Add(Me.lblNombre)
        Me.grbContainer.Size = New System.Drawing.Size(390, 414)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 151)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(234, 200)
        Me.txtDescripcion.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(117, 125)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNombre.Size = New System.Drawing.Size(234, 20)
        Me.txtNombre.TabIndex = 13
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(26, 151)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblDescripcion.Size = New System.Drawing.Size(77, 20)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Values.Text = "Descripción:"
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(45, 125)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblNombre.Size = New System.Drawing.Size(58, 20)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Values.Text = "Nombre:"
        '
        'klblFamilia
        '
        Me.klblFamilia.Location = New System.Drawing.Point(45, 99)
        Me.klblFamilia.Name = "klblFamilia"
        Me.klblFamilia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.klblFamilia.Size = New System.Drawing.Size(51, 20)
        Me.klblFamilia.TabIndex = 15
        Me.klblFamilia.Values.Text = "Familia:"
        '
        'kcbFamilias
        '
        Me.kcbFamilias.DropDownWidth = 234
        Me.kcbFamilias.Location = New System.Drawing.Point(117, 100)
        Me.kcbFamilias.Name = "kcbFamilias"
        Me.kcbFamilias.Size = New System.Drawing.Size(234, 21)
        Me.kcbFamilias.TabIndex = 16
        '
        'frmActualizaInsertaSubFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 414)
        Me.Name = "frmActualizaInsertaSubFamilia"
        Me.Text = "Insertar Sub Familia"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        Me.grbContainer.Panel.PerformLayout()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        CType(Me.kcbFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcbFamilias As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
