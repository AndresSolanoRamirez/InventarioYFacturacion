Public Class frmActualizaInsertaEstructura

    Private _rol As Rol
    Private _permiso As Permiso
    Private _familia As Familia
    Private _marca As Marcas
    Private _unidadMedida As UnidadMedida

    Private _ar As AccionesRoles
    Private _ap As AccionesPermisos
    Private _af As AccionesFamilias
    Private _am As AccionesMarcas
    Private _aum As AccionesUnidadMedida

    Private _tipoInsercion As TipoInsercion

    Enum TipoInsercion
        ROL
        PERMISO
        FAMILIA
        MARCA
        UNIDAD_MEDIDA
    End Enum


#Region "Acciones"
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ' ====================================================================================================
    '   Si el id que pasa por parámetro es igual a -1 inserta un nuevo registro
    '   si el id que pasa por parámetro es mayor  a cero entonces edita el registro
    Public Sub New(ByVal id As Integer, ByVal tipoInsercion As TipoInsercion)
        Me.New()
        _tipoInsercion = tipoInsercion

        If tipoInsercion = tipoInsercion.ROL Then

            _rol = New Rol()
            _rol.IdRol = id
            _ar = New AccionesRoles()

            Me.Text = "Roles"

            If _rol.IdRol = -1 Then
                lblEncabezado.Text = "Insertar Nuevo Rol"
                pBoxEncabezado.Image = My.Resources.plus_5_64
            Else
                Me.Text = "Editar Rol"
                pBoxEncabezado.Image = My.Resources.pencil_64
                lblEncabezado.Text = "Editar Rol"

                _rol = _ar.ObtieneRolXCodigo(id)
                AsignaValores(_rol)
            End If

        ElseIf tipoInsercion = frmActualizaInsertaEstructura.TipoInsercion.PERMISO Then
            _permiso = New Permiso
            _permiso.IdPermiso = id
            _ap = New AccionesPermisos

            Me.Text = "Permisos"

            If _permiso.IdPermiso = -1 Then
                lblEncabezado.Text = "Insertar Nuevo Permiso"
                pBoxEncabezado.Image = My.Resources.plus_5_64
            Else
                Me.Text = "Editar Permiso"
                pBoxEncabezado.Image = My.Resources.pencil_64
                lblEncabezado.Text = "Editar Permiso"

                _permiso = _ap.ObtienePermisoXCodigo(_permiso.IdPermiso)
                AsignarValoresPermiso(_permiso)
            End If
        ElseIf _tipoInsercion = frmActualizaInsertaEstructura.TipoInsercion.FAMILIA Then ' si se trata de una familia
            _familia = New Familia
            _familia.IdFamilia = id
            _af = New AccionesFamilias

            Me.Text = "Familias"

            If id = -1 Then
                lblEncabezado.Text = "Insertar Nueva Familia"
                pBoxEncabezado.Image = My.Resources.plus_5_64
            Else
                Me.Text = "Editar Familia"
                pBoxEncabezado.Image = My.Resources.pencil_64
                lblEncabezado.Text = "Editar Familia"

                _familia = _af.ObtieneFamiliaXCodigo(id)
                AsignarValoresFamilia(_familia)
            End If

        ElseIf _tipoInsercion = frmActualizaInsertaEstructura.TipoInsercion.MARCA Then ' -- Si se trata de marca
            _marca = New Marcas
            _marca.IdMarca = id
            _am = New AccionesMarcas

            Me.Text = "Marcas"

            If id = -1 Then
                lblEncabezado.Text = "Insertar Nueva Marca"
                pBoxEncabezado.Image = My.Resources.plus_5_64
            Else
                Me.Text = "Editar Marca"
                pBoxEncabezado.Image = My.Resources.pencil_64
                lblEncabezado.Text = "Editar Marca"

                _marca = _am.ObtieneMarcaXCodigo(id)
                AsignarValoresMarca(_marca)
            End If
        Else ' -- Unidad medida
            _unidadMedida = New UnidadMedida
            _unidadMedida.IdUnidadMedida = id
            _aum = New AccionesUnidadMedida

            Me.Text = "Unidades de Medida"

            If id = -1 Then
                lblEncabezado.Text = "Insertar Nueva Unidad de Medida"
                pBoxEncabezado.Image = My.Resources.plus_5_64
            Else
                Me.Text = "Editar Marca"
                pBoxEncabezado.Image = My.Resources.pencil_64
                lblEncabezado.Text = "Editar Unidad de Medida"

                _unidadMedida = _aum.ObtieneUnidadMedidaXCodigo(id)
                AsignarValoresUnidadMedida(_unidadMedida)
            End If
        End If

    End Sub

    Protected Overrides Function ValidarForm() As Boolean

        If Me.SetError(txtNombre, txtNombre.Text.Equals(""), "Debe Ingresar un nombre") Then
            txtNombre.Focus()
            Return False
        End If

        Return MyBase.ValidarForm()

    End Function

    Protected Overrides Sub OnAceptar()

        Try

            CrearEstructura(_tipoInsercion)

            If _tipoInsercion = TipoInsercion.ROL Then
                _ar.ActualizaRol(_rol)
            ElseIf _tipoInsercion = TipoInsercion.PERMISO Then
                _ap.ActualizaPermiso(_permiso)
            ElseIf _tipoInsercion = TipoInsercion.FAMILIA Then
                _af.ActualizaFamilia(_familia)
            ElseIf _tipoInsercion = TipoInsercion.MARCA Then
                _am.ActualizaMarca(_marca)
            Else
                _aum.ActualizaUnidadMedida(_unidadMedida)
            End If

            MyBase.OnAceptar()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la solicitud: " & ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub
