<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlParametros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvParametros = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.idParametro = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.valor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.permiteEliminar = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.permiteModificar = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvParametros
        '
        Me.dgvParametros.AllowUserToAddRows = False
        Me.dgvParametros.AllowUserToDeleteRows = False
        Me.dgvParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvParametros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParametros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idParametro, Me.nombre, Me.valor, Me.permiteEliminar, Me.permiteModificar, Me.fechaCreación, Me.fechaUltimaModificacion})
        Me.dgvParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvParametros.Location = New System.Drawing.Point(0, 0)
        Me.dgvParametros.Name = "dgvParametros"
        Me.dgvParametros.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParametros.Size = New System.Drawing.Size(567, 217)
        Me.dgvParametros.TabIndex = 5
        '
        'idParametro
        '
        Me.idParametro.DataPropertyName = "idParametro"
        Me.idParametro.HeaderText = "Código Parámetro"
        Me.idParametro.Name = "idParametro"
        Me.idParametro.Width = 75
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 75
        '
        'valor
        '
        Me.valor.DataPropertyName = "value"
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.valor.Width = 75
        '
        'permiteEliminar
        '
        Me.permiteEliminar.DataPropertyName = "permiteEliminar"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.permiteEliminar.DefaultCellStyle = DataGridViewCellStyle1
        Me.permiteEliminar.FalseValue = Nothing
        Me.permiteEliminar.HeaderText = "Permite Eliminar"
        Me.permiteEliminar.IndeterminateValue = Nothing
        Me.permiteEliminar.Name = "permiteEliminar"
        Me.permiteEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.permiteEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.permiteEliminar.TrueValue = Nothing
        '
        'permiteModificar
        '
        Me.permiteModificar.DataPropertyName = "permiteModificar"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = False
        Me.permiteModificar.DefaultCellStyle = DataGridViewCellStyle2
        Me.permiteModificar.FalseValue = Nothing
        Me.permiteModificar.HeaderText = "Permite Modificar"
        Me.permiteModificar.IndeterminateValue = Nothing
        Me.permiteModificar.Name = "permiteModificar"
        Me.permiteModificar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.permiteModificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.permiteModificar.TrueValue = Nothing
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 75
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 75
        '
        'ctlParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvParametros)
        Me.Name = "ctlParametros"
        Me.Size = New System.Drawing.Size(567, 217)
        CType(Me.dgvParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvParametros As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents idParametro As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents valor As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents permiteEliminar As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents permiteModificar As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
