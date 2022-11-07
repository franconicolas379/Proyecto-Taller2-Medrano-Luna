﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class ProyectoTallerEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ProyectoTallerEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Categorias() As DbSet(Of Categorias)
    Public Overridable Property Clientes() As DbSet(Of Clientes)
    Public Overridable Property Perfiles() As DbSet(Of Perfiles)
    Public Overridable Property Productos() As DbSet(Of Productos)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property Usuarios() As DbSet(Of Usuarios)
    Public Overridable Property Ventas__detalle() As DbSet(Of Ventas__detalle)
    Public Overridable Property Ventas_cabecera() As DbSet(Of Ventas_cabecera)

    Public Overridable Function INSERTAR_CLIENTES(dni As String, nombre As String, apellido As String, email As String, domicilio As String, telefono As String) As ObjectResult(Of Nullable(Of Decimal))
        Dim dniParameter As ObjectParameter = If(dni IsNot Nothing, New ObjectParameter("dni", dni), New ObjectParameter("dni", GetType(String)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim apellidoParameter As ObjectParameter = If(apellido IsNot Nothing, New ObjectParameter("apellido", apellido), New ObjectParameter("apellido", GetType(String)))

        Dim emailParameter As ObjectParameter = If(email IsNot Nothing, New ObjectParameter("email", email), New ObjectParameter("email", GetType(String)))

        Dim domicilioParameter As ObjectParameter = If(domicilio IsNot Nothing, New ObjectParameter("domicilio", domicilio), New ObjectParameter("domicilio", GetType(String)))

        Dim telefonoParameter As ObjectParameter = If(telefono IsNot Nothing, New ObjectParameter("telefono", telefono), New ObjectParameter("telefono", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Decimal))("INSERTAR_CLIENTES", dniParameter, nombreParameter, apellidoParameter, emailParameter, domicilioParameter, telefonoParameter)
    End Function

    Public Overridable Function INSERTAR_PRODUCTOS(id_categoria As Nullable(Of Integer), descripcion As String, precio_costo As Nullable(Of Integer), precio_venta As Nullable(Of Integer), stock As Nullable(Of Integer), stock_min As Nullable(Of Integer)) As Integer
        Dim id_categoriaParameter As ObjectParameter = If(id_categoria.HasValue, New ObjectParameter("id_categoria", id_categoria), New ObjectParameter("id_categoria", GetType(Integer)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("descripcion", descripcion), New ObjectParameter("descripcion", GetType(String)))

        Dim precio_costoParameter As ObjectParameter = If(precio_costo.HasValue, New ObjectParameter("precio_costo", precio_costo), New ObjectParameter("precio_costo", GetType(Integer)))

        Dim precio_ventaParameter As ObjectParameter = If(precio_venta.HasValue, New ObjectParameter("precio_venta", precio_venta), New ObjectParameter("precio_venta", GetType(Integer)))

        Dim stockParameter As ObjectParameter = If(stock.HasValue, New ObjectParameter("stock", stock), New ObjectParameter("stock", GetType(Integer)))

        Dim stock_minParameter As ObjectParameter = If(stock_min.HasValue, New ObjectParameter("stock_min", stock_min), New ObjectParameter("stock_min", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("INSERTAR_PRODUCTOS", id_categoriaParameter, descripcionParameter, precio_costoParameter, precio_ventaParameter, stockParameter, stock_minParameter)
    End Function

    Public Overridable Function INSERTAR_USUARIOS(id_perfil As Nullable(Of Integer), dni As String, nombre As String, apellido As String, usuario As String, contraseña As String, email As String, telefono As String) As ObjectResult(Of Nullable(Of Decimal))
        Dim id_perfilParameter As ObjectParameter = If(id_perfil.HasValue, New ObjectParameter("id_perfil", id_perfil), New ObjectParameter("id_perfil", GetType(Integer)))

        Dim dniParameter As ObjectParameter = If(dni IsNot Nothing, New ObjectParameter("dni", dni), New ObjectParameter("dni", GetType(String)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim apellidoParameter As ObjectParameter = If(apellido IsNot Nothing, New ObjectParameter("apellido", apellido), New ObjectParameter("apellido", GetType(String)))

        Dim usuarioParameter As ObjectParameter = If(usuario IsNot Nothing, New ObjectParameter("usuario", usuario), New ObjectParameter("usuario", GetType(String)))

        Dim contraseñaParameter As ObjectParameter = If(contraseña IsNot Nothing, New ObjectParameter("contraseña", contraseña), New ObjectParameter("contraseña", GetType(String)))

        Dim emailParameter As ObjectParameter = If(email IsNot Nothing, New ObjectParameter("email", email), New ObjectParameter("email", GetType(String)))

        Dim telefonoParameter As ObjectParameter = If(telefono IsNot Nothing, New ObjectParameter("telefono", telefono), New ObjectParameter("telefono", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Decimal))("INSERTAR_USUARIOS", id_perfilParameter, dniParameter, nombreParameter, apellidoParameter, usuarioParameter, contraseñaParameter, emailParameter, telefonoParameter)
    End Function

    Public Overridable Function MOSTRAR_CLIENTES() As ObjectResult(Of MOSTRAR_CLIENTES_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of MOSTRAR_CLIENTES_Result)("MOSTRAR_CLIENTES")
    End Function

    Public Overridable Function MOSTRAR_USUARIOS() As ObjectResult(Of MOSTRAR_USUARIOS_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of MOSTRAR_USUARIOS_Result)("MOSTRAR_USUARIOS")
    End Function

    Public Overridable Function sp_alterdiagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_creatediagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_dropdiagram(diagramname As String, owner_id As Nullable(Of Integer)) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagramdefinition(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagramdefinition_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagramdefinition_Result)("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagrams(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagrams_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagrams_Result)("sp_helpdiagrams", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_renamediagram(diagramname As String, owner_id As Nullable(Of Integer), new_diagramname As String) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim new_diagramnameParameter As ObjectParameter = If(new_diagramname IsNot Nothing, New ObjectParameter("new_diagramname", new_diagramname), New ObjectParameter("new_diagramname", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter)
    End Function

    Public Overridable Function sp_upgraddiagrams() As Integer
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_upgraddiagrams")
    End Function

End Class
