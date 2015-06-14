Public Class AccionesUsuario

    ' =========================================================================
    '   Obtiene un listado con todos los usuarios que existen en el sistema
    ' =========================================================================
    Public Function ObtieneUsuarios() As DataTable

        Try
            Dim dsUsuarios As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneUsuarios")

            If dsUsuarios IsNot Nothing Or dsUsuarios.Tables.Count > 0 Then
                Return dsUsuarios.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene el usuario determinado por el idUsuario que pasa por parámetro
    ' =========================================================================
    Public Function ObtieneUsuarioXId(ByVal idUsuario As Integer) As Usuario

        Try

            Dim usuarioObtiene As New Usuario()

            Dim dtUsuario As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneUsuarioXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdUsuario"} _
                                                                      , {idUsuario})

            If dtUsuario.Tables(0).Rows.Count > 0 Then

                usuarioObtiene.IdUsuario = dtUsuario.Tables(0).Rows(0).Item("idUsuario")
                usuarioObtiene.Nombre = dtUsuario.Tables(0).Rows(0).Item("nombre")
                usuarioObtiene.Apellidos = dtUsuario.Tables(0).Rows(0).Item("apellidos")
                usuarioObtiene.Telefono = dtUsuario.Tables(0).Rows(0).Item("telefono")
                usuarioObtiene.Email = dtUsuario.Tables(0).Rows(0).Item("email")
                usuarioObtiene.Contrasena = dtUsuario.Tables(0).Rows(0).Item("contrasena")
                usuarioObtiene.PreguntaSeguridad = dtUsuario.Tables(0).Rows(0).Item("preguntaSeguridad")
                usuarioObtiene.RespuestaSeguridad = dtUsuario.Tables(0).Rows(0).Item("respuestaSeguridad")
                usuarioObtiene.FechaCreacion = IIf(IsDBNull(dtUsuario.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtUsuario.Tables(0).Rows(0).Item("fechaCreacion"))
                usuarioObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return usuarioObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Obtiene el usuario determinado por el nombre de usuario o contraseña
    ' =========================================================================
    Public Function ObtieneUsuarioXCredenciales(ByVal email As String, ByVal contrasena As String) As Usuario

        Try

            Dim usuarioObtiene As New Usuario

            Dim dtUsuario As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneUsuarioXCredenciales" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pEmail", "@pContrasena"} _
                                                                      , {email, contrasena})

            If dtUsuario.Tables(0).Rows.Count > 0 Then

                usuarioObtiene.IdUsuario = dtUsuario.Tables(0).Rows(0).Item("idUsuario")
                usuarioObtiene.Nombre = dtUsuario.Tables(0).Rows(0).Item("nombre")
                usuarioObtiene.Apellidos = dtUsuario.Tables(0).Rows(0).Item("apellidos")
                usuarioObtiene.Telefono = dtUsuario.Tables(0).Rows(0).Item("telefono")
                usuarioObtiene.Contrasena = dtUsuario.Tables(0).Rows(0).Item("contrasena")
                usuarioObtiene.PreguntaSeguridad = dtUsuario.Tables(0).Rows(0).Item("preguntaSeguridad")
                usuarioObtiene.RespuestaSeguridad = dtUsuario.Tables(0).Rows(0).Item("respuestaSeguridad")
                usuarioObtiene.Activo = dtUsuario.Tables(0).Rows(0).Item("activo")
                usuarioObtiene.FechaCreacion = dtUsuario.Tables(0).Rows(0).Item("fechaCreacion")
                If IsDBNull(dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion")) Then
                    usuarioObtiene.FechaUltimaModificacion = Nothing
                Else
                    usuarioObtiene.FechaUltimaModificacion = dtUsuario.Tables(0).Rows(0).Item("fechaUltimaModificacion")
                End If
                Return usuarioObtiene
            End If
            Return Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    ' =========================================================================
    '   Inserta o actualiza el usuario, recibe como parámetro un objeto de tipo Usuario
    ' =========================================================================
    Public Function ActualizaUsuario(ByVal usuario As Usuario) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaUsuario" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdUsuario", "@pNombre", "@pApellidos", "@pTelefono", _
                                                                "@pEmail", "@pContrasena", "@pPreguntaSeguridad", _
                                                                "@pRespuestaSeguridad", "@pActivo"} _
                                                             , {usuario.IdUsuario, usuario.Nombre, usuario.Apellidos, usuario.Telefono, _
                                                                usuario.Email, usuario.Contrasena, usuario.PreguntaSeguridad, _
                                                                usuario.RespuestaSeguridad, usuario.Activo})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Elimina el usuario que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarUsuario(ByVal idUsuario As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarUsuario" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdUsuario"} _
                                                      , {idUsuario})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Activa el usuario que pasa por parámetro
    ' =========================================================================
    Public Sub ActivarUsuario(ByVal idUsuario As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("ActivarUsuario" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdUsuario"} _
                                                      , {idUsuario})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Obtiene los usuario asignados y los disponibles del rol
    ' =========================================================================
    Public Function ObtieneUsuariosXRol(ByVal idRol As Integer) As DataSet

        Try
            Dim dsUsuarios As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneUsuariosXRol" _
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
    '   Asigna usuario al rol
    ' =========================================================================
    Public Sub AsignarUsuarioARol(ByVal idRol As Integer, ByVal idUsuario As Integer)

        Try
            AdministracionRepositorio.ExecuteNonQuery("AsignaUsuariosARol" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdRol", "@pIdUsuario"} _
                                                      , {idRol, idUsuario})

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    ' =========================================================================
    '   Quita usuario al rol
    ' =========================================================================
    Public Sub QuitarUsuarioARol(ByVal idRol As Integer, ByVal idUsuario As Integer)

        Try
            AdministracionRepositorio.ExecuteNonQuery("QuitarUsuariosARol" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdRol", "@pIdUsuario"} _
                                                      , {idRol, idUsuario})

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
