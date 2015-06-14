Public Class ctlFamilias

    Private _dtFamilias As DataTable
    Private _af As AccionesFamilias


#Region "Acciones"
    Private Sub ctlFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtFamilias = New DataTable
        _af = New AccionesFamilias
        CargarFamilias()
    End Sub

    Public Sub Refrescar()
        CargarFamilias()
    End Sub

    Public Sub Nuevo()
        CrearFamilia()
        CargarFamilias()
    End Sub

    Public Sub Editar()
        Try
            EditarFamilia()
            CargarFamilias()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            EliminarFamilia()
            CargarFamilias()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub GenerarPlantilla()
        Try            
            If Utilidades.GenerarArchivo(Utilidades.TipoArchivo.Familias) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)
            Else
                Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ExportarDatos()
        Try            
            If Utilidades.ExportarDatos(Utilidades.TipoArchivo.Familias, DatosParaExportar()) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)
            Else
                Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ImportarDatos()

        Try
            _dtFamilias = Utilidades.ImportarDatos(Utilidades.TipoArchivo.Familias)
            If Not IsNothing(_dtFamilias) Then
                Dim fImportarDatos As New frmImportarDatos(frmImportarDatos.TipoCarga.Familia, _dtFamilias)
                If fImportarDatos.ShowDialog = DialogResult.OK Then
                    CargarFamilias()
                End If
            End If

        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrió un error al importar las familias.", "Error en carga de Archivo", frmMessageBox.TipoMensaje.Err, ex.Message)
        End Try

    End Sub

#End Region

#Region "Funciones"

    ' ===============================================================================================
    '   Carga la tabla con todas las familias existentes
    ' ===============================================================================================
    Private Sub CargarFamilias()        
        _dtFamilias = _af.ObtieneFamilias
        dgvFamilias.DataSource = _dtFamilias
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la creación de una nueva familia
    ' ===============================================================================================
    Private Sub CrearFamilia()
        Dim fActualizaInsertaEstructura As New frmActualizaInsertaEstructura(-1, frmActualizaInsertaEstructura.TipoInsercion.FAMILIA)

        If fActualizaInsertaEstructura.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Familia editada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarFamilias()
        End If
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la edición de una nueva familia existente
    ' ===============================================================================================
    Private Sub EditarFamilia()

        Dim fActualizaInsertaEstructura As New frmActualizaInsertaEstructura(dgvFamilias.CurrentRow.Cells("idFamilia").Value, frmActualizaInsertaEstructura.TipoInsercion.FAMILIA)

        If fActualizaInsertaEstructura.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Familia editada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarFamilias()
        End If

    End Sub

    Private Sub EliminarFamilia()

        If Mensajes.ShowMessage("Está seguro que desea eliminar la familia " & dgvFamilias.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _af.EliminarFamilia(dgvFamilias.CurrentRow.Cells("idFamilia").Value)
            Mensajes.ShowMessage("La familia fue eliminada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarFamilias()
        End If        

    End Sub

    Private Function DatosParaExportar() As DataTable

        Dim dtDatosExportar As New DataTable

        dtDatosExportar.Columns.Add("Nombre")
        dtDatosExportar.Columns.Add("Descripción")

        For Each fila As DataRow In _dtFamilias.Rows
            Dim newRow As DataRow = dtDatosExportar.NewRow

            newRow.Item("Nombre") = fila.Item("nombre")
            newRow.Item("Descripción") = fila.Item("descripcion")

            dtDatosExportar.Rows.Add(newRow)
        Next
        Return dtDatosExportar
    End Function

#End Region

End Class
