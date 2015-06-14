Public Class Producto

    Private _idProducto As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _codigoBarras As String
    Private _cantidadExistencias As Integer
    Private _precioCompra As Double
    Private _impuestoVenta As Integer
    Private _montoImpuestoVenta As Double
    Private _precioCnImpuesto As Double
    Private _precioVenta As Double
    Private _utilidad As Double
    Private _unidadMedida As UnidadMedida
    Private _marca As Marcas
    Private _subFamilia As SubFamilia
    Private _proveedor As Proveedor
    Private _codigoInterno As String
    Private _responsable As String
    Private _fechaCreacion As Date
    Private _fechaUltimaModificacion As Date

    Public Sub New()        
        MyBase.New()
        _unidadMedida = New UnidadMedida
        _marca = New Marcas
        _subFamilia = New SubFamilia
        _proveedor = New Proveedor
    End Sub

    Public Sub New(ByVal idProducto As Integer, ByVal nombre As String, ByVal descripcion As String _
                   , ByVal codigoBarras As String, ByVal cantidadExistencias As Integer _
                   , ByVal precioCompra As Double, ByVal impuestoVenta As Integer _
                   , ByVal montoImpuestoVenta As Double, ByVal precioCnImpuesto As Double, ByVal precioVenta As Double _
                   , ByVal utilidad As Double, unidadMedida As UnidadMedida, ByVal marca As Marcas _
                   , ByVal subFamilia As SubFamilia, ByVal proveedor As Proveedor, ByVal codigoInterno As String _
                   , ByVal responsable As String, ByVal fechaCreacion As Date, ByVal fechaModificacion As Date)
        _idProducto = idProducto
        _nombre = nombre
        _descripcion = descripcion
        _codigoBarras = codigoBarras
        _cantidadExistencias = cantidadExistencias
        _precioCompra = precioCompra
        _precioCnImpuesto = precioCnImpuesto
        _impuestoVenta = impuestoVenta
        _montoImpuestoVenta = montoImpuestoVenta
        _precioVenta = precioVenta
        _utilidad = utilidad

        _unidadMedida = unidadMedida
        _marca = marca
        _subFamilia = subFamilia
        _proveedor = proveedor

        _codigoInterno = codigoInterno
        _responsable = responsable

        _fechaCreacion = fechaCreacion
        _fechaUltimaModificacion = fechaModificacion
    End Sub

    Public Property IdProducto() As Integer
        Get
            ' Gets the property value.
            Return _idProducto
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _idProducto = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            ' Gets the property value.
            Return _nombre
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _nombre = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            ' Gets the property value.
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _descripcion = Value
        End Set
    End Property

    Public Property CodigoBarras() As String
        Get
            ' Gets the property value.
            Return _codigoBarras
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _codigoBarras = Value
        End Set
    End Property

    Public Property CantidadExistencias() As Integer
        Get
            ' Gets the property value.
            Return _cantidadExistencias
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _cantidadExistencias = Value
        End Set
    End Property

    Public Property PrecioCompra() As Double
        Get
            ' Gets the property value.
            Return _precioCompra
        End Get
        Set(ByVal Value As Double)
            ' Sets the property value.
            _precioCompra = Value
        End Set
    End Property

    Public Property ImpuestoVenta() As Integer
        Get
            ' Gets the property value.
            Return _impuestoVenta
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _impuestoVenta = Value
        End Set
    End Property

    Public Property MontoImpuestoVenta() As Double
        Get
            ' Gets the property value.
            Return _montoImpuestoVenta
        End Get
        Set(ByVal Value As Double)
            ' Sets the property value.
            _montoImpuestoVenta = Value
        End Set
    End Property

    Public Property PrecioVenta() As Double
        Get
            ' Gets the property value.
            Return _precioVenta
        End Get
        Set(ByVal Value As Double)
            ' Sets the property value.
            _precioVenta = Value
        End Set
    End Property

    Public Property PrecioCnImpuesto() As Double
        Get
            ' Gets the property value.
            Return _precioCnImpuesto
        End Get
        Set(ByVal Value As Double)
            ' Sets the property value.
            _precioCnImpuesto = Value
        End Set
    End Property

    Public Property Utilidad() As Double
        Get
            ' Gets the property value.
            Return _utilidad
        End Get
        Set(ByVal Value As Double)
            ' Sets the property value.
            _utilidad = Value
        End Set
    End Property

    Public Property UnidadMedida() As UnidadMedida
        Get
            ' Gets the property value.
            Return _unidadMedida
        End Get
        Set(ByVal Value As UnidadMedida)
            ' Sets the property value.
            _unidadMedida = Value
        End Set
    End Property

    Public Property Marca() As Marcas
        Get
            ' Gets the property value.
            Return _marca
        End Get
        Set(ByVal Value As Marcas)
            ' Sets the property value.
            _marca = Value
        End Set
    End Property

    Public Property SubFamila() As SubFamilia
        Get
            ' Gets the property value.
            Return _subFamilia
        End Get
        Set(ByVal Value As SubFamilia)
            ' Sets the property value.
            _subFamilia = Value
        End Set
    End Property

    Public Property Proveedor() As Proveedor
        Get
            ' Gets the property value.
            Return _proveedor
        End Get
        Set(ByVal Value As Proveedor)
            ' Sets the property value.
            _proveedor = Value
        End Set
    End Property

    Public Property CodigoInterno() As String
        Get
            ' Gets the property value.
            Return _codigoInterno
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _codigoInterno = Value
        End Set
    End Property

    Public Property Responsable() As String
        Get
            ' Gets the property value.
            Return _responsable
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _responsable = Value
        End Set
    End Property

    Public Property FechaCreacion() As Date
        Get
            ' Gets the property value.
            Return _fechaCreacion
        End Get
        Set(ByVal Value As Date)
            ' Sets the property value.
            _fechaCreacion = Value
        End Set
    End Property

    Public Property FechaUltimaModificacion() As Date
        Get
            ' Gets the property value.
            Return _fechaUltimaModificacion
        End Get
        Set(ByVal Value As Date)
            ' Sets the property value.
            _fechaUltimaModificacion = Value
        End Set
    End Property
End Class
