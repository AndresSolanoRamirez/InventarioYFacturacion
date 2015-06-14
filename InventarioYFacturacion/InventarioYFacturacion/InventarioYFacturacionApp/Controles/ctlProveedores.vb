Public Class ctlProveedores

    Private _proveedor As Proveedor
    Private _apr As AccionesProveedores
    Private _dtProveedores As DataTable

#Region "Acciones"

    Private Sub ctlProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        CargarProveedores()
    End Sub

    Public Sub Nuevo()
        CrearProveedor()
    End Sub

    Public Sub Editar()

        If dgvProveedores.RowCount > 0 Then
            EditarProveedor()
        Else
            Mensajes.ShowMessage("No existen proveedores", frmMessageBox.TipoMensaje.Informacion)
        End If

    End Sub

    Public Sub Eliminar()

        If dgvProveedores.RowCount > 0 Then
            DesactivarProveedor()
        Else
            Mensajes.ShowMessage("No existen proveedores", frmMessageBox.TipoMensaje.Informacion)
        End If

    End Sub

    Public Sub Activar()
        Dim dtProveedoresInactivos As DataTable = _apr.ObtieneProveedoresInactivos()

        If dtProveedoresInactivos.Rows.Count > 0 Then
            Dim fVentanaProveedoresInactivos As New frmProveedoresInactivos

            If fVentanaProveedoresInactivos.ShowDialog = DialogResult.OK Then
                Mensajes.ShowMessage("Listado de proveedores actualizado", frmMessageBox.TipoMensaje.Informacion)
            End If
            CargarProveedores()
        Else
            Mensajes.ShowMessage("No existen proveedores inactivos", frmMessageBox.TipoMensaje.Informacion)
        End If

    End Sub

    Public Sub Recargar()
        CargarProveedores()
    End Sub

    Private Sub tlsbtnBuscar_Click(sender As Object, e As EventArgs) Handles tlsbtnBuscar.Click
        If ValidaFiltro() Then
            If ValidaNumericos(tlstxtCodigo.Text) Then
                AplicarFiltro(tlstxtCodigo.Text, tlstxtFiltroNombre.Text, tlstxtFiltroCedJuridica.Text _
                              , tlstxtFiltroContacto.Text, tlstxtFiltroEmail.Text, tlstxtFiltroEmailContacto.Text)
            Else
                Mensajes.ShowMessage("El valor del código debe ser un número", frmMessageBox.TipoMensaje.Informacion)
            End If
        Else
            Mensajes.ShowMessage("Todos los filtros están vacios", frmMessageBox.TipoMensaje.Informacion)
        End If
    End Sub

    Private Sub tlsbtnClear_Click(sender As Object, e As EventArgs) Handles tlsbtnClear.Click
        Try
            LimpiarFiltro()
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrió un problema al limpiar todos los filtros", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub GenerarPlantilla()
        Try
            If Utilidades.GenerarArchivo(Utilidades.TipoArchivo.Proveedores) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ExportarDatos()
        Try
            If Utilidades.ExportarDatos(Utilidades.TipoArchivo.Proveedores, DatosParaExportar()) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ImportarDatos()

        Try
            _dtProveedores = Utilidades.ImportarDatos(Utilidades.TipoArchivo.Proveedores)
            If Not IsNothing(_dtProveedores) Then
                Dim fImportarDatos As New frmImportarDatos(frmImportarDatos.TipoCarga.Proveedores, _dtProveedores)

                If fImportarDatos.ShowDialog = DialogResult.OK Then
                    CargarProveedores()
                End If
            End If

        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Ocurrió un error al importar las proveedores. {0}", ex.Message), frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub

#End Region

