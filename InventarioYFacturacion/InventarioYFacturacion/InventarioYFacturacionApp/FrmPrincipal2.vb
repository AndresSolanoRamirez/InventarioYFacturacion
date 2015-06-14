Public Class FormApplication

    Dim tabFacturacion1 As RibbonTab
    Dim tabInventario1 As RibbonTab
    Dim tabUsuarios As RibbonTab
    Dim tabProductos As RibbonTab
    Public _usario As Usuario

#Region "Acciones Generarles"
    Private Sub FormApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoverTabs()
        'Dim fLogin As New frmLogin

        'If fLogin.ShowDialog = Windows.Forms.DialogResult.OK Then

        '    _usario = fLogin._usuario

        '    klblNombreUsuario.Text = _usario.Nombre

        '    Me.WindowState = FormWindowState.Maximized
        '    MostrarTab(tabFacturacion)
        'Else
        '    Close()
        'End If
        MostrarTab(tabFacturacion)        
        klblNombreUsuario.Text = "Andrés"
    End Sub

    Private Sub rOrbMenuItemFacturacion_Click(sender As Object, e As EventArgs) Handles rOrbMenuItemFacturacion.Click
        MostrarTabsFacturacion()
    End Sub

    Private Sub RibbonOrbMenuItem1_Click(sender As Object, e As EventArgs) Handles RibbonOrbMenuItem1.Click
        MostrarTabsInventario()
    End Sub

    Private Sub rbtnMantenimientoUsuarios_Click(sender As Object, e As EventArgs) Handles rbtnMantenimientoUsuarios.Click
        MostrarTabsMantenimiento()
    End Sub

    Private Sub rbtnMantenimientoProductos_Click(sender As Object, e As EventArgs) Handles rbtnMantenimientoProductos.Click
        MostrarTabsMantenimientoProductos()
    End Sub

    Private Sub rbtnOtrosMantenimientos_Click(sender As Object, e As EventArgs) Handles rbtnOtrosMantenimientos.Click
        MostrarTabsOtrosMantenimientos()
    End Sub

    Private Sub rbtnMantenimientoProveedores_Click(sender As Object, e As EventArgs) Handles rbtnMantenimientoProveedores.Click
        MostrarTabsMantenimientoProveedores()
    End Sub

    Private Sub rbtnMantenimientoClientaes_Click(sender As Object, e As EventArgs) Handles rbtnMantenimientoClientaes.Click
        MostrarTabsMantenimientoClientes()
    End Sub

    Private Sub rInventarioYFacturacion_ActiveTabChanged(sender As Object, e As EventArgs) Handles rInventarioYFacturacion.ActiveTabChanged
        Dim t As String = rInventarioYFacturacion.ActiveTab.Text

        If Not IsNothing(t) Then
            If t.Equals("Usuarios") Then
                OcultarControles(CtlUsuarios1)
            ElseIf t.Equals("Productos") Then
                OcultarControles(CtlProducto1)
            ElseIf t.Equals("Roles") Then
                OcultarControles(CtlRoles1)
            ElseIf t.Equals("Permisos") Then
                OcultarControles(CtlPermisos1)
            ElseIf t.Equals("Familias") Then
                OcultarControles(CtlFamilias1)
            ElseIf t.Equals("Sub Familias") Then
                OcultarControles(CtlSubFamilias1)
            ElseIf t.Equals("Marcas") Then
                OcultarControles(CtrlMarcas1)
            ElseIf t.Equals("Und. Medidas") Then
                OcultarControles(CtlUnidadMedida1)
            ElseIf t.Equals("Parámetros") Then
                OcultarControles(CtlParametros1)
            ElseIf t.Equals("Proveedores") Then
                OcultarControles(CtlProveedores1)
            ElseIf t.Equals("Clientes") Then
                OcultarControles(CtlClientes1)
            End If
        End If

    End Sub

    Private Sub kbtnDesloggear_Click(sender As Object, e As EventArgs) Handles kbtnDesloggear.Click
        FinalizarSesion()
    End Sub
#End Region

#Region "Panel Lateral Izquierdo"
    Private Sub kbtnVerProdutos_Click(sender As Object, e As EventArgs) Handles kbtnVerProdutos.Click
        MostrarTabsMantenimientoProductos()
        OcultarControles(CtlProducto1)
    End Sub

    Private Sub kbtnVerProcedores_Click(sender As Object, e As EventArgs) Handles kbtnVerProcedores.Click
        MostrarTabsMantenimientoProveedores()
        OcultarControles(CtlProveedores1)
    End Sub

    Private Sub kbtnVerUsuarios_Click(sender As Object, e As EventArgs) Handles kbtnVerUsuarios.Click
        MostrarTabsMantenimiento()
        OcultarControles(CtlUsuarios1)
    End Sub

    Private Sub kbtnVerClientes_Click(sender As Object, e As EventArgs) Handles kbtnVerClientes.Click
        MostrarTabsMantenimientoClientes()
        OcultarControles(CtlClientes1)
    End Sub
