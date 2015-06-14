Public Class ctlClientes

    Private _cliente As Cliente
    Private _ac As AccionesClientes
    Private _dtClientes As DataTable

#Region "Acciones"

    Private Sub ctlProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        CargarClientes()
    End Sub

    Public Sub Refrescar()
        CargarClientes()
    End Sub

    Public Sub Nuevo()
        CrearCliente()
    End Sub

    Public Sub Editar()

        If dgvClientes.RowCount > 0 Then
            EditarCliente()
        Else
            Mensajes.ShowMessage("No existen clientes", frmMessageBox.TipoMensaje.Informacion)
        End If

    End Sub

    Public Sub Eliminar()
        Try
            If dgvClientes.RowCount > 0 Then
                EliminarClientes()
            Else
                Mensajes.ShowMessage("No existen Clientes", frmMessageBox.TipoMensaje.Informacion)
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrió un problea al efectuar el borrado", frmMessageBox.TipoMensaje.Err)
        End Try        

    End Sub

    Public Sub Recargar()
        CargarClientes()
    End Sub

    Private Sub tlsbtnBuscar_Click(sender As Object, e As EventArgs) Handles tlsbtnBuscar.Click
        If ValidaFiltro() Then
            If ValidaNumericos(tlstxtCodigo.Text) Then
                AplicarFiltro(tlstxtCodigo.Text, tlstxtFiltroNombre.Text, tlstxtFiltroIdentificacion.Text _
                              , tlstxtFiltroApellidos.Text, tlstxtFiltroEmail.Text)
            Else
                Mensajes.ShowMessage("El valor del código debe ser un número", frmMessageBox.TipoMensaje.Informacion)
            End If
        Else
            Mensajes.ShowMessage("Todos los filtros e  stán vacios", frmMessageBox.TipoMensaje.Informacion)
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
            If Utilidades.GenerarArchivo(Utilidades.TipoArchivo.Clientes) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ExportarDatos()
        Try
            If Utilidades.ExportarDatos(Utilidades.TipoArchivo.Clientes, DatosParaExportar()) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ImportarDatos()

        Try
            _dtClientes = Utilidades.ImportarDatos(Utilidades.TipoArchivo.Clientes)
            If Not IsNothing(_dtClientes) Then
                Dim fImportarDatos As New frmImportarDatos(frmImportarDatos.TipoCarga.Clientes, _dtClientes)

                If fImportarDatos.ShowDialog = DialogResult.OK Then
                    CargarClientes()
                End If
            End If            

        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Ocurrió un error al importar los clientes. {0}", ex.Message), frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub
#End Region

#Region "Funciones"

    Private Sub InicializarComponentes()
        _cliente = New Cliente
        _ac = New AccionesClientes
    End Sub

    Private Sub CargarClientes()
        _dtClientes = _ac.ObtieneClientes
        dgvClientes.DataSource = _dtClientes
    End Sub

    Private Sub CrearCliente()
        Dim fNuevoCliente As New frmActualizaCliente(-1)

        If fNuevoCliente.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Cliente creado con éxito", frmMessageBox.TipoMensaje.Informacion)
        End If
        CargarClientes()
    End Sub

    Private Sub EditarCliente()
        Dim fEditarCliente As New frmActualizaCliente(dgvClientes.CurrentRow.Cells("idCliente").Value)

        If fEditarCliente.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Cliente editado con éxito", frmMessageBox.TipoMensaje.Informacion)
        End If
        CargarClientes()
    End Sub

    Private Sub EliminarClientes()
        If Mensajes.ShowMessage("Está seguro que desea eliminar el cliente " & dgvClientes.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _ac.EliminarCliente(dgvClientes.CurrentRow.Cells("idCliente").Value)
            Mensajes.ShowMessage("El cliente fue eliminado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarClientes()
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
            AndAlso tlstxtFiltroApellidos.Text = "" AndAlso tlstxtFiltroIdentificacion.Text = "" _
            AndAlso tlstxtFiltroEmail.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub AplicarFiltro(ByRef codigo As String, ByRef nombre As String _
                                   , ByRef apellidos As String, ByRef identificacion As String _
                                   , ByRef email As String)
        Dim filtro As String = String.Empty
        Dim BindingSource1 As Windows.Forms.BindingSource = New BindingSource

        BindingSource1.DataSource = _dtClientes

        Try
            If codigo <> "" Then
                filtro = "idCliente= " & codigo
            End If

            If nombre <> "" Then
                If filtro = String.Empty Then
                    filtro = "nombre LIKE '%" & nombre & "%'"
                Else
                    filtro = filtro & " And " & "nombre LIKE '%" & nombre & "%'"
                End If
            End If

            If apellidos <> "" Then
                If filtro = String.Empty Then
                    filtro = "apellidos LIKE '%" & apellidos & "%'"
                Else
                    filtro = filtro & " And " & "apellidos LIKE '%" & apellidos & "%'"
                End If
            End If

            If identificacion <> "" Then
                If filtro = String.Empty Then
                    filtro = "identificacion LIKE '%" & identificacion & "%'"
                Else
                    filtro = filtro & " And " & "identificacion LIKE '%" & identificacion & "%'"
                End If
            End If

            If email <> "" Then
                If filtro = String.Empty Then
                    filtro = "email LIKE '%" & email & "%'"
                Else
                    filtro = filtro & " And " & "email LIKE '%" & email & "%'"
                End If
            End If


            If Not filtro = String.Empty Then
                'For Each row As DataRow In _dtClientes.Select(filtro)
                '    Mensajes.ShowMessage("Filtrados: " & row.Item("nombre"), frmMessageBox.TipoMensaje.Informacion)
                'Next
                BindingSource1.Filter = filtro

                dgvClientes.DataSource = BindingSource1
            End If

        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrió un error al procesar el filtrado.", frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub

    Private Sub LimpiarFiltro()
        tlstxtCodigo.Clear()
        tlstxtFiltroNombre.Clear()
        tlstxtFiltroApellidos.Clear()
        tlstxtFiltroIdentificacion.Clear()
        tlstxtFiltroEmail.Clear()

        CargarClientes()

    End Sub

    Private Function DatosParaExportar() As DataTable

        Dim dtDatosExportar As New DataTable

        dtDatosExportar.Columns.Add("Nombre")
        dtDatosExportar.Columns.Add("Apellidos")
        dtDatosExportar.Columns.Add("Identificación")
        dtDatosExportar.Columns.Add("Teléfono")
        dtDatosExportar.Columns.Add("Email")
        dtDatosExportar.Columns.Add("Dirección")

        For Each fila As DataRow In _dtClientes.Rows
            Dim newRow As DataRow = dtDatosExportar.NewRow

            newRow.Item("Nombre") = fila.Item("nombre")
            newRow.Item("Apellidos") = fila.Item("apellidos")
            newRow.Item("Identificación") = fila.Item("identificacion")
            newRow.Item("Teléfono") = fila.Item("telefono")            
            newRow.Item("Email") = fila.Item("email")            
            newRow.Item("Dirección") = fila.Item("direccion")

            dtDatosExportar.Rows.Add(newRow)
        Next
        Return dtDatosExportar
    End Function

#End Region

End Class