#End Region

#Region "Funciones"
    ' ================================
    '   Arma la estructura de rol, 
    '   de permiso o de familia
    ' ================================
    Private Sub CrearEstructura(ByRef TipoInsercion As TipoInsercion)
        If TipoInsercion = frmActualizaInsertaEstructura.TipoInsercion.ROL Then
            _rol.Nombre = txtNombre.Text
            _rol.Descripcion = txtDescripcion.Text
        ElseIf TipoInsercion = frmActualizaInsertaEstructura.TipoInsercion.PERMISO Then
            _permiso.Nombre = txtNombre.Text
            _permiso.Descripcion = txtDescripcion.Text
        ElseIf TipoInsercion = frmActualizaInsertaEstructura.TipoInsercion.FAMILIA Then ' si se trata de familias
            _familia.Nombre = txtNombre.Text
            _familia.Descripcion = txtDescripcion.Text
        ElseIf TipoInsercion = frmActualizaInsertaEstructura.TipoInsercion.MARCA Then ' si se trata de marcas
            _marca.Nombre = txtNombre.Text
            _marca.Descripcion = txtDescripcion.Text
        Else
            _unidadMedida.Nombre = txtNombre.Text
            _unidadMedida.Descripcion = txtDescripcion.Text
        End If
    End Sub

    Private Sub AsignaValores(ByRef rol As Rol)
        txtNombre.Text = rol.Nombre
        txtDescripcion.Text = rol.Descripcion
    End Sub

    Private Sub AsignarValoresPermiso(ByRef permiso As Permiso)
        txtNombre.Text = permiso.Nombre
        txtDescripcion.Text = permiso.Descripcion
    End Sub

    Private Sub AsignarValoresFamilia(ByRef familia As Familia)
        txtNombre.Text = familia.Nombre
        txtDescripcion.Text = familia.Descripcion
    End Sub

    Private Sub AsignarValoresMarca(ByRef marca As Marcas)
        txtNombre.Text = marca.Nombre
        txtDescripcion.Text = marca.Descripcion
    End Sub

    Private Sub AsignarValoresUnidadMedida(ByRef unidadMedida As UnidadMedida)
        txtNombre.Text = unidadMedida.Nombre
        txtDescripcion.Text = unidadMedida.Descripcion
    End Sub
#End Region


End Class