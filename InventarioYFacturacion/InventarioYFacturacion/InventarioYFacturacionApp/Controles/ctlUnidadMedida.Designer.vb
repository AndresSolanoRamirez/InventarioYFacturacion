<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlUnidadMedida
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
        Me.dgvUnidadesMedida = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idUnidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.apellidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.dgvUnidadesMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUnidadesMedida
        '
        Me.dgvUnidadesMedida.AllowUserToAddRows = False
        Me.dgvUnidadesMedida.AllowUserToDeleteRows = False
        Me.dgvUnidadesMedida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnidadesMedida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvUnidadesMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnidadesMedida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUnidadMedida, Me.nombre, Me.apellidos, Me.fechaCreación, Me.fechaUltimaModificacion})
        Me.dgvUnidadesMedida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUnidadesMedida.Location = New System.Drawing.Point(0, 0)
        Me.dgvUnidadesMedida.Name = "dgvUnidadesMedida"
        Me.dgvUnidadesMedida.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvUnidadesMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnidadesMedida.Size = New System.Drawing.Size(695, 253)
        Me.dgvUnidadesMedida.TabIndex = 7
        '
        'idUnidadMedida
        '
        Me.idUnidadMedida.DataPropertyName = "idUnidadMedida"
        Me.idUnidadMedida.HeaderText = "Cod. Unidad Medida"
        Me.idUnidadMedida.Name = "idUnidadMedida"
        Me.idUnidadMedida.Width = 131
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 131
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "descripcion"
        Me.apellidos.HeaderText = "Descripción"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.apellidos.Width = 130
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 131
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 131
        '
        'ctlUnidadMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvUnidadesMedida)
        Me.Name = "ctlUnidadMedida"
        Me.Size = New System.Drawing.Size(695, 253)
        CType(Me.dgvUnidadesMedida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUnidadesMedida As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents idUnidadMedida As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents apellidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
