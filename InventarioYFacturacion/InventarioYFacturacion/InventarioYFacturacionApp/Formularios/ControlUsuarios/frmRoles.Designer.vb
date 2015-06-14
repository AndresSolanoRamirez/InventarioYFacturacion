<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoles
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.btnEliminarRol = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEditarRol = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.dgvRoles = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idRol = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.apellidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbContainer
        '
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.KryptonSplitContainer1)
        Me.grbContainer.Size = New System.Drawing.Size(446, 477)
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(3, 113)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnEliminarRol)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnEditarRol)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvRoles)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(438, 321)
        Me.KryptonSplitContainer1.SplitterDistance = 58
        Me.KryptonSplitContainer1.TabIndex = 3
        '
        'btnEliminarRol
        '
        Me.btnEliminarRol.Location = New System.Drawing.Point(106, 18)
        Me.btnEliminarRol.Name = "btnEliminarRol"
        Me.btnEliminarRol.Size = New System.Drawing.Size(90, 25)
        Me.btnEliminarRol.TabIndex = 1
        Me.btnEliminarRol.Values.Text = "Eliminar"
        '
        'btnEditarRol
        '
        Me.btnEditarRol.Location = New System.Drawing.Point(9, 18)
        Me.btnEditarRol.Name = "btnEditarRol"
        Me.btnEditarRol.Size = New System.Drawing.Size(90, 25)
        Me.btnEditarRol.TabIndex = 0
        Me.btnEditarRol.Values.Text = "Editar"
        '
        'dgvRoles
        '
        Me.dgvRoles.AllowUserToAddRows = False
        Me.dgvRoles.AllowUserToDeleteRows = False
        Me.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRol, Me.nombre, Me.apellidos, Me.fechaCreación, Me.fechaUltimaModificacion})
        Me.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRoles.Location = New System.Drawing.Point(0, 0)
        Me.dgvRoles.Name = "dgvRoles"
        Me.dgvRoles.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoles.Size = New System.Drawing.Size(438, 258)
        Me.dgvRoles.TabIndex = 3
        '
        'idRol
        '
        Me.idRol.DataPropertyName = "idRol"
        Me.idRol.HeaderText = "Cod. Rol"
        Me.idRol.Name = "idRol"
        Me.idRol.Width = 79
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 80
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "descripcion"
        Me.apellidos.HeaderText = "Descripción"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.apellidos.Width = 79
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 80
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 79
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 477)
        Me.Name = "frmRoles"
        Me.Text = "Roles"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents btnEliminarRol As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEditarRol As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgvRoles As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents idRol As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents apellidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
End Class
