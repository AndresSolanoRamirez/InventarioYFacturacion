Public Class frmActualizaProveedor

#Region "Acciones"

    Private _apr As AccionesProveedores
    Private _proveedor As New Proveedor

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    ' Posibles valores de _idProveedor
    '                                -1 --> Nuevo
    '                                x > 0 --> Editar (Porque es usuario existente)
    Public Sub New(ByVal idProveedor As Integer)

        Me.New()
        _apr = New AccionesProveedores
        _proveedor.IdProveedor = idProveedor

        If _proveedor.IdProveedor > 0 Then

            ObtenieneProveedor(_proveedor.IdProveedor)
            AsignaValores(_proveedor)

            lblEncabezado.Text = "Va a editar el proveedor: " & _proveedor.Nombre
            pBoxEncabezado.Image = My.Resources.edit_user_64

            kchbxInsercionMultiple.Checked = False
            kchbxInsercionMultiple.Visible = False
            ktxtCodInterno.Enabled = False
        Else
            lblEncabezado.Text = "Va a insertar un nuevo proveedor"
            pBoxEncabezado.Image = My.Resources.add_user_2_64
        End If

    End Sub

    Private Sub frmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _apr = New AccionesProveedores
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

        If Me.SetError(txtCedulaJuridica, txtCedulaJuridica.Text.Equals(""), "Debe Ingresar la cédula jurídica") Then
            txtCedulaJuridica.Focus()
            Return False
        End If

        If Me.SetError(txtContacto, txtContacto.Text.Equals(""), "Debe Ingresar el nombre del contacto") Then
            txtContacto.Focus()
            Return False
        End If

        If Me.SetError(txtTelefono1, txtTelefono1.Text.Equals(""), "El teléfono 1 es un campo obligatorio") Then
            txtTelefono1.Focus()
            Return False
        End If

        If Me.SetError(txtEmail, txtEmail.Text.Equals(""), "Los correos electrónicos son requeridos") Then
            txtEmail.Focus()
            Return False
        End If

        If Me.SetError(txtEmailContacto, txtEmailContacto.Text.Equals(""), "Los correos electrónicos son requeridos") Then
            txtEmailContacto.Focus()
            Return False
        End If

        If Me.SetError(ktxtCodInterno, ktxtCodInterno.Text.Equals(""), "Es necesario que el proveedor tenga un código interno") Then
            ktxtCodInterno.Focus()
            Return False
        End If

        Return MyBase.ValidarForm()

    End Function

    Private Sub txtCorreoElectronico_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If Not ValidateEmail(txtEmail.Text) Then
            Mensajes.ShowMessage("Debe ingresar un email válido", frmMessageBox.TipoMensaje.Informacion)
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmailContacto_Leave(sender As Object, e As EventArgs) Handles txtEmailContacto.Leave
        If Not ValidateEmail(txtEmailContacto.Text) Then
            Mensajes.ShowMessage("Debe ingresar un email válido", frmMessageBox.TipoMensaje.Informacion)
            txtEmailContacto.Focus()
        End If
    End Sub

#End Region

#Region "Funciones"
    ' =========================================================================
    '  Inserta o actualiza un proveedor
    ' =========================================================================
    Private Sub InsertarProveedor()

        'Lo primero es settear el objeto usuario
        ConstruyeProveedor()
        'Actualiza el proveedor
        _apr.ActualizaProveedor(_proveedor)

    End Sub
    ' =========================================================================
    '   Llena el objeto usuario con los datos para actualizar o insertar
    ' =========================================================================
    Private Sub ConstruyeProveedor()

        _proveedor.Nombre = txtNombre.Text
        _proveedor.CedulaJuridica = txtCedulaJuridica.Text
        _proveedor.Contacto = txtContacto.Text
        _proveedor.Telefono1 = txtTelefono1.Text
        _proveedor.Telefono2 = txtTelefono2.Text
        _proveedor.Email = txtEmail.Text
        _proveedor.EmailContacto = txtEmailContacto.Text
        _proveedor.Direccion = txtDireccion.Text
        _proveedor.Activo = True
        _proveedor.CodigoInterno = ktxtCodInterno.Text
        _proveedor.Responsable = "Andrés"

    End Sub

    ' =========================================================================
    '   Obtiene un proveedor por código de proveedor
    ' =========================================================================
    Private Sub ObtenieneProveedor(ByRef idProveedor As Integer)

        _proveedor = _apr.ObtieneProveedorXId(idProveedor)

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
    '   Asigna los datos del usuario obtenido a la pantalla
    ' =========================================================================
    Private Sub AsignaValores(ByRef proveedor As Proveedor)
        txtNombre.Text = proveedor.Nombre
        txtCedulaJuridica.Text = proveedor.CedulaJuridica
        txtContacto.Text = proveedor.Contacto
        txtTelefono1.Text = proveedor.Telefono1
        txtTelefono2.Text = proveedor.Telefono2
        txtEmail.Text = proveedor.Email
        txtEmailContacto.Text = proveedor.EmailContacto
        txtDireccion.Text = proveedor.Direccion
        ktxtCodInterno.Text = proveedor.CodigoInterno
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtCedulaJuridica.Clear()
        txtContacto.Clear()
        txtTelefono1.Clear()
        txtTelefono2.Clear()
        txtEmail.Clear()
        txtEmailContacto.Clear()
        txtDireccion.Clear()
    End Sub

#End Region

End Class