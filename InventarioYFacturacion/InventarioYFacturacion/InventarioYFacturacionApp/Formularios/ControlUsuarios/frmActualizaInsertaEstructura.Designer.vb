<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizaInsertaEstructura
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
        Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbContainer
        '
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.txtDescripcion)
        Me.grbContainer.Panel.Controls.Add(Me.txtNombre)
        Me.grbContainer.Panel.Controls.Add(Me.lblDescripcion)
        Me.grbContainer.Panel.Controls.Add(Me.lblNombre)
        Me.grbContainer.Size = New System.Drawing.Size(370, 321)
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(37, 113)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblNombre.Size = New System.Drawing.Size(58, 20)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Values.Text = "Nombre:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(18, 139)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblDescripcion.Size = New System.Drawing.Size(77, 20)
        Me.lblDescripcion.TabIndex = 8
        Me.lblDescripcion.Values.Text = "Descripción:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(109, 113)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNombre.Size = New System.Drawing.Size(234, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(109, 139)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(234, 134)
        Me.txtDescripcion.TabIndex = 10
        '
        'frmNuevoRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 321)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoRol"
        Me.Text = "Nuevo Rol"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        Me.grbContainer.Panel.PerformLayout()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
