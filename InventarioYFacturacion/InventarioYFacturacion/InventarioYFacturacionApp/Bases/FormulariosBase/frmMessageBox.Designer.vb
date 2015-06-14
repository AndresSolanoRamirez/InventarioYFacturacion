<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBox
    Inherits System.Windows.Forms.Form

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
        Me.grbContainer = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ktxtDestalle = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.kbtnDetalles = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnOk = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblMensaje = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbContainer
        '
        Me.grbContainer.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl
        Me.grbContainer.CaptionVisible = False
        Me.grbContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbContainer.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonNavigatorStack
        Me.grbContainer.Location = New System.Drawing.Point(0, 0)
        Me.grbContainer.Name = "grbContainer"
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.ktxtDestalle)
        Me.grbContainer.Panel.Controls.Add(Me.kbtnDetalles)
        Me.grbContainer.Panel.Controls.Add(Me.btnOk)
        Me.grbContainer.Panel.Controls.Add(Me.btnAceptar)
        Me.grbContainer.Panel.Controls.Add(Me.btnCancelar)
        Me.grbContainer.Panel.Controls.Add(Me.lblMensaje)
        Me.grbContainer.Panel.Controls.Add(Me.pbxImagen)
        Me.grbContainer.Size = New System.Drawing.Size(488, 153)
        Me.grbContainer.TabIndex = 0
        Me.grbContainer.Text = "Caption"
        '
        'ktxtDestalle
        '
        Me.ktxtDestalle.Location = New System.Drawing.Point(20, 141)
        Me.ktxtDestalle.Multiline = True
        Me.ktxtDestalle.Name = "ktxtDestalle"
        Me.ktxtDestalle.Size = New System.Drawing.Size(456, 233)
        Me.ktxtDestalle.TabIndex = 600
        Me.ktxtDestalle.Text = "KryptonTextBox1"
        Me.ktxtDestalle.Visible = False
        '
        'kbtnDetalles
        '
        Me.kbtnDetalles.Location = New System.Drawing.Point(20, 102)
        Me.kbtnDetalles.Name = "kbtnDetalles"
        Me.kbtnDetalles.Size = New System.Drawing.Size(90, 27)
        Me.kbtnDetalles.TabIndex = 5
        Me.kbtnDetalles.Values.Text = "Detalles >>"
        Me.kbtnDetalles.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(194, 117)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 25)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Values.Text = "Ok"
        Me.btnOk.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(290, 117)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Values.Text = "Aceptar"
        Me.btnAceptar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(386, 117)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Values.Text = "Cancelar"
        Me.btnCancelar.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(91, 37)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.lblMensaje.Size = New System.Drawing.Size(89, 20)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Values.Text = "KryptonLabel1"
        '
        'pbxImagen
        '
        Me.pbxImagen.BackColor = System.Drawing.Color.Transparent
        Me.pbxImagen.BackgroundImage = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_64
        Me.pbxImagen.Location = New System.Drawing.Point(20, 24)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(65, 64)
        Me.pbxImagen.TabIndex = 0
        Me.pbxImagen.TabStop = False
        '
        'frmMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 153)
        Me.Controls.Add(Me.grbContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMessageBox"
        Me.Text = "Mensaje"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        Me.grbContainer.Panel.PerformLayout()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbContainer As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents pbxImagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOk As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblMensaje As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtDestalle As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kbtnDetalles As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
