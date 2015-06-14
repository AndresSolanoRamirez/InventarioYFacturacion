<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedoresInactivos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KGpBxProveedoresInactivos = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.dgvProveedores = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.seleccionar = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.idProveedor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.cedulaJuridica = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        CType(Me.KGpBxProveedoresInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KGpBxProveedoresInactivos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KGpBxProveedoresInactivos.Panel.SuspendLayout()
        Me.KGpBxProveedoresInactivos.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbContainer
        '
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.KGpBxProveedoresInactivos)
        Me.grbContainer.Size = New System.Drawing.Size(778, 414)
        '
        'KGpBxProveedoresInactivos
        '
        Me.KGpBxProveedoresInactivos.AccessibleName = ""
        Me.KGpBxProveedoresInactivos.Location = New System.Drawing.Point(12, 99)
        Me.KGpBxProveedoresInactivos.Name = "KGpBxProveedoresInactivos"
        '
        'KGpBxProveedoresInactivos.Panel
        '
        Me.KGpBxProveedoresInactivos.Panel.Controls.Add(Me.dgvProveedores)
        Me.KGpBxProveedoresInactivos.Size = New System.Drawing.Size(754, 272)
        Me.KGpBxProveedoresInactivos.TabIndex = 3
        Me.KGpBxProveedoresInactivos.Text = "Proveedores Inactivos"
        Me.KGpBxProveedoresInactivos.Values.Heading = "Proveedores Inactivos"
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionar, Me.idProveedor, Me.nombre, Me.cedulaJuridica, Me.fechaUltimaModificacion})
        Me.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProveedores.Location = New System.Drawing.Point(0, 0)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(750, 248)
        Me.dgvProveedores.TabIndex = 4
        '
        'seleccionar
        '
        Me.seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.seleccionar.DefaultCellStyle = DataGridViewCellStyle1
        Me.seleccionar.FalseValue = Nothing
        Me.seleccionar.Frozen = True
        Me.seleccionar.HeaderText = "Seleccionar"
        Me.seleccionar.IndeterminateValue = Nothing
        Me.seleccionar.Name = "seleccionar"
        Me.seleccionar.TrueValue = Nothing
        Me.seleccionar.Width = 77
        '
        'idProveedor
        '
        Me.idProveedor.DataPropertyName = "idProveedor"
        Me.idProveedor.HeaderText = "Cod. Proveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idProveedor.Width = 158
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 157
        '
        'cedulaJuridica
        '
        Me.cedulaJuridica.DataPropertyName = "cedulaJuridica"
        Me.cedulaJuridica.HeaderText = "Cédula Jurídica"
        Me.cedulaJuridica.Name = "cedulaJuridica"
        Me.cedulaJuridica.Width = 159
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 158
        '
        'frmProveedoresInactivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 414)
        Me.Name = "frmProveedoresInactivos"
        Me.Text = "Listado de proveedores Inactivos"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        CType(Me.KGpBxProveedoresInactivos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KGpBxProveedoresInactivos.Panel.ResumeLayout(False)
        CType(Me.KGpBxProveedoresInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KGpBxProveedoresInactivos.ResumeLayout(False)
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KGpBxProveedoresInactivos As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents dgvProveedores As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents seleccionar As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents idProveedor As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents cedulaJuridica As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
End Class
