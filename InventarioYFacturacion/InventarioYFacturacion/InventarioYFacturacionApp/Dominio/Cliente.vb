Public Class Cliente

    Public Sub New()
        MyBase.New()
    End Sub

    Private _idCliente As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _identificacion As String
    Private _email As String
    Private _telefono As String
    Private _direccion As String
    Private _fechaCreacion As Date
    Private _fechaUltimaModificacion As Date

    Public Sub New(ByVal idCliente As Integer, ByVal nombre As String, ByVal apellidos As String _
                   , ByVal identificacion As String, ByVal telefono As String _
                   , ByVal email As String, ByVal direccion As String _
                   , ByVal fechaCreacion As Date, ByVal fechaUltimaModificacion As Date)

        _idCliente = idCliente
        _nombre = nombre
        _apellidos = apellidos
        _telefono = telefono
        _identificacion = identificacion
        _email = email
        _direccion = direccion
        _fechaCreacion = fechaCreacion
        _fechaUltimaModificacion = fechaUltimaModificacion
    End Sub

    Public Property IdCliente() As Integer
        Get
            ' Gets the property value.
            Return _idCliente
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _idCliente = Value
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

    Public Property Identificacion() As String
        Get
            ' Gets the property value.
            Return _identificacion
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _identificacion = Value
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
