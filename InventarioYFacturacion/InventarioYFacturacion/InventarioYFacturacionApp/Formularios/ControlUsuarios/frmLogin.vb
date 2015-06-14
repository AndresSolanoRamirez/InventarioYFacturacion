Public Class frmLogin

    Private _au As AccionesUsuario
    Public _usuario As Usuario

#Region "Acciones"
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _au = New AccionesUsuario
        pBoxEncabezado.Image = My.Resources.administrator_2_64
        lblEncabezado.Text = "Digite sus credenciales para ingresar al sistema."
    End Sub

    Private Sub lnklblOlvidoContrasena_LinkClicked(sender As Object, e As EventArgs) Handles lnklblOlvidoContrasena.LinkClicked

    End Sub

    Private Sub KryptonLinkLabel1_LinkClicked(sender As Object, e As EventArgs) Handles KryptonLinkLabel1.LinkClicked
        MostrarRegistro()
    End Sub

    Protected Overrides Sub OnAceptar()

        Dim usuario As Usuario = _au.ObtieneUsuarioXCredenciales(txtNombreUsuario.Text, txtPass.Text)

        If IsNothing(usuario) Then
            Mensajes.ShowMessage("Credenciales incorrectos", frmMessageBox.TipoMensaje.Err)
        ElseIf usuario.Activo = False Then
            Mensajes.ShowMessage("El usuario está inactivo. Contacte con el administrador", frmMessageBox.TipoMensaje.Err)
        Else
            Mensajes.ShowMessage("Bienvenid@ " & usuario.Nombre, frmMessageBox.TipoMensaje.Informacion)
            _usuario = usuario
            MyBase.OnAceptar()
        End If

    End Sub

    Protected Overrides Function ValidarForm() As Boolean

        If Me.SetError(txtNombreUsuario, txtNombreUsuario.Text.Equals(""), "Debe Ingresar un nombre de usuario") Then
            txtNombreUsuario.Focus()
            Return False
        End If

        If Me.SetError(txtPass, txtPass.Text.Equals(""), "Debe Ingresar la constraseña") Then
            txtPass.Focus()
            Return False
        End If

        Return MyBase.ValidarForm()
    End Function
#End Region

#Region "Funciones"
    Private Sub MostrarRegistro()
        Dim fNUsuario As New frmNuevoUsuario(-1)

        If fNUsuario.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("El usuario fue insertado correctamente, sin embargo no puede acceder a la aplicación hasta que sea activado por el administrador", frmMessageBox.TipoMensaje.Informacion)
        End If
    End Sub
#End Region

End Class