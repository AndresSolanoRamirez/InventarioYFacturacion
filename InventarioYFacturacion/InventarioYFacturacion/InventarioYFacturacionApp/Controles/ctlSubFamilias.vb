Public Class ctlSubFamilias

    Private _dtSubFamilias As DataTable
    Private _asf As AccionesSubFamilias
    Private _af As AccionesFamilias

#Region "Acciones"
    Private Sub ctlSubFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        CargarSubFamilias()
    End Sub

    Public Sub Refrescar()
        CargarSubFamilias()
    End Sub

    Public Sub Nuevo()
        CrearSubFamilia()
        CargarSubFamilias()
    End Sub

    Public Sub Editar()
        Try
            If Not IsNothing(dgvSubFamilias) AndAlso dgvSubFamilias.RowCount > 0 Then
                EditarSubFamilia()
                CargarSubFamilias()
            Else
                Mensajes.ShowMessage("No ha creado ninguna sub familia", frmMessageBox.TipoMensaje.Informacion)
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            EliminarFamilia()
            CargarSubFamilias()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub GenerarPlantilla()
        Try
            If Utilidades.GenerarArchivo(Utilidades.TipoArchivo.SubFamilia) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ExportarDatos()
        Try
            If Utilidades.ExportarDatos(Utilidades.TipoArchivo.Familias, DatosParaExportar()) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ImportarDatos()

        Try
            _dtSubFamilias = Utilidades.ImportarDatos(Utilidades.TipoArchivo.SubFamilia)
            If Not IsNothing(_dtSubFamilias) Then
                Dim fImportarDatos As New frmImportarDatos(frmImportarDatos.TipoCarga.SubFamilia, _dtSubFamilias)

                If fImportarDatos.ShowDialog = DialogResult.OK Then
                    CargarSubFamilias()
                End If
            End If

        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Ocurrió un error al importar las sub familias. {0}", ex.Message), frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub
#End Region

#Region "Funciones"

    Private Sub InicializarComponentes()
        _dtSubFamilias = New DataTable
        _asf = New AccionesSubFamilias
        _af = New AccionesFamilias
    End Sub

    ' ===============================================================================================
    '   Carga la tabla con todas las sub familias existentes
    ' ===============================================================================================
    Private Sub CargarSubFamilias()
        _dtSubFamilias = _asf.ObtieneSubFamilias
        dgvSubFamilias.DataSource = _dtSubFamilias
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la creación de una nueva familia
    ' ===============================================================================================
    Private Sub CrearSubFamilia()
        Dim fAISubFamilia As New frmActualizaInsertaSubFamilia(-1)

        If fAISubFamilia.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Sub Familia insertada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarSubFamilias()
        End If
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la edición de una nueva sub familia existente
    ' ===============================================================================================
    Private Sub EditarSubFamilia()

        Dim fAISubFamilia As New frmActualizaInsertaSubFamilia(dgvSubFamilias.CurrentRow.Cells("idSubFamilia").Value)

        If fAISubFamilia.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Sub Familia editada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarSubFamilias()
        End If

    End Sub

    Private Sub EliminarFamilia()

        If Mensajes.ShowMessage("Está seguro que desea eliminar la sub familia " & dgvSubFamilias.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _asf.EliminarSubFamilia(dgvSubFamilias.CurrentRow.Cells("idSubFamilia").Value)
            Mensajes.ShowMessage("La sub familia fue eliminada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarSubFamilias()
        End If

    End Sub

    Private Function DatosParaExportar() As DataTable

        Dim dtDatosExportar As New DataTable

        dtDatosExportar.Columns.Add("Nombre")
        dtDatosExportar.Columns.Add("Descripción")
        dtDatosExportar.Columns.Add("Familia")

        For Each fila As DataRow In _dtSubFamilias.Rows
            Dim familia As Familia = _af.ObtieneFamiliaXCodigo(fila.Item("idFamiliaFK"))

            Dim newRow As DataRow = dtDatosExportar.NewRow

            newRow.Item("Nombre") = fila.Item("nombre")
            newRow.Item("Descripción") = fila.Item("descripcion")
            newRow.Item("Familia") = familia.Nombre

            dtDatosExportar.Rows.Add(newRow)
        Next
        Return dtDatosExportar
    End Function
#End Region

End Class
