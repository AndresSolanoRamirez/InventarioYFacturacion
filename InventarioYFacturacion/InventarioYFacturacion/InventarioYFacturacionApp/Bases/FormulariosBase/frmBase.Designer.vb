<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Me.components = New System.ComponentModel.Container()
        Me.grbContainer = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.lblEncabezado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.pBoxEncabezado = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.pBoxEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grbContainer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.btnAceptar)
        Me.grbContainer.Panel.Controls.Add(Me.btnCancelar)
        Me.grbContainer.Panel.Controls.Add(Me.KryptonGroupBox1)
        Me.grbContainer.Size = New System.Drawing.Size(445, 414)
        Me.grbContainer.TabIndex = 1
        Me.grbContainer.Text = "Caption"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(247, 377)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(343, 377)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionVisible = False
        Me.KryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabDockAutoHidden
        Me.KryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.TabDockAutoHidden
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        Me.KryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblEncabezado)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.pBoxEncabezado)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(445, 93)
        Me.KryptonGroupBox1.TabIndex = 0
        Me.KryptonGroupBox1.Text = "Caption"
        '
        'lblEncabezado
        '
        Me.lblEncabezado.Location = New System.Drawing.Point(108, 40)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.lblEncabezado.Size = New System.Drawing.Size(89, 20)
        Me.lblEncabezado.TabIndex = 1
        Me.lblEncabezado.Values.Text = "KryptonLabel1"
        '
        'pBoxEncabezado
        '
        Me.pBoxEncabezado.BackColor = System.Drawing.Color.Transparent
        Me.pBoxEncabezado.Location = New System.Drawing.Point(17, 11)
        Me.pBoxEncabezado.Name = "pBoxEncabezado"
        Me.pBoxEncabezado.Size = New System.Drawing.Size(85, 78)
        Me.pBoxEncabezado.TabIndex = 0
        Me.pBoxEncabezado.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 414)
        Me.Controls.Add(Me.grbContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBase"
        Me.Text = "frmBase"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.pBoxEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents lblEncabezado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pBoxEncabezado As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Public WithEvents grbContainer As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
