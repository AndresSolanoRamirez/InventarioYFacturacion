Public Class AccionesUnidadMedida
    ' =========================================================================
    '   Obtiene un listado con todas las unidades de medida que existen en el sistema
    ' =========================================================================
    Public Function ObtieneUnidadesMedida() As DataTable
        Try
            Dim dsUnidadesMedida As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneUnidadesMedida")

            If dsUnidadesMedida IsNot Nothing Or dsUnidadesMedida.Tables.Count > 0 Then
                Return dsUnidadesMedida.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function

    ' =========================================================================
    '   Obtiene una unidad medida por codigo
    ' =========================================================================
    Public Function ObtieneUnidadMedidaXCodigo(ByVal idUnidadMedida As Integer) As UnidadMedida

        Try

            Dim unidadMedidaObtiene As New UnidadMedida()

            Dim dtUnidadMedida As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneUnidadMedidaXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdUnidadMedida"} _
                                                                      , {idUnidadMedida})

            If dtUnidadMedida.Tables(0).Rows.Count > 0 Then

                unidadMedidaObtiene.IdUnidadMedida = dtUnidadMedida.Tables(0).Rows(0).Item("idUnidadMedida")
                unidadMedidaObtiene.Nombre = dtUnidadMedida.Tables(0).Rows(0).Item("nombre")
                unidadMedidaObtiene.Descripcion = dtUnidadMedida.Tables(0).Rows(0).Item("descripcion")
                unidadMedidaObtiene.FechaCreacion = IIf(IsDBNull(dtUnidadMedida.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtUnidadMedida.Tables(0).Rows(0).Item("fechaCreacion"))
                unidadMedidaObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtUnidadMedida.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtUnidadMedida.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return unidadMedidaObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Obtiene una unidad medida por nombre
    ' =========================================================================
    Public Function ObtieneUnidadMedidaXNombre(ByVal nombreUnidadMedida As String) As UnidadMedida

        Try

            Dim unidadMedidaObtiene As New UnidadMedida()

            Dim dtUnidadMedida As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneUnidadMedidaXNombre" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pNombreUnidadMedida"} _
                                                                      , {nombreUnidadMedida})

            If dtUnidadMedida.Tables(0).Rows.Count > 0 Then

                unidadMedidaObtiene.IdUnidadMedida = dtUnidadMedida.Tables(0).Rows(0).Item("idUnidadMedida")
                unidadMedidaObtiene.Nombre = dtUnidadMedida.Tables(0).Rows(0).Item("nombre")
                unidadMedidaObtiene.Descripcion = dtUnidadMedida.Tables(0).Rows(0).Item("descripcion")
                unidadMedidaObtiene.FechaCreacion = IIf(IsDBNull(dtUnidadMedida.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtUnidadMedida.Tables(0).Rows(0).Item("fechaCreacion"))
                unidadMedidaObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtUnidadMedida.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtUnidadMedida.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return unidadMedidaObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Inserta o actualiza la unidadMedida, recibe como parámetro un objeto de tipo familia
    ' =========================================================================
    Public Function ActualizaUnidadMedida(ByVal unidadMedida As UnidadMedida) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaUnidadMedida" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdUnidadMedida", "@pNombre", "@pDescripcion"} _
                                                             , {unidadMedida.IdUnidadMedida, unidadMedida.Nombre, unidadMedida.Descripcion})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Elimina la unidad de medida que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarUnidadMedida(ByVal idUnidadMedida As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarUnidadMedida" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdUnidadMedida"} _
                                                      , {idUnidadMedida})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
