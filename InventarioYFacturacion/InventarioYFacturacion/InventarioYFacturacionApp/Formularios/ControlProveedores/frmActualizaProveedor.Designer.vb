<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizaProveedor
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
        Me.txtCedulaJuridica = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCedulaJuridica = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtContacto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblContacto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTelefono1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTelefono1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTelefono2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblEmail = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmailContacto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblEmailContacto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDireccion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDireccion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kchbxInsercionMultiple = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtTelefono2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ktxtCodInterno = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.klblCodInterno = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
        Me.grbContainer.Panel.Controls.Add(Me.ktxtCodInterno)
        Me.grbContainer.Panel.Controls.Add(Me.klblCodInterno)
        Me.grbContainer.Panel.Controls.Add(Me.txtTelefono2)
        Me.grbContainer.Panel.Controls.Add(Me.kchbxInsercionMultiple)
        Me.grbContainer.Panel.Controls.Add(Me.txtDireccion)
        Me.grbContainer.Panel.Controls.Add(Me.lblDireccion)
        Me.grbContainer.Panel.Controls.Add(Me.txtEmailContacto)
        Me.grbContainer.Panel.Controls.Add(Me.lblEmailContacto)
        Me.grbContainer.Panel.Controls.Add(Me.txtEmail)
        Me.grbContainer.Panel.Controls.Add(Me.lblEmail)
        Me.grbContainer.Panel.Controls.Add(Me.lblTelefono2)
        Me.grbContainer.Panel.Controls.Add(Me.txtTelefono1)
        Me.grbContainer.Panel.Controls.Add(Me.lblTelefono1)
        Me.grbContainer.Panel.Controls.Add(Me.txtContacto)
        Me.grbContainer.Panel.Controls.Add(Me.lblContacto)
        Me.grbContainer.Panel.Controls.Add(Me.txtCedulaJuridica)
        Me.grbContainer.Panel.Controls.Add(Me.lblCedulaJuridica)
        Me.grbContainer.Panel.Controls.Add(Me.txtNombre)
        Me.grbContainer.Panel.Controls.Add(Me.lblNombre)
        Me.grbContainer.Size = New System.Drawing.Size(406, 459)
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
        'txtCedulaJuridica
        '
        Me.txtCedulaJuridica.Location = New System.Drawing.Point(144, 139)
        Me.txtCedulaJuridica.Name = "txtCedulaJuridica"
        Me.txtCedulaJuridica.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtCedulaJuridica.Size = New System.Drawing.Size(234, 20)
        Me.txtCedulaJuridica.TabIndex = 9
        '
        'lblCedulaJuridica
        '
        Me.lblCedulaJuridica.Location = New System.Drawing.Point(43, 139)
        Me.lblCedulaJuridica.Name = "lblCedulaJuridica"
        Me.lblCedulaJuridica.Size = New System.Drawing.Size(95, 20)
        Me.lblCedulaJuridica.TabIndex = 8
        Me.lblCedulaJuridica.Values.Text = "Cédula Jurídica:"
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(144, 165)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtContacto.Size = New System.Drawing.Size(234, 20)
        Me.txtContacto.TabIndex = 11
        '
        'lblContacto
        '
        Me.lblContacto.Location = New System.Drawing.Point(75, 165)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(63, 20)
        Me.lblContacto.TabIndex = 10
        Me.lblContacto.Values.Text = "Contacto:"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(144, 191)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtTelefono1.Size = New System.Drawing.Size(234, 20)
        Me.txtTelefono1.TabIndex = 13
        '
        'lblTelefono1
        '
        Me.lblTelefono1.Location = New System.Drawing.Point(67, 191)
        Me.lblTelefono1.Name = "lblTelefono1"
        Me.lblTelefono1.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono1.TabIndex = 12
        Me.lblTelefono1.Values.Text = "Teléfono 1:"
        '
        'lblTelefono2
        '
        Me.lblTelefono2.Location = New System.Drawing.Point(67, 217)
        Me.lblTelefono2.Name = "lblTelefono2"
        Me.lblTelefono2.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono2.TabIndex = 14
        Me.lblTelefono2.Values.Text = "Teléfono 2:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(144, 243)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtEmail.Size = New System.Drawing.Size(234, 20)
        Me.txtEmail.TabIndex = 17
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(96, 243)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 20)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Values.Text = "Email:"
        '
        'txtEmailContacto
        '
        Me.txtEmailContacto.Location = New System.Drawing.Point(144, 269)
        Me.txtEmailContacto.Name = "txtEmailContacto"
        Me.txtEmailContacto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtEmailContacto.Size = New System.Drawing.Size(234, 20)
        Me.txtEmailContacto.TabIndex = 19
        '
        'lblEmailContacto
        '
        Me.lblEmailContacto.Location = New System.Drawing.Point(43, 269)
        Me.lblEmailContacto.Name = "lblEmailContacto"
        Me.lblEmailContacto.Size = New System.Drawing.Size(95, 20)
        Me.lblEmailContacto.TabIndex = 18
        Me.lblEmailContacto.Values.Text = "Email Contacto:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(145, 321)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtDireccion.Size = New System.Drawing.Size(234, 57)
        Me.txtDireccion.TabIndex = 21
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(75, 321)
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
        Me.kchbxInsercionMultiple.Location = New System.Drawing.Point(44, 384)
        Me.kchbxInsercionMultiple.Name = "kchbxInsercionMultiple"
        Me.kchbxInsercionMultiple.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.kchbxInsercionMultiple.Size = New System.Drawing.Size(121, 20)
        Me.kchbxInsercionMultiple.TabIndex = 22
        Me.kchbxInsercionMultiple.Text = "Inserción Múltiple"
        Me.kchbxInsercionMultiple.Values.Text = "Inserción Múltiple"
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(144, 217)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtTelefono2.Size = New System.Drawing.Size(234, 20)
        Me.txtTelefono2.TabIndex = 14
        '
        'ktxtCodInterno
        '
        Me.ktxtCodInterno.Location = New System.Drawing.Point(144, 295)
        Me.ktxtCodInterno.Name = "ktxtCodInterno"
        Me.ktxtCodInterno.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.ktxtCodInterno.Size = New System.Drawing.Size(234, 20)
        Me.ktxtCodInterno.TabIndex = 24
        '
        'klblCodInterno
        '
        Me.klblCodInterno.Location = New System.Drawing.Point(57, 295)
        Me.klblCodInterno.Name = "klblCodInterno"
        Me.klblCodInterno.Size = New System.Drawing.Size(81, 20)
        Me.klblCodInterno.TabIndex = 23
        Me.klblCodInterno.Values.Text = "Cod. Interno:"
        '
        'frmActualizaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 459)
        Me.MinimizeBox = False
        Me.Name = "frmActualizaProveedor"
        Me.Text = "Insertar Proveedor"
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
    Friend WithEvents txtEmailContacto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblEmailContacto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblEmail As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTelefono2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTelefono1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTelefono1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtContacto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblContacto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCedulaJuridica As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCedulaJuridica As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kchbxInsercionMultiple As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtTelefono2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ktxtCodInterno As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents klblCodInterno As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
