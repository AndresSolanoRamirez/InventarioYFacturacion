Public Class frmActualizaInsertaSubFamilia

    Private _subFamilia As SubFamilia
    Private _asf As AccionesSubFamilias
    Private _af As AccionesFamilias

#Region "Acciones"
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ' ====================================================================================================
    '   Si el id que pasa por parámetro es igual a -1 inserta un nuevo registro
    '   si el id que pasa por parámetro es mayor  a cero entonces edita el registro
    Public Sub New(ByVal id As Integer)
        Me.New()

        _asf = New AccionesSubFamilias
        _af = New AccionesFamilias

        _subFamilia = New SubFamilia
        _subFamilia.IdSubFamilia = id

        LLenarFiltroFamilias()

        If id = -1 Then
            lblEncabezado.Text = "Inserta una nueva sub familia por familia"
            pBoxEncabezado.Image = My.Resources.plus_5_64_green
        Else
            Me.Text = "Editar sub familia"
            pBoxEncabezado.Image = My.Resources.pencil_64
            lblEncabezado.Text = "Edita los datos de la sub familia seleccionada"

            _subFamilia = _asf.ObtieneSubFamiliaXCodigo(id)
            AsignaValores(_subFamilia)
        End If
    End Sub

    Protected Overrides Function ValidarForm() As Boolean

        If Me.SetError(txtNombre, txtNombre.Text.Equals(""), "Debe Ingresar un nombre") Then
            txtNombre.Focus()
            Return False
        End If

        If Me.SetError(kcbFamilias, kcbFamilias.SelectedValue = -1, "Debe Ingresar una familia") Then
            kcbFamilias.Focus()
            Return False
        End If

        Return MyBase.ValidarForm()

    End Function

    Protected Overrides Sub OnAceptar()

        Try

            CrearEstructura()
            _asf.ActualizaSubFamilia(_subFamilia)

            MyBase.OnAceptar()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la solicitud: " & ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub
#End Region

#Region "Funciones"

    Private Sub AsignaValores(ByRef subFamilia As SubFamilia)
        txtNombre.Text = subFamilia.Nombre
        txtDescripcion.Text = subFamilia.Descripcion
    End Sub

    Private Sub LLenarFiltroFamilias()
        Dim dtFamilias As DataTable = _af.ObtieneFamilias
        Dim newRow As DataRow = dtFamilias.NewRow

        newRow.Item("idFamilia") = -1
        newRow.Item("nombre") = "Seleccione una Familia"

        dtFamilias.Rows.Add(newRow)

        kcbFamilias.DataSource = dtFamilias

        kcbFamilias.DisplayMember = "nombre"
        kcbFamilias.ValueMember = "idFamilia"

        kcbFamilias.SelectedValue = -1
    End Sub

    Private Sub CrearEstructura()
        _subFamilia.Nombre = txtNombre.Text
        _subFamilia.Descripcion = txtDescripcion.Text
        _subFamilia.Familia.IdFamilia = kcbFamilias.SelectedValue
    End Sub
#End Region

End Class