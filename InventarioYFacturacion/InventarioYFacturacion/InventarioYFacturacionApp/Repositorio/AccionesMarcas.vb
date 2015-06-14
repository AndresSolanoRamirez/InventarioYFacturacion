Public Class AccionesMarcas
    ' =========================================================================
    '   Obtiene un listado con todas las marcas que existen en el sistema
    ' =========================================================================
    Public Function ObtieneMarcas() As DataTable
        Try
            Dim dsMarcas As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneMarcas")

            If dsMarcas IsNot Nothing Or dsMarcas.Tables.Count > 0 Then
                Return dsMarcas.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function

    ' =========================================================================
    '   Obtiene una marcac por codigo
    ' =========================================================================
    Public Function ObtieneMarcaXCodigo(ByVal idMarca As Integer) As Marcas

        Try

            Dim marcaObtiene As New Marcas()

            Dim dtMarca As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneMarcaXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdMarca"} _
                                                                      , {idMarca})

            If dtMarca.Tables(0).Rows.Count > 0 Then

                marcaObtiene.IdMarca = dtMarca.Tables(0).Rows(0).Item("idMarca")
                marcaObtiene.Nombre = dtMarca.Tables(0).Rows(0).Item("nombre")
                marcaObtiene.Descripcion = dtMarca.Tables(0).Rows(0).Item("descripcion")
                marcaObtiene.FechaCreacion = IIf(IsDBNull(dtMarca.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtMarca.Tables(0).Rows(0).Item("fechaCreacion"))
                marcaObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtMarca.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtMarca.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return marcaObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Elimina la marca que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarMarca(ByVal idMarca As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarMarca" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdMarca"} _
                                                      , {idMarca})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Inserta o actualiza la marca, recibe como parámetro un objeto de tipo familia
    ' =========================================================================
    Public Function ActualizaMarca(ByVal marca As Marcas) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaMarca" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdMarca", "@pNombre", "@pDescripcion"} _
                                                             , {marca.IdMarca, marca.Nombre, marca.Descripcion})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function
End Class
