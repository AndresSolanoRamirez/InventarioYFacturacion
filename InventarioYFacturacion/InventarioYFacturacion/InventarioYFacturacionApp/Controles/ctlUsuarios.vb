Public Class ctlUsuarios

    Private _au As AccionesUsuario
    Private _ar As AccionesRoles
    Private _dtUsuarios As DataTable

#Region "Acciones"

    Private Sub ctlUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _au = New AccionesUsuario
        _ar = New AccionesRoles

        Refrescar()

    End Sub

#End Region

#Region "Funciones"

    Public Sub Refrescar()
        CargaUsuarios()
        LLenarFiltroRoles()
        LLenarFiltroCondiciones()
    End Sub

    Private Sub CargaUsuarios()
        _dtUsuarios = _au.ObtieneUsuarios()

        Dim dtActivo As DataTable = New DataTable
        dtActivo.Columns.Add("activo", System.Type.GetType("System.Boolean"))
        dtActivo.Columns.Add("nombre")

        dtActivo.Rows.Add(False, "Inactivo")
        dtActivo.Rows.Add(True, "Activo")

        Dim column As DataGridViewComboBoxColumn = DirectCast(dgvUsuarios.Columns(8), DataGridViewComboBoxColumn)

        column.DataSource = dtActivo
        column.ValueMember = "activo"
        column.DisplayMember = "nombre"
        column.ReadOnly = True

        dgvUsuarios.DataSource = _dtUsuarios

    End Sub

    Private Sub LLenarFiltroRoles()
        Dim dtRoles As DataTable = _ar.ObtieneRoles
        Dim newRow As DataRow = dtRoles.NewRow

        newRow.Item("idRol") = -1
        newRow.Item("nombre") = "Todos"

        dtRoles.Rows.Add(newRow)

        cbxTiposUsuarios.DataSource = dtRoles

        cbxTiposUsuarios.DisplayMember = "nombre"
        cbxTiposUsuarios.ValueMember = "idRol"

        cbxTiposUsuarios.SelectedItem = -1
    End Sub

    Private Sub LLenarFiltroCondiciones()

        Dim dt As New DataTable

        dt.Columns.Add("idCondicion")
        dt.Columns.Add("nombreCondicion")

        Dim dtRow0 As DataRow = dt.NewRow

        dtRow0.Item("idCondicion") = -1
        dtRow0.Item("nombreCondicion") = "Todos"

        Dim dtRow1 As DataRow = dt.NewRow

        dtRow1.Item("idCondicion") = 1
        dtRow1.Item("nombreCondicion") = "Activo"

        Dim dtRow2 As DataRow = dt.NewRow

        dtRow2.Item("idCondicion") = 0
        dtRow2.Item("nombreCondicion") = "Inactivo"

        dt.Rows.Add(dtRow0)
        dt.Rows.Add(dtRow1)
        dt.Rows.Add(dtRow2)


        cbxCondicion.DataSource = dt

        cbxCondicion.DisplayMember = "nombreCondicion"
        cbxCondicion.ValueMember = "idCondicion"

        cbxCondicion.SelectedItem = -1
    End Sub

    Public Sub NuevoUsuario()

        Dim fNuevoUsuario As New frmNuevoUsuario(-1)

        If fNuevoUsuario.ShowDialog = DialogResult.OK Then
            Mensajes.ShowMessage("Usuario insertado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargaUsuarios()
        End If

    End Sub

    Public Sub EditarUsuario()

        If dgvUsuarios.RowCount = 0 Or IsNothing(dgvUsuarios) Then
            Mensajes.ShowMessage("La lista está vacia", frmMessageBox.TipoMensaje.Err)

        Else

            Dim row As DataGridViewRow = dgvUsuarios.CurrentRow

            Dim fNuevoUsuario As New frmNuevoUsuario(row.Cells("idUsuario").Value)

            If fNuevoUsuario.ShowDialog = DialogResult.OK Then
                Mensajes.ShowMessage("Usuario Actualizado con éxito", frmMessageBox.TipoMensaje.Informacion)
                CargaUsuarios()
            End If

        End If

    End Sub

    Public Sub EliminarUsuario()

        If dgvUsuarios.RowCount = 0 Or IsNothing(dgvUsuarios) Then
            Mensajes.ShowMessage("La lista está vacia", frmMessageBox.TipoMensaje.Err)

        Else

            Dim row As DataGridViewRow = dgvUsuarios.CurrentRow

            If Mensajes.ShowMessage("Desea eliminar el usuario " & row.Cells("nombre").Value & "?", frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
                _au.EliminarUsuario(row.Cells("idUsuario").Value)
                CargaUsuarios()
            End If

        End If

    End Sub

    Public Sub ActivarUsuario()

        If dgvUsuarios.RowCount = 0 Or IsNothing(dgvUsuarios) Then
            Mensajes.ShowMessage("La lista está vacia", frmMessageBox.TipoMensaje.Err)

        Else

            Dim row As DataGridViewRow = dgvUsuarios.CurrentRow

            If row.Cells("activo").Value = False Then
                If Mensajes.ShowMessage("Desea activar el usuario " & row.Cells("nombre").Value & "?", frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
                    _au.ActivarUsuario(row.Cells("idUsuario").Value)
                    Mensajes.ShowMessage("Usuario activado con éxito", frmMessageBox.TipoMensaje.Informacion)
                    CargaUsuarios()
                End If
            Else
                Mensajes.ShowMessage("El usuario ya está activo", frmMessageBox.TipoMensaje.Informacion)
            End If

        End If

    End Sub

#End Region
End Class
