Public Class AccionesProductos

    ' =========================================================================
    '   Inserta o actualiza el producto, recibe como parámetro un objeto de tipo producto
    ' =========================================================================
    Public Function ActualizaProducto(ByVal producto As Producto) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaProducto" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdProducto", "@pNombre", "@pDescripcion" _
                                                                , "@pCodBarras", "@pCantidadExistencias", "@pPrecioCompra" _
                                                                , "@pImpuestoVenta", "@pMontoImpuestoVenta", "@pPrecioVenta", "@pPrecioCnImpuesto" _
                                                                , "@pUtilidad", "@pResponsable", "@pIdUnidadMedidaFK", "@pIdMarca" _
                                                                , "@pIdSubFamilia", "@pIdProveedor", "@pCodigoInterno"} _
                                                             , {producto.IdProducto, producto.Nombre, producto.Descripcion _
                                                                , producto.CodigoBarras, producto.CantidadExistencias, producto.PrecioCompra _
                                                                , producto.ImpuestoVenta, producto.MontoImpuestoVenta, producto.PrecioVenta, producto.PrecioCnImpuesto _
                                                                , producto.Utilidad, "Andres", producto.UnidadMedida.IdUnidadMedida, producto.Marca.IdMarca _
                                                                , producto.SubFamila.IdSubFamilia, producto.Proveedor.IdProveedor, ""})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene un listado con todos los productos que existen en el sistema
    ' =========================================================================
    Public Function ObtieneProductos() As DataTable

        Try
            Dim dsProductos As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneProductos")

            If dsProductos IsNot Nothing AndAlso dsProductos.Tables(0).Rows.Count > 0 Then
                Return dsProductos.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function


    ' =========================================================================
    '   Elimina el producto que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarProducto(ByVal idProducto As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarProducto" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdProducto"} _
                                                      , {idProducto})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
