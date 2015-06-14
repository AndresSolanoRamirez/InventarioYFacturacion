Public Class AccionesRoles

    ' =========================================================================
    '   Inserta o actualiza el rol, recibe como parámetro un objeto de tipo Rol
    ' =========================================================================
    Public Function ActualizaRol(ByVal rol As Rol) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaRol" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdRol", "@pNombre", "@pDescripcion"} _
                                                             , {rol.IdRol, rol.Nombre, rol.Descripcion})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene un listado con todos los roles que existen en el sistema
    ' =========================================================================
    Public Function ObtieneRoles() As DataTable

        Try
            Dim dsRoles As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneRoles")

            If dsRoles IsNot Nothing Or dsRoles.Tables.Count > 0 Then
                Return dsRoles.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene un rol por codigo
    ' =========================================================================
    Public Function ObtieneRolXCodigo(ByVal idRol As Integer) As Rol

        Try

            Dim rolObtiene As New Rol()

            Dim dtUsuario As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneRolXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdRol"} _
                                                                      , {idRol})

            If dtUsuario.Tables(0).Rows.Count > 0 Then

                rolObtiene.IdRol = dtUsuario.Tables(0).Rows(0).Item("idRol")
                rolObtiene.Nombre = dtUsuario.Tables(0).Rows(0).Item("nombre")
                rolObtiene.Descripcion = dtUsuario.Tables(0).Rows(0).Item("descripcion")                
                rolObtiene.FechaCreacion = IIf(IsDBNull(dtUsuario.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtUsuario.Tables(0).Rows(0).Item("fechaCreacion"))
                rolObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return rolObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Elimina el rol que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarRol(ByVal idrol As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarRol" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdRol"} _
                                                      , {idrol})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
