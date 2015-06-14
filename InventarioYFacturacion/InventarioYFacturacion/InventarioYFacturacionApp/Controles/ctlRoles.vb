Public Class ctlRoles

    Private _ar As AccionesRoles
    Private _dtRoles As DataTable
    Private _estructura As Estructura

    Enum Estructura
        ROL
        PERMISO
    End Enum

#Region "Acciones"
    Private Sub ctlRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtRoles = New DataTable
        _ar = New AccionesRoles
        CargarRoles()
    End Sub

    Public Sub Refrescar()
        CargarRoles()
    End Sub

    Public Sub Nuevo()
        CrearRol()
        CargarRoles()
    End Sub

    Public Sub Editar()
        Try
            EditarRol(_estructura)
            CargarRoles()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            EliminarRol()
            CargarRoles()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub
#End Region

#Region "Funciones"
    Private Sub CrearRol()
        Dim fNuevoRol As New frmActualizaInsertaEstructura(-1, frmActualizaInsertaEstructura.TipoInsercion.ROL)

        If fNuevoRol.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Rol Creado con Éxito", frmMessageBox.TipoMensaje.Informacion)
        End If
    End Sub

    Private Sub EditarRol(ByRef estructura As Estructura)

        Dim fEditarRol As New frmActualizaInsertaEstructura(dgvRoles.CurrentRow.Cells("idRol").Value, frmActualizaInsertaEstructura.TipoInsercion.ROL)

        If fEditarRol.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Rol editado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarRoles()
        End If

    End Sub

    Private Sub CargarRoles()
        _dtRoles = _ar.ObtieneRoles
        dgvRoles.DataSource = _dtRoles
    End Sub

    Private Sub EliminarRol()

        If Mensajes.ShowMessage("Está seguro que desea eliminar el rol " & dgvRoles.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _ar.EliminarRol(dgvRoles.CurrentRow.Cells("idRol").Value)
            Mensajes.ShowMessage("El rol fue eliminado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarRoles()
        End If

    End Sub
#End Region

End Class
