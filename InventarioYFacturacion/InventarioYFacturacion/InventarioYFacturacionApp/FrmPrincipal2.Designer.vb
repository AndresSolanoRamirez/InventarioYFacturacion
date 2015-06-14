<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormApplication))
        Me.panelContenedor = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kscLateral = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.kgbPanelIzquierdo = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.kbtnVerOtrasConfig = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtnVerClientes = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtnVerUsuarios = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtnVerProcedores = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtnVerProdutos = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnGenerarProforma = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.khTitulo = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.kscControles = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.kbtnDesloggear = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.klblNombreUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klblUsuario = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.CtlClientes1 = New InventarioYFacturacionApp.ctlClientes()
        Me.CtrlMarcas1 = New InventarioYFacturacionApp.ctrlMarcas()
        Me.CtlUsuarios1 = New InventarioYFacturacionApp.ctlUsuarios()
        Me.CtlUnidadMedida1 = New InventarioYFacturacionApp.ctlUnidadMedida()
        Me.CtlSubFamilias1 = New InventarioYFacturacionApp.ctlSubFamilias()
        Me.CtlRoles1 = New InventarioYFacturacionApp.ctlRoles()
        Me.CtlProveedores1 = New InventarioYFacturacionApp.ctlProveedores()
        Me.CtlProducto1 = New InventarioYFacturacionApp.ctlProducto()
        Me.CtlPermisos1 = New InventarioYFacturacionApp.ctlPermisos()
        Me.CtlParametros1 = New InventarioYFacturacionApp.ctlParametros()
        Me.CtlFamilias1 = New InventarioYFacturacionApp.ctlFamilias()
        CType(Me.panelContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenedor.SuspendLayout()
        CType(Me.kscLateral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscLateral.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscLateral.Panel1.SuspendLayout()
        CType(Me.kscLateral.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscLateral.Panel2.SuspendLayout()
        Me.kscLateral.SuspendLayout()
        CType(Me.kgbPanelIzquierdo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgbPanelIzquierdo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgbPanelIzquierdo.Panel.SuspendLayout()
        Me.kgbPanelIzquierdo.SuspendLayout()
        CType(Me.kscControles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kscControles.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscControles.Panel1.SuspendLayout()
        CType(Me.kscControles.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kscControles.Panel2.SuspendLayout()
        Me.kscControles.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.Controls.Add(Me.kscLateral)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 138)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.panelContenedor.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.panelContenedor.Size = New System.Drawing.Size(1248, 369)
        Me.panelContenedor.TabIndex = 1
        '
        'kscLateral
        '
        Me.kscLateral.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscLateral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscLateral.Location = New System.Drawing.Point(0, 0)
        Me.kscLateral.Name = "kscLateral"
        '
        'kscLateral.Panel1
        '
        Me.kscLateral.Panel1.Controls.Add(Me.kgbPanelIzquierdo)
        '
        'kscLateral.Panel2
        '
        Me.kscLateral.Panel2.Controls.Add(Me.kscControles)
        Me.kscLateral.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.kscLateral.Size = New System.Drawing.Size(1248, 369)
        Me.kscLateral.SplitterDistance = 135
        Me.kscLateral.TabIndex = 0
        '
        'kgbPanelIzquierdo
        '
        Me.kgbPanelIzquierdo.CaptionVisible = False
        Me.kgbPanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgbPanelIzquierdo.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kgbPanelIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.kgbPanelIzquierdo.Name = "kgbPanelIzquierdo"
        Me.kgbPanelIzquierdo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        '
        'kgbPanelIzquierdo.Panel
        '
        Me.kgbPanelIzquierdo.Panel.Controls.Add(Me.kbtnVerOtrasConfig)
        Me.kgbPanelIzquierdo.Panel.Controls.Add(Me.kbtnVerClientes)
        Me.kgbPanelIzquierdo.Panel.Controls.Add(Me.kbtnVerUsuarios)
        Me.kgbPanelIzquierdo.Panel.Controls.Add(Me.kbtnVerProcedores)
        Me.kgbPanelIzquierdo.Panel.Controls.Add(Me.kbtnVerProdutos)
        Me.kgbPanelIzquierdo.Panel.Controls.Add(Me.btnGenerarProforma)
        Me.kgbPanelIzquierdo.Panel.Controls.Add(Me.khTitulo)
        Me.kgbPanelIzquierdo.Size = New System.Drawing.Size(135, 369)
        Me.kgbPanelIzquierdo.TabIndex = 0
        Me.kgbPanelIzquierdo.Text = "Caption"
        '
        'kbtnVerOtrasConfig
        '
        Me.kbtnVerOtrasConfig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnVerOtrasConfig.Location = New System.Drawing.Point(3, 259)
        Me.kbtnVerOtrasConfig.Name = "kbtnVerOtrasConfig"
        Me.kbtnVerOtrasConfig.Size = New System.Drawing.Size(125, 40)
        Me.kbtnVerOtrasConfig.TabIndex = 6
        Me.kbtnVerOtrasConfig.Values.Text = "+ Configuraciones"
        '
        'kbtnVerClientes
        '
        Me.kbtnVerClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnVerClientes.Location = New System.Drawing.Point(3, 213)
        Me.kbtnVerClientes.Name = "kbtnVerClientes"
        Me.kbtnVerClientes.Size = New System.Drawing.Size(125, 40)
        Me.kbtnVerClientes.TabIndex = 5
        Me.kbtnVerClientes.Values.Text = "Ver Clientes"
        '
        'kbtnVerUsuarios
        '
        Me.kbtnVerUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnVerUsuarios.Location = New System.Drawing.Point(3, 167)
        Me.kbtnVerUsuarios.Name = "kbtnVerUsuarios"
        Me.kbtnVerUsuarios.Size = New System.Drawing.Size(125, 40)
        Me.kbtnVerUsuarios.TabIndex = 4
        Me.kbtnVerUsuarios.Values.Text = "Ver Usuarios"
        '
        'kbtnVerProcedores
        '
        Me.kbtnVerProcedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnVerProcedores.Location = New System.Drawing.Point(3, 121)
        Me.kbtnVerProcedores.Name = "kbtnVerProcedores"
        Me.kbtnVerProcedores.Size = New System.Drawing.Size(125, 40)
        Me.kbtnVerProcedores.TabIndex = 3
        Me.kbtnVerProcedores.Values.Text = "Ver Proveedores"
        '
        'kbtnVerProdutos
        '
        Me.kbtnVerProdutos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnVerProdutos.Location = New System.Drawing.Point(3, 75)
        Me.kbtnVerProdutos.Name = "kbtnVerProdutos"
        Me.kbtnVerProdutos.Size = New System.Drawing.Size(125, 40)
        Me.kbtnVerProdutos.TabIndex = 2
        Me.kbtnVerProdutos.Values.Text = "Ver Productos"
        '
        'btnGenerarProforma
        '
        Me.btnGenerarProforma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarProforma.Location = New System.Drawing.Point(3, 29)
        Me.btnGenerarProforma.Name = "btnGenerarProforma"
        Me.btnGenerarProforma.Size = New System.Drawing.Size(125, 40)
        Me.btnGenerarProforma.TabIndex = 1
        Me.btnGenerarProforma.Values.Text = "Generar Proforma"
        '
        'khTitulo
        '
        Me.khTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.khTitulo.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.khTitulo.Location = New System.Drawing.Point(0, 0)
        Me.khTitulo.Name = "khTitulo"
        Me.khTitulo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.khTitulo.Size = New System.Drawing.Size(131, 22)
        Me.khTitulo.TabIndex = 0
        Me.khTitulo.Values.Description = ""
        Me.khTitulo.Values.Heading = "Favoritos"
        Me.khTitulo.Values.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.star_16
        '
        'kscControles
        '
        Me.kscControles.Cursor = System.Windows.Forms.Cursors.Default
        Me.kscControles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kscControles.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.kscControles.Location = New System.Drawing.Point(0, 0)
        Me.kscControles.Name = "kscControles"
        Me.kscControles.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kscControles.Panel1
        '
        Me.kscControles.Panel1.Controls.Add(Me.PictureBox1)
        Me.kscControles.Panel1.Controls.Add(Me.kbtnDesloggear)
        Me.kscControles.Panel1.Controls.Add(Me.klblNombreUsuario)
        Me.kscControles.Panel1.Controls.Add(Me.klblUsuario)
        Me.kscControles.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        '
        'kscControles.Panel2
        '
        Me.kscControles.Panel2.Controls.Add(Me.CtlClientes1)
        Me.kscControles.Panel2.Controls.Add(Me.CtrlMarcas1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlUsuarios1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlUnidadMedida1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlSubFamilias1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlRoles1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlProveedores1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlProducto1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlPermisos1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlParametros1)
        Me.kscControles.Panel2.Controls.Add(Me.CtlFamilias1)
        Me.kscControles.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.kscControles.Size = New System.Drawing.Size(1108, 369)
        Me.kscControles.SplitterDistance = 33
        Me.kscControles.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.contacts_24
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'kbtnDesloggear
        '
        Me.kbtnDesloggear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnDesloggear.Location = New System.Drawing.Point(996, 5)
        Me.kbtnDesloggear.Name = "kbtnDesloggear"
        Me.kbtnDesloggear.Size = New System.Drawing.Size(109, 25)
        Me.kbtnDesloggear.TabIndex = 2
        Me.kbtnDesloggear.Values.Text = "Finalizar Sesión"
        '
        'klblNombreUsuario
        '
        Me.klblNombreUsuario.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption
        Me.klblNombreUsuario.Location = New System.Drawing.Point(87, 8)
        Me.klblNombreUsuario.Name = "klblNombreUsuario"
        Me.klblNombreUsuario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.klblNombreUsuario.Size = New System.Drawing.Size(98, 22)
        Me.klblNombreUsuario.TabIndex = 1
        Me.klblNombreUsuario.Values.Text = "Usuario actual"
        '
        'klblUsuario
        '
        Me.klblUsuario.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl
        Me.klblUsuario.Location = New System.Drawing.Point(36, 8)
        Me.klblUsuario.Name = "klblUsuario"
        Me.klblUsuario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.klblUsuario.Size = New System.Drawing.Size(54, 20)
        Me.klblUsuario.TabIndex = 0
        Me.klblUsuario.Values.Text = "Usuario:"
        '
        'CtlClientes1
        '
        Me.CtlClientes1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlClientes1.Location = New System.Drawing.Point(0, 0)
        Me.CtlClientes1.Name = "CtlClientes1"
        Me.CtlClientes1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlClientes1.TabIndex = 10
        '
        'CtrlMarcas1
        '
        Me.CtrlMarcas1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlMarcas1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlMarcas1.Name = "CtrlMarcas1"
        Me.CtrlMarcas1.Size = New System.Drawing.Size(1108, 331)
        Me.CtrlMarcas1.TabIndex = 9
        '
        'CtlUsuarios1
        '
        Me.CtlUsuarios1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlUsuarios1.Location = New System.Drawing.Point(0, 0)
        Me.CtlUsuarios1.Name = "CtlUsuarios1"
        Me.CtlUsuarios1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlUsuarios1.TabIndex = 8
        '
        'CtlUnidadMedida1
        '
        Me.CtlUnidadMedida1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlUnidadMedida1.Location = New System.Drawing.Point(0, 0)
        Me.CtlUnidadMedida1.Name = "CtlUnidadMedida1"
        Me.CtlUnidadMedida1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlUnidadMedida1.TabIndex = 7
        '
        'CtlSubFamilias1
        '
        Me.CtlSubFamilias1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlSubFamilias1.Location = New System.Drawing.Point(0, 0)
        Me.CtlSubFamilias1.Name = "CtlSubFamilias1"
        Me.CtlSubFamilias1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlSubFamilias1.TabIndex = 6
        '
        'CtlRoles1
        '
        Me.CtlRoles1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlRoles1.Location = New System.Drawing.Point(0, 0)
        Me.CtlRoles1.Name = "CtlRoles1"
        Me.CtlRoles1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlRoles1.TabIndex = 5
        '
        'CtlProveedores1
        '
        Me.CtlProveedores1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlProveedores1.Location = New System.Drawing.Point(0, 0)
        Me.CtlProveedores1.Name = "CtlProveedores1"
        Me.CtlProveedores1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlProveedores1.TabIndex = 4
        '
        'CtlProducto1
        '
        Me.CtlProducto1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlProducto1.Location = New System.Drawing.Point(0, 0)
        Me.CtlProducto1.Name = "CtlProducto1"
        Me.CtlProducto1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlProducto1.TabIndex = 3
        '
        'CtlPermisos1
        '
        Me.CtlPermisos1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlPermisos1.Location = New System.Drawing.Point(0, 0)
        Me.CtlPermisos1.Name = "CtlPermisos1"
        Me.CtlPermisos1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlPermisos1.TabIndex = 2
        '
        'CtlParametros1
        '
        Me.CtlParametros1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlParametros1.Location = New System.Drawing.Point(0, 0)
        Me.CtlParametros1.Name = "CtlParametros1"
        Me.CtlParametros1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlParametros1.TabIndex = 1
        '
        'CtlFamilias1
        '
        Me.CtlFamilias1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlFamilias1.Location = New System.Drawing.Point(0, 0)
        Me.CtlFamilias1.Name = "CtlFamilias1"
        Me.CtlFamilias1.Size = New System.Drawing.Size(1108, 331)
        Me.CtlFamilias1.TabIndex = 0
        '
        'FormApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 507)
        Me.Controls.Add(Me.panelContenedor)
        Me.Name = "FormApplication"
        Me.Text = "Inventario y Facturación Céspedes"
        CType(Me.panelContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenedor.ResumeLayout(False)
        CType(Me.kscLateral.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscLateral.Panel1.ResumeLayout(False)
        CType(Me.kscLateral.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscLateral.Panel2.ResumeLayout(False)
        CType(Me.kscLateral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscLateral.ResumeLayout(False)
        CType(Me.kgbPanelIzquierdo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbPanelIzquierdo.Panel.ResumeLayout(False)
        Me.kgbPanelIzquierdo.Panel.PerformLayout()
        CType(Me.kgbPanelIzquierdo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbPanelIzquierdo.ResumeLayout(False)
        CType(Me.kscControles.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscControles.Panel1.ResumeLayout(False)
        Me.kscControles.Panel1.PerformLayout()
        CType(Me.kscControles.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscControles.Panel2.ResumeLayout(False)
        CType(Me.kscControles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kscControles.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenedor As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents kscLateral As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kscControles As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents CtrlMarcas1 As InventarioYFacturacionApp.ctrlMarcas
    Friend WithEvents CtlUsuarios1 As InventarioYFacturacionApp.ctlUsuarios
    Friend WithEvents CtlUnidadMedida1 As InventarioYFacturacionApp.ctlUnidadMedida
    Friend WithEvents CtlSubFamilias1 As InventarioYFacturacionApp.ctlSubFamilias
    Friend WithEvents CtlRoles1 As InventarioYFacturacionApp.ctlRoles
    Friend WithEvents CtlProveedores1 As InventarioYFacturacionApp.ctlProveedores
    Friend WithEvents CtlProducto1 As InventarioYFacturacionApp.ctlProducto
    Friend WithEvents CtlPermisos1 As InventarioYFacturacionApp.ctlPermisos
    Friend WithEvents CtlParametros1 As InventarioYFacturacionApp.ctlParametros
    Friend WithEvents CtlFamilias1 As InventarioYFacturacionApp.ctlFamilias
    Friend WithEvents kgbPanelIzquierdo As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents khTitulo As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents kbtnDesloggear As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents klblNombreUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klblUsuario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGenerarProforma As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnVerProdutos As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents CtlClientes1 As InventarioYFacturacionApp.ctlClientes
    Friend WithEvents kbtnVerOtrasConfig As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnVerClientes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnVerUsuarios As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnVerProcedores As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class