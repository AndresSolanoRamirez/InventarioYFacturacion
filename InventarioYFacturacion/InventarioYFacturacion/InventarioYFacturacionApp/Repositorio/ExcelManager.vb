'Imports Janus.Windows.GridEX
Imports System.IO

Public Class ExcelManager

    Public Shared Function GetExcelData(ByVal fileName As String, ByVal indexSheet As Integer, ByVal startCell As String) As DataTable

        Dim dt As New DataTable

        Try

            Dim excelApp As Object = Nothing
            Dim cell As Object = Nothing
            Dim wk As Object = Nothing

            Try
                excelApp = CrearExcel()

                wk = excelApp.Workbooks.Open(fileName)

                Dim sh As Object = wk.Sheets(indexSheet)

                cell = sh.Range(startCell)

                Dim columnas As ArrayList = CrearColumnas(dt, excelApp, cell, 1)
                If columnas.Count = 0 Then Return Nothing

                SacarDatosUnaHojaExcelRapida(excelApp, sh, dt, columnas, startCell)

                Return dt

            Finally

                If wk IsNot Nothing Then
                    CerrarLibro(wk)
                End If

                If excelApp IsNot Nothing Then
                    DestruirExcel(excelApp)

                End If

            End Try

        Catch ex As Exception
            Throw New ApplicationException(ex.Message)


        End Try

    End Function

    Private Shared Function CrearColumnas(ByVal dt As DataTable _
                                   , ByVal excel As Object _
                                   , ByVal cell As Object _
                                   , ByVal pararColumnasVacias As Integer) As ArrayList

        ' ignorar las columnas vacias, hasta que encuentre tantas vacias como dice archivoexcel

        Dim vacios As Integer = 0
        Dim inicio As Integer = 1
        Dim maxCol As Integer = excel.columns.count

        Dim cols As New ArrayList
        Dim indexCol As Integer = 0
        For j As Integer = inicio To maxCol
            Dim valor As String = cell(1, j).value
            If String.IsNullOrEmpty(valor) Then
                vacios = vacios + 1
            Else

                cols.Add(valor)

                dt.Columns.Add(valor)

                indexCol = indexCol + 1
                vacios = 0
            End If

            If vacios >= pararColumnasVacias Then

                Exit For
            End If

        Next

        Return cols

    End Function



    Private Shared Sub SacarDatosUnaHojaExcelRapida(ByVal excelApp As Object _
                                            , ByVal sh As Object _
                                            , ByVal dt As DataTable _
                                            , ByVal columnas As ArrayList _
                                            , ByVal celdaInicio As String)
        Dim cell As Object = Nothing

        cell = sh.Range(celdaInicio)

        Dim CANTIDAD As Integer = 20000
        If columnas Is Nothing Then Exit Sub


        Dim region As Object = cell.currentRegion

        Dim rows As Integer = region.Rows.Count
        Dim columns As Integer = region.Columns.Count

        Dim posicion As Integer = 1

        While posicion < rows
            Dim hasta As Integer = CANTIDAD
            If hasta + posicion > rows Then hasta = rows - posicion

            Dim valoresExcel As Object

            valoresExcel = cell.Offset(posicion).Resize(hasta, columns).value
            LLenarDT(valoresExcel, columnas, dt)

            posicion = hasta + posicion
        End While

    End Sub

    Private Shared Sub LLenarDT(ByVal valoresExcel As Object _
                   , ByVal columnas As ArrayList _
                   , ByVal dt As DataTable)

        'http://www.w3schools.com/vbscript/func_lbound.asp

        For i As Integer = 1 To UBound(valoresExcel, 1)
            Dim valores(columnas.Count - 1) As Object
            For j As Integer = 1 To UBound(valoresExcel, 2)
                valores(j - 1) = valoresExcel(i, j)

            Next

            dt.Rows.Add(valores)
        Next

    End Sub


    Private Shared Function CrearExcel() As Object
        Dim excel As Object = CreateObject("Excel.Application")

        excel.DisplayAlerts = False
        excel.ScreenUpdating = False

        Return excel

    End Function

    Private Shared Sub DestruirExcel(ByRef excel As Object)

        excel.DisplayAlerts = True

        excel.Quit()

        Runtime.InteropServices.Marshal.ReleaseComObject(excel)
        Runtime.InteropServices.Marshal.FinalReleaseComObject(excel)
        excel = Nothing

        GC.Collect()
        GC.WaitForPendingFinalizers()
        ''   GC.Collect()
        GC.Collect()
    End Sub

    Private Shared Sub CerrarLibro(ByVal wk As Object)
        If wk IsNot Nothing Then
            wk.Close(False)
        End If


    End Sub

    'Copiar un DataTable a Excel
    Public Shared Sub ExportTableToExcel(ByVal pDataTable As DataTable, _
                                       ByVal pNombreArchivo As String)

        Dim excelApp As Object = Nothing
        Try
            ' Abrir el excel
            excelApp = CrearExcel()
            excelApp.Visible = False


            Dim wk As Object = excelApp.Workbooks.Add(Type.Missing)

            If excelApp.Rows.Count <= pDataTable.Rows.Count + 1 Then
                Throw New ApplicationException("Excel no tiene filas suficientes para exportar los datos")
                Exit Sub
            End If

            ' Copiar el datatable a un array
            Dim rawData(pDataTable.Rows.Count, pDataTable.Columns.Count - 1) As Object

            ' copiar los nombres de las columnas
            For col As Integer = 0 To pDataTable.Columns.Count - 1
                rawData(0, col) = pDataTable.Columns(col).ColumnName
            Next

            ' copiar los valores
            For col As Integer = 0 To pDataTable.Columns.Count - 1
                For row As Integer = 0 To pDataTable.Rows.Count - 1
                    rawData(row + 1, col) = pDataTable.Rows(row)(col)
                Next
            Next

            Dim sh = wk.ActiveSheet

            'Negrita a la fuente de las celdas
            excelApp.Range("A1:Z1").Font.Bold = True            

            Dim cell As Object = excelApp.Range("A1")

            cell.Resize(pDataTable.Rows.Count + 1, pDataTable.Columns.Count).Value2 = rawData

            Dim xlWorkbookNormal As Integer = 51

            'Auto ajustar el tamaño de las celdas al contenido
            excelApp.Columns.AutoFit()
            excelApp.Range("A1:Z1").Font.Italic = True
            excelApp.Range("A1:Z1").Font.Color = Color.Blue

            wk.SaveAs(pNombreArchivo, xlWorkbookNormal)

            CerrarLibro(wk)

        Catch ex As Exception
            Throw ex
        Finally
            DestruirExcel(excelApp)
        End Try

    End Sub

    'Public Shared Sub ExportGridToExcel(ByVal grid As GridEX, ByVal fileName As String)

    '    Using jex As New Export.GridEXExporter
    '        jex.GridEX = grid
    '        jex.IncludeChildTables = True
    '        Using fs As New FileStream(fileName, FileMode.Create)

    '            jex.Export(fs)
    '            fs.Close()
    '        End Using
    '    End Using
    'End Sub


End Class
