Public Class Mensajes
    Public Shared Function ShowMessage(ByVal pMensaje As String, _
                                       ByVal pTipoMensaje As frmMessageBox.TipoMensaje, _
                                       Optional ByVal ancho As Integer = Nothing) As MsgBoxResult
        Dim fMsgBox As New frmMessageBox(pMensaje, pTipoMensaje, IIf(Not IsNothing(ancho), ancho, Nothing))
        Return fMsgBox.ShowDialog()
    End Function

    Public Shared Function ShowMessage(ByVal pMensaje As String, _
                                       ByVal pEncabezado As String, _
                                       ByVal pTipoMensaje As frmMessageBox.TipoMensaje, _
                                       Optional ByVal ancho As Integer = Nothing) As MsgBoxResult
        Dim fMsgBox As New frmMessageBox(pMensaje, pEncabezado, pTipoMensaje, IIf(Not IsNothing(ancho), ancho, Nothing))
        Return fMsgBox.ShowDialog()
    End Function

    Public Shared Function ShowMessage(ByVal pMensaje As String, _
                                       ByVal pEncabezado As String, _
                                       ByVal pTipoMensaje As frmMessageBox.TipoMensaje, _
                                       Optional ByVal pException As String = Nothing, _
                                       Optional ByVal ancho As Integer = Nothing) As MsgBoxResult
        Dim fMsgBox As New frmMessageBox(pMensaje, pEncabezado, pTipoMensaje, IIf(Not IsNothing(pException), pException, Nothing), IIf(Not IsNothing(ancho), ancho, Nothing))
        Return fMsgBox.ShowDialog()
    End Function
End Class