#Region "Funciones"

    Private Sub InicializarComponentes()
        _proveedor = New Proveedor
        _apr = New AccionesProveedores
    End Sub

    Private Sub CargarProveedores()
        _dtProveedores = _apr.ObtieneProveedores

        'Dim dtActivo As DataTable = New DataTable
        'dtActivo.Columns.Add("activo", System.Type.GetType("System.Boolean"))
        'dtActivo.Columns.Add("nombre")

        'dtActivo.Rows.Add(False, "Inactivo")
        'dtActivo.Rows.Add(True, "Activo")

        'Dim column As DataGridViewComboBoxColumn = DirectCast(dgvProveedores.Columns(9), DataGridViewComboBoxColumn)

        'column.DataSource = dtActivo
        'column.ValueMember = "activo"
        'column.DisplayMember = "nombre"
        'column.ReadOnly = True

        dgvProveedores.DataSource = _dtProveedores
    End Sub

    Private Sub CrearProveedor()
        Dim fNuevoProveedor As New frmActualizaProveedor(-1)

        If fNuevoProveedor.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Proveedor creado con éxito", frmMessageBox.TipoMensaje.Informacion)            
        End If
        CargarProveedores()
    End Sub

    Private Sub EditarProveedor()
        Dim fEditarProveedor As New frmActualizaProveedor(dgvProveedores.CurrentRow.Cells("idProveedor").Value)

        If fEditarProveedor.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Proveedor editado con éxito", frmMessageBox.TipoMensaje.Informacion)            
        End If
        CargarProveedores()
    End Sub

    Private Sub DesactivarProveedor()
        If Mensajes.ShowMessage("Está seguro que desea eliminar el proveedor " & dgvProveedores.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _apr.EliminarProveedor(dgvProveedores.CurrentRow.Cells("idProveedor").Value)
            Mensajes.ShowMessage("El proveedor fue eliminado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarProveedores()
        End If
    End Sub

    Private Function ValidaNumericos(ByVal valor As String) As Boolean

        If valor <> "" AndAlso Not IsNumeric(valor) Then
            Return False
        End If

        Return True
    End Function

    ' =====================================================================================
    '   Valida que al menos uno de todos los campos de filtro esté lleno
    ' =====================================================================================
    Private Function ValidaFiltro() As Boolean
        If tlstxtCodigo.Text = "" AndAlso tlstxtFiltroNombre.Text = "" _
            AndAlso tlstxtFiltroCedJuridica.Text = "" AndAlso tlstxtFiltroContacto.Text = "" _
            AndAlso tlstxtFiltroEmail.Text = "" AndAlso tlstxtFiltroEmailContacto.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub AplicarFiltro(ByRef codigo As String, ByRef nombre As String _
                                   , ByRef cedulaJuridica As String, ByRef contacto As String _
                                   , ByRef email As String, ByRef emailContacto As String)
        Dim filtro As String = String.Empty
        Dim BindingSource1 As Windows.Forms.BindingSource = New BindingSource

        BindingSource1.DataSource = _dtProveedores

        Try
            If codigo <> "" Then
                filtro = "idProveedor= " & codigo
            End If

            If nombre <> "" Then
                If filtro = String.Empty Then
                    filtro = "nombre LIKE '%" & nombre & "%'"
                Else
                    filtro = filtro & " And " & "nombre LIKE '%" & nombre & "%'"
                End If
            End If

            If cedulaJuridica <> "" Then
                If filtro = String.Empty Then
                    filtro = "cedulaJuridica LIKE '%" & cedulaJuridica & "%'"
                Else
                    filtro = filtro & " And " & "cedulaJuridica LIKE '%" & cedulaJuridica & "%'"
                End If
            End If

            If contacto <> "" Then
                If filtro = String.Empty Then
                    filtro = "contacto LIKE '%" & contacto & "%'"
                Else
                    filtro = filtro & " And " & "contacto LIKE '%" & contacto & "%'"
                End If
            End If

            If email <> "" Then
                If filtro = String.Empty Then
                    filtro = "email LIKE '%" & email & "%'"
                Else
                    filtro = filtro & " And " & "email LIKE '%" & email & "%'"
                End If
            End If

            If emailContacto <> "" Then
                If filtro = String.Empty Then
                    filtro = "emailContacto LIKE '%" & emailContacto & "%'"
                Else
                    filtro = filtro & " And " & "emailContacto LIKE '%" & emailContacto & "%'"
                End If
            End If

            If Not filtro = String.Empty Then
                'For Each row As DataRow In _dtProveedores.Select(filtro)
                '    Mensajes.ShowMessage("Filtrados: " & row.Item("nombre"), frmMessageBox.TipoMensaje.Informacion)
                'Next
                BindingSource1.Filter = filtro

                dgvProveedores.DataSource = BindingSource1
            End If

        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrió un error al procesar el filtrado.", frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub

    Private Sub LimpiarFiltro()
        tlstxtCodigo.Clear()
        tlstxtFiltroNombre.Clear()
        tlstxtFiltroCedJuridica.Clear()
        tlstxtFiltroContacto.Clear()
        tlstxtFiltroEmail.Clear()
        tlstxtFiltroEmailContacto.Clear()

        CargarProveedores()

    End Sub

    Private Function DatosParaExportar() As DataTable

        Dim dtDatosExportar As New DataTable

        dtDatosExportar.Columns.Add("Nombre")
        dtDatosExportar.Columns.Add("Ced. Jurídica")
        dtDatosExportar.Columns.Add("Contacto")
        dtDatosExportar.Columns.Add("Teléfono1")
        dtDatosExportar.Columns.Add("Teléfono2")
        dtDatosExportar.Columns.Add("Email")
        dtDatosExportar.Columns.Add("Email Contacto")
        dtDatosExportar.Columns.Add("Dirección")

        For Each fila As DataRow In _dtProveedores.Rows
            Dim newRow As DataRow = dtDatosExportar.NewRow

            newRow.Item("Nombre") = fila.Item("nombre")
            newRow.Item("Ced. Jurídica") = fila.Item("cedulaJuridica")
            newRow.Item("Contacto") = fila.Item("contacto")
            newRow.Item("Teléfono1") = fila.Item("telefono1")
            newRow.Item("Teléfono2") = fila.Item("telefono2")
            newRow.Item("Email") = fila.Item("email")
            newRow.Item("Email Contacto") = fila.Item("emailContacto")
            newRow.Item("Dirección") = fila.Item("direccion")

            dtDatosExportar.Rows.Add(newRow)
        Next
        Return dtDatosExportar
    End Function

#End Region

End Class
