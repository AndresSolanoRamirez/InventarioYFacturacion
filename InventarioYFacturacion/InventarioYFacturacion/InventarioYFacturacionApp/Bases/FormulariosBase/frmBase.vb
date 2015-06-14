Public Class frmBase
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If ValidarForm() Then
            OnAceptar()
        End If
    End Sub

    Protected Overridable Function ValidarForm() As Boolean
        Return True
    End Function

    Protected Overridable Sub OnAceptar()

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Protected Overridable Sub OnCancel()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        OnCancel()
    End Sub

    Public Function SetError(ByVal c As Control, ByVal conError As Boolean, ByVal mensaje As String) As Boolean
        If conError Then
            ErrorProvider1.SetError(c, mensaje)
            Return True
        Else
            ErrorProvider1.SetError(c, "")
            Return False

        End If

    End Function

    Public Sub EnableOk(ByVal value As Boolean)
        btnAceptar.Enabled = value
    End Sub
End Class