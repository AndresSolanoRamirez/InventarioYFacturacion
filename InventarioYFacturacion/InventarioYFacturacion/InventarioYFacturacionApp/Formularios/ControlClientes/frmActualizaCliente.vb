Public Class frmActualizaCliente

#Region "Acciones"

    Private _ac As AccionesClientes
    Private _cliente As New Cliente

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    ' Posibles valores de _idCliente
    '                                -1 --> Nuevo
    '                                x > 0 --> Editar (Porque es usuario existente)
    Public Sub New(ByVal idCliente As Integer)

        Me.New()
        _ac = New AccionesClientes
        _cliente.IdCliente = idCliente

        If _cliente.IdCliente > 0 Then

            Me.Text = "Editar Cliente"

            ObtieneCliente(_cliente.IdCliente)
            AsignaValores(_cliente)

            lblEncabezado.Text = "Va a editar el cliente: " & _cliente.Nombre
            pBoxEncabezado.Image = My.Resources.edit_user_64

            kchbxInsercionMultiple.Checked = False
            kchbxInsercionMultiple.Visible = False
        Else
            lblEncabezado.Text = "Va a insertar un nuevo proveedor"
            pBoxEncabezado.Image = My.Resources.add_user_2_64
        End If

    End Sub

    Private Sub frmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ac = New AccionesClientes
    End Sub

    Protected Overrides Sub OnAceptar()

        Try
            InsertarProveedor()
            If kchbxInsercionMultiple.Checked Then
                LimpiarCampos()
            Else
                MyBase.OnAceptar()
            End If
        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Error al procesar la transacción: {0}", ex.Message), frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub

    Protected Overrides Sub OnCancel()
        MyBase.OnCancel()
    End Sub

    Protected Overrides Function ValidarForm() As Boolean

        If Me.SetError(txtNombre, txtNombre.Text.Equals(""), "Debe Ingresar un nombre") Then
            txtNombre.Focus()
            Return False
        End If

        If Me.SetError(txtApellidos, txtApellidos.Text.Equals(""), "Debe Ingresar los apellidos") Then
            txtApellidos.Focus()
            Return False
        End If

        If Me.SetError(txtIdentificacion, txtIdentificacion.Text.Equals(""), "Debe Ingresar la identificación") Then
            txtIdentificacion.Focus()
            Return False
        End If

        If Me.SetError(txtTelefono, txtTelefono.Text.Equals(""), "El teléfono es un campo obligatorio") Then
            txtTelefono.Focus()
            Return False
        End If

        If Me.SetError(txtEmail, txtEmail.Text.Equals(""), "Los correos electrónicos son requeridos") Then
            txtEmail.Focus()
            Return False
        End If

        If Me.SetError(txtEmail, Not ValidateEmail(txtEmail.Text), "Debe ingresar un email válido") Then
            txtEmail.Focus()
            Return False
        End If

        Return MyBase.ValidarForm()

    End Function

    'Private Sub txtCorreoElectronico_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
    '    If Not ValidateEmail(txtEmail.Text) Then
    '        Mensajes.ShowMessage("Debe ingresar un email válido", frmMessageBox.TipoMensaje.Informacion)
    '        txtEmail.Focus()
    '    End If
    'End Sub

#End Region

#Region "Funciones"
    ' =========================================================================
    '  Inserta o actualiza un proveedor
    ' =========================================================================
    Private Sub InsertarProveedor()

        'Lo primero es settear el objeto usuario
        ConstruyeCliente()
        'Actualiza el proveedor
        _ac.ActualizaCliente(_cliente)

    End Sub
    ' =========================================================================
    '   Llena el objeto cliente con los datos para actualizar o insertar
    ' =========================================================================
    Private Sub ConstruyeCliente()

        _cliente.Nombre = txtNombre.Text
        _cliente.Apellidos = txtApellidos.Text
        _cliente.Identificacion = txtIdentificacion.Text
        _cliente.Telefono = txtTelefono.Text
        _cliente.Email = txtEmail.Text
        _cliente.Direccion = txtDireccion.Text

    End Sub

    ' =========================================================================
    '   Obtiene un cliente por código de cliente
    ' =========================================================================
    Private Sub ObtieneCliente(ByRef idCliente As Integer)

        _cliente = _ac.ObtieneClienteXId(idCliente)

    End Sub

    ' =========================================================================
    '   Valida que el campo de correo electrónico contenga en realidad un 
    '   correo electrónico
    ' =========================================================================
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    ' =========================================================================
    '   Asigna los datos del cliente obtenido a la pantalla
    ' =========================================================================
    Private Sub AsignaValores(ByRef cliente As Cliente)
        txtNombre.Text = cliente.Nombre
        txtApellidos.Text = cliente.Apellidos
        txtIdentificacion.Text = cliente.Identificacion
        txtTelefono.Text = cliente.Telefono
        txtEmail.Text = cliente.Email
        txtDireccion.Text = cliente.Direccion
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtIdentificacion.Clear()
        txtTelefono.Clear()        
        txtEmail.Clear()        
        txtDireccion.Clear()
    End Sub

#End Region

End Class