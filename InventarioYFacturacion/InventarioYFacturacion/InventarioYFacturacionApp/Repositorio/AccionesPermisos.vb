Public Class AccionesPermisos
    ' =========================================================================
    '   Inserta o actualiza el rol, recibe como parámetro un objeto de tipo Rol
    ' =========================================================================
    Public Function ActualizaPermiso(ByVal permiso As Permiso) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaPermiso" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdPermiso", "@pNombre", "@pDescripcion"} _
                                                             , {permiso.IdPermiso, permiso.Nombre, permiso.Descripcion})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene un listado con todos los permisos que existen en el sistema
    ' =========================================================================
    Public Function ObtienePermisos() As DataTable

        Try
            Dim dsPermisos As DataSet = AdministracionRepositorio.ExecuteDataset("ObtienePermisos")

            If dsPermisos IsNot Nothing Or dsPermisos.Tables.Count > 0 Then
                Return dsPermisos.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene un permiso por codigo
    ' =========================================================================
    Public Function ObtienePermisoXCodigo(ByVal idPermiso As Integer) As Permiso

        Try

            Dim permisoObtiene As New Permiso()

            Dim dtUsuario As DataSet = AdministracionRepositorio.ExecuteDataset("ObtienePermisoXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdPermiso"} _
                                                                      , {idPermiso})

            If dtUsuario.Tables(0).Rows.Count > 0 Then

                permisoObtiene.IdPermiso = dtUsuario.Tables(0).Rows(0).Item("idPermiso")
                permisoObtiene.Nombre = dtUsuario.Tables(0).Rows(0).Item("nombre")
                permisoObtiene.Descripcion = dtUsuario.Tables(0).Rows(0).Item("descripcion")
                permisoObtiene.FechaCreacion = IIf(IsDBNull(dtUsuario.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtUsuario.Tables(0).Rows(0).Item("fechaCreacion"))
                permisoObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return permisoObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Elimina el Permiso que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarPermiso(ByVal idPemiso As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarPermiso" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdPermiso"} _
                                                      , {idPemiso})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Obtiene los permisos asignados y los disponibles del rol
    ' =========================================================================
    Public Function ObtienePermisosXRol(ByVal idRol As Integer) As DataSet

        Try
            Dim dsUsuarios As DataSet = AdministracionRepositorio.ExecuteDataset("ObtienePermisosXRol" _
                                                                                 , CommandType.StoredProcedure _
                                                                                 , {"@pIdRol"} _
                                                                                 , {idRol})

            If dsUsuarios IsNot Nothing Or dsUsuarios.Tables.Count > 0 Then
                Return dsUsuarios
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Asigna permiso al rol
    ' =========================================================================
    Public Sub AsignarPermisoARol(ByVal idRol As Integer, ByVal idPermiso As Integer)

        Try
            AdministracionRepositorio.ExecuteNonQuery("AsignaPermisoARol" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdRol", "@pIdPermiso"} _
                                                      , {idRol, idPermiso})

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    ' =========================================================================
    '   Quita permiso al rol
    ' =========================================================================
    Public Sub QuitarPermisoARol(ByVal idRol As Integer, ByVal idPermiso As Integer)

        Try
            AdministracionRepositorio.ExecuteNonQuery("QuitarPermisoARol" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdRol", "@pIdPermiso"} _
                                                      , {idRol, idPermiso})

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
