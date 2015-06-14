<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormApplication
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
        Me.rInventarioYFacturacion = New System.Windows.Forms.Ribbon()
        Me.rOrbMenuItemFacturacion = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem1 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem2 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.rbtnMantenimientoUsuarios = New System.Windows.Forms.RibbonButton()
        Me.rbtnMantenimientoProductos = New System.Windows.Forms.RibbonButton()
        Me.rbtnMantenimientoProveedores = New System.Windows.Forms.RibbonButton()
        Me.rbtnMantenimientoClientaes = New System.Windows.Forms.RibbonButton()
        Me.rbtnOtrosMantenimientos = New System.Windows.Forms.RibbonButton()
        Me.roopbtnCerrar = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.tabFacturacion = New System.Windows.Forms.RibbonTab()
        Me.tabInventario = New System.Windows.Forms.RibbonTab()
        Me.tabMantenimiento = New System.Windows.Forms.RibbonTab()
        Me.rPanelUsuario = New System.Windows.Forms.RibbonPanel()
        Me.btnNuevo = New System.Windows.Forms.RibbonButton()
        Me.btnEditar = New System.Windows.Forms.RibbonButton()
        Me.btnEliminar = New System.Windows.Forms.RibbonButton()
        Me.rbtnActivar = New System.Windows.Forms.RibbonButton()
        Me.rbtnAsignaciones = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator4 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarUsuarios = New System.Windows.Forms.RibbonButton()
        Me.tabMantenimientoProductos = New System.Windows.Forms.RibbonTab()
        Me.rpAcciones = New System.Windows.Forms.RibbonPanel()
        Me.rbtnNuevoProducto = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarProducto = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminar = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator3 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarProducto = New System.Windows.Forms.RibbonButton()
        Me.rpDatos = New System.Windows.Forms.RibbonPanel()
        Me.rbtnGenerarPlantilla = New System.Windows.Forms.RibbonButton()
        Me.rbtnImportarProductos = New System.Windows.Forms.RibbonButton()
        Me.rbtnExportarProductos = New System.Windows.Forms.RibbonButton()
        Me.tabRoles = New System.Windows.Forms.RibbonTab()
        Me.rpAcionesRoles = New System.Windows.Forms.RibbonPanel()
        Me.btnAgregarRoles = New System.Windows.Forms.RibbonButton()
        Me.btnEditarRoles = New System.Windows.Forms.RibbonButton()
        Me.btnElimarRoles = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator5 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarRoles = New System.Windows.Forms.RibbonButton()
        Me.tabPermisos = New System.Windows.Forms.RibbonTab()
        Me.rpAccionesPermisos = New System.Windows.Forms.RibbonPanel()
        Me.rbtnAgregarPermiso = New System.Windows.Forms.RibbonButton()
        Me.btnEditarPermiso = New System.Windows.Forms.RibbonButton()
        Me.btnEliminarPermiso = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator6 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarPermisos = New System.Windows.Forms.RibbonButton()
        Me.tabMarcas = New System.Windows.Forms.RibbonTab()
        Me.rpAccionesMarcas = New System.Windows.Forms.RibbonPanel()
        Me.rbtnNuevaMarca = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarMarca = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminarMarca = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator7 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarMarcas = New System.Windows.Forms.RibbonButton()
        Me.tabFamilias = New System.Windows.Forms.RibbonTab()
        Me.rpAccionesFamilias = New System.Windows.Forms.RibbonPanel()
        Me.rbtnInsertarFamilia = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarFamilia = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminarFamilia = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator8 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarFamilias = New System.Windows.Forms.RibbonButton()
        Me.rpDatosFamilias = New System.Windows.Forms.RibbonPanel()
        Me.rbtnGenerarPlantillaFamilias = New System.Windows.Forms.RibbonButton()
        Me.rbtnImportarFamilias = New System.Windows.Forms.RibbonButton()
        Me.rbtnExportarFamilias = New System.Windows.Forms.RibbonButton()
        Me.tabSubFamilias = New System.Windows.Forms.RibbonTab()
        Me.rpAccionesSubFamilias = New System.Windows.Forms.RibbonPanel()
        Me.rbtnInsertarSubFamilia = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarSubFamilia = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminarSubFamilia = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator9 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarSubFamilias = New System.Windows.Forms.RibbonButton()
        Me.rpDatosSubFamilia = New System.Windows.Forms.RibbonPanel()
        Me.rbtnGenerarPlantillaSubFamilias = New System.Windows.Forms.RibbonButton()
        Me.rbtnImportarSubFamilias = New System.Windows.Forms.RibbonButton()
        Me.rbtnExportarSubFamilias = New System.Windows.Forms.RibbonButton()
        Me.tabUnidadesMedidas = New System.Windows.Forms.RibbonTab()
        Me.rpAccionesUnidadesMedidas = New System.Windows.Forms.RibbonPanel()
        Me.rbtnNuevo = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarUnidadMedida = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminarUnidadMedida = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator10 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarUndMedida = New System.Windows.Forms.RibbonButton()
        Me.rpDatosUndMedida = New System.Windows.Forms.RibbonPanel()
        Me.rbtnGenerarPlantillaUndMedida = New System.Windows.Forms.RibbonButton()
        Me.rbtnImportarUndMedida = New System.Windows.Forms.RibbonButton()
        Me.rbtnExportarUndMedida = New System.Windows.Forms.RibbonButton()
        Me.tabMantenimientoParametros = New System.Windows.Forms.RibbonTab()
        Me.pAccionesParametros = New System.Windows.Forms.RibbonPanel()
        Me.rbtnNuevoParametro = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarParametro = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminarParametro = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator11 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarParametros = New System.Windows.Forms.RibbonButton()
        Me.tabProveedores = New System.Windows.Forms.RibbonTab()
        Me.rpAccionesProveedores = New System.Windows.Forms.RibbonPanel()
        Me.rbtnNuevoProveedor = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarProveedor = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminarProveedor = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator1 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarProveedores = New System.Windows.Forms.RibbonButton()
        Me.rbtnActivarProveedores = New System.Windows.Forms.RibbonButton()
        Me.rpDatosProveedores = New System.Windows.Forms.RibbonPanel()
        Me.rbtnGenerarPlantillaProveedores = New System.Windows.Forms.RibbonButton()
        Me.rbtnImportaDatosProveedores = New System.Windows.Forms.RibbonButton()
        Me.rbtnExportarDatosProveedores = New System.Windows.Forms.RibbonButton()
        Me.tabClientes = New System.Windows.Forms.RibbonTab()
        Me.rpAccionesClientes = New System.Windows.Forms.RibbonPanel()
        Me.rbtnNuevoCliente = New System.Windows.Forms.RibbonButton()
        Me.rbtnEditarCliente = New System.Windows.Forms.RibbonButton()
        Me.rbtnEliminarCliente = New System.Windows.Forms.RibbonButton()
        Me.RibbonSeparator2 = New System.Windows.Forms.RibbonSeparator()
        Me.rbtnRefrescarClientes = New System.Windows.Forms.RibbonButton()
        Me.rpDatosClientes = New System.Windows.Forms.RibbonPanel()
        Me.rbtnGenerarPlantillaClientes = New System.Windows.Forms.RibbonButton()
        Me.rbtnImportarClientes = New System.Windows.Forms.RibbonButton()
        Me.rtbtnExportarClientes = New System.Windows.Forms.RibbonButton()
        Me.RibbonTextBox1 = New System.Windows.Forms.RibbonTextBox()
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
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
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
        'rInventarioYFacturacion
        '
        Me.rInventarioYFacturacion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.rInventarioYFacturacion.Location = New System.Drawing.Point(0, 0)
        Me.rInventarioYFacturacion.Minimized = False
        Me.rInventarioYFacturacion.Name = "rInventarioYFacturacion"
        '
        '
        '
        Me.rInventarioYFacturacion.OrbDropDown.BorderRoundness = 8
        Me.rInventarioYFacturacion.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.rInventarioYFacturacion.OrbDropDown.MenuItems.Add(Me.rOrbMenuItemFacturacion)
        Me.rInventarioYFacturacion.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem1)
        Me.rInventarioYFacturacion.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem2)
        Me.rInventarioYFacturacion.OrbDropDown.Name = ""
        Me.rInventarioYFacturacion.OrbDropDown.OptionItems.Add(Me.roopbtnCerrar)
        Me.rInventarioYFacturacion.OrbDropDown.Size = New System.Drawing.Size(527, 204)
        Me.rInventarioYFacturacion.OrbDropDown.TabIndex = 0
        Me.rInventarioYFacturacion.OrbImage = Nothing
        '
        '
        '
        Me.rInventarioYFacturacion.QuickAcessToolbar.AltKey = Nothing
        Me.rInventarioYFacturacion.QuickAcessToolbar.Image = Nothing
        Me.rInventarioYFacturacion.QuickAcessToolbar.Tag = Nothing
        Me.rInventarioYFacturacion.QuickAcessToolbar.Text = Nothing
        Me.rInventarioYFacturacion.QuickAcessToolbar.ToolTip = Nothing
        Me.rInventarioYFacturacion.QuickAcessToolbar.ToolTipImage = Nothing
        Me.rInventarioYFacturacion.QuickAcessToolbar.ToolTipTitle = Nothing
        Me.rInventarioYFacturacion.Size = New System.Drawing.Size(1248, 138)
        Me.rInventarioYFacturacion.TabIndex = 0
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabFacturacion)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabInventario)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabMantenimiento)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabMantenimientoProductos)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabRoles)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabPermisos)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabMarcas)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabFamilias)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabSubFamilias)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabUnidadesMedidas)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabMantenimientoParametros)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabProveedores)
        Me.rInventarioYFacturacion.Tabs.Add(Me.tabClientes)
        Me.rInventarioYFacturacion.TabSpacing = 6
        Me.rInventarioYFacturacion.Text = "Ribbon1"
        '
        'rOrbMenuItemFacturacion
        '
        Me.rOrbMenuItemFacturacion.AltKey = Nothing
        Me.rOrbMenuItemFacturacion.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.rOrbMenuItemFacturacion.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rOrbMenuItemFacturacion.Image = CType(resources.GetObject("rOrbMenuItemFacturacion.Image"), System.Drawing.Image)
        Me.rOrbMenuItemFacturacion.SmallImage = CType(resources.GetObject("rOrbMenuItemFacturacion.SmallImage"), System.Drawing.Image)
        Me.rOrbMenuItemFacturacion.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rOrbMenuItemFacturacion.Tag = Nothing
        Me.rOrbMenuItemFacturacion.Text = "Facturación"
        Me.rOrbMenuItemFacturacion.ToolTip = Nothing
        Me.rOrbMenuItemFacturacion.ToolTipImage = Nothing
        Me.rOrbMenuItemFacturacion.ToolTipTitle = Nothing
        '
        'RibbonOrbMenuItem1
        '
        Me.RibbonOrbMenuItem1.AltKey = Nothing
        Me.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem1.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonOrbMenuItem1.Image = CType(resources.GetObject("RibbonOrbMenuItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonOrbMenuItem1.Tag = Nothing
        Me.RibbonOrbMenuItem1.Text = "Inventario"
        Me.RibbonOrbMenuItem1.ToolTip = Nothing
        Me.RibbonOrbMenuItem1.ToolTipImage = Nothing
        Me.RibbonOrbMenuItem1.ToolTipTitle = Nothing
        '
        'RibbonOrbMenuItem2
        '
        Me.RibbonOrbMenuItem2.AltKey = Nothing
        Me.RibbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem2.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonOrbMenuItem2.DropDownItems.Add(Me.rbtnMantenimientoUsuarios)
        Me.RibbonOrbMenuItem2.DropDownItems.Add(Me.rbtnMantenimientoProductos)
        Me.RibbonOrbMenuItem2.DropDownItems.Add(Me.rbtnMantenimientoProveedores)
        Me.RibbonOrbMenuItem2.DropDownItems.Add(Me.rbtnMantenimientoClientaes)
        Me.RibbonOrbMenuItem2.DropDownItems.Add(Me.rbtnOtrosMantenimientos)
        Me.RibbonOrbMenuItem2.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Tools_icon32x32
        Me.RibbonOrbMenuItem2.SmallImage = Global.InventarioYFacturacionApp.My.Resources.Resources.Tools_icon32x32
        Me.RibbonOrbMenuItem2.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.RibbonOrbMenuItem2.Tag = Nothing
        Me.RibbonOrbMenuItem2.Text = "Config."
        Me.RibbonOrbMenuItem2.ToolTip = Nothing
        Me.RibbonOrbMenuItem2.ToolTipImage = Nothing
        Me.RibbonOrbMenuItem2.ToolTipTitle = Nothing
        '
        'rbtnMantenimientoUsuarios
        '
        Me.rbtnMantenimientoUsuarios.AltKey = Nothing
        Me.rbtnMantenimientoUsuarios.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.rbtnMantenimientoUsuarios.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnMantenimientoUsuarios.Image = CType(resources.GetObject("rbtnMantenimientoUsuarios.Image"), System.Drawing.Image)
        Me.rbtnMantenimientoUsuarios.SmallImage = Global.InventarioYFacturacionApp.My.Resources.Resources.contacts_16
        Me.rbtnMantenimientoUsuarios.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnMantenimientoUsuarios.Tag = Nothing
        Me.rbtnMantenimientoUsuarios.Text = "Usuarios"
        Me.rbtnMantenimientoUsuarios.ToolTip = "Mantenimiento de usuarios"
        Me.rbtnMantenimientoUsuarios.ToolTipImage = Nothing
        Me.rbtnMantenimientoUsuarios.ToolTipTitle = Nothing
        '
        'rbtnMantenimientoProductos
        '
        Me.rbtnMantenimientoProductos.AltKey = Nothing
        Me.rbtnMantenimientoProductos.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.rbtnMantenimientoProductos.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnMantenimientoProductos.Image = CType(resources.GetObject("rbtnMantenimientoProductos.Image"), System.Drawing.Image)
        Me.rbtnMantenimientoProductos.SmallImage = Global.InventarioYFacturacionApp.My.Resources.Resources.Producto16x16
        Me.rbtnMantenimientoProductos.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnMantenimientoProductos.Tag = Nothing
        Me.rbtnMantenimientoProductos.Text = "Productos"
        Me.rbtnMantenimientoProductos.ToolTip = "Mantimiento de productos"
        Me.rbtnMantenimientoProductos.ToolTipImage = Nothing
        Me.rbtnMantenimientoProductos.ToolTipTitle = Nothing
        '
        'rbtnMantenimientoProveedores
        '
        Me.rbtnMantenimientoProveedores.AltKey = Nothing
        Me.rbtnMantenimientoProveedores.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.rbtnMantenimientoProveedores.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnMantenimientoProveedores.Image = Nothing
        Me.rbtnMantenimientoProveedores.SmallImage = Global.InventarioYFacturacionApp.My.Resources.Resources.camion16X16
        Me.rbtnMantenimientoProveedores.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnMantenimientoProveedores.Tag = Nothing
        Me.rbtnMantenimientoProveedores.Text = "Proveedores"
        Me.rbtnMantenimientoProveedores.ToolTip = Nothing
        Me.rbtnMantenimientoProveedores.ToolTipImage = Nothing
        Me.rbtnMantenimientoProveedores.ToolTipTitle = Nothing
        '
        'rbtnMantenimientoClientaes
        '
        Me.rbtnMantenimientoClientaes.AltKey = Nothing
        Me.rbtnMantenimientoClientaes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.rbtnMantenimientoClientaes.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnMantenimientoClientaes.Image = CType(resources.GetObject("rbtnMantenimientoClientaes.Image"), System.Drawing.Image)
        Me.rbtnMantenimientoClientaes.SmallImage = Global.InventarioYFacturacionApp.My.Resources.Resources.client16x16
        Me.rbtnMantenimientoClientaes.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnMantenimientoClientaes.Tag = Nothing
        Me.rbtnMantenimientoClientaes.Text = "Clientes"
        Me.rbtnMantenimientoClientaes.ToolTip = Nothing
        Me.rbtnMantenimientoClientaes.ToolTipImage = Nothing
        Me.rbtnMantenimientoClientaes.ToolTipTitle = Nothing
        '
        'rbtnOtrosMantenimientos
        '
        Me.rbtnOtrosMantenimientos.AltKey = Nothing
        Me.rbtnOtrosMantenimientos.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.rbtnOtrosMantenimientos.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnOtrosMantenimientos.Image = CType(resources.GetObject("rbtnOtrosMantenimientos.Image"), System.Drawing.Image)
        Me.rbtnOtrosMantenimientos.SmallImage = Global.InventarioYFacturacionApp.My.Resources.Resources.data_configuration_16
        Me.rbtnOtrosMantenimientos.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnOtrosMantenimientos.Tag = Nothing
        Me.rbtnOtrosMantenimientos.Text = "Otras Configuraciones"
        Me.rbtnOtrosMantenimientos.ToolTip = Nothing
        Me.rbtnOtrosMantenimientos.ToolTipImage = Nothing
        Me.rbtnOtrosMantenimientos.ToolTipTitle = Nothing
        '
        'roopbtnCerrar
        '
        Me.roopbtnCerrar.AltKey = Nothing
        Me.roopbtnCerrar.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.roopbtnCerrar.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.roopbtnCerrar.Image = Nothing
        Me.roopbtnCerrar.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.roopbtnCerrar.Tag = Nothing
        Me.roopbtnCerrar.Text = "Salir"
        Me.roopbtnCerrar.ToolTip = Nothing
        Me.roopbtnCerrar.ToolTipImage = Nothing
        Me.roopbtnCerrar.ToolTipTitle = Nothing
        '
        'tabFacturacion
        '
        Me.tabFacturacion.Tag = Nothing
        Me.tabFacturacion.Text = "Facturación"
        '
        'tabInventario
        '
        Me.tabInventario.Tag = Nothing
        Me.tabInventario.Text = "Inventario"
        '
        'tabMantenimiento
        '
        Me.tabMantenimiento.Panels.Add(Me.rPanelUsuario)
        Me.tabMantenimiento.Tag = Nothing
        Me.tabMantenimiento.Text = "Usuarios"
        '
        'rPanelUsuario
        '
        Me.rPanelUsuario.Items.Add(Me.btnNuevo)
        Me.rPanelUsuario.Items.Add(Me.btnEditar)
        Me.rPanelUsuario.Items.Add(Me.btnEliminar)
        Me.rPanelUsuario.Items.Add(Me.rbtnActivar)
        Me.rPanelUsuario.Items.Add(Me.rbtnAsignaciones)
        Me.rPanelUsuario.Items.Add(Me.RibbonSeparator4)
        Me.rPanelUsuario.Items.Add(Me.rbtnRefrescarUsuarios)
        Me.rPanelUsuario.Tag = Nothing
        Me.rPanelUsuario.Text = "Usuarios"
        '
        'btnNuevo
        '
        Me.btnNuevo.AltKey = Nothing
        Me.btnNuevo.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnNuevo.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnNuevo.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.add_user_2_32
        Me.btnNuevo.SmallImage = CType(resources.GetObject("btnNuevo.SmallImage"), System.Drawing.Image)
        Me.btnNuevo.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnNuevo.Tag = Nothing
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.ToolTip = "Crea un  nuevo usuario"
        Me.btnNuevo.ToolTipImage = Nothing
        Me.btnNuevo.ToolTipTitle = Nothing
        '
        'btnEditar
        '
        Me.btnEditar.AltKey = Nothing
        Me.btnEditar.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnEditar.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnEditar.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.edit_user_32
        Me.btnEditar.SmallImage = CType(resources.GetObject("btnEditar.SmallImage"), System.Drawing.Image)
        Me.btnEditar.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnEditar.Tag = Nothing
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.ToolTip = "Modifica los datos de un usuario"
        Me.btnEditar.ToolTipImage = Nothing
        Me.btnEditar.ToolTipTitle = Nothing
        '
        'btnEliminar
        '
        Me.btnEliminar.AltKey = Nothing
        Me.btnEliminar.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnEliminar.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnEliminar.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.remove_user_32
        Me.btnEliminar.SmallImage = CType(resources.GetObject("btnEliminar.SmallImage"), System.Drawing.Image)
        Me.btnEliminar.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnEliminar.Tag = Nothing
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTip = "Elimina usuarios"
        Me.btnEliminar.ToolTipImage = Nothing
        Me.btnEliminar.ToolTipTitle = Nothing
        '
        'rbtnActivar
        '
        Me.rbtnActivar.AltKey = Nothing
        Me.rbtnActivar.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnActivar.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnActivar.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.reviewer_32
        Me.rbtnActivar.SmallImage = CType(resources.GetObject("rbtnActivar.SmallImage"), System.Drawing.Image)
        Me.rbtnActivar.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnActivar.Tag = Nothing
        Me.rbtnActivar.Text = "Activar"
        Me.rbtnActivar.ToolTip = Nothing
        Me.rbtnActivar.ToolTipImage = Nothing
        Me.rbtnActivar.ToolTipTitle = Nothing
        '
        'rbtnAsignaciones
        '
        Me.rbtnAsignaciones.AltKey = Nothing
        Me.rbtnAsignaciones.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnAsignaciones.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnAsignaciones.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.view_details_32
        Me.rbtnAsignaciones.SmallImage = CType(resources.GetObject("rbtnAsignaciones.SmallImage"), System.Drawing.Image)
        Me.rbtnAsignaciones.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnAsignaciones.Tag = Nothing
        Me.rbtnAsignaciones.Text = "Asignaciones"
        Me.rbtnAsignaciones.ToolTip = Nothing
        Me.rbtnAsignaciones.ToolTipImage = Nothing
        Me.rbtnAsignaciones.ToolTipTitle = Nothing
        '
        'RibbonSeparator4
        '
        Me.RibbonSeparator4.AltKey = Nothing
        Me.RibbonSeparator4.Image = Nothing
        Me.RibbonSeparator4.Tag = Nothing
        Me.RibbonSeparator4.Text = Nothing
        Me.RibbonSeparator4.ToolTip = Nothing
        Me.RibbonSeparator4.ToolTipImage = Nothing
        Me.RibbonSeparator4.ToolTipTitle = Nothing
        '
        'rbtnRefrescarUsuarios
        '
        Me.rbtnRefrescarUsuarios.AltKey = Nothing
        Me.rbtnRefrescarUsuarios.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarUsuarios.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarUsuarios.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarUsuarios.SmallImage = CType(resources.GetObject("rbtnRefrescarUsuarios.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarUsuarios.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarUsuarios.Tag = Nothing
        Me.rbtnRefrescarUsuarios.Text = "Refrescar"
        Me.rbtnRefrescarUsuarios.ToolTip = Nothing
        Me.rbtnRefrescarUsuarios.ToolTipImage = Nothing
        Me.rbtnRefrescarUsuarios.ToolTipTitle = Nothing
        '
        'tabMantenimientoProductos
        '
        Me.tabMantenimientoProductos.Panels.Add(Me.rpAcciones)
        Me.tabMantenimientoProductos.Panels.Add(Me.rpDatos)
        Me.tabMantenimientoProductos.Tag = Nothing
        Me.tabMantenimientoProductos.Text = "Productos"
        '
        'rpAcciones
        '
        Me.rpAcciones.Items.Add(Me.rbtnNuevoProducto)
        Me.rpAcciones.Items.Add(Me.rbtnEditarProducto)
        Me.rpAcciones.Items.Add(Me.rbtnEliminar)
        Me.rpAcciones.Items.Add(Me.RibbonSeparator3)
        Me.rpAcciones.Items.Add(Me.rbtnRefrescarProducto)
        Me.rpAcciones.Tag = Nothing
        Me.rpAcciones.Text = "Acciones"
        '
        'rbtnNuevoProducto
        '
        Me.rbtnNuevoProducto.AltKey = Nothing
        Me.rbtnNuevoProducto.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnNuevoProducto.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnNuevoProducto.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32_green
        Me.rbtnNuevoProducto.SmallImage = CType(resources.GetObject("rbtnNuevoProducto.SmallImage"), System.Drawing.Image)
        Me.rbtnNuevoProducto.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnNuevoProducto.Tag = Nothing
        Me.rbtnNuevoProducto.Text = "Nuevo"
        Me.rbtnNuevoProducto.ToolTip = Nothing
        Me.rbtnNuevoProducto.ToolTipImage = Nothing
        Me.rbtnNuevoProducto.ToolTipTitle = Nothing
        '
        'rbtnEditarProducto
        '
        Me.rbtnEditarProducto.AltKey = Nothing
        Me.rbtnEditarProducto.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarProducto.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarProducto.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarProducto.SmallImage = CType(resources.GetObject("rbtnEditarProducto.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarProducto.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarProducto.Tag = Nothing
        Me.rbtnEditarProducto.Text = "Editar"
        Me.rbtnEditarProducto.ToolTip = Nothing
        Me.rbtnEditarProducto.ToolTipImage = Nothing
        Me.rbtnEditarProducto.ToolTipTitle = Nothing
        '
        'rbtnEliminar
        '
        Me.rbtnEliminar.AltKey = Nothing
        Me.rbtnEliminar.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminar.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminar.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminar.SmallImage = CType(resources.GetObject("rbtnEliminar.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminar.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminar.Tag = Nothing
        Me.rbtnEliminar.Text = "Eliminar"
        Me.rbtnEliminar.ToolTip = Nothing
        Me.rbtnEliminar.ToolTipImage = Nothing
        Me.rbtnEliminar.ToolTipTitle = Nothing
        '
        'RibbonSeparator3
        '
        Me.RibbonSeparator3.AltKey = Nothing
        Me.RibbonSeparator3.Image = Nothing
        Me.RibbonSeparator3.Tag = Nothing
        Me.RibbonSeparator3.Text = Nothing
        Me.RibbonSeparator3.ToolTip = Nothing
        Me.RibbonSeparator3.ToolTipImage = Nothing
        Me.RibbonSeparator3.ToolTipTitle = Nothing
        '
        'rbtnRefrescarProducto
        '
        Me.rbtnRefrescarProducto.AltKey = Nothing
        Me.rbtnRefrescarProducto.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarProducto.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarProducto.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarProducto.SmallImage = CType(resources.GetObject("rbtnRefrescarProducto.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarProducto.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarProducto.Tag = Nothing
        Me.rbtnRefrescarProducto.Text = "Refrescar"
        Me.rbtnRefrescarProducto.ToolTip = Nothing
        Me.rbtnRefrescarProducto.ToolTipImage = Nothing
        Me.rbtnRefrescarProducto.ToolTipTitle = Nothing
        '
        'rpDatos
        '
        Me.rpDatos.Items.Add(Me.rbtnGenerarPlantilla)
        Me.rpDatos.Items.Add(Me.rbtnImportarProductos)
        Me.rpDatos.Items.Add(Me.rbtnExportarProductos)
        Me.rpDatos.Tag = Nothing
        Me.rpDatos.Text = "Datos"
        '
        'rbtnGenerarPlantilla
        '
        Me.rbtnGenerarPlantilla.AltKey = Nothing
        Me.rbtnGenerarPlantilla.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnGenerarPlantilla.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnGenerarPlantilla.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Plantilla32x32
        Me.rbtnGenerarPlantilla.SmallImage = CType(resources.GetObject("rbtnGenerarPlantilla.SmallImage"), System.Drawing.Image)
        Me.rbtnGenerarPlantilla.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnGenerarPlantilla.Tag = Nothing
        Me.rbtnGenerarPlantilla.Text = "Plantilla"
        Me.rbtnGenerarPlantilla.ToolTip = Nothing
        Me.rbtnGenerarPlantilla.ToolTipImage = Nothing
        Me.rbtnGenerarPlantilla.ToolTipTitle = Nothing
        '
        'rbtnImportarProductos
        '
        Me.rbtnImportarProductos.AltKey = Nothing
        Me.rbtnImportarProductos.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnImportarProductos.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnImportarProductos.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.importar_32
        Me.rbtnImportarProductos.SmallImage = CType(resources.GetObject("rbtnImportarProductos.SmallImage"), System.Drawing.Image)
        Me.rbtnImportarProductos.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnImportarProductos.Tag = Nothing
        Me.rbtnImportarProductos.Text = "Importar Productos"
        Me.rbtnImportarProductos.ToolTip = Nothing
        Me.rbtnImportarProductos.ToolTipImage = Nothing
        Me.rbtnImportarProductos.ToolTipTitle = Nothing
        '
        'rbtnExportarProductos
        '
        Me.rbtnExportarProductos.AltKey = Nothing
        Me.rbtnExportarProductos.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnExportarProductos.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnExportarProductos.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.format_indent_more_32
        Me.rbtnExportarProductos.SmallImage = CType(resources.GetObject("rbtnExportarProductos.SmallImage"), System.Drawing.Image)
        Me.rbtnExportarProductos.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnExportarProductos.Tag = Nothing
        Me.rbtnExportarProductos.Text = "Exportar Productos"
        Me.rbtnExportarProductos.ToolTip = Nothing
        Me.rbtnExportarProductos.ToolTipImage = Nothing
        Me.rbtnExportarProductos.ToolTipTitle = Nothing
        '
        'tabRoles
        '
        Me.tabRoles.Panels.Add(Me.rpAcionesRoles)
        Me.tabRoles.Tag = Nothing
        Me.tabRoles.Text = "Roles"
        '
        'rpAcionesRoles
        '
        Me.rpAcionesRoles.Items.Add(Me.btnAgregarRoles)
        Me.rpAcionesRoles.Items.Add(Me.btnEditarRoles)
        Me.rpAcionesRoles.Items.Add(Me.btnElimarRoles)
        Me.rpAcionesRoles.Items.Add(Me.RibbonSeparator5)
        Me.rpAcionesRoles.Items.Add(Me.rbtnRefrescarRoles)
        Me.rpAcionesRoles.Tag = Nothing
        Me.rpAcionesRoles.Text = "Acciones"
        '
        'btnAgregarRoles
        '
        Me.btnAgregarRoles.AltKey = Nothing
        Me.btnAgregarRoles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnAgregarRoles.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnAgregarRoles.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32
        Me.btnAgregarRoles.SmallImage = CType(resources.GetObject("btnAgregarRoles.SmallImage"), System.Drawing.Image)
        Me.btnAgregarRoles.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnAgregarRoles.Tag = Nothing
        Me.btnAgregarRoles.Text = "Agregar"
        Me.btnAgregarRoles.ToolTip = Nothing
        Me.btnAgregarRoles.ToolTipImage = Nothing
        Me.btnAgregarRoles.ToolTipTitle = Nothing
        '
        'btnEditarRoles
        '
        Me.btnEditarRoles.AltKey = Nothing
        Me.btnEditarRoles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnEditarRoles.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnEditarRoles.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.btnEditarRoles.SmallImage = CType(resources.GetObject("btnEditarRoles.SmallImage"), System.Drawing.Image)
        Me.btnEditarRoles.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnEditarRoles.Tag = Nothing
        Me.btnEditarRoles.Text = "Editar"
        Me.btnEditarRoles.ToolTip = Nothing
        Me.btnEditarRoles.ToolTipImage = Nothing
        Me.btnEditarRoles.ToolTipTitle = Nothing
        '
        'btnElimarRoles
        '
        Me.btnElimarRoles.AltKey = Nothing
        Me.btnElimarRoles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnElimarRoles.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnElimarRoles.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.btnElimarRoles.SmallImage = CType(resources.GetObject("btnElimarRoles.SmallImage"), System.Drawing.Image)
        Me.btnElimarRoles.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnElimarRoles.Tag = Nothing
        Me.btnElimarRoles.Text = "Eliminar"
        Me.btnElimarRoles.ToolTip = Nothing
        Me.btnElimarRoles.ToolTipImage = Nothing
        Me.btnElimarRoles.ToolTipTitle = Nothing
        '
        'RibbonSeparator5
        '
        Me.RibbonSeparator5.AltKey = Nothing
        Me.RibbonSeparator5.Image = Nothing
        Me.RibbonSeparator5.Tag = Nothing
        Me.RibbonSeparator5.Text = Nothing
        Me.RibbonSeparator5.ToolTip = Nothing
        Me.RibbonSeparator5.ToolTipImage = Nothing
        Me.RibbonSeparator5.ToolTipTitle = Nothing
        '
        'rbtnRefrescarRoles
        '
        Me.rbtnRefrescarRoles.AltKey = Nothing
        Me.rbtnRefrescarRoles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarRoles.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarRoles.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarRoles.SmallImage = CType(resources.GetObject("rbtnRefrescarRoles.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarRoles.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarRoles.Tag = Nothing
        Me.rbtnRefrescarRoles.Text = "Refrescar"
        Me.rbtnRefrescarRoles.ToolTip = Nothing
        Me.rbtnRefrescarRoles.ToolTipImage = Nothing
        Me.rbtnRefrescarRoles.ToolTipTitle = Nothing
        '
        'tabPermisos
        '
        Me.tabPermisos.Panels.Add(Me.rpAccionesPermisos)
        Me.tabPermisos.Tag = Nothing
        Me.tabPermisos.Text = "Permisos"
        '
        'rpAccionesPermisos
        '
        Me.rpAccionesPermisos.Items.Add(Me.rbtnAgregarPermiso)
        Me.rpAccionesPermisos.Items.Add(Me.btnEditarPermiso)
        Me.rpAccionesPermisos.Items.Add(Me.btnEliminarPermiso)
        Me.rpAccionesPermisos.Items.Add(Me.RibbonSeparator6)
        Me.rpAccionesPermisos.Items.Add(Me.rbtnRefrescarPermisos)
        Me.rpAccionesPermisos.Tag = Nothing
        Me.rpAccionesPermisos.Text = "Acciones"
        '
        'rbtnAgregarPermiso
        '
        Me.rbtnAgregarPermiso.AltKey = Nothing
        Me.rbtnAgregarPermiso.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnAgregarPermiso.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnAgregarPermiso.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32
        Me.rbtnAgregarPermiso.SmallImage = CType(resources.GetObject("rbtnAgregarPermiso.SmallImage"), System.Drawing.Image)
        Me.rbtnAgregarPermiso.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnAgregarPermiso.Tag = Nothing
        Me.rbtnAgregarPermiso.Text = "Agregar"
        Me.rbtnAgregarPermiso.ToolTip = Nothing
        Me.rbtnAgregarPermiso.ToolTipImage = Nothing
        Me.rbtnAgregarPermiso.ToolTipTitle = Nothing
        '
        'btnEditarPermiso
        '
        Me.btnEditarPermiso.AltKey = Nothing
        Me.btnEditarPermiso.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnEditarPermiso.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnEditarPermiso.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.btnEditarPermiso.SmallImage = CType(resources.GetObject("btnEditarPermiso.SmallImage"), System.Drawing.Image)
        Me.btnEditarPermiso.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnEditarPermiso.Tag = Nothing
        Me.btnEditarPermiso.Text = "Editar"
        Me.btnEditarPermiso.ToolTip = Nothing
        Me.btnEditarPermiso.ToolTipImage = Nothing
        Me.btnEditarPermiso.ToolTipTitle = Nothing
        '
        'btnEliminarPermiso
        '
        Me.btnEliminarPermiso.AltKey = Nothing
        Me.btnEliminarPermiso.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.btnEliminarPermiso.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.btnEliminarPermiso.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.btnEliminarPermiso.SmallImage = CType(resources.GetObject("btnEliminarPermiso.SmallImage"), System.Drawing.Image)
        Me.btnEliminarPermiso.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.btnEliminarPermiso.Tag = Nothing
        Me.btnEliminarPermiso.Text = "Eliminar"
        Me.btnEliminarPermiso.ToolTip = Nothing
        Me.btnEliminarPermiso.ToolTipImage = Nothing
        Me.btnEliminarPermiso.ToolTipTitle = Nothing
        '
        'RibbonSeparator6
        '
        Me.RibbonSeparator6.AltKey = Nothing
        Me.RibbonSeparator6.Image = Nothing
        Me.RibbonSeparator6.Tag = Nothing
        Me.RibbonSeparator6.Text = Nothing
        Me.RibbonSeparator6.ToolTip = Nothing
        Me.RibbonSeparator6.ToolTipImage = Nothing
        Me.RibbonSeparator6.ToolTipTitle = Nothing
        '
        'rbtnRefrescarPermisos
        '
        Me.rbtnRefrescarPermisos.AltKey = Nothing
        Me.rbtnRefrescarPermisos.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarPermisos.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarPermisos.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarPermisos.SmallImage = CType(resources.GetObject("rbtnRefrescarPermisos.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarPermisos.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarPermisos.Tag = Nothing
        Me.rbtnRefrescarPermisos.Text = "Refrescar"
        Me.rbtnRefrescarPermisos.ToolTip = Nothing
        Me.rbtnRefrescarPermisos.ToolTipImage = Nothing
        Me.rbtnRefrescarPermisos.ToolTipTitle = Nothing
        '
        'tabMarcas
        '
        Me.tabMarcas.Panels.Add(Me.rpAccionesMarcas)
        Me.tabMarcas.Tag = Nothing
        Me.tabMarcas.Text = "Marcas"
        '
        'rpAccionesMarcas
        '
        Me.rpAccionesMarcas.Items.Add(Me.rbtnNuevaMarca)
        Me.rpAccionesMarcas.Items.Add(Me.rbtnEditarMarca)
        Me.rpAccionesMarcas.Items.Add(Me.rbtnEliminarMarca)
        Me.rpAccionesMarcas.Items.Add(Me.RibbonSeparator7)
        Me.rpAccionesMarcas.Items.Add(Me.rbtnRefrescarMarcas)
        Me.rpAccionesMarcas.Tag = Nothing
        Me.rpAccionesMarcas.Text = "Acciones"
        '
        'rbtnNuevaMarca
        '
        Me.rbtnNuevaMarca.AltKey = Nothing
        Me.rbtnNuevaMarca.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnNuevaMarca.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnNuevaMarca.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32_green
        Me.rbtnNuevaMarca.SmallImage = CType(resources.GetObject("rbtnNuevaMarca.SmallImage"), System.Drawing.Image)
        Me.rbtnNuevaMarca.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnNuevaMarca.Tag = Nothing
        Me.rbtnNuevaMarca.Text = "Nueva"
        Me.rbtnNuevaMarca.ToolTip = Nothing
        Me.rbtnNuevaMarca.ToolTipImage = Nothing
        Me.rbtnNuevaMarca.ToolTipTitle = Nothing
        '
        'rbtnEditarMarca
        '
        Me.rbtnEditarMarca.AltKey = Nothing
        Me.rbtnEditarMarca.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarMarca.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarMarca.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarMarca.SmallImage = CType(resources.GetObject("rbtnEditarMarca.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarMarca.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarMarca.Tag = Nothing
        Me.rbtnEditarMarca.Text = "Editar"
        Me.rbtnEditarMarca.ToolTip = Nothing
        Me.rbtnEditarMarca.ToolTipImage = Nothing
        Me.rbtnEditarMarca.ToolTipTitle = Nothing
        '
        'rbtnEliminarMarca
        '
        Me.rbtnEliminarMarca.AltKey = Nothing
        Me.rbtnEliminarMarca.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminarMarca.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminarMarca.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminarMarca.SmallImage = CType(resources.GetObject("rbtnEliminarMarca.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminarMarca.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminarMarca.Tag = Nothing
        Me.rbtnEliminarMarca.Text = "Eliminar"
        Me.rbtnEliminarMarca.ToolTip = Nothing
        Me.rbtnEliminarMarca.ToolTipImage = Nothing
        Me.rbtnEliminarMarca.ToolTipTitle = Nothing
        '
        'RibbonSeparator7
        '
        Me.RibbonSeparator7.AltKey = Nothing
        Me.RibbonSeparator7.Image = Nothing
        Me.RibbonSeparator7.Tag = Nothing
        Me.RibbonSeparator7.Text = Nothing
        Me.RibbonSeparator7.ToolTip = Nothing
        Me.RibbonSeparator7.ToolTipImage = Nothing
        Me.RibbonSeparator7.ToolTipTitle = Nothing
        '
        'rbtnRefrescarMarcas
        '
        Me.rbtnRefrescarMarcas.AltKey = Nothing
        Me.rbtnRefrescarMarcas.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarMarcas.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarMarcas.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarMarcas.SmallImage = CType(resources.GetObject("rbtnRefrescarMarcas.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarMarcas.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarMarcas.Tag = Nothing
        Me.rbtnRefrescarMarcas.Text = "Refrescar"
        Me.rbtnRefrescarMarcas.ToolTip = Nothing
        Me.rbtnRefrescarMarcas.ToolTipImage = Nothing
        Me.rbtnRefrescarMarcas.ToolTipTitle = Nothing
        '
        'tabFamilias
        '
        Me.tabFamilias.Panels.Add(Me.rpAccionesFamilias)
        Me.tabFamilias.Panels.Add(Me.rpDatosFamilias)
        Me.tabFamilias.Tag = Nothing
        Me.tabFamilias.Text = "Familias"
        '
        'rpAccionesFamilias
        '
        Me.rpAccionesFamilias.Items.Add(Me.rbtnInsertarFamilia)
        Me.rpAccionesFamilias.Items.Add(Me.rbtnEditarFamilia)
        Me.rpAccionesFamilias.Items.Add(Me.rbtnEliminarFamilia)
        Me.rpAccionesFamilias.Items.Add(Me.RibbonSeparator8)
        Me.rpAccionesFamilias.Items.Add(Me.rbtnRefrescarFamilias)
        Me.rpAccionesFamilias.Tag = Nothing
        Me.rpAccionesFamilias.Text = "Acciones"
        '
        'rbtnInsertarFamilia
        '
        Me.rbtnInsertarFamilia.AltKey = Nothing
        Me.rbtnInsertarFamilia.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnInsertarFamilia.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnInsertarFamilia.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32
        Me.rbtnInsertarFamilia.SmallImage = CType(resources.GetObject("rbtnInsertarFamilia.SmallImage"), System.Drawing.Image)
        Me.rbtnInsertarFamilia.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnInsertarFamilia.Tag = Nothing
        Me.rbtnInsertarFamilia.Text = "Nueva"
        Me.rbtnInsertarFamilia.ToolTip = Nothing
        Me.rbtnInsertarFamilia.ToolTipImage = Nothing
        Me.rbtnInsertarFamilia.ToolTipTitle = Nothing
        '
        'rbtnEditarFamilia
        '
        Me.rbtnEditarFamilia.AltKey = Nothing
        Me.rbtnEditarFamilia.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarFamilia.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarFamilia.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarFamilia.SmallImage = CType(resources.GetObject("rbtnEditarFamilia.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarFamilia.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarFamilia.Tag = Nothing
        Me.rbtnEditarFamilia.Text = "Editar"
        Me.rbtnEditarFamilia.ToolTip = Nothing
        Me.rbtnEditarFamilia.ToolTipImage = Nothing
        Me.rbtnEditarFamilia.ToolTipTitle = Nothing
        '
        'rbtnEliminarFamilia
        '
        Me.rbtnEliminarFamilia.AltKey = Nothing
        Me.rbtnEliminarFamilia.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminarFamilia.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminarFamilia.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminarFamilia.SmallImage = CType(resources.GetObject("rbtnEliminarFamilia.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminarFamilia.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminarFamilia.Tag = Nothing
        Me.rbtnEliminarFamilia.Text = "Eliminar"
        Me.rbtnEliminarFamilia.ToolTip = Nothing
        Me.rbtnEliminarFamilia.ToolTipImage = Nothing
        Me.rbtnEliminarFamilia.ToolTipTitle = Nothing
        '
        'RibbonSeparator8
        '
        Me.RibbonSeparator8.AltKey = Nothing
        Me.RibbonSeparator8.Image = Nothing
        Me.RibbonSeparator8.Tag = Nothing
        Me.RibbonSeparator8.Text = Nothing
        Me.RibbonSeparator8.ToolTip = Nothing
        Me.RibbonSeparator8.ToolTipImage = Nothing
        Me.RibbonSeparator8.ToolTipTitle = Nothing
        '
        'rbtnRefrescarFamilias
        '
        Me.rbtnRefrescarFamilias.AltKey = Nothing
        Me.rbtnRefrescarFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarFamilias.SmallImage = CType(resources.GetObject("rbtnRefrescarFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarFamilias.Tag = Nothing
        Me.rbtnRefrescarFamilias.Text = "Refrescar"
        Me.rbtnRefrescarFamilias.ToolTip = Nothing
        Me.rbtnRefrescarFamilias.ToolTipImage = Nothing
        Me.rbtnRefrescarFamilias.ToolTipTitle = Nothing
        '
        'rpDatosFamilias
        '
        Me.rpDatosFamilias.Items.Add(Me.rbtnGenerarPlantillaFamilias)
        Me.rpDatosFamilias.Items.Add(Me.rbtnImportarFamilias)
        Me.rpDatosFamilias.Items.Add(Me.rbtnExportarFamilias)
        Me.rpDatosFamilias.Tag = Nothing
        Me.rpDatosFamilias.Text = "Datos"
        '
        'rbtnGenerarPlantillaFamilias
        '
        Me.rbtnGenerarPlantillaFamilias.AltKey = Nothing
        Me.rbtnGenerarPlantillaFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnGenerarPlantillaFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnGenerarPlantillaFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Plantilla32x32
        Me.rbtnGenerarPlantillaFamilias.SmallImage = CType(resources.GetObject("rbtnGenerarPlantillaFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnGenerarPlantillaFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnGenerarPlantillaFamilias.Tag = Nothing
        Me.rbtnGenerarPlantillaFamilias.Text = "Plantilla"
        Me.rbtnGenerarPlantillaFamilias.ToolTip = Nothing
        Me.rbtnGenerarPlantillaFamilias.ToolTipImage = Nothing
        Me.rbtnGenerarPlantillaFamilias.ToolTipTitle = Nothing
        '
        'rbtnImportarFamilias
        '
        Me.rbtnImportarFamilias.AltKey = Nothing
        Me.rbtnImportarFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnImportarFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnImportarFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.importar_32
        Me.rbtnImportarFamilias.SmallImage = CType(resources.GetObject("rbtnImportarFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnImportarFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnImportarFamilias.Tag = Nothing
        Me.rbtnImportarFamilias.Text = "Importar"
        Me.rbtnImportarFamilias.ToolTip = Nothing
        Me.rbtnImportarFamilias.ToolTipImage = Nothing
        Me.rbtnImportarFamilias.ToolTipTitle = Nothing
        '
        'rbtnExportarFamilias
        '
        Me.rbtnExportarFamilias.AltKey = Nothing
        Me.rbtnExportarFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnExportarFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnExportarFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.format_indent_more_32
        Me.rbtnExportarFamilias.SmallImage = CType(resources.GetObject("rbtnExportarFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnExportarFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnExportarFamilias.Tag = Nothing
        Me.rbtnExportarFamilias.Text = "Exportar"
        Me.rbtnExportarFamilias.ToolTip = Nothing
        Me.rbtnExportarFamilias.ToolTipImage = Nothing
        Me.rbtnExportarFamilias.ToolTipTitle = Nothing
        '
        'tabSubFamilias
        '
        Me.tabSubFamilias.Panels.Add(Me.rpAccionesSubFamilias)
        Me.tabSubFamilias.Panels.Add(Me.rpDatosSubFamilia)
        Me.tabSubFamilias.Tag = Nothing
        Me.tabSubFamilias.Text = "Sub Familias"
        '
        'rpAccionesSubFamilias
        '
        Me.rpAccionesSubFamilias.Items.Add(Me.rbtnInsertarSubFamilia)
        Me.rpAccionesSubFamilias.Items.Add(Me.rbtnEditarSubFamilia)
        Me.rpAccionesSubFamilias.Items.Add(Me.rbtnEliminarSubFamilia)
        Me.rpAccionesSubFamilias.Items.Add(Me.RibbonSeparator9)
        Me.rpAccionesSubFamilias.Items.Add(Me.rbtnRefrescarSubFamilias)
        Me.rpAccionesSubFamilias.Tag = Nothing
        Me.rpAccionesSubFamilias.Text = "Acciones"
        '
        'rbtnInsertarSubFamilia
        '
        Me.rbtnInsertarSubFamilia.AltKey = Nothing
        Me.rbtnInsertarSubFamilia.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnInsertarSubFamilia.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnInsertarSubFamilia.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32_green
        Me.rbtnInsertarSubFamilia.SmallImage = CType(resources.GetObject("rbtnInsertarSubFamilia.SmallImage"), System.Drawing.Image)
        Me.rbtnInsertarSubFamilia.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnInsertarSubFamilia.Tag = Nothing
        Me.rbtnInsertarSubFamilia.Text = "Nuevo"
        Me.rbtnInsertarSubFamilia.ToolTip = Nothing
        Me.rbtnInsertarSubFamilia.ToolTipImage = Nothing
        Me.rbtnInsertarSubFamilia.ToolTipTitle = Nothing
        '
        'rbtnEditarSubFamilia
        '
        Me.rbtnEditarSubFamilia.AltKey = Nothing
        Me.rbtnEditarSubFamilia.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarSubFamilia.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarSubFamilia.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarSubFamilia.SmallImage = CType(resources.GetObject("rbtnEditarSubFamilia.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarSubFamilia.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarSubFamilia.Tag = Nothing
        Me.rbtnEditarSubFamilia.Text = "Editar"
        Me.rbtnEditarSubFamilia.ToolTip = Nothing
        Me.rbtnEditarSubFamilia.ToolTipImage = Nothing
        Me.rbtnEditarSubFamilia.ToolTipTitle = Nothing
        '
        'rbtnEliminarSubFamilia
        '
        Me.rbtnEliminarSubFamilia.AltKey = Nothing
        Me.rbtnEliminarSubFamilia.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminarSubFamilia.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminarSubFamilia.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminarSubFamilia.SmallImage = CType(resources.GetObject("rbtnEliminarSubFamilia.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminarSubFamilia.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminarSubFamilia.Tag = Nothing
        Me.rbtnEliminarSubFamilia.Text = "Eliminar"
        Me.rbtnEliminarSubFamilia.ToolTip = Nothing
        Me.rbtnEliminarSubFamilia.ToolTipImage = Nothing
        Me.rbtnEliminarSubFamilia.ToolTipTitle = Nothing
        '
        'RibbonSeparator9
        '
        Me.RibbonSeparator9.AltKey = Nothing
        Me.RibbonSeparator9.Image = Nothing
        Me.RibbonSeparator9.Tag = Nothing
        Me.RibbonSeparator9.Text = Nothing
        Me.RibbonSeparator9.ToolTip = Nothing
        Me.RibbonSeparator9.ToolTipImage = Nothing
        Me.RibbonSeparator9.ToolTipTitle = Nothing
        '
        'rbtnRefrescarSubFamilias
        '
        Me.rbtnRefrescarSubFamilias.AltKey = Nothing
        Me.rbtnRefrescarSubFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarSubFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarSubFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarSubFamilias.SmallImage = CType(resources.GetObject("rbtnRefrescarSubFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarSubFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarSubFamilias.Tag = Nothing
        Me.rbtnRefrescarSubFamilias.Text = "Refrescar"
        Me.rbtnRefrescarSubFamilias.ToolTip = Nothing
        Me.rbtnRefrescarSubFamilias.ToolTipImage = Nothing
        Me.rbtnRefrescarSubFamilias.ToolTipTitle = Nothing
        '
        'rpDatosSubFamilia
        '
        Me.rpDatosSubFamilia.Items.Add(Me.rbtnGenerarPlantillaSubFamilias)
        Me.rpDatosSubFamilia.Items.Add(Me.rbtnImportarSubFamilias)
        Me.rpDatosSubFamilia.Items.Add(Me.rbtnExportarSubFamilias)
        Me.rpDatosSubFamilia.Tag = Nothing
        Me.rpDatosSubFamilia.Text = "Datos"
        '
        'rbtnGenerarPlantillaSubFamilias
        '
        Me.rbtnGenerarPlantillaSubFamilias.AltKey = Nothing
        Me.rbtnGenerarPlantillaSubFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnGenerarPlantillaSubFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnGenerarPlantillaSubFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Plantilla32x32
        Me.rbtnGenerarPlantillaSubFamilias.SmallImage = CType(resources.GetObject("rbtnGenerarPlantillaSubFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnGenerarPlantillaSubFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnGenerarPlantillaSubFamilias.Tag = Nothing
        Me.rbtnGenerarPlantillaSubFamilias.Text = "Plantilla"
        Me.rbtnGenerarPlantillaSubFamilias.ToolTip = Nothing
        Me.rbtnGenerarPlantillaSubFamilias.ToolTipImage = Nothing
        Me.rbtnGenerarPlantillaSubFamilias.ToolTipTitle = Nothing
        '
        'rbtnImportarSubFamilias
        '
        Me.rbtnImportarSubFamilias.AltKey = Nothing
        Me.rbtnImportarSubFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnImportarSubFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnImportarSubFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.importar_32
        Me.rbtnImportarSubFamilias.SmallImage = CType(resources.GetObject("rbtnImportarSubFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnImportarSubFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnImportarSubFamilias.Tag = Nothing
        Me.rbtnImportarSubFamilias.Text = "Importar"
        Me.rbtnImportarSubFamilias.ToolTip = Nothing
        Me.rbtnImportarSubFamilias.ToolTipImage = Nothing
        Me.rbtnImportarSubFamilias.ToolTipTitle = Nothing
        '
        'rbtnExportarSubFamilias
        '
        Me.rbtnExportarSubFamilias.AltKey = Nothing
        Me.rbtnExportarSubFamilias.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnExportarSubFamilias.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnExportarSubFamilias.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.format_indent_more_32
        Me.rbtnExportarSubFamilias.SmallImage = CType(resources.GetObject("rbtnExportarSubFamilias.SmallImage"), System.Drawing.Image)
        Me.rbtnExportarSubFamilias.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnExportarSubFamilias.Tag = Nothing
        Me.rbtnExportarSubFamilias.Text = "Exportar"
        Me.rbtnExportarSubFamilias.ToolTip = Nothing
        Me.rbtnExportarSubFamilias.ToolTipImage = Nothing
        Me.rbtnExportarSubFamilias.ToolTipTitle = Nothing
        '
        'tabUnidadesMedidas
        '
        Me.tabUnidadesMedidas.Panels.Add(Me.rpAccionesUnidadesMedidas)
        Me.tabUnidadesMedidas.Panels.Add(Me.rpDatosUndMedida)
        Me.tabUnidadesMedidas.Tag = Nothing
        Me.tabUnidadesMedidas.Text = "Und. Medidas"
        '
        'rpAccionesUnidadesMedidas
        '
        Me.rpAccionesUnidadesMedidas.Items.Add(Me.rbtnNuevo)
        Me.rpAccionesUnidadesMedidas.Items.Add(Me.rbtnEditarUnidadMedida)
        Me.rpAccionesUnidadesMedidas.Items.Add(Me.rbtnEliminarUnidadMedida)
        Me.rpAccionesUnidadesMedidas.Items.Add(Me.RibbonSeparator10)
        Me.rpAccionesUnidadesMedidas.Items.Add(Me.rbtnRefrescarUndMedida)
        Me.rpAccionesUnidadesMedidas.Tag = Nothing
        Me.rpAccionesUnidadesMedidas.Text = "Acciones"
        '
        'rbtnNuevo
        '
        Me.rbtnNuevo.AltKey = Nothing
        Me.rbtnNuevo.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnNuevo.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnNuevo.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32_green
        Me.rbtnNuevo.SmallImage = CType(resources.GetObject("rbtnNuevo.SmallImage"), System.Drawing.Image)
        Me.rbtnNuevo.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnNuevo.Tag = Nothing
        Me.rbtnNuevo.Text = "Nueva"
        Me.rbtnNuevo.ToolTip = Nothing
        Me.rbtnNuevo.ToolTipImage = Nothing
        Me.rbtnNuevo.ToolTipTitle = Nothing
        '
        'rbtnEditarUnidadMedida
        '
        Me.rbtnEditarUnidadMedida.AltKey = Nothing
        Me.rbtnEditarUnidadMedida.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarUnidadMedida.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarUnidadMedida.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarUnidadMedida.SmallImage = CType(resources.GetObject("rbtnEditarUnidadMedida.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarUnidadMedida.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarUnidadMedida.Tag = Nothing
        Me.rbtnEditarUnidadMedida.Text = "Editar"
        Me.rbtnEditarUnidadMedida.ToolTip = Nothing
        Me.rbtnEditarUnidadMedida.ToolTipImage = Nothing
        Me.rbtnEditarUnidadMedida.ToolTipTitle = Nothing
        '
        'rbtnEliminarUnidadMedida
        '
        Me.rbtnEliminarUnidadMedida.AltKey = Nothing
        Me.rbtnEliminarUnidadMedida.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminarUnidadMedida.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminarUnidadMedida.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminarUnidadMedida.SmallImage = CType(resources.GetObject("rbtnEliminarUnidadMedida.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminarUnidadMedida.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminarUnidadMedida.Tag = Nothing
        Me.rbtnEliminarUnidadMedida.Text = "Eliminar"
        Me.rbtnEliminarUnidadMedida.ToolTip = Nothing
        Me.rbtnEliminarUnidadMedida.ToolTipImage = Nothing
        Me.rbtnEliminarUnidadMedida.ToolTipTitle = Nothing
        '
        'RibbonSeparator10
        '
        Me.RibbonSeparator10.AltKey = Nothing
        Me.RibbonSeparator10.Image = Nothing
        Me.RibbonSeparator10.Tag = Nothing
        Me.RibbonSeparator10.Text = Nothing
        Me.RibbonSeparator10.ToolTip = Nothing
        Me.RibbonSeparator10.ToolTipImage = Nothing
        Me.RibbonSeparator10.ToolTipTitle = Nothing
        '
        'rbtnRefrescarUndMedida
        '
        Me.rbtnRefrescarUndMedida.AltKey = Nothing
        Me.rbtnRefrescarUndMedida.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarUndMedida.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarUndMedida.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarUndMedida.SmallImage = CType(resources.GetObject("rbtnRefrescarUndMedida.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarUndMedida.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarUndMedida.Tag = Nothing
        Me.rbtnRefrescarUndMedida.Text = "Refrescar"
        Me.rbtnRefrescarUndMedida.ToolTip = Nothing
        Me.rbtnRefrescarUndMedida.ToolTipImage = Nothing
        Me.rbtnRefrescarUndMedida.ToolTipTitle = Nothing
        '
        'rpDatosUndMedida
        '
        Me.rpDatosUndMedida.Items.Add(Me.rbtnGenerarPlantillaUndMedida)
        Me.rpDatosUndMedida.Items.Add(Me.rbtnImportarUndMedida)
        Me.rpDatosUndMedida.Items.Add(Me.rbtnExportarUndMedida)
        Me.rpDatosUndMedida.Tag = Nothing
        Me.rpDatosUndMedida.Text = "Datos"
        '
        'rbtnGenerarPlantillaUndMedida
        '
        Me.rbtnGenerarPlantillaUndMedida.AltKey = Nothing
        Me.rbtnGenerarPlantillaUndMedida.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnGenerarPlantillaUndMedida.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnGenerarPlantillaUndMedida.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Plantilla32x32
        Me.rbtnGenerarPlantillaUndMedida.SmallImage = CType(resources.GetObject("rbtnGenerarPlantillaUndMedida.SmallImage"), System.Drawing.Image)
        Me.rbtnGenerarPlantillaUndMedida.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnGenerarPlantillaUndMedida.Tag = Nothing
        Me.rbtnGenerarPlantillaUndMedida.Text = "Plantilla"
        Me.rbtnGenerarPlantillaUndMedida.ToolTip = Nothing
        Me.rbtnGenerarPlantillaUndMedida.ToolTipImage = Nothing
        Me.rbtnGenerarPlantillaUndMedida.ToolTipTitle = Nothing
        '
        'rbtnImportarUndMedida
        '
        Me.rbtnImportarUndMedida.AltKey = Nothing
        Me.rbtnImportarUndMedida.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnImportarUndMedida.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnImportarUndMedida.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.importar_32
        Me.rbtnImportarUndMedida.SmallImage = CType(resources.GetObject("rbtnImportarUndMedida.SmallImage"), System.Drawing.Image)
        Me.rbtnImportarUndMedida.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnImportarUndMedida.Tag = Nothing
        Me.rbtnImportarUndMedida.Text = "Importar"
        Me.rbtnImportarUndMedida.ToolTip = Nothing
        Me.rbtnImportarUndMedida.ToolTipImage = Nothing
        Me.rbtnImportarUndMedida.ToolTipTitle = Nothing
        '
        'rbtnExportarUndMedida
        '
        Me.rbtnExportarUndMedida.AltKey = Nothing
        Me.rbtnExportarUndMedida.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnExportarUndMedida.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnExportarUndMedida.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.format_indent_more_32
        Me.rbtnExportarUndMedida.SmallImage = CType(resources.GetObject("rbtnExportarUndMedida.SmallImage"), System.Drawing.Image)
        Me.rbtnExportarUndMedida.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnExportarUndMedida.Tag = Nothing
        Me.rbtnExportarUndMedida.Text = "Exportar"
        Me.rbtnExportarUndMedida.ToolTip = Nothing
        Me.rbtnExportarUndMedida.ToolTipImage = Nothing
        Me.rbtnExportarUndMedida.ToolTipTitle = Nothing
        '
        'tabMantenimientoParametros
        '
        Me.tabMantenimientoParametros.Panels.Add(Me.pAccionesParametros)
        Me.tabMantenimientoParametros.Tag = Nothing
        Me.tabMantenimientoParametros.Text = "Parámetros"
        '
        'pAccionesParametros
        '
        Me.pAccionesParametros.Items.Add(Me.rbtnNuevoParametro)
        Me.pAccionesParametros.Items.Add(Me.rbtnEditarParametro)
        Me.pAccionesParametros.Items.Add(Me.rbtnEliminarParametro)
        Me.pAccionesParametros.Items.Add(Me.RibbonSeparator11)
        Me.pAccionesParametros.Items.Add(Me.rbtnRefrescarParametros)
        Me.pAccionesParametros.Tag = Nothing
        Me.pAccionesParametros.Text = "Acciones"
        '
        'rbtnNuevoParametro
        '
        Me.rbtnNuevoParametro.AltKey = Nothing
        Me.rbtnNuevoParametro.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnNuevoParametro.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnNuevoParametro.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32_green
        Me.rbtnNuevoParametro.SmallImage = CType(resources.GetObject("rbtnNuevoParametro.SmallImage"), System.Drawing.Image)
        Me.rbtnNuevoParametro.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnNuevoParametro.Tag = Nothing
        Me.rbtnNuevoParametro.Text = "Nuevo"
        Me.rbtnNuevoParametro.ToolTip = Nothing
        Me.rbtnNuevoParametro.ToolTipImage = Nothing
        Me.rbtnNuevoParametro.ToolTipTitle = Nothing
        '
        'rbtnEditarParametro
        '
        Me.rbtnEditarParametro.AltKey = Nothing
        Me.rbtnEditarParametro.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarParametro.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarParametro.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarParametro.SmallImage = CType(resources.GetObject("rbtnEditarParametro.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarParametro.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarParametro.Tag = Nothing
        Me.rbtnEditarParametro.Text = "Editar"
        Me.rbtnEditarParametro.ToolTip = Nothing
        Me.rbtnEditarParametro.ToolTipImage = Nothing
        Me.rbtnEditarParametro.ToolTipTitle = Nothing
        '
        'rbtnEliminarParametro
        '
        Me.rbtnEliminarParametro.AltKey = Nothing
        Me.rbtnEliminarParametro.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminarParametro.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminarParametro.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminarParametro.SmallImage = CType(resources.GetObject("rbtnEliminarParametro.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminarParametro.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminarParametro.Tag = Nothing
        Me.rbtnEliminarParametro.Text = "Eliminar"
        Me.rbtnEliminarParametro.ToolTip = Nothing
        Me.rbtnEliminarParametro.ToolTipImage = Nothing
        Me.rbtnEliminarParametro.ToolTipTitle = Nothing
        '
        'RibbonSeparator11
        '
        Me.RibbonSeparator11.AltKey = Nothing
        Me.RibbonSeparator11.Image = Nothing
        Me.RibbonSeparator11.Tag = Nothing
        Me.RibbonSeparator11.Text = Nothing
        Me.RibbonSeparator11.ToolTip = Nothing
        Me.RibbonSeparator11.ToolTipImage = Nothing
        Me.RibbonSeparator11.ToolTipTitle = Nothing
        '
        'rbtnRefrescarParametros
        '
        Me.rbtnRefrescarParametros.AltKey = Nothing
        Me.rbtnRefrescarParametros.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarParametros.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarParametros.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarParametros.SmallImage = CType(resources.GetObject("rbtnRefrescarParametros.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarParametros.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarParametros.Tag = Nothing
        Me.rbtnRefrescarParametros.Text = "Refrescar"
        Me.rbtnRefrescarParametros.ToolTip = Nothing
        Me.rbtnRefrescarParametros.ToolTipImage = Nothing
        Me.rbtnRefrescarParametros.ToolTipTitle = Nothing
        '
        'tabProveedores
        '
        Me.tabProveedores.Panels.Add(Me.rpAccionesProveedores)
        Me.tabProveedores.Panels.Add(Me.rpDatosProveedores)
        Me.tabProveedores.Tag = Nothing
        Me.tabProveedores.Text = "Proveedores"
        '
        'rpAccionesProveedores
        '
        Me.rpAccionesProveedores.Items.Add(Me.rbtnNuevoProveedor)
        Me.rpAccionesProveedores.Items.Add(Me.rbtnEditarProveedor)
        Me.rpAccionesProveedores.Items.Add(Me.rbtnEliminarProveedor)
        Me.rpAccionesProveedores.Items.Add(Me.RibbonSeparator1)
        Me.rpAccionesProveedores.Items.Add(Me.rbtnRefrescarProveedores)
        Me.rpAccionesProveedores.Items.Add(Me.rbtnActivarProveedores)
        Me.rpAccionesProveedores.Tag = Nothing
        Me.rpAccionesProveedores.Text = "Acciones"
        '
        'rbtnNuevoProveedor
        '
        Me.rbtnNuevoProveedor.AltKey = Nothing
        Me.rbtnNuevoProveedor.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnNuevoProveedor.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnNuevoProveedor.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32_green
        Me.rbtnNuevoProveedor.SmallImage = CType(resources.GetObject("rbtnNuevoProveedor.SmallImage"), System.Drawing.Image)
        Me.rbtnNuevoProveedor.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnNuevoProveedor.Tag = Nothing
        Me.rbtnNuevoProveedor.Text = "Nuevo"
        Me.rbtnNuevoProveedor.ToolTip = Nothing
        Me.rbtnNuevoProveedor.ToolTipImage = Nothing
        Me.rbtnNuevoProveedor.ToolTipTitle = Nothing
        '
        'rbtnEditarProveedor
        '
        Me.rbtnEditarProveedor.AltKey = Nothing
        Me.rbtnEditarProveedor.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarProveedor.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarProveedor.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarProveedor.SmallImage = CType(resources.GetObject("rbtnEditarProveedor.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarProveedor.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarProveedor.Tag = Nothing
        Me.rbtnEditarProveedor.Text = "Editar"
        Me.rbtnEditarProveedor.ToolTip = Nothing
        Me.rbtnEditarProveedor.ToolTipImage = Nothing
        Me.rbtnEditarProveedor.ToolTipTitle = Nothing
        '
        'rbtnEliminarProveedor
        '
        Me.rbtnEliminarProveedor.AltKey = Nothing
        Me.rbtnEliminarProveedor.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminarProveedor.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminarProveedor.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminarProveedor.SmallImage = CType(resources.GetObject("rbtnEliminarProveedor.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminarProveedor.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminarProveedor.Tag = Nothing
        Me.rbtnEliminarProveedor.Text = "Eliminar"
        Me.rbtnEliminarProveedor.ToolTip = Nothing
        Me.rbtnEliminarProveedor.ToolTipImage = Nothing
        Me.rbtnEliminarProveedor.ToolTipTitle = Nothing
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.AltKey = Nothing
        Me.RibbonSeparator1.Image = Nothing
        Me.RibbonSeparator1.Tag = Nothing
        Me.RibbonSeparator1.Text = Nothing
        Me.RibbonSeparator1.ToolTip = Nothing
        Me.RibbonSeparator1.ToolTipImage = Nothing
        Me.RibbonSeparator1.ToolTipTitle = Nothing
        '
        'rbtnRefrescarProveedores
        '
        Me.rbtnRefrescarProveedores.AltKey = Nothing
        Me.rbtnRefrescarProveedores.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarProveedores.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarProveedores.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarProveedores.SmallImage = CType(resources.GetObject("rbtnRefrescarProveedores.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarProveedores.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarProveedores.Tag = Nothing
        Me.rbtnRefrescarProveedores.Text = "Refrescar"
        Me.rbtnRefrescarProveedores.ToolTip = Nothing
        Me.rbtnRefrescarProveedores.ToolTipImage = Nothing
        Me.rbtnRefrescarProveedores.ToolTipTitle = Nothing
        '
        'rbtnActivarProveedores
        '
        Me.rbtnActivarProveedores.AltKey = Nothing
        Me.rbtnActivarProveedores.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnActivarProveedores.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnActivarProveedores.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.reviewer_32
        Me.rbtnActivarProveedores.SmallImage = CType(resources.GetObject("rbtnActivarProveedores.SmallImage"), System.Drawing.Image)
        Me.rbtnActivarProveedores.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnActivarProveedores.Tag = Nothing
        Me.rbtnActivarProveedores.Text = "Activar"
        Me.rbtnActivarProveedores.ToolTip = Nothing
        Me.rbtnActivarProveedores.ToolTipImage = Nothing
        Me.rbtnActivarProveedores.ToolTipTitle = Nothing
        '
        'rpDatosProveedores
        '
        Me.rpDatosProveedores.Items.Add(Me.rbtnGenerarPlantillaProveedores)
        Me.rpDatosProveedores.Items.Add(Me.rbtnImportaDatosProveedores)
        Me.rpDatosProveedores.Items.Add(Me.rbtnExportarDatosProveedores)
        Me.rpDatosProveedores.Tag = Nothing
        Me.rpDatosProveedores.Text = "Datos"
        '
        'rbtnGenerarPlantillaProveedores
        '
        Me.rbtnGenerarPlantillaProveedores.AltKey = Nothing
        Me.rbtnGenerarPlantillaProveedores.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnGenerarPlantillaProveedores.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnGenerarPlantillaProveedores.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Plantilla32x32
        Me.rbtnGenerarPlantillaProveedores.SmallImage = CType(resources.GetObject("rbtnGenerarPlantillaProveedores.SmallImage"), System.Drawing.Image)
        Me.rbtnGenerarPlantillaProveedores.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnGenerarPlantillaProveedores.Tag = Nothing
        Me.rbtnGenerarPlantillaProveedores.Text = "Plantilla"
        Me.rbtnGenerarPlantillaProveedores.ToolTip = Nothing
        Me.rbtnGenerarPlantillaProveedores.ToolTipImage = Nothing
        Me.rbtnGenerarPlantillaProveedores.ToolTipTitle = Nothing
        '
        'rbtnImportaDatosProveedores
        '
        Me.rbtnImportaDatosProveedores.AltKey = Nothing
        Me.rbtnImportaDatosProveedores.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnImportaDatosProveedores.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnImportaDatosProveedores.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.importar_32
        Me.rbtnImportaDatosProveedores.SmallImage = CType(resources.GetObject("rbtnImportaDatosProveedores.SmallImage"), System.Drawing.Image)
        Me.rbtnImportaDatosProveedores.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnImportaDatosProveedores.Tag = Nothing
        Me.rbtnImportaDatosProveedores.Text = "Importar"
        Me.rbtnImportaDatosProveedores.ToolTip = Nothing
        Me.rbtnImportaDatosProveedores.ToolTipImage = Nothing
        Me.rbtnImportaDatosProveedores.ToolTipTitle = Nothing
        '
        'rbtnExportarDatosProveedores
        '
        Me.rbtnExportarDatosProveedores.AltKey = Nothing
        Me.rbtnExportarDatosProveedores.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnExportarDatosProveedores.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnExportarDatosProveedores.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.format_indent_more_32
        Me.rbtnExportarDatosProveedores.SmallImage = CType(resources.GetObject("rbtnExportarDatosProveedores.SmallImage"), System.Drawing.Image)
        Me.rbtnExportarDatosProveedores.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnExportarDatosProveedores.Tag = Nothing
        Me.rbtnExportarDatosProveedores.Text = "Exportar"
        Me.rbtnExportarDatosProveedores.ToolTip = Nothing
        Me.rbtnExportarDatosProveedores.ToolTipImage = Nothing
        Me.rbtnExportarDatosProveedores.ToolTipTitle = Nothing
        '
        'tabClientes
        '
        Me.tabClientes.Panels.Add(Me.rpAccionesClientes)
        Me.tabClientes.Panels.Add(Me.rpDatosClientes)
        Me.tabClientes.Tag = Nothing
        Me.tabClientes.Text = "Clientes"
        '
        'rpAccionesClientes
        '
        Me.rpAccionesClientes.Items.Add(Me.rbtnNuevoCliente)
        Me.rpAccionesClientes.Items.Add(Me.rbtnEditarCliente)
        Me.rpAccionesClientes.Items.Add(Me.rbtnEliminarCliente)
        Me.rpAccionesClientes.Items.Add(Me.RibbonSeparator2)
        Me.rpAccionesClientes.Items.Add(Me.rbtnRefrescarClientes)
        Me.rpAccionesClientes.Tag = Nothing
        Me.rpAccionesClientes.Text = "Acciones"
        '
        'rbtnNuevoCliente
        '
        Me.rbtnNuevoCliente.AltKey = Nothing
        Me.rbtnNuevoCliente.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnNuevoCliente.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnNuevoCliente.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.plus_5_32_green
        Me.rbtnNuevoCliente.SmallImage = CType(resources.GetObject("rbtnNuevoCliente.SmallImage"), System.Drawing.Image)
        Me.rbtnNuevoCliente.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnNuevoCliente.Tag = Nothing
        Me.rbtnNuevoCliente.Text = "Nuevo"
        Me.rbtnNuevoCliente.ToolTip = Nothing
        Me.rbtnNuevoCliente.ToolTipImage = Nothing
        Me.rbtnNuevoCliente.ToolTipTitle = Nothing
        '
        'rbtnEditarCliente
        '
        Me.rbtnEditarCliente.AltKey = Nothing
        Me.rbtnEditarCliente.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEditarCliente.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEditarCliente.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.pencil_32
        Me.rbtnEditarCliente.SmallImage = CType(resources.GetObject("rbtnEditarCliente.SmallImage"), System.Drawing.Image)
        Me.rbtnEditarCliente.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEditarCliente.Tag = Nothing
        Me.rbtnEditarCliente.Text = "Editar"
        Me.rbtnEditarCliente.ToolTip = Nothing
        Me.rbtnEditarCliente.ToolTipImage = Nothing
        Me.rbtnEditarCliente.ToolTipTitle = Nothing
        '
        'rbtnEliminarCliente
        '
        Me.rbtnEliminarCliente.AltKey = Nothing
        Me.rbtnEliminarCliente.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnEliminarCliente.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnEliminarCliente.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.x_mark_3_32
        Me.rbtnEliminarCliente.SmallImage = CType(resources.GetObject("rbtnEliminarCliente.SmallImage"), System.Drawing.Image)
        Me.rbtnEliminarCliente.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnEliminarCliente.Tag = Nothing
        Me.rbtnEliminarCliente.Text = "Eliminar"
        Me.rbtnEliminarCliente.ToolTip = Nothing
        Me.rbtnEliminarCliente.ToolTipImage = Nothing
        Me.rbtnEliminarCliente.ToolTipTitle = Nothing
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.AltKey = Nothing
        Me.RibbonSeparator2.Image = Nothing
        Me.RibbonSeparator2.Tag = Nothing
        Me.RibbonSeparator2.Text = Nothing
        Me.RibbonSeparator2.ToolTip = Nothing
        Me.RibbonSeparator2.ToolTipImage = Nothing
        Me.RibbonSeparator2.ToolTipTitle = Nothing
        '
        'rbtnRefrescarClientes
        '
        Me.rbtnRefrescarClientes.AltKey = Nothing
        Me.rbtnRefrescarClientes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnRefrescarClientes.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnRefrescarClientes.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.refresh_32
        Me.rbtnRefrescarClientes.SmallImage = CType(resources.GetObject("rbtnRefrescarClientes.SmallImage"), System.Drawing.Image)
        Me.rbtnRefrescarClientes.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnRefrescarClientes.Tag = Nothing
        Me.rbtnRefrescarClientes.Text = "Refrescar"
        Me.rbtnRefrescarClientes.ToolTip = Nothing
        Me.rbtnRefrescarClientes.ToolTipImage = Nothing
        Me.rbtnRefrescarClientes.ToolTipTitle = Nothing
        '
        'rpDatosClientes
        '
        Me.rpDatosClientes.Items.Add(Me.rbtnGenerarPlantillaClientes)
        Me.rpDatosClientes.Items.Add(Me.rbtnImportarClientes)
        Me.rpDatosClientes.Items.Add(Me.rtbtnExportarClientes)
        Me.rpDatosClientes.Tag = Nothing
        Me.rpDatosClientes.Text = "Datos"
        '
        'rbtnGenerarPlantillaClientes
        '
        Me.rbtnGenerarPlantillaClientes.AltKey = Nothing
        Me.rbtnGenerarPlantillaClientes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnGenerarPlantillaClientes.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnGenerarPlantillaClientes.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Plantilla32x32
        Me.rbtnGenerarPlantillaClientes.SmallImage = CType(resources.GetObject("rbtnGenerarPlantillaClientes.SmallImage"), System.Drawing.Image)
        Me.rbtnGenerarPlantillaClientes.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnGenerarPlantillaClientes.Tag = Nothing
        Me.rbtnGenerarPlantillaClientes.Text = "Plantilla"
        Me.rbtnGenerarPlantillaClientes.ToolTip = Nothing
        Me.rbtnGenerarPlantillaClientes.ToolTipImage = Nothing
        Me.rbtnGenerarPlantillaClientes.ToolTipTitle = Nothing
        '
        'rbtnImportarClientes
        '
        Me.rbtnImportarClientes.AltKey = Nothing
        Me.rbtnImportarClientes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rbtnImportarClientes.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rbtnImportarClientes.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.importar_32
        Me.rbtnImportarClientes.SmallImage = CType(resources.GetObject("rbtnImportarClientes.SmallImage"), System.Drawing.Image)
        Me.rbtnImportarClientes.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rbtnImportarClientes.Tag = Nothing
        Me.rbtnImportarClientes.Text = "Importar"
        Me.rbtnImportarClientes.ToolTip = Nothing
        Me.rbtnImportarClientes.ToolTipImage = Nothing
        Me.rbtnImportarClientes.ToolTipTitle = Nothing
        '
        'rtbtnExportarClientes
        '
        Me.rtbtnExportarClientes.AltKey = Nothing
        Me.rtbtnExportarClientes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
        Me.rtbtnExportarClientes.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.rtbtnExportarClientes.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.format_indent_more_32
        Me.rtbtnExportarClientes.SmallImage = CType(resources.GetObject("rtbtnExportarClientes.SmallImage"), System.Drawing.Image)
        Me.rtbtnExportarClientes.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.rtbtnExportarClientes.Tag = Nothing
        Me.rtbtnExportarClientes.Text = "Exportar"
        Me.rtbtnExportarClientes.ToolTip = Nothing
        Me.rtbtnExportarClientes.ToolTipImage = Nothing
        Me.rtbtnExportarClientes.ToolTipTitle = Nothing
        '
        'RibbonTextBox1
        '
        Me.RibbonTextBox1.AltKey = Nothing
        Me.RibbonTextBox1.Image = Nothing
        Me.RibbonTextBox1.Tag = Nothing
        Me.RibbonTextBox1.Text = Nothing
        Me.RibbonTextBox1.TextBoxText = Nothing
        Me.RibbonTextBox1.ToolTip = Nothing
        Me.RibbonTextBox1.ToolTipImage = Nothing
        Me.RibbonTextBox1.ToolTipTitle = Nothing
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
        'RibbonButton1
        '
        Me.RibbonButton1.AltKey = Nothing
        Me.RibbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonButton1.DropDownArrowSize = New System.Drawing.Size(5, 3)
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal
        Me.RibbonButton1.Tag = Nothing
        Me.RibbonButton1.Text = "Prueba"
        Me.RibbonButton1.ToolTip = Nothing
        Me.RibbonButton1.ToolTipImage = Nothing
        Me.RibbonButton1.ToolTipTitle = Nothing
        '
        'FormApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 507)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.rInventarioYFacturacion)
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
    Friend WithEvents rInventarioYFacturacion As System.Windows.Forms.Ribbon
    Friend WithEvents tabInventario As System.Windows.Forms.RibbonTab
    Friend WithEvents tabMantenimiento As System.Windows.Forms.RibbonTab
    Friend WithEvents rPanelUsuario As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnNuevo As System.Windows.Forms.RibbonButton
    Friend WithEvents btnEditar As System.Windows.Forms.RibbonButton
    Friend WithEvents btnEliminar As System.Windows.Forms.RibbonButton
    Friend WithEvents rOrbMenuItemFacturacion As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem1 As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem2 As System.Windows.Forms.RibbonOrbMenuItem
    Friend WithEvents tabFacturacion As System.Windows.Forms.RibbonTab
    Friend WithEvents tabMantenimientoProductos As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonTextBox1 As System.Windows.Forms.RibbonTextBox
    Friend WithEvents rbtnAsignaciones As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnActivar As System.Windows.Forms.RibbonButton
    Friend WithEvents panelContenedor As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents rpAcciones As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnNuevoProducto As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarProducto As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminar As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton1 As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnMantenimientoUsuarios As System.Windows.Forms.RibbonButton
    Friend WithEvents tabRoles As System.Windows.Forms.RibbonTab
    Friend WithEvents rpAcionesRoles As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnAgregarRoles As System.Windows.Forms.RibbonButton
    Friend WithEvents btnEditarRoles As System.Windows.Forms.RibbonButton
    Friend WithEvents btnElimarRoles As System.Windows.Forms.RibbonButton
    Friend WithEvents tabPermisos As System.Windows.Forms.RibbonTab
    Friend WithEvents rpAccionesPermisos As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnAgregarPermiso As System.Windows.Forms.RibbonButton
    Friend WithEvents btnEditarPermiso As System.Windows.Forms.RibbonButton
    Friend WithEvents btnEliminarPermiso As System.Windows.Forms.RibbonButton
    Friend WithEvents tabMarcas As System.Windows.Forms.RibbonTab
    Friend WithEvents rpAccionesMarcas As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnMantenimientoProductos As System.Windows.Forms.RibbonButton
    Friend WithEvents tabFamilias As System.Windows.Forms.RibbonTab
    Friend WithEvents tabSubFamilias As System.Windows.Forms.RibbonTab
    Friend WithEvents rpAccionesFamilias As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnInsertarFamilia As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarFamilia As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminarFamilia As System.Windows.Forms.RibbonButton
    Friend WithEvents rpAccionesSubFamilias As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnInsertarSubFamilia As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarSubFamilia As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminarSubFamilia As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnNuevaMarca As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarMarca As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminarMarca As System.Windows.Forms.RibbonButton
    Friend WithEvents tabUnidadesMedidas As System.Windows.Forms.RibbonTab
    Friend WithEvents rpAccionesUnidadesMedidas As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnNuevo As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarUnidadMedida As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminarUnidadMedida As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnOtrosMantenimientos As System.Windows.Forms.RibbonButton
    Friend WithEvents tabMantenimientoParametros As System.Windows.Forms.RibbonTab
    Friend WithEvents pAccionesParametros As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnNuevoParametro As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarParametro As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminarParametro As System.Windows.Forms.RibbonButton
    Friend WithEvents rpDatos As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnGenerarPlantilla As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnImportarProductos As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnExportarProductos As System.Windows.Forms.RibbonButton
    Friend WithEvents tabProveedores As System.Windows.Forms.RibbonTab
    Friend WithEvents rpAccionesProveedores As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnNuevoProveedor As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarProveedor As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminarProveedor As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnMantenimientoProveedores As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnRefrescarProveedores As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnActivarProveedores As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator1 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnMantenimientoClientaes As System.Windows.Forms.RibbonButton
    Friend WithEvents rpDatosProveedores As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnImportaDatosProveedores As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnExportarDatosProveedores As System.Windows.Forms.RibbonButton
    Friend WithEvents tabClientes As System.Windows.Forms.RibbonTab
    Friend WithEvents rpAccionesClientes As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnNuevoCliente As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEditarCliente As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnEliminarCliente As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator2 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarClientes As System.Windows.Forms.RibbonButton
    Friend WithEvents rpDatosClientes As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnImportarClientes As System.Windows.Forms.RibbonButton
    Friend WithEvents rtbtnExportarClientes As System.Windows.Forms.RibbonButton
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
    Friend WithEvents roopbtnCerrar As System.Windows.Forms.RibbonOrbOptionButton
    Friend WithEvents RibbonSeparator3 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarProducto As System.Windows.Forms.RibbonButton
    Friend WithEvents rpDatosFamilias As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnGenerarPlantillaFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnImportarFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnExportarFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents rpDatosSubFamilia As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnGenerarPlantillaSubFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnImportarSubFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnExportarSubFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents rpDatosUndMedida As System.Windows.Forms.RibbonPanel
    Friend WithEvents rbtnGenerarPlantillaUndMedida As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnImportarUndMedida As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnExportarUndMedida As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator4 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarUsuarios As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnGenerarPlantillaProveedores As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator5 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarRoles As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator6 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarPermisos As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator7 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarMarcas As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator8 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator9 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarSubFamilias As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator10 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarUndMedida As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonSeparator11 As System.Windows.Forms.RibbonSeparator
    Friend WithEvents rbtnRefrescarParametros As System.Windows.Forms.RibbonButton
    Friend WithEvents rbtnGenerarPlantillaClientes As System.Windows.Forms.RibbonButton

End Class