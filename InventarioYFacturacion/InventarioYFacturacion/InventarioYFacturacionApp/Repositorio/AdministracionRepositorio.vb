Imports System.Data.SqlClient

Public Class AdministracionRepositorio

    Private Const cCommandTimeOut As Integer = 0

    ' Obtiene la conexión a la base de datos
    Private Shared Function ConnectionString() As String

        Return My.Settings.ConnectionString

    End Function

    ' Prueba la conexión a la base de datos
    Public Shared Function TryConnect(ByVal mostrarMensajeOk As Boolean) As Boolean

        Try
            Dim cn As New SqlConnection(ConnectionString)
            cn.Open()
            If mostrarMensajeOk Then
                Mensajes.ShowMessage("Conexión exitosa", frmMessageBox.TipoMensaje.Informacion)

            End If
            Return True

        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Imposible conectarse, ha ocurrido el siguiente error: '{0}'. Verifique que la conexión se haya definido correctamente", ex.Message), frmMessageBox.TipoMensaje.Err)

            Return False
        End Try


    End Function

    ' Inserta parametros en el sqlcommand
    Private Shared Sub InsertParameters(ByVal cmd As SqlCommand, _
                                 ByVal parameterNames() As String, _
                                 ByVal parameterValues() As Object)

        If parameterNames IsNot Nothing AndAlso parameterNames.Length > 0 Then
            For i As Integer = 0 To parameterNames.Length - 1
                cmd.Parameters.AddWithValue(parameterNames(i), parameterValues(i))

            Next
        End If
    End Sub

    ' Crea el command
    Private Shared Function CreateCommand(ByVal commandText As String, _
                                   ByVal commandType As CommandType, _
                                   ByVal cn As SqlConnection) As SqlCommand
        Dim cmd As New SqlCommand
        cmd.CommandType = commandType
        cmd.Connection = cn
        cmd.CommandText = commandText
        cmd.CommandTimeout = cCommandTimeOut

        Return cmd

    End Function

    ' Retorna un valor Scalar
    Public Shared Function ExecuteScalar(ByVal commandText As String, _
                                   ByVal commandType As CommandType, _
                                   ByVal parameterNames() As String, _
                                   ByVal parameterValues() As Object) As Object

        Dim cn As New SqlConnection(ConnectionString)

        Try
            cn.Open()


            Dim cmd As SqlCommand = CreateCommand(commandText, commandType, cn)


            InsertParameters(cmd, parameterNames, parameterValues)

            Return cmd.ExecuteScalar()

        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

        End Try

    End Function

    ' Ejecuta un procedimiento
    Public Shared Function ExecuteNonQuery(ByVal commandText As String, _
                                     ByVal commandType As CommandType, _
                                     ByVal parameterNames() As String, _
                                     ByVal parameterValues() As Object, _
                                     Optional ByVal pId As String = Nothing) As Integer

        Dim cn As New SqlConnection(ConnectionString)

        Try
            cn.Open()

            Dim cmd As SqlCommand = CreateCommand(commandText, commandType, cn)

            InsertParameters(cmd, parameterNames, parameterValues)

            ' Si requiere devolver el ID entonces ingresa un parámetro más de tipo output
            If Not pId Is Nothing Then
                Dim vParamId As SqlParameter = cmd.Parameters.AddWithValue(pId, -1)
                vParamId.Direction = ParameterDirection.ReturnValue
            End If

            Dim vReturnValue As Integer = cmd.ExecuteNonQuery()

            If Not pId Is Nothing Then
                vReturnValue = cmd.Parameters(pId).Value
            End If

            Return vReturnValue

        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

        End Try

    End Function

    ' Retorna un dataset de un procedimiento
    Public Shared Function ExecuteDataset(ByVal storeProcedure As String) As DataSet
        Return ExecuteDataset(storeProcedure, CommandType.StoredProcedure, Nothing, Nothing)

    End Function

    ' Retorna un dataset
    Public Shared Function ExecuteDataset(ByVal commandText As String, _
                                    ByVal commandType As CommandType, _
                                    ByVal parameterNames() As String, _
                                    ByVal parameterValues() As Object) As DataSet

        Dim cn As New SqlConnection(ConnectionString)


        Dim cmd As SqlCommand = CreateCommand(commandText, commandType, cn)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        InsertParameters(cmd, parameterNames, parameterValues)

        Try
            cn.Open()

            da.Fill(ds)

        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

        End Try

        Return ds


    End Function

    ' Retorna un datareader
    Public Shared Function ExecuteReader(ByVal commandText As String, _
                                   ByVal commandType As CommandType, _
                                   ByVal parameterNames() As String, _
                                   ByVal parameterValues() As Object)

        Dim cn As New SqlConnection(ConnectionString)
        Dim cmd As SqlCommand = CreateCommand(commandText, commandType, cn)

        Dim dr As SqlClient.SqlDataReader

        InsertParameters(cmd, parameterNames, parameterValues)

        'Try
        cn.Open()

        dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

        'Finally
        '    If cn.State = ConnectionState.Open Then
        '        cn.Close()
        '    End If

        'End Try


        Return dr

    End Function

    'Raliza una consulta a otra tabla que no está en la conexión a base de datos que tiene actualmenta
    ' la aplicación
    Public Shared Function GetDataOfTable(ByVal commandText As String, ByVal connection As String) As DataSet

        Dim cn As New SqlConnection(connection)

        Dim cmd As New SqlCommand(commandText, cn)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            cn.Open()

            da.Fill(ds)

        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

        End Try

        Return ds

    End Function

    ' Prueba la conexión a la alterna
    Public Shared Function TryAlternateConnect(ByVal mostrarMensajeOk As Boolean, ByVal coneccion As String) As Boolean

        Try
            Dim cn As New SqlConnection(coneccion)
            cn.Open()
            If mostrarMensajeOk Then
                Mensajes.ShowMessage("Conexión exitosa", frmMessageBox.TipoMensaje.Informacion)

            End If
            Return True

        Catch ex As Exception
            Mensajes.ShowMessage(String.Format("Imposible conectarse, ha ocurrido el siguiente error: '{0}'. Verifique que la conexión se haya definido correctamente", ex.Message), frmMessageBox.TipoMensaje.Err)

            Return False
        End Try


    End Function

End Class
