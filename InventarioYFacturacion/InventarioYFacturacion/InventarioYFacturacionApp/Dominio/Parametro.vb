Public Class Parametro

    Private _idParametro As Integer
    Private _nombre As String
    Private _value As String
    Private _fechaCreacion As Date
    Private _fechaUltimaModificacion As Date
    Private _permiteEliminar As Boolean
    Private _permiteModificar As Boolean

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal idParametro As Integer, ByVal nombre As String, ByVal _value As String _
                   , ByVal fechaCreacion As Date, ByVal fechaUltimaModificacion As Date, ByVal permiteEliminar As Boolean, ByVal permiteModificar As Boolean)
        idParametro = _idParametro
        _nombre = nombre
        _value = _value
        _fechaCreacion = fechaCreacion
        _fechaUltimaModificacion = fechaUltimaModificacion
        _permiteEliminar = permiteEliminar
        _permiteModificar = permiteModificar
    End Sub

    Public Property IdParametro() As Integer
        Get
            ' Gets the property value.
            Return _idParametro
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _idParametro = Value
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

    Public Property Value As String
        Get
            ' Gets the property value.
            Return _value
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _value = Value
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

    Public Property PermiteEliminar() As Boolean
        Get
            ' Gets the property value.
            Return _permiteEliminar
        End Get
        Set(ByVal Value As Boolean)
            ' Sets the property value.
            _permiteEliminar = Value
        End Set
    End Property

    Public Property PermiteModificar() As Boolean
        Get
            ' Gets the property value.
            Return _permiteModificar
        End Get
        Set(ByVal Value As Boolean)
            ' Sets the property value.
            _permiteModificar = Value
        End Set
    End Property
End Class
