using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using webapi.data.Repositorios;
using webapi.data.Repositorios.Implementaciones;
using webapi.data;
using Microsoft.EntityFrameworkCore;

namespace webapi.business.Servicios.Implementaciones
{
    public class VehiculosServicio : IVehiculosServicios
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehiculosServicio(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public Task Actualizar(Vehiculos pVehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<Vehiculos> Agregar(Vehiculos vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task Borrar(Vehiculos pVehiculo)
        {
            throw new NotImplementedException();
        }

        public async Task<Vehiculos> ObtenerPorPatente(string pPatente)
        {
            return await _unitOfWork.VehiculosRepositorio
                .ObtenerPorPatente(pPatente);
        }

        public Task<Vehiculos> ObtenerPorId(int pId)
        {
            throw new NotImplementedException();
        }
    }
}
