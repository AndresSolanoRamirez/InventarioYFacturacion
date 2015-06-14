Public Class AccionesSubFamilias

    Private _af As AccionesFamilias

    ' =========================================================================
    '   Obtiene un listado con todas las sub familias que existen en el sistema
    ' =========================================================================
    Public Function ObtieneSubFamilias() As DataTable
        Try
            Dim dsSubFamilias As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneSubFamilias")

            If dsSubFamilias IsNot Nothing Or dsSubFamilias.Tables.Count > 0 Then
                Return dsSubFamilias.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function

    ' =========================================================================
    '   Obtiene una sub familia por codigo
    ' =========================================================================
    Public Function ObtieneSubFamiliaXCodigo(ByVal idSubFamilia As Integer) As SubFamilia

        Try

            Dim subFamiliaObtiene As New SubFamilia()

            Dim dtSubFamilia As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneSubFamiliaXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdSubFamilia"} _
                                                                      , {idSubFamilia})

            If dtSubFamilia.Tables(0).Rows.Count > 0 Then

                subFamiliaObtiene.IdSubFamilia = dtSubFamilia.Tables(0).Rows(0).Item("idSubFamilia")
                subFamiliaObtiene.Nombre = dtSubFamilia.Tables(0).Rows(0).Item("nombre")
                subFamiliaObtiene.Descripcion = dtSubFamilia.Tables(0).Rows(0).Item("descripcion")
                subFamiliaObtiene.FechaCreacion = IIf(IsDBNull(dtSubFamilia.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtSubFamilia.Tables(0).Rows(0).Item("fechaCreacion"))
                subFamiliaObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtSubFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtSubFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                ' -- Obtengo los datos de la familia

                Dim familia As New Familia
                _af = New AccionesFamilias
                If Not IsNothing(dtSubFamilia.Tables(0).Rows(0).Item("idSubFamilia")) Then
                    familia = _af.ObtieneFamiliaXCodigo(dtSubFamilia.Tables(0).Rows(0).Item("idSubFamilia"))
                    subFamiliaObtiene.Familia.IdFamilia = familia.IdFamilia
                    subFamiliaObtiene.Familia.Nombre = familia.Nombre
                    subFamiliaObtiene.Familia.Descripcion = familia.Descripcion
                    subFamiliaObtiene.Familia.FechaCreacion = familia.FechaCreacion
                    subFamiliaObtiene.Familia.FechaUltimaModificacion = familia.FechaUltimaModificacion
                End If                

                Return subFamiliaObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Obtiene una sub familia por nombre
    ' =========================================================================
    Public Function ObtieneSubFamiliaXNombre(ByVal nombre As String) As SubFamilia

        Try

            Dim subFamiliaObtiene As New SubFamilia()

            Dim dtSubFamilia As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneSubFamiliaXNombre" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pNombreSubFamilia"} _
                                                                      , {nombre})

            If dtSubFamilia.Tables(0).Rows.Count > 0 Then

                subFamiliaObtiene.IdSubFamilia = dtSubFamilia.Tables(0).Rows(0).Item("idSubFamilia")
                subFamiliaObtiene.Nombre = dtSubFamilia.Tables(0).Rows(0).Item("nombre")
                subFamiliaObtiene.Descripcion = dtSubFamilia.Tables(0).Rows(0).Item("descripcion")
                subFamiliaObtiene.FechaCreacion = IIf(IsDBNull(dtSubFamilia.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtSubFamilia.Tables(0).Rows(0).Item("fechaCreacion"))
                subFamiliaObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtSubFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtSubFamilia.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                ' -- Obtengo los datos de la familia

                Dim familia As New Familia
                _af = New AccionesFamilias
                If Not IsNothing(dtSubFamilia.Tables(0).Rows(0).Item("idSubFamilia")) Then
                    familia = _af.ObtieneFamiliaXCodigo(dtSubFamilia.Tables(0).Rows(0).Item("idSubFamilia"))
                    subFamiliaObtiene.Familia.IdFamilia = familia.IdFamilia
                    subFamiliaObtiene.Familia.Nombre = familia.Nombre
                    subFamiliaObtiene.Familia.Descripcion = familia.Descripcion
                    subFamiliaObtiene.Familia.FechaCreacion = familia.FechaCreacion
                    subFamiliaObtiene.Familia.FechaUltimaModificacion = familia.FechaUltimaModificacion
                End If

                Return subFamiliaObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Inserta o actualiza la sub familia, recibe como parámetro un objeto de tipo familia
    ' =========================================================================
    Public Function ActualizaSubFamilia(ByVal subFamilia As SubFamilia) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaSubFamilia" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdSubFamilia", "@pNombre", "@pDescripcion", "@pIdFamilia"} _
                                                             , {subFamilia.IdSubFamilia, subFamilia.Nombre, subFamilia.Descripcion, subFamilia.Familia.IdFamilia})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Elimina la sub familia que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarSubFamilia(ByVal idSubFamilia As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarSubFamilia" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdSubFamilia"} _
                                                      , {idSubFamilia})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
