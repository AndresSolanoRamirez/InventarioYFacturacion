Imports ComponentFactory.Krypton.Toolkit

Public Class frmAsignacionesRoles

    Private _ar As AccionesRoles
    Private _au As AccionesUsuario
    Private _ap As AccionesPermisos
    Private _tab As TabPage
    Private _idRol As Integer

#Region "Acciones"
    Private Sub frmAsignacionesRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ar = New AccionesRoles
        _au = New AccionesUsuario
        _ap = New AccionesPermisos

        lblEncabezado.Text = "Pantalla de asignaciones. Del lado derecho está lo DISPONIBLE y del lado izquierdo lo ASIGNADO"

        LLenarFiltroRoles(cbxRoles)

        Dim idRolSeleccionado As Integer = cbxRoles.SelectedValue
        _tab = tpRoles
        LLenaTables(idRolSeleccionado, _tab)

    End Sub

    Private Sub cbxRoles_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxRoles.SelectedValueChanged
        _idRol = cbxRoles.SelectedValue
        LLenaTables(_idRol, _tab)
    End Sub

    Private Sub cbxRoles2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxRoles2.SelectedValueChanged
        _idRol = cbxRoles2.SelectedValue
        LLenaTables(_idRol, _tab)
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Try
            AsignarUsuarios()
            LLenaTables(cbxRoles.SelectedValue, _tab)
        Catch ex As Exception
            Mensajes.ShowMessage(ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub btnAsignarPermiso_Click(sender As Object, e As EventArgs) Handles btnAsignarPermiso.Click
        Try
            AsignarPermisos()
            LLenaTables(cbxRoles2.SelectedValue, _tab)
        Catch ex As Exception
            Mensajes.ShowMessage(ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            QuitarUsuarios()
            LLenaTables(cbxRoles.SelectedValue, _tab)
        Catch ex As Exception
            Mensajes.ShowMessage(ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub btnDenegarPermiso_Click(sender As Object, e As EventArgs) Handles btnDenegarPermiso.Click
        Try
            QuitarUsuarios()
            LLenaTables(cbxRoles.SelectedValue, _tab)
        Catch ex As Exception
            Mensajes.ShowMessage(ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub tcAsignaciones_Selected(sender As Object, e As TabControlEventArgs) Handles tcAsignaciones.Selected
        If tcAsignaciones.SelectedTab Is tpRoles Then
            _tab = tpRoles
            LLenarFiltroRoles(cbxRoles)
            LLenaTables(_idRol, _tab)
        Else
            _tab = tpPermisos
            LLenarFiltroRoles(cbxRoles2)
            LLenaTables(_idRol, _tab)
        End If
    End Sub
#End Region

#Region "Funciones"

    Private Sub AsignarUsuarios()
        For Each item As DataGridViewRow In dgvDisponibles.SelectedRows
            _au.AsignarUsuarioARol(cbxRoles.SelectedValue, item.Cells("idUsuario").Value)
        Next
    End Sub

    Private Sub AsignarPermisos()
        For Each item As DataGridViewRow In kdgvDisponiblesPermisos.SelectedRows
            _ap.AsignarPermisoARol(cbxRoles2.SelectedValue, item.Cells("idPermiso").Value)
        Next
    End Sub

    Private Sub QuitarUsuarios()
        For Each item As DataGridViewRow In kdgvAsignados.SelectedRows
            _au.QuitarUsuarioARol(cbxRoles.SelectedValue, item.Cells(0).Value)
        Next
    End Sub

    Private Sub QuitarPermisos()
        For Each item As DataGridViewRow In kdgvAsignadosPermisos.SelectedRows
            _ap.QuitarPermisoARol(cbxRoles2.SelectedValue, item.Cells(0).Value)
        Next
    End Sub

    Private Sub LLenarFiltroRoles(ByVal combo As KryptonComboBox)
        Dim dtRoles As DataTable = _ar.ObtieneRoles
        Dim newRow As DataRow = dtRoles.NewRow

        combo.DisplayMember = "nombre"
        combo.ValueMember = "idRol"

        combo.DataSource = dtRoles

    End Sub

    ' ==============================================================================
    '   Llena los datatables dependiendo del tab que pasa por parámetro y el idRol
    ' ==============================================================================
    Private Sub LLenaTables(ByVal idRol As Integer, ByVal tab As TabPage)

        If tab Is tpRoles Then
            Dim dtUsuarios As DataSet = _au.ObtieneUsuariosXRol(idRol)
            dgvDisponibles.DataSource = dtUsuarios.Tables(1)
            kdgvAsignados.DataSource = dtUsuarios.Tables(0)
        Else
            Dim dtPermisos As DataSet = _ap.ObtienePermisosXRol(idRol)
            kdgvDisponiblesPermisos.DataSource = dtPermisos.Tables(1)
            kdgvAsignadosPermisos.DataSource = dtPermisos.Tables(0)
        End If

    End Sub

#End Region

End Class