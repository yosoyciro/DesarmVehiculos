using System;
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
            CreateMap<Modelos, ModeloRecurso>();
            CreateMap<TiposCombustible, TiposCombustibleRecurso>();
            CreateMap<VehiculosTipo, VehiculosTipoRecurso>();
            CreateMap<Categorias, CategoriasRecurso>();
            CreateMap<Colores, ColoresRecurso>();
            CreateMap<Companias, CompaniasRecurso>();
            CreateMap<Depositos, DepositosRecurso>();
            CreateMap<Empleados, EmpleadosRecurso>();
            CreateMap<MarcasChasis, MarcasChasisRecurso>();
            CreateMap<MarcasMotor, MarcasMotorRecurso>();            

            // Resource to Domain
            CreateMap<VehiculosRecurso, Vehiculos>();
            CreateMap<MarcasRecurso, Marcas>();
            CreateMap<ModeloRecurso, Modelos>();
            CreateMap<TiposCombustibleRecurso, TiposCombustible>();
            CreateMap<VehiculosTipoRecurso, VehiculosTipo>();
            CreateMap<CategoriasRecurso, Categorias>();
            CreateMap<ColoresRecurso, Colores>();
            CreateMap<CompaniasRecurso, Companias>();
            CreateMap<DepositosRecurso, Depositos>();
            CreateMap<EmpleadosRecurso, Empleados>();
            CreateMap<MarcasChasisRecurso, MarcasChasis>();
            CreateMap<MarcasMotorRecurso, MarcasMotor>();
        }
    }
}
