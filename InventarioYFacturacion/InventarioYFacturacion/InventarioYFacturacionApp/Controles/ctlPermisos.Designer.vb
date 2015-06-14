<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPermisos
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
        Me.dgvRoles = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idPermiso = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.apellidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRoles
        '
        Me.dgvRoles.AllowUserToAddRows = False
        Me.dgvRoles.AllowUserToDeleteRows = False
        Me.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPermiso, Me.nombre, Me.apellidos, Me.fechaCreación, Me.fechaUltimaModificacion})
        Me.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRoles.Location = New System.Drawing.Point(0, 0)
        Me.dgvRoles.Name = "dgvRoles"
        Me.dgvRoles.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoles.Size = New System.Drawing.Size(628, 304)
        Me.dgvRoles.TabIndex = 4
        '
        'idPermiso
        '
        Me.idPermiso.DataPropertyName = "idPermiso"
        Me.idPermiso.HeaderText = "Cod. Permiso"
        Me.idPermiso.Name = "idPermiso"
        Me.idPermiso.Width = 117
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 118
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "descripcion"
        Me.apellidos.HeaderText = "Descripción"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.apellidos.Width = 117
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 118
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 117
        '
        'ctlPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvRoles)
        Me.Name = "ctlPermisos"
        Me.Size = New System.Drawing.Size(628, 304)
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRoles As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents idPermiso As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents apellidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
