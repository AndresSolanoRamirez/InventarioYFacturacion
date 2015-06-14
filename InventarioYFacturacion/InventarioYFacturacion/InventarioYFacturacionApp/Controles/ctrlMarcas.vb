Public Class ctrlMarcas
    Private _dtMarcas As DataTable
    Private _am As AccionesMarcas

#Region "Acciones"
    Private Sub ctlSubFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtMarcas = New DataTable
        _am = New AccionesMarcas
        CargarMarcas()
    End Sub

    Public Sub Refrescar()
        CargarMarcas()
    End Sub

    Public Sub Nuevo()
        CrearMarca()
        CargarMarcas()
    End Sub

    Public Sub Editar()
        Try
            If Not IsNothing(_dtMarcas) AndAlso _dtMarcas.Rows.Count > 0 Then
                EditarMarca()
                CargarMarcas()
            Else
                Mensajes.ShowMessage("No ha creado ninguna marca", frmMessageBox.TipoMensaje.Informacion)
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            EliminarMarca()
            CargarMarcas()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub
#End Region

#Region "Funciones"

    ' ===============================================================================================
    '   Carga la tabla con todas las marcas existentes
    ' ===============================================================================================
    Private Sub CargarMarcas()
        _dtMarcas = _am.ObtieneMarcas
        dgvMarcas.DataSource = _dtMarcas
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la creación de una nueva familia
    ' ===============================================================================================
    Private Sub CrearMarca()
        Dim fAIMarca As New frmActualizaInsertaEstructura(-1, frmActualizaInsertaEstructura.TipoInsercion.MARCA)

        If fAIMarca.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Marca insertada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarMarcas()
        End If
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la edición de una nueva sub familia existente
    ' ===============================================================================================
    Private Sub EditarMarca()

        Dim fAIMarca As New frmActualizaInsertaEstructura(dgvMarcas.CurrentRow.Cells("idMarca").Value, frmActualizaInsertaEstructura.TipoInsercion.MARCA)

        If fAIMarca.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Marca editada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarMarcas()
        End If

    End Sub

    Private Sub EliminarMarca()

        If Mensajes.ShowMessage("Está seguro que desea eliminar la sub familia " & dgvMarcas.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _am.EliminarMarca(dgvMarcas.CurrentRow.Cells("idMarca").Value)
            Mensajes.ShowMessage("La sub familia fue eliminada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarMarcas()
        End If

    End Sub
#End Region
End Class
