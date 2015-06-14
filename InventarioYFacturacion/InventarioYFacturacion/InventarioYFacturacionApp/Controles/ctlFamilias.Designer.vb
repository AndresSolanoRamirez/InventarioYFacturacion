<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlFamilias
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
        Me.dgvFamilias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idFamilia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.apellidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFamilias
        '
        Me.dgvFamilias.AllowUserToAddRows = False
        Me.dgvFamilias.AllowUserToDeleteRows = False
        Me.dgvFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFamilias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFamilia, Me.nombre, Me.apellidos, Me.fechaCreación, Me.fechaUltimaModificacion})
        Me.dgvFamilias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFamilias.Location = New System.Drawing.Point(0, 0)
        Me.dgvFamilias.Name = "dgvFamilias"
        Me.dgvFamilias.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFamilias.Size = New System.Drawing.Size(567, 217)
        Me.dgvFamilias.TabIndex = 5
        '
        'idPermiso
        '
        Me.idFamilia.DataPropertyName = "idFamilia"
        Me.idFamilia.HeaderText = "Cod. Familia"
        Me.idFamilia.Name = "idFamilia"
        Me.idFamilia.Width = 105
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 105
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "descripcion"
        Me.apellidos.HeaderText = "Descripción"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.apellidos.Width = 106
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 105
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 105
        '
        'ctlFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvFamilias)
        Me.Name = "ctlFamilias"
        Me.Size = New System.Drawing.Size(567, 217)
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvFamilias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents idFamilia As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents apellidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
