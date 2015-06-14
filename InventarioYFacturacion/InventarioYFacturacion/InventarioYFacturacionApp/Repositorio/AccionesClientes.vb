Public Class AccionesClientes
    ' =========================================================================
    '   Obtiene un listado con todos los clientes que existen en el sistema
    ' =========================================================================
    Public Function ObtieneClientes() As DataTable

        Try
            Dim dsClientes As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneClientes")

            If dsClientes IsNot Nothing Or dsClientes.Tables.Count > 0 Then
                Return dsClientes.Tables(0)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Elimina el cliente que pasa por parámetro
    ' =========================================================================
    Public Sub EliminarCliente(ByVal idCliente As Integer)
        Try
            AdministracionRepositorio.ExecuteNonQuery("EliminarCliente" _
                                                      , CommandType.StoredProcedure _
                                                      , {"@pIdCliente"} _
                                                      , {idCliente})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' =========================================================================
    '   Inserta o actualiza el cliente, recibe como parámetro un objeto de tipo cliente
    ' =========================================================================
    Public Function ActualizaCliente(ByVal cliente As Cliente) As Integer

        Try

            Return AdministracionRepositorio.ExecuteNonQuery("ActualizaCliente" _
                                                             , CommandType.StoredProcedure _
                                                             , {"@pIdCliente", "@pNombre", "@pApellidos", "@pIdentificacion", _
                                                                "@pTelefono", "@pEmail", "@pDireccion"} _
                                                             , {cliente.IdCliente, cliente.Nombre, cliente.Apellidos, cliente.Identificacion, _
                                                                cliente.Telefono, cliente.Email, cliente.Direccion})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing

    End Function

    ' =========================================================================
    '   Obtiene el cliente determinado por el idCliente que pasa por parámetro
    ' =========================================================================
    Public Function ObtieneClienteXId(ByVal idCliente As Integer) As Cliente

        Try

            Dim clienteObtiene As New Cliente()

            Dim dtCliente As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneClienteXCodigo" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdCliente"} _
                                                                      , {idCliente})

            If dtCliente.Tables(0).Rows.Count > 0 Then

                clienteObtiene.IdCliente = dtCliente.Tables(0).Rows(0).Item("idCliente")
                clienteObtiene.Nombre = dtCliente.Tables(0).Rows(0).Item("nombre")
                clienteObtiene.Apellidos = dtCliente.Tables(0).Rows(0).Item("apellidos")
                clienteObtiene.Identificacion = dtCliente.Tables(0).Rows(0).Item("identificacion")
                clienteObtiene.Telefono = dtCliente.Tables(0).Rows(0).Item("telefono")                
                clienteObtiene.Email = dtCliente.Tables(0).Rows(0).Item("email")                
                clienteObtiene.Direccion = dtCliente.Tables(0).Rows(0).Item("direccion")                
                clienteObtiene.FechaCreacion = IIf(IsDBNull(dtCliente.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtCliente.Tables(0).Rows(0).Item("fechaCreacion"))
                clienteObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtCliente.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtCliente.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return clienteObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    ' =========================================================================
    '   Obtiene el cliente determinado por la identificación que pasa por parámetro
    ' =========================================================================
    Public Function ObtieneClienteXIdentificacion(ByVal identificacion As String) As Cliente

        Try

            Dim clienteObtiene As New Cliente()

            Dim dtCliente As DataSet = AdministracionRepositorio.ExecuteDataset("ObtieneClienteXIdentificacion" _
                                                                      , CommandType.StoredProcedure _
                                                                      , {"@pIdentificacionCliente"} _
                                                                      , {identificacion})

            If dtCliente.Tables(0).Rows.Count > 0 Then

                clienteObtiene.IdCliente = dtCliente.Tables(0).Rows(0).Item("idCliente")
                clienteObtiene.Nombre = dtCliente.Tables(0).Rows(0).Item("nombre")
                clienteObtiene.Apellidos = dtCliente.Tables(0).Rows(0).Item("apellidos")
                clienteObtiene.Identificacion = dtCliente.Tables(0).Rows(0).Item("identificacion")
                clienteObtiene.Telefono = dtCliente.Tables(0).Rows(0).Item("telefono")
                clienteObtiene.Email = dtCliente.Tables(0).Rows(0).Item("email")
                clienteObtiene.Direccion = dtCliente.Tables(0).Rows(0).Item("direccion")
                clienteObtiene.FechaCreacion = IIf(IsDBNull(dtCliente.Tables(0).Rows(0).Item("fechaCreacion")), Nothing, dtCliente.Tables(0).Rows(0).Item("fechaCreacion"))
                clienteObtiene.FechaUltimaModificacion = IIf(IsDBNull(dtCliente.Tables(0).Rows(0).Item("fechaUltimaModificacion")), Nothing, dtCliente.Tables(0).Rows(0).Item("fechaUltimaModificacion"))

                Return clienteObtiene
            End If
            Return Nothing
        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function
End Class
