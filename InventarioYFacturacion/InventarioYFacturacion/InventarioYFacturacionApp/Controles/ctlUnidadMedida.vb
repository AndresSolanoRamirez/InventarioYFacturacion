Public Class ctlUnidadMedida

    Private _dtUnidadesMedida As DataTable
    Private _aum As AccionesUnidadMedida

#Region "Acciones"
    Private Sub ctlUnidadMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtUnidadesMedida = New DataTable
        _aum = New AccionesUnidadMedida
        CargarUnidadesMedidas()
    End Sub

    Public Sub Refrescar()
        CargarUnidadesMedidas()
    End Sub

    Public Sub Nuevo()
        CrearUnidadMedida()
        CargarUnidadesMedidas()
    End Sub

    Public Sub Editar()
        Try
            EditarFamilia()
            CargarUnidadesMedidas()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            EliminarUnidadMedida()
            CargarUnidadesMedidas()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub GenerarPlantilla()
        Try
            If Utilidades.GenerarArchivo(Utilidades.TipoArchivo.UnidadesMedida) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ExportarDatos()
        Try
            If Utilidades.ExportarDatos(Utilidades.TipoArchivo.UnidadesMedida, DatosParaExportar()) Then
                Mensajes.ShowMessage("Archivo generado con éxito", frmMessageBox.TipoMensaje.Informacion)            
            End If
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrio un error al generar la plantilla", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Public Sub ImportarDatos()

        Try
            _dtUnidadesMedida = Utilidades.ImportarDatos(Utilidades.TipoArchivo.UnidadesMedida)

            If Not IsNothing(_dtUnidadesMedida) Then
                Dim fImportarDatos As New frmImportarDatos(frmImportarDatos.TipoCarga.UnidadesMedida, _dtUnidadesMedida)

                If fImportarDatos.ShowDialog = DialogResult.OK Then
                    CargarUnidadesMedidas()
                End If
            End If

        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Ocurrió un error al importar las Unidades de medida. {0}", ex.Message), frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub
#End Region

#Region "Funciones"

    ' ===============================================================================================
    '   Carga la tabla con todas las CargarUnidadesMedidas existentes
    ' ===============================================================================================
    Private Sub CargarUnidadesMedidas()
        _dtUnidadesMedida = _aum.ObtieneUnidadesMedida
        dgvUnidadesMedida.DataSource = _dtUnidadesMedida
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la creación de una nueva familia
    ' ===============================================================================================
    Private Sub CrearUnidadMedida()
        Dim fActualizaInsertaEstructura As New frmActualizaInsertaEstructura(-1, frmActualizaInsertaEstructura.TipoInsercion.UNIDAD_MEDIDA)

        If fActualizaInsertaEstructura.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Unidad de medida editada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarUnidadesMedidas()
        End If
    End Sub

    ' ===============================================================================================
    '   Levanta la ventana para la edición de una nueva familia existente
    ' ===============================================================================================
    Private Sub EditarFamilia()

        Dim fActualizaInsertaEstructura As New frmActualizaInsertaEstructura(dgvUnidadesMedida.CurrentRow.Cells("idUnidadMedida").Value, frmActualizaInsertaEstructura.TipoInsercion.UNIDAD_MEDIDA)

        If fActualizaInsertaEstructura.ShowDialog = Windows.Forms.DialogResult.OK Then
            Mensajes.ShowMessage("Unidad de medida editada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarUnidadesMedidas()
        End If

    End Sub

    Private Sub EliminarUnidadMedida()

        If Mensajes.ShowMessage("Está seguro que desea eliminar la unidad de medida " & dgvUnidadesMedida.CurrentRow.Cells("nombre").Value, frmMessageBox.TipoMensaje.Alerta) = MsgBoxResult.Yes Then
            _aum.EliminarUnidadMedida(dgvUnidadesMedida.CurrentRow.Cells("idUnidadMedida").Value)
            Mensajes.ShowMessage("La Unidad de medida fue eliminada con éxito", frmMessageBox.TipoMensaje.Informacion)
            CargarUnidadesMedidas()
        End If

    End Sub

    Private Function DatosParaExportar() As DataTable

        Dim dtDatosExportar As New DataTable

        dtDatosExportar.Columns.Add("Nombre")
        dtDatosExportar.Columns.Add("Descripción")        

        For Each fila As DataRow In _dtUnidadesMedida.Rows            

            Dim newRow As DataRow = dtDatosExportar.NewRow

            newRow.Item("Nombre") = fila.Item("nombre")
            newRow.Item("Descripción") = fila.Item("descripcion")            

            dtDatosExportar.Rows.Add(newRow)
        Next
        Return dtDatosExportar
    End Function
#End Region
End Class
