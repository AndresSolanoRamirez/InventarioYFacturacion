Public Class frmActualizaInsertaParametro

    Private _ap As AccionesParametros
    Private _parametro As Parametro

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

        _ap = New AccionesParametros

        _parametro = New Parametro
        _parametro.IdParametro = id

        If id = -1 Then
            lblEncabezado.Text = "Inserta un nuevo parámetro"
            pBoxEncabezado.Image = My.Resources.plus_5_64_green
        Else
            Me.Text = "Editar Parámetro"
            pBoxEncabezado.Image = My.Resources.pencil_64
            lblEncabezado.Text = "Edita los datos del parámetro seleccionado"

            _parametro = _ap.ObtieneParametroXCodigo(id)            
            AsignaValores(_parametro)
        End If
    End Sub

    Protected Overrides Function ValidarForm() As Boolean

        If Me.SetError(txtNombre, txtNombre.Text.Equals(""), "Debe Ingresar un nombre") Then
            txtNombre.Focus()
            Return False
        End If

        If Me.SetError(ktxtValor, ktxtValor.Text.Equals(""), "Debe Ingresar un valor") Then
            ktxtValor.Focus()
            Return False
        End If

        Return MyBase.ValidarForm()

    End Function

    Protected Overrides Sub OnAceptar()

        Try

            CrearEstructura()
            _ap.ActualizaParametro(_parametro)

            MyBase.OnAceptar()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la solicitud: " & ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub
#End Region

#Region "Funciones"

    Private Sub AsignaValores(ByRef parametro As Parametro)
        txtNombre.Text = parametro.Nombre
        ktxtValor.Text = parametro.Value
        kchbxPermiteModificar.Checked = IIf(IsDBNull(parametro.PermiteModificar), False, parametro.PermiteModificar)
        kchbxPermiteEliminar.Checked = IIf(IsDBNull(parametro.PermiteEliminar), False, parametro.PermiteEliminar)
    End Sub


    Private Sub CrearEstructura()

        _parametro.Nombre = txtNombre.Text
        _parametro.Value = ktxtValor.Text
        _parametro.PermiteEliminar = kchbxPermiteEliminar.Checked
        _parametro.PermiteModificar = kchbxPermiteModificar.Checked

    End Sub
#End Region

End Class