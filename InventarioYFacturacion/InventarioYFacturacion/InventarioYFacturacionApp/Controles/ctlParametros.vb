Public Class ctlParametros

    Private _dtParametros As DataTable
    Private _ap As AccionesParametros


#Region "Acciones"
    Private Sub ctlFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtParametros = New DataTable
        _ap = New AccionesParametros
        CargarParametros()
    End Sub

    Public Sub Refrescar()
        CargarParametros()
    End Sub

    Public Sub Nuevo()
        CrearParametro()
        CargarParametros()
    End Sub

    Public Sub Editar()
        Try
            EditarParametro()
            CargarParametros()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            EliminarParametro()
            CargarParametros()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub
#End Region

#Region "Funciones"

    ' ===============================================================================================
    '   Carga la tabla con todas los parámetros existentes
    ' ===============================================================================================
    Private Sub CargarParametros()
        _dtParametros = _ap.ObtieneParametros
        dgvParametros.DataSource = _dtParametros
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la creación de un nuevo parámetro
    ' ===============================================================================================
    Private Sub CrearParametro()
        Dim fActualizaInsertaParametro As New frmActualizaInsertaParametro(-1)

        If fActualizaInsertaParametro.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Parametro insertado con éxito", frmMessageBox.TipoMensaje.Informacion)
        End If
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la edición de una nueva familia existente
    ' ===============================================================================================
    Private Sub EditarParametro()

        Dim parametroConsulta As Parametro = _ap.ObtieneParametroXCodigo(dgvParametros.CurrentRow.Cells("idParametro").Value)

        If Not parametroConsulta.PermiteModificar Then
            Mensajes.ShowMessage(String.Format("El parámetro {0} no se puede modificar", parametroConsulta.Nombre), frmMessageBox.TipoMensaje.Informacion)
        Else
            Dim fActualizaInsertaParametro As New frmActualizaInsertaParametro(dgvParametros.CurrentRow.Cells("idParametro").Value)

            If fActualizaInsertaParametro.ShowDialog = Windows.Forms.DialogResult.OK Then
                Mensajes.ShowMessage("Parámetro editado con éxito", frmMessageBox.TipoMensaje.Informacion)
            End If
        End If

    End Sub

    Private Sub EliminarParametro()

        Dim parametroConsulta As Parametro = _ap.ObtieneParametroXCodigo(dgvParametros.CurrentRow.Cells("idParametro").Value)

        If Not parametroConsulta.PermiteEliminar Then
            Mensajes.ShowMessage(String.Format("El parámetro {0} no se puede eliminar", parametroConsulta.Nombre), frmMessageBox.TipoMensaje.Informacion)
        Else
            If Mensajes.ShowMessage("Está seguro que desea eliminar el parámetro " & dgvParametros.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
                _ap.EliminarParametro(dgvParametros.CurrentRow.Cells("idParametro").Value)
                Mensajes.ShowMessage("El parámetro fue eliminada con éxito", frmMessageBox.TipoMensaje.Informacion)
            End If
        End If

    End Sub
#End Region

End Class
