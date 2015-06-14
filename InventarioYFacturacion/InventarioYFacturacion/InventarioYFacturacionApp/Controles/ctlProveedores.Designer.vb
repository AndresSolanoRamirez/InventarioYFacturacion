<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlProveedores
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
        Me.dgvProveedores = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idProveedor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.cedulaJuridica = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.contacto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.telefono1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.telefono2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.email = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.emailContacto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.direccion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        Me.tlsFiltros.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tlsFiltros)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvProveedores)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1003, 302)
        Me.KryptonSplitContainer1.SplitterDistance = 25
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'tlsFiltros
        '
        Me.tlsFiltros.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tlsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlslblCodigo, Me.tlstxtCodigo, Me.tlslblFiltroNombre, Me.tlstxtFiltroNombre, Me.tlslblFiltroCedJuridica, Me.tlstxtFiltroCedJuridica, Me.tlslblFiltroCedContacto, Me.tlstxtFiltroContacto, Me.tlslblFiltroCedEmail, Me.tlstxtFiltroEmail, Me.tlslblFiltroEmailContacto, Me.tlstxtFiltroEmailContacto, Me.tlsbtnBuscar, Me.tlsbtnClear})
        Me.tlsFiltros.Location = New System.Drawing.Point(0, 0)
        Me.tlsFiltros.Name = "tlsFiltros"
        Me.tlsFiltros.Size = New System.Drawing.Size(1003, 25)
        Me.tlsFiltros.TabIndex = 0
        Me.tlsFiltros.Text = "ToolStrip1"
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
        Me.tlstxtFiltroEmail.Size = New System.Drawing.Size(100, 25)
        '
        'tlslblFiltroEmailContacto
        '
        Me.tlslblFiltroEmailContacto.Name = "tlslblFiltroEmailContacto"
        Me.tlslblFiltroEmailContacto.Size = New System.Drawing.Size(68, 22)
        Me.tlslblFiltroEmailContacto.Text = "Email Cont:"
        '
        'tlstxtFiltroEmailContacto
        '
        Me.tlstxtFiltroEmailContacto.Name = "tlstxtFiltroEmailContacto"
        Me.tlstxtFiltroEmailContacto.Size = New System.Drawing.Size(100, 25)
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
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProveedor, Me.nombre, Me.cedulaJuridica, Me.contacto, Me.telefono1, Me.telefono2, Me.email, Me.emailContacto, Me.direccion, Me.activo, Me.fechaCreación, Me.fechaUltimaModificacion})
        Me.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProveedores.Location = New System.Drawing.Point(0, 0)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(1003, 272)
        Me.dgvProveedores.TabIndex = 4
        '
        'idProveedor
        '
        Me.idProveedor.DataPropertyName = "idProveedor"
        Me.idProveedor.HeaderText = "Cod. Proveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idProveedor.Width = 87
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.FillWeight = 99.93219!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 88
        '
        'cedulaJuridica
        '
        Me.cedulaJuridica.DataPropertyName = "cedulaJuridica"
        Me.cedulaJuridica.FillWeight = 100.0068!
        Me.cedulaJuridica.HeaderText = "Cédula Jurídica"
        Me.cedulaJuridica.Name = "cedulaJuridica"
        Me.cedulaJuridica.Width = 87
        '
        'contacto
        '
        Me.contacto.DataPropertyName = "contacto"
        Me.contacto.FillWeight = 99.93824!
        Me.contacto.HeaderText = "Contacto"
        Me.contacto.Name = "contacto"
        Me.contacto.Width = 88
        '
        'telefono1
        '
        Me.telefono1.DataPropertyName = "telefono1"
        Me.telefono1.FillWeight = 100.0122!
        Me.telefono1.HeaderText = "telefono1"
        Me.telefono1.Name = "telefono1"
        Me.telefono1.Width = 87
        '
        'telefono2
        '
        Me.telefono2.DataPropertyName = "telefono2"
        Me.telefono2.FillWeight = 99.94287!
        Me.telefono2.HeaderText = "telefono2"
        Me.telefono2.Name = "telefono2"
        Me.telefono2.Width = 88
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.FillWeight = 100.0161!
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Width = 87
        '
        'emailContacto
        '
        Me.emailContacto.DataPropertyName = "emailContacto"
        Me.emailContacto.FillWeight = 99.9462!
        Me.emailContacto.HeaderText = "Email Contacto"
        Me.emailContacto.Name = "emailContacto"
        Me.emailContacto.Width = 88
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.FillWeight = 100.0189!
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 87
        '
        'activo
        '
        Me.activo.DataPropertyName = "activo"
        Me.activo.FillWeight = 99.94835!
        Me.activo.HeaderText = "Estado"
        Me.activo.Name = "activo"
        Me.activo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.activo.Visible = False
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.FillWeight = 100.0204!
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 88
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.FillWeight = 99.94939!
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 87
        '
        'ctlProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctlProveedores"
        Me.Size = New System.Drawing.Size(1003, 302)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        Me.tlsFiltros.ResumeLayout(False)
        Me.tlsFiltros.PerformLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgvProveedores As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tlsFiltros As System.Windows.Forms.ToolStrip
    Friend WithEvents tlslblFiltroNombre As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroNombre As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlsbtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlslblFiltroCedJuridica As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroCedJuridica As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroCedContacto As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroContacto As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroCedEmail As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroEmail As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroEmailContacto As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroEmailContacto As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblCodigo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtCodigo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlsbtnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents idProveedor As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents cedulaJuridica As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents contacto As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents telefono1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents telefono2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents email As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents emailContacto As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents direccion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents activo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
