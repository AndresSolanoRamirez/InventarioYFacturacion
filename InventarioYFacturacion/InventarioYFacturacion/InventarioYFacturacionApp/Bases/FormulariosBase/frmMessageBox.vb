Public Class frmMessageBox
    Public Enum TipoMensaje
        Informacion
        Alerta
        Err
    End Enum

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal pMensaje As String, _
                   ByVal pEncabezado As String, _
                   ByVal pTipoMensaje As TipoMensaje, _
                   Optional ByVal pException As String = Nothing, _
                   Optional ByVal ancho As Integer = Nothing)
        Me.New()
        Dim anchoDefecto = Me.Width

        ' Establece el mensaje
        lblMensaje.Text = pMensaje
        ktxtDestalle.Text = pException

        ' Establece el encabezado de la pantalla
        Me.Text = pEncabezado

        'Estable el ancho de la pantalla
        If Not IsNothing(ancho) AndAlso ancho > 50 Then
            Me.Width = ancho
        End If

        Dim nuevaLocation As Integer = Me.Width - anchoDefecto

        ' Establece el tipo de Mensaje
        Select Case pTipoMensaje
            Case TipoMensaje.Informacion
                pbxImagen.BackgroundImage = My.Resources.info_3_64
            Case TipoMensaje.Alerta
                pbxImagen.BackgroundImage = My.Resources.alert_64
            Case TipoMensaje.Err
                pbxImagen.BackgroundImage = My.Resources.x_mark_3_64

        End Select

        ' Establece los botones que debe mostrar
        Select Case pTipoMensaje

            Case TipoMensaje.Alerta
                btnAceptar.Location = New Point(288 + nuevaLocation, 119)
                btnCancelar.Location = New Point(384 + nuevaLocation, 119)
                btnAceptar.Visible = True
                btnCancelar.Visible = True
                btnAceptar.Focus()
            Case Else

                If pTipoMensaje = TipoMensaje.Err Then
                    kbtnDetalles.Visible = True
                End If

                btnOk.Location = New Point(384 + nuevaLocation, 119)
                btnOk.Visible = True                
                btnOk.Focus()
        End Select

    End Sub

    Public Sub New(ByVal pMensaje As String, _
                   ByVal pTipoMensaje As TipoMensaje, _
                   Optional ByVal ancho As Integer = Nothing)

        Me.New(pMensaje, Nothing, pTipoMensaje)

        Dim vEncabezado As String = String.Empty

        'Estable el ancho de la pantalla
        If Not IsNothing(ancho) AndAlso ancho > 50 Then
            Me.Width = ancho
        End If

        Select Case pTipoMensaje
            Case TipoMensaje.Informacion
                vEncabezado = "Información"
            Case TipoMensaje.Alerta
                vEncabezado = "Alerta"
            Case TipoMensaje.Err
                vEncabezado = "Error"
        End Select

        Me.Text = vEncabezado

    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()

    End Sub

    Private Sub kbtnDetalles_Click(sender As Object, e As EventArgs) Handles kbtnDetalles.Click
        Me.Size = New Size(504, 465)
        ktxtDestalle.Visible = True
    End Sub
End Class