Public Class frmActualizarProductos

    Private _idProducto As Integer
    Private _dtProveedores, _dtMarcas, _dtSubFamilias, _dtUnidadesMedida, _dtParametros As DataTable

    Private _producto As Producto

    Private _ap As AccionesProveedores
    Private _am As AccionesMarcas
    Private _asf As AccionesSubFamilias
    Private _aum As AccionesUnidadMedida
    Private _aparam As AccionesParametros
    Private _apr As AccionesProductos

#Region "Acciones"
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal idProducto)
        Me.New()

        _idProducto = idProducto

        InicializarComponentes()

        If (_idProducto = -1) Then
            ConfigurarPantallaPNuevoProducto()
        Else
            'ConfigurarPantallaPProductoExistente()
        End If

    End Sub

    Protected Overrides Sub OnAceptar()

        Try
            CrearEstructura()
            _apr.ActualizaProducto(_producto)
        Catch ex As Exception
            Mensajes.ShowMessage("Algo salió mal!!!!", "Error Insertar Producto", frmMessageBox.TipoMensaje.Err, ex.Message)
        End Try

        MyBase.OnAceptar()

    End Sub

    Protected Overrides Function ValidarForm() As Boolean
        If Me.SetError(kcmbxProveedores, kcmbxProveedores.SelectedValue = -1, "Debe seleccionar un proveedor") Then
            kcmbxProveedores.Focus()
            Return False
        End If

        If Me.SetError(kcmbxMarca, kcmbxMarca.SelectedValue = -1, "Debe seleccionar una marca") Then
            kcmbxMarca.Focus()
            Return False
        End If

        If Me.SetError(kcmbxSubFamilias, kcmbxSubFamilias.SelectedValue = -1, "Debe seleccionar una sub familia") Then
            kcmbxSubFamilias.Focus()
            Return False
        End If

        If Me.SetError(kcmbxUnidadMedida, kcmbxUnidadMedida.SelectedValue = -1, "Debe seleccionar una unidad de medida") Then
            kcmbxUnidadMedida.Focus()
            Return False
        End If

        If Me.SetError(ktxtNombre, ktxtNombre.Text.Equals(""), "Debe Ingresar un nombre") Then
            ktxtNombre.Focus()
            Return False
        End If

        If Me.SetError(kntxtPrecioCompra, kntxtPrecioCompra.Value = 0, "Debe Ingresar un precio de compra") Then
            kntxtPrecioCompra.Focus()
            Return False
        End If

        If Me.SetError(kntxtImpuestoVenta, kntxtImpuestoVenta.Value = 0, "Debe Ingresar un I.V") Then
            kntxtImpuestoVenta.Focus()
            Return False
        End If

        If Me.SetError(kntxtPrecioCnImpuesto, kntxtPrecioCnImpuesto.Value = 0, "Debe Ingresar un precio con impuesto") Then
            kntxtPrecioCnImpuesto.Focus()
            Return False
        End If

        If Me.SetError(kntxtPrecioVenta, kntxtPrecioVenta.Value = 0, "Debe Ingresar un precio de venta") Then
            kntxtPrecioVenta.Focus()
            Return False
        End If

        Return MyBase.ValidarForm()
    End Function

    Private Sub krbtnImpuesto1_CheckedChanged(sender As Object, e As EventArgs) Handles krbtnImpuesto1.CheckedChanged
        If Not IsNothing(_dtParametros) Then
            ImpuestoGeneral()
        End If
    End Sub

    Private Sub krbtnImpuesto2_CheckedChanged(sender As Object, e As EventArgs) Handles krbtnImpuesto2.CheckedChanged
        Impuesto2()
    End Sub

    Private Sub krbtnImpuesto3_CheckedChanged(sender As Object, e As EventArgs) Handles krbtnImpuesto3.CheckedChanged
        Impuesto3()
    End Sub

    Private Sub KryptonRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles KryptonRadioButton1.CheckedChanged
        ImpuestoPersonalizado()
    End Sub

    Private Sub kntxtPrecioCompra_Leave(sender As Object, e As EventArgs) Handles kntxtPrecioCompra.Leave
        Try
            AsignarPrecioCnImpuesto(kntxtPrecioCompra.Value, kntxtImpuestoVenta.Value)
        Catch ex As Exception
            Mensajes.ShowMessage("Error al ingreas un precio de compra", "Precio en cero", frmMessageBox.TipoMensaje.Err, ex.Message)
        End Try
    End Sub

    Private Sub kntxtUtilidad_Leave(sender As Object, e As EventArgs) Handles kntxtUtilidad.Leave
        Try
            AsignarPrecioVenta(kntxtPrecioCnImpuesto.Value, kntxtUtilidad.Value)
        Catch ex As Exception
            Mensajes.ShowMessage("Error al ingreas un precio con impuesto", "Precio en cero", frmMessageBox.TipoMensaje.Err, ex.Message)
        End Try        
    End Sub

    Private Sub kntxtImpuestoVenta_Leave(sender As Object, e As EventArgs) Handles kntxtImpuestoVenta.Leave
        Try
            If kntxtPrecioCompra.Value > 0 Then
                AsignarPrecioCnImpuesto(kntxtPrecioCompra.Value, kntxtImpuestoVenta.Value)
            End If

            If kntxtUtilidad.Value > 0 AndAlso kntxtPrecioCnImpuesto.Value > 0 Then
                AsignarPrecioVenta(kntxtPrecioCnImpuesto.Value, kntxtUtilidad.Value)
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Error al ingreas un precio de compra", "Precio en cero", frmMessageBox.TipoMensaje.Err, ex.Message)
        End Try
    End Sub
