Public Class frmImportarDatos

    Private _dt As DataTable
    Private _af As AccionesFamilias
    Private _asf As AccionesSubFamilias
    Private _aum As AccionesUnidadMedida
    Private _aprv As AccionesProveedores
    Private _ac As AccionesClientes

    Private _tipoCarga As TipoCarga

    Private _dtDatosActuales As DataTable

    Private _familia As Familia
    Private _subFamilia As SubFamilia
    Private _unidadMedida As UnidadMedida
    Private _proveedor As Proveedor
    Private _cliente As Cliente

    Public Enum TipoCarga
        Familia
        SubFamilia
        UnidadesMedida
        Proveedores
        Clientes
    End Enum
#Region "Acciones"
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal tipoCarga As TipoCarga, ByVal dt As DataTable)
        Me.New()
        InicializarComponentes()
        _dt = dt
        CargarExcel()
        lblEncabezado.Text = "Revise todos los valores que va a importar. La herramienta importará toda la vista previa mostrada"
        btnAceptar.Text = "Importar"
    End Sub

    Protected Overrides Sub OnCancel()
        MyBase.OnCancel()
    End Sub

    Protected Overrides Sub OnAceptar()

        Try
            Me.Cursor = Cursors.WaitCursor
            ImportarDatos(_tipoCarga)
            Me.Cursor = Cursors.Default

            MyBase.OnAceptar()
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrió un error al importar los datos", frmMessageBox.TipoMensaje.Err)
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "Funciones"
    Private Sub InicializarComponentes()
        _af = New AccionesFamilias
        _asf = New AccionesSubFamilias
        _aum = New AccionesUnidadMedida
        _aprv = New AccionesProveedores
        _ac = New AccionesClientes
    End Sub

    Private Sub CargarExcel()
        kdgvDatos.DataSource = _dt
    End Sub

    ' =====================================================================
    '   Inserta los datos del excel cargado en la estructura que corresponda
    ' =====================================================================
    Private Sub ImportarDatos(ByVal tipoCarga As TipoCarga)

        For Each fila As DataRow In _dt.Rows
            If CrearEstructura(fila) Then
                InsertarDatos()
            End If            
        Next

    End Sub

    ' ======================================================================
    '   Crea la estructura según el tipo de carga que se esté realizando
    ' ======================================================================
    Private Function CrearEstructura(ByRef fila As DataRow) As Boolean
        If _tipoCarga = TipoCarga.Familia Then            
            _familia = _af.ObtieneFamiliaXNombre(fila.Item("Nombre"))
            If IsNothing(_familia) Then
                _familia = New Familia
                _familia.IdFamilia = -1
                _familia.Nombre = fila.Item("Nombre")
                _familia.Descripcion = fila.Item("Descripción")
            End If

            Return True
        ElseIf _tipoCarga = TipoCarga.SubFamilia Then            
            _familia = _af.ObtieneFamiliaXNombre(fila.Item("Familia"))
            If IsNothing(_familia) Then
                Return False
            End If

            _subFamilia = _asf.ObtieneSubFamiliaXNombre(fila.Item("Nombre"))

            If IsNothing(_subFamilia) Then
                _subFamilia = New SubFamilia
                _subFamilia.IdSubFamilia = -1
                _subFamilia.Nombre = fila.Item("Nombre")
                _subFamilia.Descripcion = fila.Item("Descripción")
            End If

            _subFamilia.Familia = _familia
            Return True
        ElseIf _tipoCarga = TipoCarga.UnidadesMedida Then                        
            _unidadMedida = _aum.ObtieneUnidadMedidaXNombre(fila.Item("Nombre"))

            If IsNothing(_unidadMedida) Then
                _unidadMedida = New UnidadMedida
                _unidadMedida.IdUnidadMedida = -1
                _unidadMedida.Nombre = fila.Item("Nombre")
                _unidadMedida.Descripcion = fila.Item("Descripción")
            End If

            
            Return True
        ElseIf _tipoCarga = TipoCarga.Proveedores Then            
            _proveedor = _aprv.ObtieneProveedorXNombre(fila.Item("Nombre"))

            If IsNothing(_proveedor) Then
                _proveedor = New Proveedor

                _proveedor.IdProveedor = -1
                _proveedor.Nombre = fila.Item("Nombre")
                _proveedor.CedulaJuridica = fila.Item("Ced. Jurídica")
                _proveedor.Contacto = fila.Item("Contacto")
                _proveedor.Telefono1 = fila.Item("Teléfono1")
                _proveedor.Telefono2 = fila.Item("Teléfono2")
                _proveedor.Email = fila.Item("Email")
                _proveedor.EmailContacto = fila.Item("Email Contacto")
                _proveedor.Direccion = fila.Item("Dirección")
            End If

            Return True
        ElseIf _tipoCarga = TipoCarga.Clientes Then            

            _cliente = _ac.ObtieneClienteXIdentificacion("Identificación")

            If IsNothing(_cliente) Then
                _cliente = New Cliente

                _cliente.IdCliente = -1
                _cliente.Nombre = fila.Item("Nombre")
                _cliente.Apellidos = fila.Item("Apellidos")
                _cliente.Identificacion = fila.Item("Identificación")
                _cliente.Telefono = fila.Item("Teléfono")
                _cliente.Email = fila.Item("Email")
                _cliente.Direccion = fila.Item("Dirección")
            End If

            Return True
        End If
        Return False
    End Function

    Private Sub InsertarDatos()
        If _tipoCarga = TipoCarga.Familia Then
            _af.ActualizaFamilia(_familia)
        ElseIf _tipoCarga = TipoCarga.SubFamilia Then
            _asf.ActualizaSubFamilia(_subFamilia)
        ElseIf _tipoCarga = TipoCarga.UnidadesMedida Then
            _aum.ActualizaUnidadMedida(_unidadMedida)
        ElseIf _tipoCarga = TipoCarga.Proveedores Then
            _aprv.ActualizaProveedor(_proveedor)
        ElseIf _tipoCarga = TipoCarga.Clientes Then
            _ac.ActualizaCliente(_cliente)
        End If
    End Sub

#End Region

End Class