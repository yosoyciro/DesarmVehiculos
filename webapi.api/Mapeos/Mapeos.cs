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

            // Resource to Domain
            CreateMap<VehiculosRecurso, Vehiculos>();
            CreateMap<MarcasRecurso, Marcas>();
            CreateMap<ModeloRecurso, Modelos>();
        }
    }
}