#End Region

#Region "Funciones"

    Private Sub ConfigurarPantallaPNuevoProducto()
        lblEncabezado.Text = " Complete todos los espacios requeridos para la correcta inserción del producto"
        pBoxEncabezado.Image = My.Resources.plus_5_64_green
        Me.Text = "Nuevo Producto"
        ImpuestoGeneral()
    End Sub

    Private Sub InicializarComponentes()

        _ap = New AccionesProveedores
        _am = New AccionesMarcas
        _asf = New AccionesSubFamilias
        _aum = New AccionesUnidadMedida
        _aparam = New AccionesParametros
        _apr = New AccionesProductos

        LlenarComboProveedores()
        LlenarComboMarcas()
        LlenarComboSubFamilias()
        LlenarComboUnidadesMedida()
        CargarImpuestos()


    End Sub

    Private Sub AsignarPrecioCnImpuesto(ByRef precioCompra As Double, ByRef impuesto As Integer)

        If precioCompra = 0 Or IsNothing(precioCompra) Then
            Throw New Exception("Debe ingresar un precio de compra")
        Else
            Dim impuestoConvertido As Decimal = Convert.ToDecimal("0," & impuesto)
            kntxtPrecioCnImpuesto.Value = (impuestoConvertido * precioCompra) + precioCompra
        End If

    End Sub

    Private Sub AsignarPrecioVenta(ByRef precioCnImpuesto As Double, ByRef utilidad As Integer)

        If precioCnImpuesto = 0 Or IsNothing(precioCnImpuesto) Then
            Throw New Exception("Debe existir un precio con impuesto")
        Else
            Dim impuestoConvertido As Decimal = Convert.ToDecimal("0," & utilidad)
            kntxtPrecioVenta.Value = (impuestoConvertido * precioCnImpuesto) + precioCnImpuesto
        End If

    End Sub

#Region "Configuración de Combos"
    Private Sub LlenarComboProveedores()
        _dtProveedores = _ap.ObtieneProveedores
        Dim newRow As DataRow = _dtProveedores.NewRow

        newRow.Item("idProveedor") = -1
        newRow.Item("nombre") = "Seleccione un proveedor"

        _dtProveedores.Rows.Add(newRow)

        kcmbxProveedores.DataSource = _dtProveedores

        kcmbxProveedores.DisplayMember = "nombre"
        kcmbxProveedores.ValueMember = "idProveedor"

        kcmbxProveedores.SelectedValue = -1
    End Sub

    Private Sub LlenarComboMarcas()
        _dtMarcas = _am.ObtieneMarcas
        Dim newRow As DataRow = _dtMarcas.NewRow

        newRow.Item("idMarca") = -1
        newRow.Item("nombre") = "Seleccione una marca"

        _dtMarcas.Rows.Add(newRow)

        kcmbxMarca.DataSource = _dtMarcas

        kcmbxMarca.DisplayMember = "nombre"
        kcmbxMarca.ValueMember = "idMarca"

        kcmbxMarca.SelectedValue = -1
    End Sub

    Private Sub LlenarComboSubFamilias()
        _dtSubFamilias = _asf.ObtieneSubFamilias
        Dim newRow As DataRow = _dtSubFamilias.NewRow

        newRow.Item("idSubFamilia") = -1
        newRow.Item("nombre") = "Seleccione una sub familia"

        _dtSubFamilias.Rows.Add(newRow)

        kcmbxSubFamilias.DataSource = _dtSubFamilias

        kcmbxSubFamilias.DisplayMember = "nombre"
        kcmbxSubFamilias.ValueMember = "idSubFamilia"

        kcmbxSubFamilias.SelectedValue = -1
    End Sub

    Private Sub LlenarComboUnidadesMedida()
        _dtUnidadesMedida = _aum.ObtieneUnidadesMedida
        Dim newRow As DataRow = _dtUnidadesMedida.NewRow

        newRow.Item("idUnidadMedida") = -1
        newRow.Item("nombre") = "Seleccione una unidad d medida"

        _dtUnidadesMedida.Rows.Add(newRow)

        kcmbxUnidadMedida.DataSource = _dtUnidadesMedida

        kcmbxUnidadMedida.DisplayMember = "nombre"
        kcmbxUnidadMedida.ValueMember = "idUnidadMedida"

        kcmbxUnidadMedida.SelectedValue = -1
    End Sub
