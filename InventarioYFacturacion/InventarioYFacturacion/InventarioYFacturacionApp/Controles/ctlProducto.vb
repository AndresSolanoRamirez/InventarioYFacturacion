Public Class ctlProducto

    Private _producto As Producto
    Private _aprd As AccionesProductos
    Private _aum As AccionesUnidadMedida
    Private _am As AccionesMarcas
    Private _asf As AccionesSubFamilias
    Private _apr As AccionesProveedores
    Private _dtProductos As DataTable

#Region "Acciones"

    Private Sub ctlProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        CargarProductos()
    End Sub

    Public Sub Nuevo()
        AgregarProducto()
    End Sub

    Public Sub Editar()

        If dgvProductos.RowCount > 0 Then
            EditarProducto()
        Else
            Mensajes.ShowMessage("No existen productos", frmMessageBox.TipoMensaje.Informacion)
        End If

    End Sub

    Public Sub Eliminar()
        Try
            EliminarProducto()
        Catch ex As Exception
            Mensajes.ShowMessage("No se pudo eliminar el producto seleccionado", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Refrescar()        
        _dtProductos = _aprd.ObtieneProductos
        dgvProductos.Update()
    End Sub

    Private Sub tlsbtnBuscar_Click(sender As Object, e As EventArgs) Handles tlsbtnBuscar.Click
        If ValidaFiltro() Then
            'If ValidaNumericos(tlstxtCodigo.Text) Then
            '    AplicarFiltro(tlstxtCodigo.Text, tlstxtFiltroNombre.Text, tlstxtFiltroCedJuridica.Text _
            '                  , tlstxtFiltroContacto.Text, tlstxtFiltroEmail.Text, tlstxtFiltroEmailContacto.Text)
            'Else
            '    Mensajes.ShowMessage("El valor del código debe ser un número", frmMessageBox.TipoMensaje.Informacion)
            'End If
        Else
            Mensajes.ShowMessage("Todos los filtros están vacios", frmMessageBox.TipoMensaje.Informacion)
        End If
    End Sub

    Public Sub GenerarPlantilla()
        Try
            If Utilidades.GenerarArchivo(Utilidades.TipoArchivo.Productos) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub
#End Region

#Region "Funciones"

    Private Sub InicializarComponentes()
        _producto = New Producto
        _aprd = New AccionesProductos
        _aum = New AccionesUnidadMedida
        _am = New AccionesMarcas
        _asf = New AccionesSubFamilias
        _apr = New AccionesProveedores
    End Sub

    Private Sub CargarProductos()
        _dtProductos = Nothing        

        _dtProductos = _aprd.ObtieneProductos

        ConfigurarUnidadMedida()
        ConfigurarMarca()
        ConfigurarSubFamilia()
        ConfigurarProveedores()

        dgvProductos.DataSource = _dtProductos
    End Sub

    Private Sub AgregarProducto()
        Dim fNuevoProducto As New frmActualizarProductos(-1)

        If fNuevoProducto.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Producto Creado con Éxito", frmMessageBox.TipoMensaje.Informacion)
        End If
    End Sub

    Private Sub EditarProducto()
        Dim fEditarProducto As New frmActualizarProductos(dgvProductos.CurrentRow.Cells("idProducto").Value)

        If fEditarProducto.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Proveedor editado con éxito", frmMessageBox.TipoMensaje.Informacion)
        End If
        CargarProductos()
    End Sub

    Private Sub EliminarProducto()
        If Mensajes.ShowMessage("Está seguro que desea eliminar el producto " & dgvProductos.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _aprd.EliminarProducto(dgvProductos.CurrentRow.Cells("idProducto").Value)
            Mensajes.ShowMessage("El producto fue eliminado con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarProductos()
        End If
    End Sub

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

    Private Sub ConfigurarUnidadMedida()
        Dim dtUnidadMedida As DataTable = New DataTable

        dtUnidadMedida = _aum.ObtieneUnidadesMedida

        Dim column As DataGridViewComboBoxColumn = DirectCast(dgvProductos.Columns(9), DataGridViewComboBoxColumn)

        column.DataSource = dtUnidadMedida
        column.ValueMember = "idUnidadMedida"
        column.DisplayMember = "nombre"
        column.ReadOnly = True
    End Sub

    Private Sub ConfigurarMarca()
        Dim dtMarca As DataTable = New DataTable

        dtMarca = _am.ObtieneMarcas

        Dim column As DataGridViewComboBoxColumn = DirectCast(dgvProductos.Columns(10), DataGridViewComboBoxColumn)

        column.DataSource = dtMarca
        column.ValueMember = "idMarca"
        column.DisplayMember = "nombre"
        column.ReadOnly = True
    End Sub

    Private Sub ConfigurarSubFamilia()
        Dim dtSubFamilia As DataTable = New DataTable

        dtSubFamilia = _asf.ObtieneSubFamilias

        Dim column As DataGridViewComboBoxColumn = DirectCast(dgvProductos.Columns(11), DataGridViewComboBoxColumn)

        column.DataSource = dtSubFamilia
        column.ValueMember = "idSubFamilia"
        column.DisplayMember = "nombre"
        column.ReadOnly = True
    End Sub

    Private Sub ConfigurarProveedores()
        Dim dtProveedores As DataTable = New DataTable

        dtProveedores = _apr.ObtieneProveedores

        Dim column As DataGridViewComboBoxColumn = DirectCast(dgvProductos.Columns(12), DataGridViewComboBoxColumn)

        column.DataSource = dtProveedores
        column.ValueMember = "idProveedor"
        column.DisplayMember = "nombre"
        column.ReadOnly = True
    End Sub
#End Region

End Class
