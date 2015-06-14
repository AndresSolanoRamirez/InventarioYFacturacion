Public Class AccionesFamilias

    ' =========================================================================
    '   Obtiene un listado con todas las familias que existen en el sistema
    ' =========================================================================
    Public Function ObtieneFamilias() As DataTable
        Try
            Dim dsFamilias As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneFamilias")

            If dsFamilias IsNot Nothing Or dsFamilias.Tables.Count > 0 Then
                Return dsFamilias.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function

    ' =========================================================================
    '   Obtiene una familia por codigo
    ' =========================================================================
    Public Function ObtieneFamiliaXCodigo(ByVal idFamilia As Integer) As Familia

        Try

            Dim familiaObtiene As New Familia()

            Dim dtFamilia As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneFamiliaXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdFamilia"} _
                                                                      , {idFamilia})

            If dtFamilia.Tables(0).Rows.Count > 0 Then

                familiaObtiene.IdFamilia = dtFamilia.Tables(0).Rows(0).Item("idFamilia")
                familiaObtiene.Nombre = dtFamilia.Tables(0).Rows(0).Item("nombre")
                familiaObtiene.Descripcion = dtFamilia.Tables(0).Rows(0).Item("descripcion")
                familiaObtiene.FechaCreacion = IIf(IsDBNull(dtFamilia.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtFamilia.Tables(0).Rows(0).Item("fechaCreacion"))
                familiaObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return familiaObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Inserta o actualiza la familia, recibe como parámetro un objeto de tipo familia
    ' =========================================================================
    Public Function ActualizaFamilia(ByVal familia As Familia) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaFamilia" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdFamilia", "@pNombre", "@pDescripcion"} _
                                                             , {familia.IdFamilia, familia.Nombre, familia.Descripcion})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Elimina la familia que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarFamilia(ByVal idFamilia As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarFamilia" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdFamilia"} _
                                                      , {idFamilia})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Obtiene una familia por nombre
    ' =========================================================================
    Public Function ObtieneFamiliaXNombre(ByVal nombre As String) As Familia

        Try

            Dim familiaObtiene As New Familia()

            Dim dtFamilia As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneFamiliaXNombre" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pNombre"} _
                                                                      , {nombre})

            If dtFamilia.Tables(0).Rows.Count > 0 Then

                familiaObtiene.IdFamilia = dtFamilia.Tables(0).Rows(0).Item("idFamilia")
                familiaObtiene.Nombre = dtFamilia.Tables(0).Rows(0).Item("nombre")
                familiaObtiene.Descripcion = dtFamilia.Tables(0).Rows(0).Item("descripcion")
                familiaObtiene.FechaCreacion = IIf(IsDBNull(dtFamilia.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtFamilia.Tables(0).Rows(0).Item("fechaCreacion"))
                familiaObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return familiaObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function
End Class
