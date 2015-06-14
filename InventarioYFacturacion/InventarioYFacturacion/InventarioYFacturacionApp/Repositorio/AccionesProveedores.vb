Public Class AccionesProveedores
    ' =========================================================================
    '   Obtiene un listado con todos los proveedores que existen en el sistema
    ' =========================================================================
    Public Function ObtieneProveedores() As DataTable

        Try
            Dim dsProveedores As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneProveedores")

            If dsProveedores IsNot Nothing Or dsProveedores.Tables.Count > 0 Then
                Return dsProveedores.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene un listado con todos los proveedores que han sido inactivados
    ' =========================================================================
    Public Function ObtieneProveedoresInactivos() As DataTable

        Try
            Dim dsProveedores As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneProveedoresInactivos")

            If dsProveedores IsNot Nothing Or dsProveedores.Tables.Count > 0 Then
                Return dsProveedores.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene el proveedor determinado por el idProveedor que pasa por parámetro
    ' =========================================================================
    Public Function ObtieneProveedorXId(ByVal idProveedor As Integer) As Proveedor

        Try

            Dim proveedorObtiene As New Proveedor()

            Dim dtProveedor As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneProveedorXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdProveedor"} _
                                                                      , {idProveedor})

            If dtProveedor.Tables(0).Rows.Count > 0 Then

                proveedorObtiene.IdProveedor = dtProveedor.Tables(0).Rows(0).Item("idProveedor")
                proveedorObtiene.Nombre = dtProveedor.Tables(0).Rows(0).Item("nombre")
                proveedorObtiene.CedulaJuridica = dtProveedor.Tables(0).Rows(0).Item("cedulaJuridica")
                proveedorObtiene.Contacto = dtProveedor.Tables(0).Rows(0).Item("contacto")
                proveedorObtiene.Telefono1 = dtProveedor.Tables(0).Rows(0).Item("telefono1")
                proveedorObtiene.Telefono2 = dtProveedor.Tables(0).Rows(0).Item("telefono2")
                proveedorObtiene.Email = dtProveedor.Tables(0).Rows(0).Item("email")
                proveedorObtiene.EmailContacto = dtProveedor.Tables(0).Rows(0).Item("emailContacto")
                proveedorObtiene.Direccion = dtProveedor.Tables(0).Rows(0).Item("direccion")
                proveedorObtiene.Activo = dtProveedor.Tables(0).Rows(0).Item("activo")
                proveedorObtiene.CodigoInterno = IIf(IsDBNull(dtProveedor.Tables(0).Rows(0).Item("codInterno")), Nothing, dtProveedor.Tables(0).Rows(0).Item("codInterno"))
                proveedorObtiene.FechaCreacion = IIf(IsDBNull(dtProveedor.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtProveedor.Tables(0).Rows(0).Item("fechaCreacion"))
                proveedorObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtProveedor.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtProveedor.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return proveedorObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Obtiene el proveedor determinado por el nombre que pasa por parámetro
    ' =========================================================================
    Public Function ObtieneProveedorXNombre(ByVal nombre As String) As Proveedor

        Try

            Dim proveedorObtiene As New Proveedor()

            Dim dtProveedor As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneProveedorXNombre" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pNombreProveedor"} _
                                                                      , {nombre})

            If dtProveedor.Tables(0).Rows.Count > 0 Then

                proveedorObtiene.IdProveedor = dtProveedor.Tables(0).Rows(0).Item("idProveedor")
                proveedorObtiene.Nombre = dtProveedor.Tables(0).Rows(0).Item("nombre")
                proveedorObtiene.CedulaJuridica = dtProveedor.Tables(0).Rows(0).Item("cedulaJuridica")
                proveedorObtiene.Contacto = dtProveedor.Tables(0).Rows(0).Item("contacto")
                proveedorObtiene.Telefono1 = dtProveedor.Tables(0).Rows(0).Item("telefono1")
                proveedorObtiene.Telefono2 = dtProveedor.Tables(0).Rows(0).Item("telefono2")
                proveedorObtiene.Email = dtProveedor.Tables(0).Rows(0).Item("email")
                proveedorObtiene.EmailContacto = dtProveedor.Tables(0).Rows(0).Item("emailContacto")
                proveedorObtiene.Direccion = dtProveedor.Tables(0).Rows(0).Item("direccion")
                proveedorObtiene.Activo = dtProveedor.Tables(0).Rows(0).Item("activo")
                proveedorObtiene.CodigoInterno = IIf(IsDBNull(dtProveedor.Tables(0).Rows(0).Item("codInterno")), Nothing, dtProveedor.Tables(0).Rows(0).Item("codInterno"))
                proveedorObtiene.FechaCreacion = IIf(IsDBNull(dtProveedor.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtProveedor.Tables(0).Rows(0).Item("fechaCreacion"))
                proveedorObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtProveedor.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtProveedor.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return proveedorObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Inserta o actualiza el proveedor, recibe como parámetro un objeto de tipo proveedor
    ' =========================================================================
    Public Function ActualizaProveedor(ByVal proveedor As Proveedor) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaProveedor" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdProveedor", "@pNombre", "@pCedulaJuridica", "@pContacto", _
                                                                "@pTelefono1", "@pTelefono2", "@pEmail", "@pEmailContacto", _
                                                                "@pDireccion", "@pActivo", "@pCodigoInterno", "@pResponsable"} _
                                                             , {proveedor.IdProveedor, proveedor.Nombre, proveedor.CedulaJuridica, _
                                                                proveedor.Contacto, proveedor.Telefono1, proveedor.Telefono2, _
                                                                proveedor.Email, proveedor.EmailContacto, proveedor.Direccion, _
                                                                proveedor.Activo, proveedor.CodigoInterno, proveedor.Responsable})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Elimina el proveedor que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarProveedor(ByVal idProveedor As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("DesactivarProveedor" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdProveedor"} _
                                                      , {idProveedor})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Activa el proveedor que pasa por parámetro y que ya está 
    ' =========================================================================
    Public Sub ActivarProveedor(ByVal idProveedor As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("ActivarProveedor" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdProveedor"} _
                                                      , {idProveedor})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
