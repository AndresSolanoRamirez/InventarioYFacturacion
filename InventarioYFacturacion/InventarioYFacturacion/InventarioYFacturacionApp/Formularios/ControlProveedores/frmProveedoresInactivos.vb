Public Class frmProveedoresInactivos

    Private _apr As AccionesProveedores
    Private _proveedor As New Proveedor
    Private _dtProveedoresInactivos As DataTable

#Region "Acciones"
    Private Sub frmProveedoresInactivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InicializarComponentes()
            MostrarProveedoresInactivos()

            btnAceptar.Text = "Activar"
            lblEncabezado.Text = "Seleccione los proveedores que desea activar"
            pBoxEncabezado.Image = My.Resources.alert_64

        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub OnAceptar()

        Try
            ActivarProveedores()
            MyBase.OnAceptar()
        Catch ex As Exception
            Mensajes.ShowMessage("Ocurrió un problema al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub
#End Region

#Region "Funciones"
    Private Sub InicializarComponentes()
        _proveedor = New Proveedor
        _apr = New AccionesProveedores
    End Sub

    Private Sub MostrarProveedoresInactivos()
        _dtProveedoresInactivos = _apr.ObtieneProveedoresInactivos
        dgvProveedores.DataSource = _dtProveedoresInactivos
    End Sub

    Private Sub ActivarProveedores()

        For Each row As DataGridViewRow In dgvProveedores.Rows

            If row.Cells("seleccionar").Value = True Then
                _apr.ActivarProveedor(row.Cells("idProveedor").Value)
            End If

        Next

    End Sub
#End Region
End Class