#End Region

#Region "Configuración de Impuestos"

    Private Sub CargarImpuestos()

        Try
            _dtParametros = _aparam.ObtieneImpuestos

            If IsNothing(_dtParametros) Then
                Throw New Exception("No existen parámetros")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub ImpuestoGeneral()

        Dim consulta As String = "idParametro = 1"

        kntxtImpuestoVenta.Value = _dtParametros.Select(consulta).First.Item("value")
        kntxtImpuestoVenta.ReadOnly = True
        kntxtImpuestoVenta.Tag = _dtParametros.Select(consulta).First.Item("idParametro")

        If kntxtPrecioCompra.Value > 0 Then
            AsignarPrecioCnImpuesto(kntxtPrecioCompra.Value, kntxtImpuestoVenta.Value)
        End If

        If kntxtUtilidad.Value > 0 AndAlso kntxtPrecioCnImpuesto.Value > 0 Then
            AsignarPrecioVenta(kntxtPrecioCnImpuesto.Value, kntxtUtilidad.Value)
        End If

    End Sub

    Private Sub Impuesto2()

        Dim consulta As String = "idParametro = 3"

        kntxtImpuestoVenta.Value = _dtParametros.Select(consulta).First.Item("value")
        kntxtImpuestoVenta.ReadOnly = True
        kntxtImpuestoVenta.Tag = _dtParametros.Select(consulta).First.Item("idParametro")

        If kntxtPrecioCompra.Value > 0 Then
            AsignarPrecioCnImpuesto(kntxtPrecioCompra.Value, kntxtImpuestoVenta.Value)
        End If

        If kntxtUtilidad.Value > 0 AndAlso kntxtPrecioCnImpuesto.Value > 0 Then
            AsignarPrecioVenta(kntxtPrecioCnImpuesto.Value, kntxtUtilidad.Value)
        End If

    End Sub

    Private Sub Impuesto3()

        Dim consulta As String = "idParametro = 4"

        kntxtImpuestoVenta.Value = _dtParametros.Select(consulta).First.Item("value")
        kntxtImpuestoVenta.ReadOnly = True
        kntxtImpuestoVenta.Tag = _dtParametros.Select(consulta).First.Item("idParametro")

        If kntxtPrecioCompra.Value > 0 Then
            AsignarPrecioCnImpuesto(kntxtPrecioCompra.Value, kntxtImpuestoVenta.Value)
        End If

        If kntxtUtilidad.Value > 0 AndAlso kntxtPrecioCnImpuesto.Value > 0 Then
            AsignarPrecioVenta(kntxtPrecioCnImpuesto.Value, kntxtUtilidad.Value)
        End If

    End Sub

    Private Sub ImpuestoPersonalizado()

        kntxtImpuestoVenta.ReadOnly = False
        kntxtImpuestoVenta.Value = 0

        If kntxtPrecioCompra.Value > 0 Then
            AsignarPrecioCnImpuesto(kntxtPrecioCompra.Value, kntxtImpuestoVenta.Value)
        End If

        If kntxtUtilidad.Value > 0 AndAlso kntxtPrecioCnImpuesto.Value > 0 Then
            AsignarPrecioVenta(kntxtPrecioCnImpuesto.Value, kntxtUtilidad.Value)
        End If

    End Sub

    Private Sub CrearEstructura()

        _producto = New Producto

        _producto.IdProducto = _idProducto
        _producto.Nombre = ktxtNombre.Text
        _producto.Descripcion = ktxtDescripcion.Text
        _producto.CodigoBarras = ktxtCodigoBarras.Text
        _producto.CantidadExistencias = kntxtCantidadExistencias.Value
        _producto.PrecioCompra = kntxtPrecioCompra.Value
        _producto.ImpuestoVenta = kntxtImpuestoVenta.Tag
        _producto.MontoImpuestoVenta = kntxtImpuestoVenta.Value
        _producto.PrecioCnImpuesto = kntxtPrecioCnImpuesto.Value
        _producto.Utilidad = kntxtUtilidad.Value
        _producto.PrecioVenta = kntxtImpuestoVenta.Value
        _producto.CantidadExistencias = kntxtCantidadExistencias.Value

        _producto.UnidadMedida = _aum.ObtieneUnidadMedidaXCodigo(kcmbxUnidadMedida.SelectedValue)
        _producto.Proveedor = _ap.ObtieneProveedorXId(kcmbxProveedores.SelectedValue)
        _producto.Marca = _am.ObtieneMarcaXCodigo(kcmbxMarca.SelectedValue)
        _producto.SubFamila = _asf.ObtieneSubFamiliaXCodigo(kcmbxSubFamilias.SelectedValue)


    End Sub

#End Region

#End Region
End Class