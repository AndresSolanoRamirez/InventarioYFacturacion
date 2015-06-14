Public Class Usuario

    Public Sub New()
        MyBase.New()
    End Sub

    Private _idUsuario As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _telefono As String
    Private _email As String
    Private _contrasena As String
    Private _preguntaSeguridad As String
    Private _respuestaSeguridad As String
    Private _activo As Boolean
    Private _cuentaFallos As Integer
    Private _fechaCreacion As Date
    Private _fechaUltimaModificacion As Date

    Public Sub New(ByVal idUsuario As Integer, ByVal nombre As String, ByVal apellidos As String _
                   , ByVal telefono As String, ByVal email As String, ByVal contrasena As String _
                   , ByVal preguntaSeguridad As String, ByVal respuestaSeguridad As String _
                   , ByVal activo As Boolean, ByVal cuentaFallos As Integer, ByVal fechaCreacion As Date _
                   , ByVal fechaUltimaModificacion As Date)
        _idUsuario = idUsuario
        _nombre = nombre
        _apellidos = apellidos
        _telefono = telefono
        _email = email
        _contrasena = contrasena
        _preguntaSeguridad = preguntaSeguridad
        _respuestaSeguridad = respuestaSeguridad
        _activo = activo
        _cuentaFallos = cuentaFallos
        _fechaCreacion = fechaCreacion
        _fechaUltimaModificacion = fechaUltimaModificacion
    End Sub


    Public Property IdUsuario() As Integer
        Get
            ' Gets the property value.
            Return _idUsuario
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _idUsuario = Value
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

    Public Property Apellidos() As String
        Get
            ' Gets the property value.
            Return _apellidos
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _apellidos = Value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            ' Gets the property value.
            Return _telefono
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _telefono = Value
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

    Public Property Contrasena() As String
        Get
            ' Gets the property value.
            Return _contrasena
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _contrasena = Value
        End Set
    End Property

    Public Property PreguntaSeguridad() As String
        Get
            ' Gets the property value.
            Return _preguntaSeguridad
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _preguntaSeguridad = Value
        End Set
    End Property

    Public Property RespuestaSeguridad() As String
        Get
            ' Gets the property value.
            Return _respuestaSeguridad
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _respuestaSeguridad = Value
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

    Public Property CuentaFallos() As Integer
        Get
            ' Gets the property value.
            Return _cuentaFallos
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _cuentaFallos = Value
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
