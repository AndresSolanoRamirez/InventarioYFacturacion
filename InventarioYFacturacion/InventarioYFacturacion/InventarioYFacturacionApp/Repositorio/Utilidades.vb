Public Class Utilidades

    Public Enum TipoArchivo
        Familias
        SubFamilia
        UnidadesMedida
        Proveedores
        Clientes
        Productos
    End Enum

    Private Shared _dt As DataTable

#Region "Acciones"
    Public Shared Function GenerarArchivo(ByVal tipoArchivo As TipoArchivo) As Boolean
        Dim f As New SaveFileDialog()
        f.Filter = "Archivos de Excel|*.xls;*.xlsx"
        f.DefaultExt = "xls"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                ExcelManager.ExportTableToExcel(GenerarDataTable(tipoArchivo), f.FileName)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Public Shared Function ExportarDatos(ByVal tipoArchivo As TipoArchivo, ByVal dt As DataTable) As Boolean
        Dim f As New SaveFileDialog()
        f.Filter = "Archivos de Excel|*.xls;*.xlsx"
        f.DefaultExt = "xls"

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                ExcelManager.ExportTableToExcel(dt, f.FileName)
                Return True
            Catch ex As Exception                
                Return False
            End Try
        End If
        Return False
    End Function

    Public Shared Function ImportarDatos(ByVal tipoCarga As TipoArchivo) As DataTable
        Dim _tipoCarga As TipoArchivo = tipoCarga        
        Dim op As New OpenFileDialog
        op.Filter = "Archivos de Excel|*.xls;*.xlsx"
        op.DefaultExt = "xls"

        Try
            _tipoCarga = tipoCarga
            If op.ShowDialog = DialogResult.OK Then

                CargarExcel(op)

                If Not FormatoValido(tipoCarga) Then
                    Mensajes.ShowMessage("Formato Inválido", frmMessageBox.TipoMensaje.Err)
                    Return Nothing
                Else
                    Return _dt
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "Funciones"


    Private Shared Function GenerarDataTable(ByVal tipoArchivo As TipoArchivo) As DataTable
        Dim dt As New DataTable

        If tipoArchivo = Utilidades.TipoArchivo.Familias Then
            Familia(dt)
        ElseIf tipoArchivo = Utilidades.TipoArchivo.SubFamilia Then
            SubFamilia(dt)
        ElseIf tipoArchivo = Utilidades.TipoArchivo.UnidadesMedida Then
            UnidadesMedida(dt)
        ElseIf tipoArchivo = Utilidades.TipoArchivo.Proveedores Then
            Proveedores(dt)
        ElseIf tipoArchivo = Utilidades.TipoArchivo.Clientes Then
            Clientes(dt)
        ElseIf tipoArchivo = Utilidades.TipoArchivo.Productos Then
            Productos(dt)
        End If

        Return dt

    End Function

    Private Shared Sub Familia(ByVal dt As DataTable)
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Descripción")
    End Sub

    Private Shared Sub SubFamilia(ByVal dt As DataTable)
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Descripción")
        dt.Columns.Add("Familia")
    End Sub

    Private Shared Sub UnidadesMedida(ByVal dt As DataTable)
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Descripción")
    End Sub

    Private Shared Sub Proveedores(ByVal dt As DataTable)
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Ced. Jurídica")
        dt.Columns.Add("Contacto")
        dt.Columns.Add("Teléfono1")
        dt.Columns.Add("Teléfono2")
        dt.Columns.Add("Email")
        dt.Columns.Add("Email Contacto")
        dt.Columns.Add("Dirección")
    End Sub

    Private Shared Sub Clientes(ByVal dt As DataTable)
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellidos")
        dt.Columns.Add("Identificación")
        dt.Columns.Add("Teléfono")
        dt.Columns.Add("Email")
        dt.Columns.Add("Dirección")
    End Sub

    Private Shared Sub Productos(ByVal dt As DataTable)
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Descripción")
        dt.Columns.Add("Cod. Barras")
        dt.Columns.Add("Cantidad Existencias")
        dt.Columns.Add("Precio Compra")
        dt.Columns.Add("Utilidad")
        dt.Columns.Add("Unidad de Medida")
        dt.Columns.Add("Marca")
        dt.Columns.Add("Sub Familia")
        dt.Columns.Add("Proveedor")
    End Sub

    ' ===============================================================
    '   Valida si el formato del archivo de excel es válido, esto lo
    '   analiza comparando las columnas que pasan por el datatable 
    '   con las válidas según sea el tipo de carga
    ' ===============================================================
    Private Shared Function FormatoValido(ByVal tipoCarga As TipoArchivo) As Boolean
        If tipoCarga = frmImportarDatos.TipoCarga.Familia Or tipoCarga = frmImportarDatos.TipoCarga.UnidadesMedida Then
            If _dt.Columns(0).Caption = "Nombre" AndAlso _dt.Columns(1).Caption = "Descripción" AndAlso _dt.Columns.Count = 2 Then
                Return True
            End If
        ElseIf tipoCarga = frmImportarDatos.TipoCarga.SubFamilia Then
            If _dt.Columns(0).Caption = "Nombre" AndAlso _dt.Columns(1).Caption = "Descripción" _
            AndAlso _dt.Columns(2).Caption = "Familia" AndAlso _dt.Columns.Count = 3 Then
                Return True
            End If
        ElseIf tipoCarga = frmImportarDatos.TipoCarga.Clientes Then
            If _dt.Columns(0).Caption = "Nombre" AndAlso _dt.Columns(1).Caption = "Apellidos" _
                AndAlso _dt.Columns(2).Caption = "Identificación" AndAlso _dt.Columns(3).Caption = "Teléfono" _
                AndAlso _dt.Columns(4).Caption = "Email" AndAlso _dt.Columns(5).Caption = "Dirección" _
                AndAlso _dt.Columns.Count = 6 Then
                Return True
            End If
        ElseIf tipoCarga = frmImportarDatos.TipoCarga.Proveedores Then
            If _dt.Columns(0).Caption = "Nombre" AndAlso _dt.Columns(1).Caption = "Ced. Jurídica" _
                AndAlso _dt.Columns(2).Caption = "Contacto" AndAlso _dt.Columns(3).Caption = "Teléfono1" _
                AndAlso _dt.Columns(4).Caption = "Teléfono2" AndAlso _dt.Columns(5).Caption = "Email" _
                AndAlso _dt.Columns(6).Caption = "Email Contacto" AndAlso _dt.Columns(7).Caption = "Dirección" AndAlso _dt.Columns.Count = 8 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Shared Sub CargarExcel(ByVal file As OpenFileDialog)
        _dt = ExcelManager.GetExcelData(file.FileName, 1, "A1")
    End Sub
#End Region


End Class
