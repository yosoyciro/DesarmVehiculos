﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.api.Recursos;
using AutoMapper;
using webapi.core.Modelos;

namespace webapi.api.Mapeos
{
    public class Mapeos : Profile
    {
        public Mapeos()
        {
             // Domain to Resource
            CreateMap<Vehiculos, VehiculosRecurso>();
            CreateMap<Marcas, MarcasRecurso>();
            CreateMap<Modelos, ModelosRecurso>();
            CreateMap<TiposCombustible, TiposCombustibleRecurso>();
            CreateMap<VehiculosTipo, VehiculosTipoRecurso>();
            CreateMap<Categorias, CategoriasRecurso>();
            CreateMap<Colores, ColoresRecurso>();
            CreateMap<Companias, CompaniasRecurso>();
            CreateMap<Depositos, DepositosRecurso>();
            CreateMap<Empleados, EmpleadosRecurso>();
            CreateMap<MarcasChasis, MarcasChasisRecurso>();
            CreateMap<MarcasMotor, MarcasMotorRecurso>();
            CreateMap<Formulario04D, Formulario04DRecurso>();
            CreateMap<DepositosIslasUbicaciones, DepositosIslasUbicacionesRecurso>();
            CreateMap<DepositosIslasMapa, DepositosIslasMapaRecursos>();
            CreateMap<ArticulosStock, ArticulosStockRecurso>();
            CreateMap<ArticulosDescarte, ArticulosDescarteRecurso>();
            CreateMap<DesarmeArtDes, DesarmeArtDesRecurso>();
            CreateMap<DesarmeArtDesDetalle, DesarmeArtDesDetalleRecurso>();
            CreateMap<Remitos, RemitosRecurso>();
            CreateMap<RemitosDetalle, RemitosDetalleRecurso>();
            CreateMap<RemitosAuditoria, RemitosAuditoriaRecurso>();
            CreateMap<Articulos, ArticulosRecurso>();
            
            // Resource to Domain
            CreateMap<VehiculosRecurso, Vehiculos>();
            CreateMap<MarcasRecurso, Marcas>();
            CreateMap<ModelosRecurso, Modelos>();
            CreateMap<TiposCombustibleRecurso, TiposCombustible>();
            CreateMap<VehiculosTipoRecurso, VehiculosTipo>();
            CreateMap<CategoriasRecurso, Categorias>();
            CreateMap<ColoresRecurso, Colores>();
            CreateMap<CompaniasRecurso, Companias>();
            CreateMap<DepositosRecurso, Depositos>();
            CreateMap<EmpleadosRecurso, Empleados>();
            CreateMap<MarcasChasisRecurso, MarcasChasis>();
            CreateMap<MarcasMotorRecurso, MarcasMotor>();
            CreateMap<Formulario04DRecurso, Formulario04D>();
            CreateMap<DepositosIslasUbicacionesRecurso, DepositosIslasUbicaciones>();
            CreateMap<DepositosIslasMapaRecursos, DepositosIslasMapa>();
            CreateMap<ArticulosStockRecurso, ArticulosStock>();
            CreateMap<ArticulosDescarteRecurso, ArticulosDescarte>();
            CreateMap<DesarmeArtDesRecurso, DesarmeArtDes>();
            CreateMap<DesarmeArtDesDetalleRecurso, DesarmeArtDesDetalle>();
            CreateMap<RemitosRecurso, Remitos>();
            CreateMap<RemitosAuditoriaRecurso, RemitosAuditoria>();
            CreateMap<RemitosDetalleRecurso, RemitosDetalle>();
            CreateMap<ArticulosRecurso, Articulos>();

            //Save resources
            CreateMap<VehiculoGuardarRecurso, Vehiculos>();
            CreateMap<RemitoGuardarRecurso, Remitos>();
            CreateMap<RemitosDetalleGuardarRecurso, RemitosDetalle>();
            CreateMap<RemitosAuditoriaRecurso, RemitosAuditoria>();
        }
    }
}
