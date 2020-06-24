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
    public class Formulario04DServicio : IFormulario04DServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public Formulario04DServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Formulario04D>> ListarTodos()
        {
            return await _unitOfWork.Formulario04DRepositorio.ListarTodos();
        }

        public async Task<Formulario04D> ObtenerPorVehiculo(int pVehiculosId)
        {
            return await _unitOfWork.Formulario04DRepositorio.ObtenerPorVehiculo(pVehiculosId);
        }
    }
}
