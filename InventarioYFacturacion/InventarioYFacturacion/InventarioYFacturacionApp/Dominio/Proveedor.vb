Public Class Proveedor

    Public Sub New()
        MyBase.New()
    End Sub

    Private _idProveedor As Integer
    Private _nombre As String
    Private _cedulaJuridica As String
    Private _contacto As String
    Private _telefono1 As String
    Private _telefono2 As String
    Private _email As String
    Private _emailContacto As String
    Private _direccion As String
    Private _activo As Boolean
    Private _codigoInterno As String
    Private _responsable As String
    Private _fechaCreacion As Date
    Private _fechaUltimaModificacion As Date

    Public Sub New(ByVal idProveedor As Integer, ByVal nombre As String, ByVal cedulaJuridica As String _
                   , ByVal contacto As String, ByVal telefono1 As String, ByVal telefono2 As String _
                   , ByVal email As String, ByVal emailContacto As String, ByVal direccion As String _
                   , ByVal activo As Boolean, ByVal codigoInterno As String, ByVal responsable As String _
                   , ByVal fechaCreacion As Date, ByVal fechaUltimaModificacion As Date)

        _idProveedor = idProveedor
        _nombre = nombre
        _cedulaJuridica = cedulaJuridica
        _contacto = contacto
        _telefono1 = telefono1
        _telefono2 = telefono2
        _email = email
        _emailContacto = emailContacto
        _direccion = direccion
        _activo = activo
        _codigoInterno = codigoInterno
        _responsable = responsable
        _fechaCreacion = FechaCreacion
        _fechaUltimaModificacion = FechaUltimaModificacion

    End Sub

    Public Property IdProveedor() As Integer
        Get
            ' Gets the property value.
            Return _idProveedor
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _idProveedor = Value
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

    Public Property CedulaJuridica() As String
        Get
            ' Gets the property value.
            Return _cedulaJuridica
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _cedulaJuridica = Value
        End Set
    End Property

    Public Property Contacto() As String
        Get
            ' Gets the property value.
            Return _contacto
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _contacto = Value
        End Set
    End Property

    Public Property Telefono1() As String
        Get
            ' Gets the property value.
            Return _telefono1
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _telefono1 = Value
        End Set
    End Property

    Public Property Telefono2() As String
        Get
            ' Gets the property value.
            Return _telefono2
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _telefono2 = Value
        End Set
    End Property

    Public Property Email() As String
        Get
            ' Gets the property value.
            Return _email
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _email = Value
        End Set
    End Property

    Public Property EmailContacto() As String
        Get
            ' Gets the property value.
            Return _emailContacto
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _emailContacto = Value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            ' Gets the property value.
            Return _direccion
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _direccion = Value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            ' Gets the property value.
            Return _activo
        End Get
        Set(ByVal Value As Boolean)
            ' Sets the property value.
            _activo = Value
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
