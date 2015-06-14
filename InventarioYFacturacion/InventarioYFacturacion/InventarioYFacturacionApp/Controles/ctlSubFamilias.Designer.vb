<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSubFamilias
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
        Me.dgvSubFamilias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idSubFamilia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.apellidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.idFamiliaFK = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewComboBoxColumn()
        CType(Me.dgvSubFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSubFamilias
        '
        Me.dgvSubFamilias.AllowUserToAddRows = False
        Me.dgvSubFamilias.AllowUserToDeleteRows = False
        Me.dgvSubFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubFamilias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvSubFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSubFamilia, Me.nombre, Me.apellidos, Me.fechaCreación, Me.fechaUltimaModificacion, Me.idFamiliaFK})
        Me.dgvSubFamilias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSubFamilias.Location = New System.Drawing.Point(0, 0)
        Me.dgvSubFamilias.Name = "dgvSubFamilias"
        Me.dgvSubFamilias.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvSubFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubFamilias.Size = New System.Drawing.Size(567, 217)
        Me.dgvSubFamilias.TabIndex = 5
        '
        'idSubFamilia
        '
        Me.idSubFamilia.DataPropertyName = "idSubFamilia"
        Me.idSubFamilia.HeaderText = "Cod. Sub Familia"
        Me.idSubFamilia.Name = "idSubFamilia"
        Me.idSubFamilia.Width = 88
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 87
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "descripcion"
        Me.apellidos.HeaderText = "Descripción"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.apellidos.Width = 88
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 88
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 87
        '
        'idFamiliaFK
        '
        Me.idFamiliaFK.DropDownWidth = 121
        Me.idFamiliaFK.HeaderText = "Familia"
        Me.idFamiliaFK.Name = "idFamiliaFK"
        Me.idFamiliaFK.Width = 88
        '
        'ctlSubFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvSubFamilias)
        Me.Name = "ctlSubFamilias"
        Me.Size = New System.Drawing.Size(567, 217)
        CType(Me.dgvSubFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSubFamilias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents idSubFamilia As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents apellidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents idFamiliaFK As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewComboBoxColumn

End Class
