<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlProducto
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.tlsFiltros = New System.Windows.Forms.ToolStrip()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.KryptonSplitContainer3 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tlslblCodigo = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtCodigo = New System.Windows.Forms.ToolStripTextBox()
        Me.tlslblFiltroNombre = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroNombre = New System.Windows.Forms.ToolStripTextBox()
        Me.tlslblFiltroCedJuridica = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroCedJuridica = New System.Windows.Forms.ToolStripTextBox()
        Me.tlslblFiltroCedContacto = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroContacto = New System.Windows.Forms.ToolStripTextBox()
        Me.tlslblFiltroCedEmail = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroEmail = New System.Windows.Forms.ToolStripTextBox()
        Me.tlslblFiltroEmailContacto = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroEmailContacto = New System.Windows.Forms.ToolStripTextBox()
        Me.tlsbtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlsbtnClear = New System.Windows.Forms.ToolStripButton()
        Me.dgvProductos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idProducto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.descripcion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.codBarras = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.cantidadExistencias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.precioCompra = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.impuesto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.precioVenta = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.utilidad = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.unidadMedida = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.idSubFamiliaFK = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.idProveedorFK = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.codigoInterno = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.responsable = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel2.SuspendLayout()
        Me.KryptonSplitContainer3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(150, 150)
        Me.KryptonSplitContainer1.SplitterDistance = 100
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'tlsFiltros
        '
        Me.tlsFiltros.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tlsFiltros.Location = New System.Drawing.Point(0, 0)
        Me.tlsFiltros.Name = "tlsFiltros"
        Me.tlsFiltros.Size = New System.Drawing.Size(100, 25)
        Me.tlsFiltros.TabIndex = 0
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.KryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(150, 150)
        Me.KryptonSplitContainer2.SplitterDistance = 100
        Me.KryptonSplitContainer2.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'KryptonSplitContainer3
        '
        Me.KryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.KryptonSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer3.Name = "KryptonSplitContainer3"
        Me.KryptonSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer3.Panel1
        '
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'KryptonSplitContainer3.Panel2
        '
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.dgvProductos)
        Me.KryptonSplitContainer3.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer3.Size = New System.Drawing.Size(763, 322)
        Me.KryptonSplitContainer3.SplitterDistance = 25
        Me.KryptonSplitContainer3.TabIndex = 3
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlslblCodigo, Me.tlstxtCodigo, Me.tlslblFiltroNombre, Me.tlstxtFiltroNombre, Me.tlslblFiltroCedJuridica, Me.tlstxtFiltroCedJuridica, Me.tlslblFiltroCedContacto, Me.tlstxtFiltroContacto, Me.tlslblFiltroCedEmail, Me.tlstxtFiltroEmail, Me.tlslblFiltroEmailContacto, Me.tlstxtFiltroEmailContacto, Me.tlsbtnBuscar, Me.tlsbtnClear})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(763, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip1"
        '
        'tlslblCodigo
        '
        Me.tlslblCodigo.Name = "tlslblCodigo"
        Me.tlslblCodigo.Size = New System.Drawing.Size(49, 22)
        Me.tlslblCodigo.Text = "Código:"
        '
        'tlstxtCodigo
        '
        Me.tlstxtCodigo.Name = "tlstxtCodigo"
        Me.tlstxtCodigo.Size = New System.Drawing.Size(100, 25)
        '
        'tlslblFiltroNombre
        '
        Me.tlslblFiltroNombre.Name = "tlslblFiltroNombre"
        Me.tlslblFiltroNombre.Size = New System.Drawing.Size(54, 22)
        Me.tlslblFiltroNombre.Text = "Nombre:"
        '
        'tlstxtFiltroNombre
        '
        Me.tlstxtFiltroNombre.Name = "tlstxtFiltroNombre"
        Me.tlstxtFiltroNombre.Size = New System.Drawing.Size(100, 25)
        '
        'tlslblFiltroCedJuridica
        '
        Me.tlslblFiltroCedJuridica.Name = "tlslblFiltroCedJuridica"
        Me.tlslblFiltroCedJuridica.Size = New System.Drawing.Size(77, 22)
        Me.tlslblFiltroCedJuridica.Text = "Ced. Jurídica:"
        '
        'tlstxtFiltroCedJuridica
        '
        Me.tlstxtFiltroCedJuridica.Name = "tlstxtFiltroCedJuridica"
        Me.tlstxtFiltroCedJuridica.Size = New System.Drawing.Size(100, 25)
        '
        'tlslblFiltroCedContacto
        '
        Me.tlslblFiltroCedContacto.Name = "tlslblFiltroCedContacto"
        Me.tlslblFiltroCedContacto.Size = New System.Drawing.Size(59, 22)
        Me.tlslblFiltroCedContacto.Text = "Contacto:"
        '
        'tlstxtFiltroContacto
        '
        Me.tlstxtFiltroContacto.Name = "tlstxtFiltroContacto"
        Me.tlstxtFiltroContacto.Size = New System.Drawing.Size(100, 25)
        '
        'tlslblFiltroCedEmail
        '
        Me.tlslblFiltroCedEmail.Name = "tlslblFiltroCedEmail"
        Me.tlslblFiltroCedEmail.Size = New System.Drawing.Size(39, 22)
        Me.tlslblFiltroCedEmail.Text = "Email:"
        '
        'tlstxtFiltroEmail
        '
        Me.tlstxtFiltroEmail.Name = "tlstxtFiltroEmail"
        Me.tlstxtFiltroEmail.Size = New System.Drawing.Size(100, 23)
        '
        'tlslblFiltroEmailContacto
        '
        Me.tlslblFiltroEmailContacto.Name = "tlslblFiltroEmailContacto"
        Me.tlslblFiltroEmailContacto.Size = New System.Drawing.Size(68, 15)
        Me.tlslblFiltroEmailContacto.Text = "Email Cont:"
        '
        'tlstxtFiltroEmailContacto
        '
        Me.tlstxtFiltroEmailContacto.Name = "tlstxtFiltroEmailContacto"
        Me.tlstxtFiltroEmailContacto.Size = New System.Drawing.Size(100, 23)
        '
        'tlsbtnBuscar
        '
        Me.tlsbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbtnBuscar.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.search_3_16
        Me.tlsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbtnBuscar.Name = "tlsbtnBuscar"
        Me.tlsbtnBuscar.Size = New System.Drawing.Size(23, 20)
        Me.tlsbtnBuscar.Text = "Buscar"
        '
        'tlsbtnClear
        '
        Me.tlsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbtnClear.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Clear01
        Me.tlsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbtnClear.Name = "tlsbtnClear"
        Me.tlsbtnClear.Size = New System.Drawing.Size(23, 20)
        Me.tlsbtnClear.Text = "Limpiar Filtros"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.nombre, Me.descripcion, Me.codBarras, Me.cantidadExistencias, Me.precioCompra, Me.impuesto, Me.precioVenta, Me.utilidad, Me.unidadMedida, Me.marca, Me.idSubFamiliaFK, Me.idProveedorFK, Me.codigoInterno, Me.responsable, Me.fechaCreacion, Me.fechaUltimaModificacion})
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.Location = New System.Drawing.Point(0, 0)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(763, 292)
        Me.dgvProductos.TabIndex = 3
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "idProduto"
        Me.idProducto.HeaderText = "Cod. Producto"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idProducto.Width = 100
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 100
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.descripcion.Width = 100
        '
        'codBarras
        '
        Me.codBarras.DataPropertyName = "codBarras"
        Me.codBarras.HeaderText = "Cod. Barras"
        Me.codBarras.Name = "codBarras"
        Me.codBarras.ReadOnly = True
        Me.codBarras.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.codBarras.Width = 85
        '
        'cantidadExistencias
        '
        Me.cantidadExistencias.DataPropertyName = "cantidadExistencias"
        Me.cantidadExistencias.HeaderText = "Cant. Existencias"
        Me.cantidadExistencias.Name = "cantidadExistencias"
        Me.cantidadExistencias.ReadOnly = True
        Me.cantidadExistencias.Width = 85
        '
        'precioCompra
        '
        Me.precioCompra.DataPropertyName = "precioCompra"
        Me.precioCompra.HeaderText = "Precio Compra"
        Me.precioCompra.Name = "precioCompra"
        Me.precioCompra.ReadOnly = True
        Me.precioCompra.Width = 85
        '
        'impuesto
        '
        Me.impuesto.DataPropertyName = "montoImpuestoVenta"
        Me.impuesto.HeaderText = "Impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.ReadOnly = True
        Me.impuesto.Width = 85
        '
        'precioVenta
        '
        Me.precioVenta.DataPropertyName = "precioVenta"
        Me.precioVenta.HeaderText = "Precio Venta"
        Me.precioVenta.Name = "precioVenta"
        Me.precioVenta.ReadOnly = True
        Me.precioVenta.Width = 85
        '
        'utilidad
        '
        Me.utilidad.DataPropertyName = "utilidad"
        Me.utilidad.HeaderText = "Utilidad"
        Me.utilidad.Name = "utilidad"
        Me.utilidad.ReadOnly = True
        Me.utilidad.Width = 85
        '
        'unidadMedida
        '
        Me.unidadMedida.DataPropertyName = "idUnidadMedidaFK"
        Me.unidadMedida.HeaderText = "Unidad de Medida"
        Me.unidadMedida.Name = "unidadMedida"
        Me.unidadMedida.ReadOnly = True
        Me.unidadMedida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.unidadMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.unidadMedida.Width = 85
        '
        'marca
        '
        Me.marca.DataPropertyName = "idMarcaFK"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.marca.Width = 85
        '
        'idSubFamiliaFK
        '
        Me.idSubFamiliaFK.DataPropertyName = "idSubFamiliaFK"
        Me.idSubFamiliaFK.HeaderText = "Sub Familia"
        Me.idSubFamiliaFK.Name = "idSubFamiliaFK"
        '
        'idProveedorFK
        '
        Me.idProveedorFK.DataPropertyName = "idProveedorFK"
        Me.idProveedorFK.HeaderText = "Proveedor"
        Me.idProveedorFK.Name = "idProveedorFK"
        '
        'codigoInterno
        '
        Me.codigoInterno.DataPropertyName = "codigoInterno"
        Me.codigoInterno.HeaderText = "Cod. Interno"
        Me.codigoInterno.Name = "codigoInterno"
        Me.codigoInterno.ReadOnly = True
        Me.codigoInterno.Width = 100
        '
        'responsable
        '
        Me.responsable.DataPropertyName = "responsable"
        Me.responsable.HeaderText = "Responsable"
        Me.responsable.Name = "responsable"
        Me.responsable.ReadOnly = True
        Me.responsable.Width = 100
        '
        'fechaCreacion
        '
        Me.fechaCreacion.DataPropertyName = "fechaCreacion"
        Me.fechaCreacion.HeaderText = "Fecha de Creación"
        Me.fechaCreacion.Name = "fechaCreacion"
        Me.fechaCreacion.ReadOnly = True
        Me.fechaCreacion.Width = 100
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.ReadOnly = True
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 100
        '
        'ctlProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer3)
        Me.Name = "ctlProducto"
        Me.Size = New System.Drawing.Size(763, 322)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents tlsFiltros As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonSplitContainer3 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlslblCodigo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtCodigo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroNombre As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroNombre As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroCedJuridica As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroCedJuridica As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroCedContacto As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroContacto As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroCedEmail As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroEmail As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroEmailContacto As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroEmailContacto As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlsbtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsbtnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvProductos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents idProducto As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents descripcion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents codBarras As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents cantidadExistencias As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents precioCompra As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents impuesto As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents precioVenta As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents utilidad As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents unidadMedida As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents idSubFamiliaFK As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents idProveedorFK As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents codigoInterno As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents responsable As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
