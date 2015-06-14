<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlUsuarios
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
        Me.kbtnFiltrar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cbxCondicion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.lblFiltro2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFiltro1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cbxTiposUsuarios = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.dgvUsuarios = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.idUsuario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.cuentaFallos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.nombre = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.apellidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.telefono = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.email = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaCreación = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.fechaUltimaModificacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.contrasena = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.preguntaSeguridad = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.respuestaSeguridad = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.cbxCondicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTiposUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.KryptonSplitContainer1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.kbtnFiltrar)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cbxCondicion)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lblFiltro2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lblFiltro1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.cbxTiposUsuarios)
        Me.KryptonSplitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.KryptonSplitContainer1.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvUsuarios)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(806, 346)
        Me.KryptonSplitContainer1.SplitterDistance = 30
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'kbtnFiltrar
        '
        Me.kbtnFiltrar.Location = New System.Drawing.Point(533, 17)
        Me.kbtnFiltrar.Name = "kbtnFiltrar"
        Me.kbtnFiltrar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kbtnFiltrar.Size = New System.Drawing.Size(106, 25)
        Me.kbtnFiltrar.TabIndex = 4
        Me.kbtnFiltrar.Values.Text = "Filtrar"
        '
        'cbxCondicion
        '
        Me.cbxCondicion.DropDownWidth = 148
        Me.cbxCondicion.Location = New System.Drawing.Point(379, 19)
        Me.cbxCondicion.Name = "cbxCondicion"
        Me.cbxCondicion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.cbxCondicion.Size = New System.Drawing.Size(148, 21)
        Me.cbxCondicion.TabIndex = 3
        '
        'lblFiltro2
        '
        Me.lblFiltro2.Location = New System.Drawing.Point(248, 20)
        Me.lblFiltro2.Name = "lblFiltro2"
        Me.lblFiltro2.Size = New System.Drawing.Size(125, 20)
        Me.lblFiltro2.TabIndex = 2
        Me.lblFiltro2.Values.Text = "Filtrar por Condición:"
        '
        'lblFiltro1
        '
        Me.lblFiltro1.Location = New System.Drawing.Point(4, 20)
        Me.lblFiltro1.Name = "lblFiltro1"
        Me.lblFiltro1.Size = New System.Drawing.Size(84, 20)
        Me.lblFiltro1.TabIndex = 1
        Me.lblFiltro1.Values.Text = "Filtrar por rol:"
        '
        'cbxTiposUsuarios
        '
        Me.cbxTiposUsuarios.DropDownWidth = 148
        Me.cbxTiposUsuarios.Location = New System.Drawing.Point(94, 21)
        Me.cbxTiposUsuarios.Name = "cbxTiposUsuarios"
        Me.cbxTiposUsuarios.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.cbxTiposUsuarios.Size = New System.Drawing.Size(148, 21)
        Me.cbxTiposUsuarios.TabIndex = 0
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.ColumnHeadersHeight = 35
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.cuentaFallos, Me.nombre, Me.apellidos, Me.telefono, Me.email, Me.fechaCreación, Me.fechaUltimaModificacion, Me.activo, Me.contrasena, Me.preguntaSeguridad, Me.respuestaSeguridad})
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(806, 311)
        Me.dgvUsuarios.TabIndex = 1
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.UniqueName = "9D209741938643CF7D8524B8147E7436"
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "idUsuario"
        Me.idUsuario.FillWeight = 117.847!
        Me.idUsuario.HeaderText = "Cod. Usuario"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idUsuario.Width = 115
        '
        'cuentaFallos
        '
        Me.cuentaFallos.DataPropertyName = "cuentaFallos"
        Me.cuentaFallos.HeaderText = "cuentaFallos"
        Me.cuentaFallos.Name = "cuentaFallos"
        Me.cuentaFallos.Visible = False
        Me.cuentaFallos.Width = 102
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.FillWeight = 83.91124!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.Width = 82
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.FillWeight = 86.07985!
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.apellidos.Width = 84
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.FillWeight = 80.79604!
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.telefono.Width = 79
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.FillWeight = 126.1841!
        Me.email.HeaderText = "Correo Electrónico"
        Me.email.Name = "email"
        Me.email.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.email.Width = 123
        '
        'fechaCreación
        '
        Me.fechaCreación.DataPropertyName = "fechaCreacion"
        Me.fechaCreación.FillWeight = 112.4661!
        Me.fechaCreación.HeaderText = "Fecha de Creación"
        Me.fechaCreación.Name = "fechaCreación"
        Me.fechaCreación.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaCreación.Width = 110
        '
        'fechaUltimaModificacion
        '
        Me.fechaUltimaModificacion.DataPropertyName = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.FillWeight = 132.2641!
        Me.fechaUltimaModificacion.HeaderText = "Fecha Última Modifiación"
        Me.fechaUltimaModificacion.Name = "fechaUltimaModificacion"
        Me.fechaUltimaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaUltimaModificacion.Width = 129
        '
        'activo
        '
        Me.activo.DataPropertyName = "activo"
        Me.activo.FillWeight = 60.45154!
        Me.activo.HeaderText = "Condición"
        Me.activo.Name = "activo"
        Me.activo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'contrasena
        '
        Me.contrasena.DataPropertyName = "contrasena"
        Me.contrasena.HeaderText = "contrasena"
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.contrasena.Visible = False
        Me.contrasena.Width = 94
        '
        'preguntaSeguridad
        '
        Me.preguntaSeguridad.DataPropertyName = "preguntaSeguridad"
        Me.preguntaSeguridad.HeaderText = "preguntaSeguridad"
        Me.preguntaSeguridad.Name = "preguntaSeguridad"
        Me.preguntaSeguridad.Visible = False
        Me.preguntaSeguridad.Width = 137
        '
        'respuestaSeguridad
        '
        Me.respuestaSeguridad.DataPropertyName = "respuestaSeguridad"
        Me.respuestaSeguridad.HeaderText = "respuestaSeguridad"
        Me.respuestaSeguridad.Name = "respuestaSeguridad"
        Me.respuestaSeguridad.Visible = False
        Me.respuestaSeguridad.Width = 139
        '
        'ctlUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "ctlUsuarios"
        Me.Size = New System.Drawing.Size(806, 346)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.cbxCondicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTiposUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents cbxTiposUsuarios As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents dgvUsuarios As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblFiltro1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxCondicion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblFiltro2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kbtnFiltrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents idUsuario As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents cuentaFallos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents nombre As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents apellidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents telefono As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents email As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaCreación As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents fechaUltimaModificacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents activo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents contrasena As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents preguntaSeguridad As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents respuestaSeguridad As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn

End Class
