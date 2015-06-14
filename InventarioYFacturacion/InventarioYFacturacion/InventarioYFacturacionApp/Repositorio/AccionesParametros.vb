Public Class AccionesParametros
    ' =========================================================================
    '   Obtiene un listado con todos los parámetros que existen en el sistema
    ' =========================================================================
    Public Function ObtieneParametros() As DataTable
        Try
            Dim dsParametros As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneParametros")

            If dsParametros IsNot Nothing Or dsParametros.Tables.Count > 0 Then
                Return dsParametros.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function

    ' =========================================================================
    '   Obtiene un parámetro por codigo
    ' =========================================================================
    Public Function ObtieneParametroXCodigo(ByVal idParametro As Integer) As Parametro

        Try

            Dim parametroObtiene As New Parametro()

            Dim dtParametro As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneParametroXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdParametro"} _
                                                                      , {idParametro})

            If dtParametro.Tables(0).Rows.Count > 0 Then

                parametroObtiene.IdParametro = dtParametro.Tables(0).Rows(0).Item("idParametro")
                parametroObtiene.Nombre = dtParametro.Tables(0).Rows(0).Item("nombre")
                parametroObtiene.Value = dtParametro.Tables(0).Rows(0).Item("value")
                parametroObtiene.PermiteEliminar = dtParametro.Tables(0).Rows(0).Item("permiteEliminar")
                parametroObtiene.PermiteModificar = dtParametro.Tables(0).Rows(0).Item("permiteModificar")
                parametroObtiene.FechaCreacion = IIf(IsDBNull(dtParametro.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtParametro.Tables(0).Rows(0).Item("fechaCreacion"))
                parametroObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtParametro.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtParametro.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return parametroObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Inserta o actualiza el parametro, recibe como parámetro un objeto de tipo familia
    ' =========================================================================
    Public Function ActualizaParametro(ByVal parametro As Parametro) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaParametro" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdParametro", "@pNombre", "@pValue", "@pPermiteModificar", "@pPermiteEliminar"} _
                                                             , {parametro.IdParametro, parametro.Nombre, parametro.Value, parametro.PermiteModificar, parametro.PermiteEliminar})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Elimina el parametro
    ' =========================================================================
    Public Sub EliminarParametro(ByVal idParametro As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarParametro" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdParametro"} _
                                                      , {idParametro})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Obtiene el parametro por el nombre que pasa por parámetro 
    ' =========================================================================
    Public Function ObtieneParametroXNombre(ByVal nombre As String) As Parametro

        Try

            Dim parametroObtiene As New Parametro()

            Dim dtParametro As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneParametroXNombre" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pNombre"} _
                                                                      , {nombre})

            If dtParametro.Tables(0).Rows.Count > 0 Then

                parametroObtiene.IdParametro = dtParametro.Tables(0).Rows(0).Item("idParametro")
                parametroObtiene.Nombre = dtParametro.Tables(0).Rows(0).Item("nombre")
                parametroObtiene.Value = dtParametro.Tables(0).Rows(0).Item("value")
                parametroObtiene.PermiteEliminar = dtParametro.Tables(0).Rows(0).Item("permiteEliminar")
                parametroObtiene.PermiteModificar = dtParametro.Tables(0).Rows(0).Item("permiteModificar")
                parametroObtiene.FechaCreacion = IIf(IsDBNull(dtParametro.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtParametro.Tables(0).Rows(0).Item("fechaCreacion"))
                parametroObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtParametro.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtParametro.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return parametroObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Obtiene un listado con todos los impuestos que existen en el sistema
    ' =========================================================================
    Public Function ObtieneImpuestos() As DataTable
        Try
            Dim dsImpuestos As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneImpuestos")

            If dsImpuestos IsNot Nothing Or dsImpuestos.Tables.Count > 0 Then
                Return dsImpuestos.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function
End Class
