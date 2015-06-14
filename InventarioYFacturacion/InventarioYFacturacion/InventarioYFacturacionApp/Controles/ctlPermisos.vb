Public Class ctlPermisos

    Private _ap As AccionesPermisos
    Private _dtPermisos As DataTable    

#Region "Acciones"
    Private Sub ctlPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtPermisos = New DataTable
        _ap = New AccionesPermisos
        CargarPermisos()
    End Sub

    Public Sub Nuevo()
        CrearPermiso()
        CargarPermisos()
    End Sub

    Public Sub Editar()
        Try
            EditarPermiso()
            CargarPermisos()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            EliminarRol()
            CargarPermisos()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Refrescar()
        CargarPermisos()
    End Sub
#End Region

#Region "Funciones"
    Private Sub CargarPermisos()
        _dtPermisos = _ap.ObtienePermisos
        dgvRoles.DataSource = _dtPermisos
    End Sub

    Private Sub CrearPermiso()
        Dim fActualizaInsertaEstructura As New frmActualizaInsertaEstructura(-1, frmActualizaInsertaEstructura.TipoInsercion.FAMILIA)

        If fActualizaInsertaEstructura.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Permiso editado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarPermisos()
        End If
    End Sub

    Private Sub EditarPermiso()

        Dim fEditarRol As New frmActualizaInsertaEstructura(dgvRoles.CurrentRow.Cells("idPermiso").Value, frmActualizaInsertaEstructura.TipoInsercion.PERMISO)

        If fEditarRol.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Permiso editado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarPermisos()
        End If

    End Sub

    Private Sub EliminarRol()

        If Mensajes.ShowMessage("Está seguro que desea eliminar el permiso " & dgvRoles.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _ap.EliminarPermiso(dgvRoles.CurrentRow.Cells("idPermiso").Value)
            Mensajes.ShowMessage("El permiso fue eliminado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarPermisos()
        End If

    End Sub    
#End Region

End Class