#End Region

#Region "Roles"

#Region "Acciones"
    Private Sub btnAgregarRoles_Click(sender As Object, e As EventArgs) Handles btnAgregarRoles.Click
        CtlRoles1.Nuevo()
    End Sub

    Private Sub btnEditarRoles_Click(sender As Object, e As EventArgs) Handles btnEditarRoles.Click
        CtlRoles1.Editar()
    End Sub

    Private Sub btnElimarRoles_Click(sender As Object, e As EventArgs) Handles btnElimarRoles.Click
        CtlRoles1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarRoles_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarRoles.Click
        CtlRoles1.Refrescar()
    End Sub
#End Region

#End Region

#Region "Permisos"

#Region "Acciones"
    Private Sub rbtnAgregarPermiso_Click(sender As Object, e As EventArgs) Handles rbtnAgregarPermiso.Click
        CtlPermisos1.Nuevo()
    End Sub

    Private Sub btnEditarPermiso_Click(sender As Object, e As EventArgs) Handles btnEditarPermiso.Click
        CtlPermisos1.Editar()
    End Sub

    Private Sub btnEliminarPermiso_Click(sender As Object, e As EventArgs) Handles btnEliminarPermiso.Click
        CtlPermisos1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarPermisos_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarPermisos.Click
        CtlPermisos1.Refrescar()
    End Sub
#End Region

#End Region

#Region "Usuarios"

