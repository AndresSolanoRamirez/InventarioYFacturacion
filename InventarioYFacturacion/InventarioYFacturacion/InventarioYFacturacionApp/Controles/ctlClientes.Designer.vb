<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlClientes
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
        Me.tlslblFiltroApellidos = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroApellidos = New System.Windows.Forms.ToolStripTextBox()
        Me.tlslblFiltroIdentificacion = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroIdentificacion = New System.Windows.Forms.ToolStripTextBox()
        Me.tlslblFiltroEmail = New System.Windows.Forms.ToolStripLabel()
        Me.tlstxtFiltroEmail = New System.Windows.Forms.ToolStripTextBox()
        Me.tlsbtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlsbtnClear = New System.Windows.Forms.ToolStripButton()
        Me.dgvClientes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.apellidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.identificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.telefono = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.email = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.direccion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.KryptonSplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.KryptonSplitContainer1.Panel1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.KryptonSplitContainer1.Panel1.SuspendLayout
        CType(Me.KryptonSplitContainer1.Panel2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.KryptonSplitContainer1.Panel2.SuspendLayout
        Me.KryptonSplitContainer1.SuspendLayout
        Me.tlsFiltros.SuspendLayout
        CType(Me.dgvClientes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvClientes)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1003, 302)
        Me.KryptonSplitContainer1.SplitterDistance = 25
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'tlsFiltros
        '
        Me.tlsFiltros.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.tlsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlslblCodigo, Me.tlstxtCodigo, Me.tlslblFiltroNombre, Me.tlstxtFiltroNombre, Me.tlslblFiltroApellidos, Me.tlstxtFiltroApellidos, Me.tlslblFiltroIdentificacion, Me.tlstxtFiltroIdentificacion, Me.tlslblFiltroEmail, Me.tlstxtFiltroEmail, Me.tlsbtnBuscar, Me.tlsbtnClear})
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
        'tlslblFiltroApellidos
        '
        Me.tlslblFiltroApellidos.Name = "tlslblFiltroApellidos"
        Me.tlslblFiltroApellidos.Size = New System.Drawing.Size(59, 22)
        Me.tlslblFiltroApellidos.Text = "Apellidos:"
        '
        'tlstxtFiltroApellidos
        '
        Me.tlstxtFiltroApellidos.Name = "tlstxtFiltroApellidos"
        Me.tlstxtFiltroApellidos.Size = New System.Drawing.Size(100, 25)
        '
        'tlslblFiltroIdentificacion
        '
        Me.tlslblFiltroIdentificacion.Name = "tlslblFiltroIdentificacion"
        Me.tlslblFiltroIdentificacion.Size = New System.Drawing.Size(82, 22)
        Me.tlslblFiltroIdentificacion.Text = "Identificación:"
        '
        'tlstxtFiltroIdentificacion
        '
        Me.tlstxtFiltroIdentificacion.Name = "tlstxtFiltroIdentificacion"
        Me.tlstxtFiltroIdentificacion.Size = New System.Drawing.Size(100, 25)
        '
        'tlslblFiltroEmail
        '
        Me.tlslblFiltroEmail.Name = "tlslblFiltroEmail"
        Me.tlslblFiltroEmail.Size = New System.Drawing.Size(39, 22)
        Me.tlslblFiltroEmail.Text = "Email:"
        '
        'tlstxtFiltroEmail
        '
        Me.tlstxtFiltroEmail.Name = "tlstxtFiltroEmail"
        Me.tlstxtFiltroEmail.Size = New System.Drawing.Size(100, 25)
        '
        'tlsbtnBuscar
        '
        Me.tlsbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbtnBuscar.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.search_3_16
        Me.tlsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbtnBuscar.Name = "tlsbtnBuscar"
        Me.tlsbtnBuscar.Size = New System.Drawing.Size(23, 22)
        Me.tlsbtnBuscar.Text = "Buscar"
        '
        'tlsbtnClear
        '
        Me.tlsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsbtnClear.Image = Global.InventarioYFacturacionApp.My.Resources.Resources.Clear01
        Me.tlsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsbtnClear.Name = "tlsbtnClear"
        Me.tlsbtnClear.Size = New System.Drawing.Size(23, 22)
        Me.tlsbtnClear.Text = "Limpiar Filtros"
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = false
        Me.dgvClientes.AllowUserToDeleteRows = false
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.nombre, Me.apellidos, Me.identificacion, Me.telefono, Me.email, Me.direccion, Me.fechaCreación, Me.fechaUltimaModificacion})
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(1003, 272)
        Me.dgvClientes.TabIndex = 4
        '
        'idProveedor
        '
        Me.idCliente.DataPropertyName = "idCliente"
        Me.idCliente.HeaderText = "Cod. Cliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idCliente.Width = 107
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.FillWeight = 99.93219!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 107
        '
        'cedulaJuridica
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.FillWeight = 100.0068!
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Width = 107
        '
        'contacto
        '
        Me.identificacion.DataPropertyName = "identificacion"
        Me.identificacion.FillWeight = 99.93824!
        Me.identificacion.HeaderText = "Identificación"
        Me.identificacion.Name = "contacto"
        Me.identificacion.Width = 106
        '
        'telefono1
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.FillWeight = 100.0122!
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.Width = 107
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.FillWeight = 100.0161!
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Width = 107
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.FillWeight = 100.0189!
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 107
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.FillWeight = 100.0204!
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 107
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.FillWeight = 99.94939!
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 107
        '
        'ctlClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctlClientes"
        Me.Size = New System.Drawing.Size(1003, 302)
        CType(Me.KryptonSplitContainer1.Panel1,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(false)
        Me.KryptonSplitContainer1.Panel1.PerformLayout
        CType(Me.KryptonSplitContainer1.Panel2,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.KryptonSplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonSplitContainer1.ResumeLayout(false)
        Me.tlsFiltros.ResumeLayout(false)
        Me.tlsFiltros.PerformLayout
        CType(Me.dgvClientes,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgvClientes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tlsFiltros As System.Windows.Forms.ToolStrip
    Friend WithEvents tlslblFiltroNombre As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroNombre As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlsbtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlslblFiltroApellidos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroApellidos As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroIdentificacion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroIdentificacion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblFiltroEmail As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtFiltroEmail As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlslblCodigo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstxtCodigo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tlsbtnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents idCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents apellidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents identificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents telefono As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents email As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents direccion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
