<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarProductos
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
        Me.klblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kcmbxProveedores = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.klblMarca = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kcmbxMarca = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.klblSubFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kcmbxSubFamilias = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.klblUniidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kcmbxUnidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.klblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ktxtNombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.klblPrecioCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kntxtPrecioCompra = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.klblImpuestoVenta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kntxtImpuestoVenta = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.klblPrecioCnImpuesto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kntxtPrecioCnImpuesto = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.klblUtilidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kntxtUtilidad = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.klblPrecioVenta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kntxtPrecioVenta = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.klblCantidadExistencias = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kntxtCantidadExistencias = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.kgbxControlInterno = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.kgbxGenerales = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonRadioButton2 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonRadioButton1 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.krbtnImpuesto3 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.krbtnImpuesto2 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.krbtnImpuesto1 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.ktxtCodigoInterno = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.klblCodigoInterno = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kgbxOpcionales = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ktxtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.klblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ktxtCodigoBarras = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.klblCodigoBarras = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContainer.Panel.SuspendLayout()
        Me.grbContainer.SuspendLayout()
        CType(Me.kcmbxProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbxMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbxSubFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbxUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgbxControlInterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgbxControlInterno.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgbxControlInterno.Panel.SuspendLayout()
        Me.kgbxControlInterno.SuspendLayout()
        CType(Me.kgbxGenerales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgbxGenerales.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgbxGenerales.Panel.SuspendLayout()
        Me.kgbxGenerales.SuspendLayout()
        CType(Me.kgbxOpcionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kgbxOpcionales.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgbxOpcionales.Panel.SuspendLayout()
        Me.kgbxOpcionales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbContainer
        '
        '
        'grbContainer.Panel
        '
        Me.grbContainer.Panel.Controls.Add(Me.kgbxOpcionales)
        Me.grbContainer.Panel.Controls.Add(Me.kgbxGenerales)
        Me.grbContainer.Panel.Controls.Add(Me.kgbxControlInterno)
        Me.grbContainer.Size = New System.Drawing.Size(767, 661)
        '
        'klblProveedor
        '
        Me.klblProveedor.Location = New System.Drawing.Point(43, 16)
        Me.klblProveedor.Name = "klblProveedor"
        Me.klblProveedor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblProveedor.Size = New System.Drawing.Size(69, 20)
        Me.klblProveedor.TabIndex = 3
        Me.klblProveedor.Values.Text = "Proveedor:"
        '
        'kcmbxProveedores
        '
        Me.kcmbxProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbxProveedores.DropDownWidth = 199
        Me.kcmbxProveedores.Location = New System.Drawing.Point(118, 15)
        Me.kcmbxProveedores.Name = "kcmbxProveedores"
        Me.kcmbxProveedores.Size = New System.Drawing.Size(199, 21)
        Me.kcmbxProveedores.TabIndex = 4
        '
        'klblMarca
        '
        Me.klblMarca.Location = New System.Drawing.Point(413, 16)
        Me.klblMarca.Name = "klblMarca"
        Me.klblMarca.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblMarca.Size = New System.Drawing.Size(47, 20)
        Me.klblMarca.TabIndex = 5
        Me.klblMarca.Values.Text = "Marca:"
        '
        'kcmbxMarca
        '
        Me.kcmbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbxMarca.DropDownWidth = 199
        Me.kcmbxMarca.Location = New System.Drawing.Point(466, 15)
        Me.kcmbxMarca.Name = "kcmbxMarca"
        Me.kcmbxMarca.Size = New System.Drawing.Size(199, 21)
        Me.kcmbxMarca.TabIndex = 6
        '
        'klblSubFamilia
        '
        Me.klblSubFamilia.Location = New System.Drawing.Point(39, 42)
        Me.klblSubFamilia.Name = "klblSubFamilia"
        Me.klblSubFamilia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblSubFamilia.Size = New System.Drawing.Size(73, 20)
        Me.klblSubFamilia.TabIndex = 7
        Me.klblSubFamilia.Values.Text = "Sub familia:"
        '
        'kcmbxSubFamilias
        '
        Me.kcmbxSubFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbxSubFamilias.DropDownWidth = 199
        Me.kcmbxSubFamilias.Location = New System.Drawing.Point(118, 40)
        Me.kcmbxSubFamilias.Name = "kcmbxSubFamilias"
        Me.kcmbxSubFamilias.Size = New System.Drawing.Size(199, 21)
        Me.kcmbxSubFamilias.TabIndex = 8
        '
        'klblUniidadMedida
        '
        Me.klblUniidadMedida.Location = New System.Drawing.Point(346, 40)
        Me.klblUniidadMedida.Name = "klblUniidadMedida"
        Me.klblUniidadMedida.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblUniidadMedida.Size = New System.Drawing.Size(114, 20)
        Me.klblUniidadMedida.TabIndex = 9
        Me.klblUniidadMedida.Values.Text = "Unidad de medida:"
        '
        'kcmbxUnidadMedida
        '
        Me.kcmbxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbxUnidadMedida.DropDownWidth = 199
        Me.kcmbxUnidadMedida.Location = New System.Drawing.Point(466, 40)
        Me.kcmbxUnidadMedida.Name = "kcmbxUnidadMedida"
        Me.kcmbxUnidadMedida.Size = New System.Drawing.Size(199, 21)
        Me.kcmbxUnidadMedida.TabIndex = 10
        '
        'klblNombre
        '
        Me.klblNombre.Location = New System.Drawing.Point(89, 22)
        Me.klblNombre.Name = "klblNombre"
        Me.klblNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblNombre.Size = New System.Drawing.Size(58, 20)
        Me.klblNombre.TabIndex = 11
        Me.klblNombre.Values.Text = "Nombre:"
        '
        'ktxtNombre
        '
        Me.ktxtNombre.Location = New System.Drawing.Point(153, 19)
        Me.ktxtNombre.Name = "ktxtNombre"
        Me.ktxtNombre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.ktxtNombre.Size = New System.Drawing.Size(199, 20)
        Me.ktxtNombre.TabIndex = 12
        '
        'klblPrecioCompra
        '
        Me.klblPrecioCompra.Location = New System.Drawing.Point(386, 18)
        Me.klblPrecioCompra.Name = "klblPrecioCompra"
        Me.klblPrecioCompra.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblPrecioCompra.Size = New System.Drawing.Size(109, 20)
        Me.klblPrecioCompra.TabIndex = 13
        Me.klblPrecioCompra.Values.Text = "Precio de compra:"
        '
        'kntxtPrecioCompra
        '
        Me.kntxtPrecioCompra.Location = New System.Drawing.Point(501, 17)
        Me.kntxtPrecioCompra.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.kntxtPrecioCompra.Name = "kntxtPrecioCompra"
        Me.kntxtPrecioCompra.Size = New System.Drawing.Size(199, 22)
        Me.kntxtPrecioCompra.TabIndex = 14
        '
        'klblImpuestoVenta
        '
        Me.klblImpuestoVenta.Location = New System.Drawing.Point(32, 48)
        Me.klblImpuestoVenta.Name = "klblImpuestoVenta"
        Me.klblImpuestoVenta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblImpuestoVenta.Size = New System.Drawing.Size(115, 20)
        Me.klblImpuestoVenta.TabIndex = 15
        Me.klblImpuestoVenta.Values.Text = "Impuesto de venta:"
        '
        'kntxtImpuestoVenta
        '
        Me.kntxtImpuestoVenta.Location = New System.Drawing.Point(153, 43)
        Me.kntxtImpuestoVenta.Name = "kntxtImpuestoVenta"
        Me.kntxtImpuestoVenta.ReadOnly = True
        Me.kntxtImpuestoVenta.Size = New System.Drawing.Size(199, 22)
        Me.kntxtImpuestoVenta.TabIndex = 16
        '
        'klblPrecioCnImpuesto
        '
        Me.klblPrecioCnImpuesto.Location = New System.Drawing.Point(370, 42)
        Me.klblPrecioCnImpuesto.Name = "klblPrecioCnImpuesto"
        Me.klblPrecioCnImpuesto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblPrecioCnImpuesto.Size = New System.Drawing.Size(125, 20)
        Me.klblPrecioCnImpuesto.TabIndex = 17
        Me.klblPrecioCnImpuesto.Values.Text = "Precio con impuesto:"
        '
        'kntxtPrecioCnImpuesto
        '
        Me.kntxtPrecioCnImpuesto.Location = New System.Drawing.Point(501, 43)
        Me.kntxtPrecioCnImpuesto.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.kntxtPrecioCnImpuesto.Name = "kntxtPrecioCnImpuesto"
        Me.kntxtPrecioCnImpuesto.ReadOnly = True
        Me.kntxtPrecioCnImpuesto.Size = New System.Drawing.Size(199, 22)
        Me.kntxtPrecioCnImpuesto.TabIndex = 18
        '
        'klblUtilidad
        '
        Me.klblUtilidad.Location = New System.Drawing.Point(91, 69)
        Me.klblUtilidad.Name = "klblUtilidad"
        Me.klblUtilidad.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblUtilidad.Size = New System.Drawing.Size(56, 20)
        Me.klblUtilidad.TabIndex = 19
        Me.klblUtilidad.Values.Text = "Utilidad:"
        '
        'kntxtUtilidad
        '
        Me.kntxtUtilidad.Location = New System.Drawing.Point(153, 69)
        Me.kntxtUtilidad.Name = "kntxtUtilidad"
        Me.kntxtUtilidad.Size = New System.Drawing.Size(199, 22)
        Me.kntxtUtilidad.TabIndex = 20
        '
        'klblPrecioVenta
        '
        Me.klblPrecioVenta.Location = New System.Drawing.Point(398, 66)
        Me.klblPrecioVenta.Name = "klblPrecioVenta"
        Me.klblPrecioVenta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblPrecioVenta.Size = New System.Drawing.Size(97, 20)
        Me.klblPrecioVenta.TabIndex = 21
        Me.klblPrecioVenta.Values.Text = "Precio de venta:"
        '
        'kntxtPrecioVenta
        '
        Me.kntxtPrecioVenta.Location = New System.Drawing.Point(501, 69)
        Me.kntxtPrecioVenta.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.kntxtPrecioVenta.Name = "kntxtPrecioVenta"
        Me.kntxtPrecioVenta.ReadOnly = True
        Me.kntxtPrecioVenta.Size = New System.Drawing.Size(199, 22)
        Me.kntxtPrecioVenta.TabIndex = 22
        '
        'klblCantidadExistencias
        '
        Me.klblCantidadExistencias.Location = New System.Drawing.Point(6, 95)
        Me.klblCantidadExistencias.Name = "klblCantidadExistencias"
        Me.klblCantidadExistencias.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblCantidadExistencias.Size = New System.Drawing.Size(141, 20)
        Me.klblCantidadExistencias.TabIndex = 23
        Me.klblCantidadExistencias.Values.Text = "Cantidad de existencias:"
        '
        'kntxtCantidadExistencias
        '
        Me.kntxtCantidadExistencias.Location = New System.Drawing.Point(153, 93)
        Me.kntxtCantidadExistencias.Name = "kntxtCantidadExistencias"
        Me.kntxtCantidadExistencias.Size = New System.Drawing.Size(199, 22)
        Me.kntxtCantidadExistencias.TabIndex = 24
        '
        'kgbxControlInterno
        '
        Me.kgbxControlInterno.Location = New System.Drawing.Point(27, 99)
        Me.kgbxControlInterno.Name = "kgbxControlInterno"
        '
        'kgbxControlInterno.Panel
        '
        Me.kgbxControlInterno.Panel.Controls.Add(Me.klblProveedor)
        Me.kgbxControlInterno.Panel.Controls.Add(Me.kcmbxProveedores)
        Me.kgbxControlInterno.Panel.Controls.Add(Me.klblMarca)
        Me.kgbxControlInterno.Panel.Controls.Add(Me.kcmbxMarca)
        Me.kgbxControlInterno.Panel.Controls.Add(Me.klblSubFamilia)
        Me.kgbxControlInterno.Panel.Controls.Add(Me.kcmbxSubFamilias)
        Me.kgbxControlInterno.Panel.Controls.Add(Me.klblUniidadMedida)
        Me.kgbxControlInterno.Panel.Controls.Add(Me.kcmbxUnidadMedida)
        Me.kgbxControlInterno.Size = New System.Drawing.Size(715, 101)
        Me.kgbxControlInterno.TabIndex = 25
        Me.kgbxControlInterno.Text = "Control Interno"
        Me.kgbxControlInterno.Values.Heading = "Control Interno"
        '
        'kgbxGenerales
        '
        Me.kgbxGenerales.Location = New System.Drawing.Point(27, 206)
        Me.kgbxGenerales.Name = "kgbxGenerales"
        '
        'kgbxGenerales.Panel
        '
        Me.kgbxGenerales.Panel.Controls.Add(Me.KryptonRadioButton2)
        Me.kgbxGenerales.Panel.Controls.Add(Me.KryptonRadioButton1)
        Me.kgbxGenerales.Panel.Controls.Add(Me.krbtnImpuesto3)
        Me.kgbxGenerales.Panel.Controls.Add(Me.krbtnImpuesto2)
        Me.kgbxGenerales.Panel.Controls.Add(Me.krbtnImpuesto1)
        Me.kgbxGenerales.Panel.Controls.Add(Me.ktxtCodigoInterno)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblCodigoInterno)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblNombre)
        Me.kgbxGenerales.Panel.Controls.Add(Me.ktxtNombre)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblPrecioCompra)
        Me.kgbxGenerales.Panel.Controls.Add(Me.kntxtPrecioCompra)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblImpuestoVenta)
        Me.kgbxGenerales.Panel.Controls.Add(Me.kntxtCantidadExistencias)
        Me.kgbxGenerales.Panel.Controls.Add(Me.kntxtImpuestoVenta)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblCantidadExistencias)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblPrecioCnImpuesto)
        Me.kgbxGenerales.Panel.Controls.Add(Me.kntxtPrecioVenta)
        Me.kgbxGenerales.Panel.Controls.Add(Me.kntxtPrecioCnImpuesto)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblPrecioVenta)
        Me.kgbxGenerales.Panel.Controls.Add(Me.klblUtilidad)
        Me.kgbxGenerales.Panel.Controls.Add(Me.kntxtUtilidad)
        Me.kgbxGenerales.Size = New System.Drawing.Size(715, 183)
        Me.kgbxGenerales.TabIndex = 26
        Me.kgbxGenerales.Text = "Generales"
        Me.kgbxGenerales.Values.Heading = "Generales"
        '
        'KryptonRadioButton2
        '
        Me.KryptonRadioButton2.Location = New System.Drawing.Point(540, 119)
        Me.KryptonRadioButton2.Name = "KryptonRadioButton2"
        Me.KryptonRadioButton2.Size = New System.Drawing.Size(172, 20)
        Me.KryptonRadioButton2.TabIndex = 31
        Me.KryptonRadioButton2.Values.Text = "Excento de Impuesto Venta"
        '
        'KryptonRadioButton1
        '
        Me.KryptonRadioButton1.Location = New System.Drawing.Point(381, 121)
        Me.KryptonRadioButton1.Name = "KryptonRadioButton1"
        Me.KryptonRadioButton1.Size = New System.Drawing.Size(153, 20)
        Me.KryptonRadioButton1.TabIndex = 30
        Me.KryptonRadioButton1.Values.Text = "Impuesto Personalizado"
        '
        'krbtnImpuesto3
        '
        Me.krbtnImpuesto3.Location = New System.Drawing.Point(256, 121)
        Me.krbtnImpuesto3.Name = "krbtnImpuesto3"
        Me.krbtnImpuesto3.Size = New System.Drawing.Size(119, 20)
        Me.krbtnImpuesto3.TabIndex = 29
        Me.krbtnImpuesto3.Values.Text = "Impuesto Venta 3"
        '
        'krbtnImpuesto2
        '
        Me.krbtnImpuesto2.Location = New System.Drawing.Point(131, 121)
        Me.krbtnImpuesto2.Name = "krbtnImpuesto2"
        Me.krbtnImpuesto2.Size = New System.Drawing.Size(119, 20)
        Me.krbtnImpuesto2.TabIndex = 28
        Me.krbtnImpuesto2.Values.Text = "Impuesto Venta 2"
        '
        'krbtnImpuesto1
        '
        Me.krbtnImpuesto1.Checked = True
        Me.krbtnImpuesto1.Location = New System.Drawing.Point(6, 121)
        Me.krbtnImpuesto1.Name = "krbtnImpuesto1"
        Me.krbtnImpuesto1.Size = New System.Drawing.Size(119, 20)
        Me.krbtnImpuesto1.TabIndex = 27
        Me.krbtnImpuesto1.Values.Text = "Impuesto General"
        '
        'ktxtCodigoInterno
        '
        Me.ktxtCodigoInterno.Location = New System.Drawing.Point(501, 93)
        Me.ktxtCodigoInterno.Name = "ktxtCodigoInterno"
        Me.ktxtCodigoInterno.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.ktxtCodigoInterno.ReadOnly = True
        Me.ktxtCodigoInterno.Size = New System.Drawing.Size(199, 20)
        Me.ktxtCodigoInterno.TabIndex = 26
        Me.ktxtCodigoInterno.Text = "El código se asignará automático"
        '
        'klblCodigoInterno
        '
        Me.klblCodigoInterno.Location = New System.Drawing.Point(400, 93)
        Me.klblCodigoInterno.Name = "klblCodigoInterno"
        Me.klblCodigoInterno.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblCodigoInterno.Size = New System.Drawing.Size(95, 20)
        Me.klblCodigoInterno.TabIndex = 25
        Me.klblCodigoInterno.Values.Text = "Código interno:"
        '
        'kgbxOpcionales
        '
        Me.kgbxOpcionales.Location = New System.Drawing.Point(26, 395)
        Me.kgbxOpcionales.Name = "kgbxOpcionales"
        '
        'kgbxOpcionales.Panel
        '
        Me.kgbxOpcionales.Panel.Controls.Add(Me.ktxtDescripcion)
        Me.kgbxOpcionales.Panel.Controls.Add(Me.klblDescripcion)
        Me.kgbxOpcionales.Panel.Controls.Add(Me.ktxtCodigoBarras)
        Me.kgbxOpcionales.Panel.Controls.Add(Me.klblCodigoBarras)
        Me.kgbxOpcionales.Size = New System.Drawing.Size(715, 198)
        Me.kgbxOpcionales.TabIndex = 27
        Me.kgbxOpcionales.Text = "Opcionales"
        Me.kgbxOpcionales.Values.Heading = "Opcionales"
        '
        'ktxtDescripcion
        '
        Me.ktxtDescripcion.Location = New System.Drawing.Point(119, 29)
        Me.ktxtDescripcion.Multiline = True
        Me.ktxtDescripcion.Name = "ktxtDescripcion"
        Me.ktxtDescripcion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.ktxtDescripcion.Size = New System.Drawing.Size(581, 132)
        Me.ktxtDescripcion.TabIndex = 29
        '
        'klblDescripcion
        '
        Me.klblDescripcion.Location = New System.Drawing.Point(36, 29)
        Me.klblDescripcion.Name = "klblDescripcion"
        Me.klblDescripcion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblDescripcion.Size = New System.Drawing.Size(77, 20)
        Me.klblDescripcion.TabIndex = 28
        Me.klblDescripcion.Values.Text = "Descripción:"
        '
        'ktxtCodigoBarras
        '
        Me.ktxtCodigoBarras.Location = New System.Drawing.Point(118, 3)
        Me.ktxtCodigoBarras.Name = "ktxtCodigoBarras"
        Me.ktxtCodigoBarras.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.ktxtCodigoBarras.Size = New System.Drawing.Size(582, 20)
        Me.ktxtCodigoBarras.TabIndex = 27
        '
        'klblCodigoBarras
        '
        Me.klblCodigoBarras.Location = New System.Drawing.Point(6, 3)
        Me.klblCodigoBarras.Name = "klblCodigoBarras"
        Me.klblCodigoBarras.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.klblCodigoBarras.Size = New System.Drawing.Size(107, 20)
        Me.klblCodigoBarras.TabIndex = 27
        Me.klblCodigoBarras.Values.Text = "Código de barras:"
        '
        'frmActualizarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 661)
        Me.Name = "frmActualizarProductos"
        Me.Text = "frmActualizarProducto"
        CType(Me.grbContainer.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.Panel.ResumeLayout(False)
        CType(Me.grbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContainer.ResumeLayout(False)
        CType(Me.kcmbxProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbxMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbxSubFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbxUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kgbxControlInterno.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbxControlInterno.Panel.ResumeLayout(False)
        Me.kgbxControlInterno.Panel.PerformLayout()
        CType(Me.kgbxControlInterno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbxControlInterno.ResumeLayout(False)
        CType(Me.kgbxGenerales.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbxGenerales.Panel.ResumeLayout(False)
        Me.kgbxGenerales.Panel.PerformLayout()
        CType(Me.kgbxGenerales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbxGenerales.ResumeLayout(False)
        CType(Me.kgbxOpcionales.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbxOpcionales.Panel.ResumeLayout(False)
        Me.kgbxOpcionales.Panel.PerformLayout()
        CType(Me.kgbxOpcionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgbxOpcionales.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kcmbxMarca As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents klblMarca As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbxProveedores As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents klblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgbxControlInterno As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents klblSubFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbxSubFamilias As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents klblUniidadMedida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbxUnidadMedida As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kntxtCantidadExistencias As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblCantidadExistencias As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kntxtPrecioVenta As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblPrecioVenta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kntxtUtilidad As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblUtilidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kntxtPrecioCnImpuesto As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblPrecioCnImpuesto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kntxtImpuestoVenta As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblImpuestoVenta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kntxtPrecioCompra As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klblPrecioCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents klblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgbxGenerales As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kgbxOpcionales As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents ktxtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents klblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtCodigoBarras As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents klblCodigoBarras As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtCodigoInterno As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents klblCodigoInterno As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents krbtnImpuesto3 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbtnImpuesto2 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents krbtnImpuesto1 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonRadioButton2 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonRadioButton1 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