#Region "Acciones"
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            CtlUsuarios1.NuevoUsuario()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            CtlUsuarios1.EditarUsuario()
        Catch ex As Exception
            Mensajes.ShowMessage("Error al procesar la transacción", frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            CtlUsuarios1.EliminarUsuario()
        Catch ex As Exception
            Mensajes.ShowMessage(ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try

    End Sub

    Private Sub rbtnActivar_Click(sender As Object, e As EventArgs) Handles rbtnActivar.Click
        Try
            CtlUsuarios1.ActivarUsuario()
        Catch ex As Exception
            Mensajes.ShowMessage(ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub rbtnAsignaciones_Click(sender As Object, e As EventArgs) Handles rbtnAsignaciones.Click
        Try
            Dim fAsignaciones As New frmAsignacionesRoles
            fAsignaciones.Show()
        Catch ex As Exception
            Mensajes.ShowMessage(ex.Message, frmMessageBox.TipoMensaje.Err)
        End Try
    End Sub

    Private Sub rbtnRefrescarUsuarios_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarUsuarios.Click
        CtlUsuarios1.Refrescar()
    End Sub
#End Region

#End Region

#Region "Familias"

#Region "Acciones"
    Private Sub rbtnInsertarFamilia_Click(sender As Object, e As EventArgs) Handles rbtnInsertarFamilia.Click
        CtlFamilias1.Nuevo()
    End Sub

    Private Sub rbtnEditarFamilia_Click(sender As Object, e As EventArgs) Handles rbtnEditarFamilia.Click
        CtlFamilias1.Editar()
    End Sub

    Private Sub rbtnEliminarFamilia_Click(sender As Object, e As EventArgs) Handles rbtnEliminarFamilia.Click
        CtlFamilias1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarFamilias_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarFamilias.Click
        CtlFamilias1.Refrescar()
    End Sub

    Private Sub rbtnGenerarPlantillaFamilias_Click(sender As Object, e As EventArgs) Handles rbtnGenerarPlantillaFamilias.Click
        CtlFamilias1.GenerarPlantilla()
    End Sub

    Private Sub rbtnExportarFamilias_Click(sender As Object, e As EventArgs) Handles rbtnExportarFamilias.Click
        CtlFamilias1.ExportarDatos()
    End Sub

    Private Sub rbtnImportarFamilias_Click(sender As Object, e As EventArgs) Handles rbtnImportarFamilias.Click
        CtlFamilias1.ImportarDatos()
    End Sub
#End Region

#End Region

#Region "SubFamilias"

#Region "Acciones"
    Private Sub rbtnInsertarSubFamilia_Click(sender As Object, e As EventArgs) Handles rbtnInsertarSubFamilia.Click
        CtlSubFamilias1.Nuevo()
    End Sub

    Private Sub rbtnEditarSubFamilia_Click(sender As Object, e As EventArgs) Handles rbtnEditarSubFamilia.Click
        CtlSubFamilias1.Editar()
    End Sub

    Private Sub rbtnEliminarSubFamilia_Click(sender As Object, e As EventArgs) Handles rbtnEliminarSubFamilia.Click
        CtlSubFamilias1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarSubFamilias_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarSubFamilias.Click
        CtlSubFamilias1.Refrescar()
    End Sub

    Private Sub rbtnGenerarPlantillaSubFamilias_Click(sender As Object, e As EventArgs) Handles rbtnGenerarPlantillaSubFamilias.Click
        CtlSubFamilias1.GenerarPlantilla()
    End Sub

    Private Sub rbtnExportarSubFamilias_Click(sender As Object, e As EventArgs) Handles rbtnExportarSubFamilias.Click
        CtlSubFamilias1.ExportarDatos()
    End Sub

    Private Sub rbtnImportarSubFamilias_Click(sender As Object, e As EventArgs) Handles rbtnImportarSubFamilias.Click
        CtlSubFamilias1.ImportarDatos()
    End Sub
#End Region

#End Region

#Region "Marcas"

#Region "Acciones"
    Private Sub rbtnNuevaMarca_Click(sender As Object, e As EventArgs) Handles rbtnNuevaMarca.Click
        CtrlMarcas1.Nuevo()
    End Sub

    Private Sub rbtnEditarMarca_Click(sender As Object, e As EventArgs) Handles rbtnEditarMarca.Click
        CtrlMarcas1.Editar()
    End Sub

    Private Sub rbtnEliminarMarca_Click(sender As Object, e As EventArgs) Handles rbtnEliminarMarca.Click
        CtrlMarcas1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarMarcas_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarMarcas.Click
        CtrlMarcas1.Refrescar()
    End Sub
#End Region

#End Region

#Region "UnidadesMedidas"

#Region "Acciones"
    Private Sub rbtnNuevo_Click(sender As Object, e As EventArgs) Handles rbtnNuevo.Click
        CtlUnidadMedida1.Nuevo()
    End Sub

    Private Sub rbtnEditarUnidadMedida_Click(sender As Object, e As EventArgs) Handles rbtnEditarUnidadMedida.Click
        CtlUnidadMedida1.Editar()
    End Sub

    Private Sub rbtnEliminarUnidadMedida_Click(sender As Object, e As EventArgs) Handles rbtnEliminarUnidadMedida.Click
        CtlUnidadMedida1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarUndMedida_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarUndMedida.Click
        CtlUnidadMedida1.Refrescar()
    End Sub

    Private Sub rbtnGenerarPlantillaUndMedida_Click(sender As Object, e As EventArgs) Handles rbtnGenerarPlantillaUndMedida.Click
        CtlUnidadMedida1.GenerarPlantilla()
    End Sub

    Private Sub rbtnExportarUndMedida_Click(sender As Object, e As EventArgs) Handles rbtnExportarUndMedida.Click
        CtlUnidadMedida1.ExportarDatos()
    End Sub

    Private Sub rbtnImportarUndMedida_Click(sender As Object, e As EventArgs) Handles rbtnImportarUndMedida.Click
        CtlUnidadMedida1.ImportarDatos()
    End Sub
#End Region

#End Region

#Region "Productos"

#Region "Acciones"
    Private Sub rbtnNuevoProducto_Click(sender As Object, e As EventArgs) Handles rbtnNuevoProducto.Click
        CtlProducto1.Nuevo()
    End Sub

    Private Sub rbtnEditarProducto_Click(sender As Object, e As EventArgs) Handles rbtnEditarProducto.Click
        CtlProducto1.Editar()
    End Sub

    Private Sub rbtnEliminar_Click(sender As Object, e As EventArgs) Handles rbtnEliminar.Click
        CtlProducto1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarProducto_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarProducto.Click
        CtlProducto1.Refrescar()
    End Sub

    Private Sub rbtnGenerarPlantilla_Click(sender As Object, e As EventArgs) Handles rbtnGenerarPlantilla.Click
        CtlProducto1.GenerarPlantilla()
    End Sub
#End Region

#End Region

#Region "Parametros"

#Region "Acciones"
    Private Sub rbtnNuevoParametro_Click(sender As Object, e As EventArgs) Handles rbtnNuevoParametro.Click
        CtlParametros1.Nuevo()
    End Sub

    Private Sub rbtnEditarParametro_Click(sender As Object, e As EventArgs) Handles rbtnEditarParametro.Click
        CtlParametros1.Editar()
    End Sub

    Private Sub rbtnEliminarParametro_Click(sender As Object, e As EventArgs) Handles rbtnEliminarParametro.Click
        CtlParametros1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarParametros_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarParametros.Click
        CtlParametros1.Refrescar()
    End Sub
#End Region

#End Region

#Region "Proveedores"

#Region "Acciones"
    Private Sub rbtnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles rbtnNuevoProveedor.Click
        CtlProveedores1.Nuevo()
    End Sub

    Private Sub rbtnEditarProveedor_Click(sender As Object, e As EventArgs) Handles rbtnEditarProveedor.Click
        CtlProveedores1.Editar()
    End Sub

    Private Sub rbtnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles rbtnEliminarProveedor.Click
        CtlProveedores1.Eliminar()
    End Sub

    Private Sub rbtnActivarProveedores_Click(sender As Object, e As EventArgs) Handles rbtnActivarProveedores.Click
        CtlProveedores1.Activar()
    End Sub

    Private Sub rbtnRefrescarProveedores_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarProveedores.Click
        CtlProveedores1.Recargar()
    End Sub

    Private Sub rbtnGenerarPlantillaProveedores_Click(sender As Object, e As EventArgs) Handles rbtnGenerarPlantillaProveedores.Click
        CtlProveedores1.GenerarPlantilla()
    End Sub

    Private Sub rbtnExportarDatosProveedores_Click(sender As Object, e As EventArgs) Handles rbtnExportarDatosProveedores.Click
        CtlProveedores1.ExportarDatos()
    End Sub

    Private Sub rbtnImportaDatosProveedores_Click(sender As Object, e As EventArgs) Handles rbtnImportaDatosProveedores.Click
        CtlProveedores1.ImportarDatos()
    End Sub
#End Region

#End Region

#Region "Clientes"

#Region "Acciones"
    Private Sub rbtnNuevoCliente_Click(sender As Object, e As EventArgs) Handles rbtnNuevoCliente.Click
        CtlClientes1.Nuevo()
    End Sub

    Private Sub rbtnEditarCliente_Click(sender As Object, e As EventArgs) Handles rbtnEditarCliente.Click
        CtlClientes1.Editar()
    End Sub

    Private Sub rbtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles rbtnEliminarCliente.Click
        CtlClientes1.Eliminar()
    End Sub

    Private Sub rbtnRefrescarClientes_Click(sender As Object, e As EventArgs) Handles rbtnRefrescarClientes.Click
        CtlClientes1.Refrescar()
    End Sub

    Private Sub rbtnGenerarPlantillaClientes_Click(sender As Object, e As EventArgs) Handles rbtnGenerarPlantillaClientes.Click
        CtlClientes1.GenerarPlantilla()
    End Sub

    Private Sub rtbtnExportarClientes_Click(sender As Object, e As EventArgs) Handles rtbtnExportarClientes.Click
        CtlClientes1.ExportarDatos()
    End Sub

    Private Sub rbtnImportarClientes_Click(sender As Object, e As EventArgs) Handles rbtnImportarClientes.Click
        CtlClientes1.ImportarDatos()
    End Sub
#End Region

#End Region

#Region "Funciones"    

    Private Sub RemoverTabs()
        rInventarioYFacturacion.Tabs.Clear()
    End Sub

    Private Sub MostrarTab(ByVal tab As RibbonTab)
        rInventarioYFacturacion.Tabs.Add(tab)
    End Sub

    Private Sub OcultarControles(ByVal c As Control)

        If Not IsNothing(c) Then

            c.Visible = True

            For Each control As Control In Me.kscControles.Panel2.Controls

                control.GetType()

                If Not control Is c Then
                    control.Visible = False
                End If

            Next

        End If

    End Sub

    Private Sub FinalizarSesion()
        Dim fLogin As New frmLogin

        If fLogin.ShowDialog = Windows.Forms.DialogResult.OK Then
            RemoverTabs()
            _usario = fLogin._usuario

            klblNombreUsuario.Text = _usario.Nombre & " " & _usario.Apellidos

            Me.WindowState = FormWindowState.Maximized
            MostrarTab(tabFacturacion)
        Else
            Close()
        End If
    End Sub

#Region "Tab Especificos"
    Private Sub MostrarTabsFacturacion()
        RemoverTabs()
        MostrarTab(tabFacturacion)
    End Sub

    Private Sub MostrarTabsInventario()
        RemoverTabs()
        MostrarTab(tabInventario)
    End Sub

    Private Sub MostrarTabsMantenimiento()
        RemoverTabs()
        MostrarTab(tabMantenimiento)
        MostrarTab(tabRoles)
        MostrarTab(tabPermisos)
    End Sub

    Private Sub MostrarTabsMantenimientoProductos()
        RemoverTabs()
        MostrarTab(tabMantenimientoProductos)
        MostrarTab(tabFamilias)
        MostrarTab(tabSubFamilias)
        MostrarTab(tabMarcas)
        MostrarTab(tabUnidadesMedidas)
    End Sub

    Private Sub MostrarTabsOtrosMantenimientos()
        RemoverTabs()
        MostrarTab(tabMantenimientoParametros)
    End Sub

    Private Sub MostrarTabsMantenimientoProveedores()
        RemoverTabs()
        MostrarTab(tabProveedores)
    End Sub

    Private Sub MostrarTabsMantenimientoClientes()
        RemoverTabs()
        MostrarTab(tabClientes)
    End Sub
#End Region

#End Region

End Class
