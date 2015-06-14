Public Class frmRoles

    Private _ar As AccionesRoles
    Private _ap As AccionesPermisos
    Private _dtRoles, _dtPermisos As DataTable
    Private _estructura As Estructura

    Enum Estructura
        ROL
        PERMISO
    End Enum

#Region "Acciones"

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal estructura As Estructura)

        Me.New()
        _ar = New AccionesRoles
        _ap = New AccionesPermisos
        _estructura = estructura

        btnAceptar.Text = "Insertar"

        If estructura = frmRoles.Estructura.ROL Then

            lblEncabezado.Text = "Muesta el listado de los roles que existen en la aplicación"
            pBoxEncabezado.Image = My.Resources.filled_box_64

            CargarRoles()

        Else

            Me.Text = "Permisos"
            lblEncabezado.Text = "Muesta el listado de los permisos que existen en la aplicación"
            pBoxEncabezado.Image = My.Resources.filled_box_64
            dgvRoles.Columns("idRol").DataPropertyName = "idPermiso"
            dgvRoles.Columns("idRol").HeaderText = "Cod. Permiso"

            CargarPermisos()

        End If

    End Sub

    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Overrides Sub OnCancel()
        MyBase.OnCancel()
    End Sub

    Protected Overrides Sub OnAceptar()

        Try

            If _estructura = Estructura.ROL Then
                Dim fNuevoRol As New frmActualizaInsertaEstructura(-1, frmActualizaInsertaEstructura.TipoInsercion.ROL)

                If fNuevoRol.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Mensajes.ShowMessage("Rol insertado con éxito", frmMessageBox.TipoMensaje.Informacion)
                    CargarRoles()
                End If
            Else
                Dim fNuevoRol As New frmActualizaInsertaEstructura(-1, frmActualizaInsertaEstructura.TipoInsercion.PERMISO)

                If fNuevoRol.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Mensajes.ShowMessage("Permiso insertado con éxito", frmMessageBox.TipoMensaje.Informacion)
                    CargarPermisos()
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEditarRol_Click(sender As Object, e As EventArgs) Handles btnEditarRol.Click
        Try
            EditarRol(_estructura)
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub btnEliminarRol_Click(sender As Object, e As EventArgs) Handles btnEliminarRol.Click
        Try
            EliminarRol()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub
#End Region

#Region "Funciones"
    Private Sub CargarRoles()
        _dtRoles = _ar.ObtieneRoles
        dgvRoles.DataSource = _dtRoles
    End Sub

    Private Sub CargarPermisos()
        _dtPermisos = _ap.ObtienePermisos
        dgvRoles.DataSource = _dtPermisos
    End Sub

    Private Sub EditarRol(ByRef estructura As Estructura)

        If estructura = frmRoles.Estructura.ROL Then
            Dim fEditarRol As New frmActualizaInsertaEstructura(dgvRoles.CurrentRow.Cells("idRol").Value, frmActualizaInsertaEstructura.TipoInsercion.ROL)

            If fEditarRol.ShowDialog = Windows.Forms.DialogResult.OK Then
                Mensajes.ShowMessage("Rol editado con éxito", frmMessageBox.TipoMensaje.Informacion)
                CargarRoles()
            End If
        Else
            Dim fEditarRol As New frmActualizaInsertaEstructura(dgvRoles.CurrentRow.Cells("idRol").Value, frmActualizaInsertaEstructura.TipoInsercion.PERMISO)

            If fEditarRol.ShowDialog = Windows.Forms.DialogResult.OK Then
                Mensajes.ShowMessage("Permiso editado con éxito", frmMessageBox.TipoMensaje.Informacion)
                CargarRoles()
            End If
        End If
    End Sub

    Private Sub EliminarRol()

        If _estructura = Estructura.ROL Then
            If Mensajes.ShowMessage("Está seguro que desea eliminar el rol " & dgvRoles.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
                _ar.EliminarRol(dgvRoles.CurrentRow.Cells("idRol").Value)
                Mensajes.ShowMessage("El rol fue eliminado con éxito", frmMessageBox.TipoMensaje.Informacion)
                CargarRoles()
            End If
        Else
            If Mensajes.ShowMessage("Está seguro que desea eliminar el permiso " & dgvRoles.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
                _ap.EliminarPermiso(dgvRoles.CurrentRow.Cells("idRol").Value)
                Mensajes.ShowMessage("El permiso fue eliminado con éxito", frmMessageBox.TipoMensaje.Informacion)
                CargarPermisos()
            End If
        End If

    End Sub
#End Region

End Class