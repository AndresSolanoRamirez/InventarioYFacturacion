<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblNombreUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblContrasena = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNombreUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPass = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lnklblOlvidoContrasena = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLinkLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
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
        Me.grbContainer.Panel.Controls.Add(Me.KryptonLinkLabel1)
        Me.grbContainer.Panel.Controls.Add(Me.lnklblOlvidoContrasena)
        Me.grbContainer.Panel.Controls.Add(Me.txtPass)
        Me.grbContainer.Panel.Controls.Add(Me.txtNombreUsuario)
        Me.grbContainer.Panel.Controls.Add(Me.lblContrasena)
        Me.grbContainer.Panel.Controls.Add(Me.lblNombreUsuario)
        Me.grbContainer.Size = New System.Drawing.Size(401, 238)
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.Location = New System.Drawing.Point(18, 113)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(120, 20)
        Me.lblNombreUsuario.TabIndex = 3
        Me.lblNombreUsuario.Values.Text = "Nombre de Usuario:"
        '
        'lblContrasena
        '
        Me.lblContrasena.Location = New System.Drawing.Point(63, 139)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(75, 20)
        Me.lblContrasena.TabIndex = 4
        Me.lblContrasena.Values.Text = "Contraseña:"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(144, 113)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNombreUsuario.Size = New System.Drawing.Size(234, 20)
        Me.txtNombreUsuario.TabIndex = 5
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(144, 139)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(234, 20)
        Me.txtPass.TabIndex = 6
        Me.txtPass.UseSystemPasswordChar = True
        '
        'lnklblOlvidoContrasena
        '
        Me.lnklblOlvidoContrasena.Location = New System.Drawing.Point(257, 166)
        Me.lnklblOlvidoContrasena.Name = "lnklblOlvidoContrasena"
        Me.lnklblOlvidoContrasena.Size = New System.Drawing.Size(131, 20)
        Me.lnklblOlvidoContrasena.TabIndex = 7
        Me.lnklblOlvidoContrasena.Values.Text = "Olvidó su contraseña?"
        '
        'KryptonLinkLabel1
        '
        Me.KryptonLinkLabel1.Location = New System.Drawing.Point(180, 166)
        Me.KryptonLinkLabel1.Name = "KryptonLinkLabel1"
        Me.KryptonLinkLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.KryptonLinkLabel1.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLinkLabel1.TabIndex = 8
        Me.KryptonLinkLabel1.Values.Text = "Registrarse"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 238)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        Me.grbContainer.Panel.PerformLayout()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblContrasena As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNombreUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPass As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNombreUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLinkLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents lnklblOlvidoContrasena As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
End Class
