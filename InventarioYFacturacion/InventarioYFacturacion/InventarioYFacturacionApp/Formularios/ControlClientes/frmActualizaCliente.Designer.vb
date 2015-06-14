<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizaCliente
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
        Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtApellidos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblApellidos = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtIdentificacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblIdentificacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTelefono = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTelefono = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblEmail = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDireccion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDireccion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kchbxInsercionMultiple = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
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
        Me.grbContainer.Panel.Controls.Add(Me.kchbxInsercionMultiple)
        Me.grbContainer.Panel.Controls.Add(Me.txtDireccion)
        Me.grbContainer.Panel.Controls.Add(Me.lblDireccion)
        Me.grbContainer.Panel.Controls.Add(Me.txtEmail)
        Me.grbContainer.Panel.Controls.Add(Me.lblEmail)
        Me.grbContainer.Panel.Controls.Add(Me.txtTelefono)
        Me.grbContainer.Panel.Controls.Add(Me.lblTelefono)
        Me.grbContainer.Panel.Controls.Add(Me.txtIdentificacion)
        Me.grbContainer.Panel.Controls.Add(Me.lblIdentificacion)
        Me.grbContainer.Panel.Controls.Add(Me.txtApellidos)
        Me.grbContainer.Panel.Controls.Add(Me.lblApellidos)
        Me.grbContainer.Panel.Controls.Add(Me.txtNombre)
        Me.grbContainer.Panel.Controls.Add(Me.lblNombre)
        Me.grbContainer.Size = New System.Drawing.Size(406, 373)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(144, 113)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtNombre.Size = New System.Drawing.Size(234, 20)
        Me.txtNombre.TabIndex = 7
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(80, 113)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 20)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Values.Text = "Nombre:"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(144, 139)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtApellidos.Size = New System.Drawing.Size(234, 20)
        Me.txtApellidos.TabIndex = 9
        '
        'lblApellidos
        '
        Me.lblApellidos.Location = New System.Drawing.Point(74, 139)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(64, 20)
        Me.lblApellidos.TabIndex = 8
        Me.lblApellidos.Values.Text = "Apellidos:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(144, 165)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtIdentificacion.Size = New System.Drawing.Size(234, 20)
        Me.txtIdentificacion.TabIndex = 11
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Location = New System.Drawing.Point(52, 165)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(86, 20)
        Me.lblIdentificacion.TabIndex = 10
        Me.lblIdentificacion.Values.Text = "Identificación:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(144, 191)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtTelefono.Size = New System.Drawing.Size(234, 20)
        Me.txtTelefono.TabIndex = 13
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(77, 191)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 20)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Values.Text = "Teléfono:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(144, 217)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtEmail.Size = New System.Drawing.Size(234, 20)
        Me.txtEmail.TabIndex = 17
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(96, 217)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 20)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Values.Text = "Email:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(144, 243)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtDireccion.Size = New System.Drawing.Size(234, 57)
        Me.txtDireccion.TabIndex = 21
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(74, 243)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(64, 20)
        Me.lblDireccion.TabIndex = 20
        Me.lblDireccion.Values.Text = "Dirección:"
        '
        'kchbxInsercionMultiple
        '
        Me.kchbxInsercionMultiple.Checked = True
        Me.kchbxInsercionMultiple.CheckState = System.Windows.Forms.CheckState.Checked
        Me.kchbxInsercionMultiple.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.kchbxInsercionMultiple.Location = New System.Drawing.Point(52, 306)
        Me.kchbxInsercionMultiple.Name = "kchbxInsercionMultiple"
        Me.kchbxInsercionMultiple.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.kchbxInsercionMultiple.Size = New System.Drawing.Size(121, 20)
        Me.kchbxInsercionMultiple.TabIndex = 22
        Me.kchbxInsercionMultiple.Text = "Inserción Múltiple"
        Me.kchbxInsercionMultiple.Values.Text = "Inserción Múltiple"
        '
        'frmActualizaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 373)
        Me.MinimizeBox = False
        Me.Name = "frmActualizaCliente"
        Me.Text = "Insertar Cliente"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        Me.grbContainer.Panel.PerformLayout()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDireccion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDireccion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblEmail As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTelefono As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTelefono As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtIdentificacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblIdentificacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtApellidos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblApellidos As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kchbxInsercionMultiple As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
