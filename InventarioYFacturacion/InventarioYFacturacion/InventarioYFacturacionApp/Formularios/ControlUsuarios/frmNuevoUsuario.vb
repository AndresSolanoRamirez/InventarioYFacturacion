Public Class frmNuevoUsuario

#Region "Acciones"

    Private _au As AccionesUsuario
    Private _usuarioInsertar As New Usuario

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    ' Posibles valores de _idUsuario:
    '                                -1 --> Nuevo
    '                                x > 0 --> Editar (Porque es usuario existente)
    Public Sub New(ByVal idUsuario As Integer)

        Me.New()
        _au = New AccionesUsuario
        _usuarioInsertar.IdUsuario = idUsuario

        If _usuarioInsertar.IdUsuario > 0 Then

            _usuarioInsertar = _au.ObtieneUsuarioXId(idUsuario)
            AsignaValores(_usuarioInsertar)

            lblEncabezado.Text = "Va a editar al usuario: " & _usuarioInsertar.Nombre
            pBoxEncabezado.Image = My.Resources.edit_user_64
        Else
            lblEncabezado.Text = "Ingrese todos los datos para insertar un nuevo usuario"
            pBoxEncabezado.Image = My.Resources.add_user_2_64
        End If

    End Sub

    Private Sub frmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _au = New AccionesUsuario

    End Sub

    Protected Overrides Sub OnAceptar()

        Try
            If ValidaUsuario() Then
                InsertarUsuario()
                MyBase.OnAceptar()
                Mensajes.ShowMessage("El usuario fue creado con éxito. En unos minutos será aprobado", "Usuario creado con éxito", frmMessageBox.TipoMensaje.Informacion, Nothing, Nothing)
            Else
                Mensajes.ShowMessage("Todos los campos son requeridos", frmMessageBox.TipoMensaje.Err)
            End If
        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Error al procesar la transacción: {0}", ex.Message), frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub

    Protected Overrides Sub OnCancel()
        MyBase.OnCancel()
    End Sub

    Private Sub txtRContrasena_Leave(sender As Object, e As EventArgs) Handles txtRContrasena.Leave
        If Not ValidaContrasenas() Then
            Mensajes.ShowMessage("Las contraseñas no coinciden", frmMessageBox.TipoMensaje.Err)
            txtRContrasena.Text = ""
            txtRContrasena.Focus()
        End If
    End Sub

    Private Sub txtContrasena_Leave(sender As Object, e As EventArgs) Handles txtContrasena.Leave
        If Not ValidaContrasena() Then
            Mensajes.ShowMessage("Contraseña debe tener un mínimo de 6 caractéres, un número y una mayúscula", "Error al digitar contraseña", frmMessageBox.TipoMensaje.Informacion, 580)
            txtContrasena.Focus()
        End If
    End Sub

    Private Sub txtCorreoElectronico_Leave(sender As Object, e As EventArgs) Handles txtCorreoElectronico.Leave
        If Not ValidateEmail(txtCorreoElectronico.Text) Then
            Mensajes.ShowMessage("Debe ingresar un email válido", frmMessageBox.TipoMensaje.Informacion)
            txtCorreoElectronico.Focus()
        End If
    End Sub

#End Region

#Region "Funciones"
    ' =========================================================================
    '  Inserta o actualiza un usuario
    ' =========================================================================
    Private Sub InsertarUsuario()

        'Lo primero es settear el objeto usuario
        ConstruyeUsuario()
        'Actualiza el usuario
        _au.ActualizaUsuario(_usuarioInsertar)

    End Sub
    ' =========================================================================
    '   Llena el objeto usuario con los datos para actualizar o insertar
    ' =========================================================================
    Private Sub ConstruyeUsuario()

        _usuarioInsertar.Nombre = txtNombre.Text
        _usuarioInsertar.Apellidos = txtApellidos.Text
        _usuarioInsertar.Telefono = txtTelefono.Text
        _usuarioInsertar.Email = txtCorreoElectronico.Text
        _usuarioInsertar.Contrasena = txtContrasena.Text
        _usuarioInsertar.PreguntaSeguridad = txtPSeguridad.Text
        _usuarioInsertar.RespuestaSeguridad = txtRespuesta.Text
        _usuarioInsertar.Activo = False
        _usuarioInsertar.CuentaFallos = 0

    End Sub

    ' =========================================================================
    '   Obtiene un usuaario por código de usuario
    ' =========================================================================
    Private Sub ObtenieneUsuario(ByRef idUsuario As Integer)

        _usuarioInsertar = _au.ObtieneUsuarioXId(idUsuario)

    End Sub

    ' =========================================================================
    '   Valida que todos los datos del usuario estén completos
    ' =========================================================================
    Private Function ValidaUsuario() As Boolean
        If txtNombre.Text.Equals("") Or txtApellidos.Text.Equals("") Or txtTelefono.Text.Equals("") _
            Or txtCorreoElectronico.Text.Equals("") Or txtContrasena.Text.Equals("") Or _
            txtPSeguridad.Text.Equals("") Or txtRespuesta.Text.Equals("") Or txtRContrasena.Text.Equals("") Then
            Return False
        End If
        Return True
    End Function

    ' =========================================================================
    '   Valida la contraseña con la repetición de la misma
    ' =========================================================================
    Public Function ValidaContrasenas() As Boolean

        If txtContrasena.Text.Equals(txtRContrasena.Text) Then
            Return True
        End If

        Return False

    End Function

    ' =========================================================================
    '   Analiza que la contraseña cumpla con las mínimas reglas definidas
    ' =========================================================================
    Private Function ValidaContrasena() As Boolean

        'La primer validación es que tenga al menos 6 caractéres
        If txtContrasena.Text.Length < 6 Then
            Return False
            Exit Function
        End If

        Dim cuentaMayusculas As Integer = 0
        Dim cuentaNumeros As Integer = 0

        For contador As Integer = 0 To txtContrasena.TextLength - 1 Step 1

            Dim caracter As Char = txtContrasena.Text(contador)

            If Char.IsUpper(caracter) Then
                cuentaMayusculas += 1
            End If
            If Char.IsNumber(caracter) Then
                cuentaNumeros += 1
            End If

        Next

        If cuentaMayusculas = 0 Then
            Return False
            Exit Function
        ElseIf cuentaNumeros = 0 Then
            Return False
            Exit Function
        End If

        Return True
    End Function

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
    Private Sub AsignaValores(ByRef usuario As Usuario)
        txtNombre.Text = usuario.Nombre
        txtApellidos.Text = usuario.Apellidos
        txtTelefono.Text = usuario.Telefono
        txtCorreoElectronico.Text = usuario.Email
        txtContrasena.Text = usuario.Contrasena
        txtRContrasena.Text = usuario.Contrasena
        txtPSeguridad.Text = usuario.PreguntaSeguridad
        txtRespuesta.Text = usuario.RespuestaSeguridad
    End Sub

#End Region

End Class