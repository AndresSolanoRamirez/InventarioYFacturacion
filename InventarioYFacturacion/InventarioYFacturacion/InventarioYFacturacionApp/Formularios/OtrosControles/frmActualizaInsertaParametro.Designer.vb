<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizaInsertaParametro
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
        Me.txtNombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ktxtValor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.kchbxPermiteModificar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.kchbxPermiteEliminar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
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
        Me.grbContainer.Panel.Controls.Add(Me.kchbxPermiteEliminar)
        Me.grbContainer.Panel.Controls.Add(Me.kchbxPermiteModificar)
        Me.grbContainer.Panel.Controls.Add(Me.ktxtValor)
        Me.grbContainer.Panel.Controls.Add(Me.txtNombre)
        Me.grbContainer.Panel.Controls.Add(Me.lblDescripcion)
        Me.grbContainer.Panel.Controls.Add(Me.lblNombre)
        Me.grbContainer.Size = New System.Drawing.Size(487, 193)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 99)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtNombre.Size = New System.Drawing.Size(234, 20)
        Me.txtNombre.TabIndex = 13
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(34, 125)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblDescripcion.Size = New System.Drawing.Size(42, 20)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Values.Text = "Valor:"
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(18, 99)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblNombre.Size = New System.Drawing.Size(58, 20)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Values.Text = "Nombre:"
        '
        'ktxtValor
        '
        Me.ktxtValor.Location = New System.Drawing.Point(90, 125)
        Me.ktxtValor.Name = "ktxtValor"
        Me.ktxtValor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.ktxtValor.Size = New System.Drawing.Size(234, 20)
        Me.ktxtValor.TabIndex = 14
        '
        'kchbxPermiteModificar
        '
        Me.kchbxPermiteModificar.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.kchbxPermiteModificar.Location = New System.Drawing.Point(345, 98)
        Me.kchbxPermiteModificar.Name = "kchbxPermiteModificar"
        Me.kchbxPermiteModificar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.kchbxPermiteModificar.Size = New System.Drawing.Size(121, 20)
        Me.kchbxPermiteModificar.TabIndex = 15
        Me.kchbxPermiteModificar.Text = "Permite Modificar"
        Me.kchbxPermiteModificar.Values.Text = "Permite Modificar"
        '
        'kchbxPermiteEliminar
        '
        Me.kchbxPermiteEliminar.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.kchbxPermiteEliminar.Location = New System.Drawing.Point(345, 125)
        Me.kchbxPermiteEliminar.Name = "kchbxPermiteEliminar"
        Me.kchbxPermiteEliminar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.kchbxPermiteEliminar.Size = New System.Drawing.Size(112, 20)
        Me.kchbxPermiteEliminar.TabIndex = 16
        Me.kchbxPermiteEliminar.Text = "Permite Eliminar"
        Me.kchbxPermiteEliminar.Values.Text = "Permite Eliminar"
        '
        'frmActualizaInsertaParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 193)
        Me.Name = "frmActualizaInsertaParametro"
        Me.Text = "Insertar Parámetro"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        Me.grbContainer.Panel.PerformLayout()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kchbxPermiteEliminar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchbxPermiteModificar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ktxtValor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
