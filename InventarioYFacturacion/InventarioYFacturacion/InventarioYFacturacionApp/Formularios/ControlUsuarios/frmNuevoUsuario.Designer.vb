<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoUsuario
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
        Me.txtTelefono = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTelefono = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCorreoElectronico = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCorreoElectronico = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtContrasena = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblContrasena = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtRContrasena = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblRContrasena = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPSeguridad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPreguntaSeguridad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtRespuesta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblRespuesta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
        Me.grbContainer.Panel.Controls.Add(Me.txtRespuesta)
        Me.grbContainer.Panel.Controls.Add(Me.lblRespuesta)
        Me.grbContainer.Panel.Controls.Add(Me.txtPSeguridad)
        Me.grbContainer.Panel.Controls.Add(Me.lblPreguntaSeguridad)
        Me.grbContainer.Panel.Controls.Add(Me.txtRContrasena)
        Me.grbContainer.Panel.Controls.Add(Me.lblRContrasena)
        Me.grbContainer.Panel.Controls.Add(Me.txtContrasena)
        Me.grbContainer.Panel.Controls.Add(Me.lblContrasena)
        Me.grbContainer.Panel.Controls.Add(Me.txtCorreoElectronico)
        Me.grbContainer.Panel.Controls.Add(Me.lblCorreoElectronico)
        Me.grbContainer.Panel.Controls.Add(Me.txtTelefono)
        Me.grbContainer.Panel.Controls.Add(Me.lblTelefono)
        Me.grbContainer.Panel.Controls.Add(Me.txtApellidos)
        Me.grbContainer.Panel.Controls.Add(Me.lblApellidos)
        Me.grbContainer.Panel.Controls.Add(Me.txtNombre)
        Me.grbContainer.Panel.Controls.Add(Me.lblNombre)
        Me.grbContainer.Size = New System.Drawing.Size(406, 376)
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
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(144, 165)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtTelefono.Size = New System.Drawing.Size(234, 20)
        Me.txtTelefono.TabIndex = 11
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(77, 165)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 20)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Values.Text = "Teléfono:"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(144, 191)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(234, 20)
        Me.txtCorreoElectronico.TabIndex = 13
        '
        'lblCorreoElectronico
        '
        Me.lblCorreoElectronico.Location = New System.Drawing.Point(24, 191)
        Me.lblCorreoElectronico.Name = "lblCorreoElectronico"
        Me.lblCorreoElectronico.Size = New System.Drawing.Size(114, 20)
        Me.lblCorreoElectronico.TabIndex = 12
        Me.lblCorreoElectronico.Values.Text = "Correo Electrónico:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(144, 217)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContrasena.Size = New System.Drawing.Size(234, 20)
        Me.txtContrasena.TabIndex = 15
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'lblContrasena
        '
        Me.lblContrasena.Location = New System.Drawing.Point(63, 217)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(75, 20)
        Me.lblContrasena.TabIndex = 14
        Me.lblContrasena.Values.Text = "Contraseña:"
        '
        'txtRContrasena
        '
        Me.txtRContrasena.Location = New System.Drawing.Point(144, 243)
        Me.txtRContrasena.Name = "txtRContrasena"
        Me.txtRContrasena.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtRContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRContrasena.Size = New System.Drawing.Size(234, 20)
        Me.txtRContrasena.TabIndex = 17
        '
        'lblRContrasena
        '
        Me.lblRContrasena.Location = New System.Drawing.Point(21, 243)
        Me.lblRContrasena.Name = "lblRContrasena"
        Me.lblRContrasena.Size = New System.Drawing.Size(117, 20)
        Me.lblRContrasena.TabIndex = 16
        Me.lblRContrasena.Values.Text = "Repetir Contraseña:"
        '
        'txtPSeguridad
        '
        Me.txtPSeguridad.Location = New System.Drawing.Point(144, 269)
        Me.txtPSeguridad.Name = "txtPSeguridad"
        Me.txtPSeguridad.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtPSeguridad.Size = New System.Drawing.Size(234, 20)
        Me.txtPSeguridad.TabIndex = 19
        '
        'lblPreguntaSeguridad
        '
        Me.lblPreguntaSeguridad.Location = New System.Drawing.Point(1, 269)
        Me.lblPreguntaSeguridad.Name = "lblPreguntaSeguridad"
        Me.lblPreguntaSeguridad.Size = New System.Drawing.Size(137, 20)
        Me.lblPreguntaSeguridad.TabIndex = 18
        Me.lblPreguntaSeguridad.Values.Text = "Pregunta de seguridad:"
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(144, 295)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtRespuesta.Size = New System.Drawing.Size(234, 20)
        Me.txtRespuesta.TabIndex = 21
        '
        'lblRespuesta
        '
        Me.lblRespuesta.Location = New System.Drawing.Point(69, 295)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(69, 20)
        Me.lblRespuesta.TabIndex = 20
        Me.lblRespuesta.Values.Text = "Respuesta:"
        '
        'frmNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 376)
        Me.MinimizeBox = False
        Me.Name = "frmNuevoUsuario"
        Me.Text = "Acciones sobre Usuarios"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        Me.grbContainer.Panel.PerformLayout()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRespuesta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRespuesta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPSeguridad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPreguntaSeguridad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRContrasena As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRContrasena As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtContrasena As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblContrasena As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCorreoElectronico As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCorreoElectronico As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTelefono As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTelefono As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtApellidos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblApellidos As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
