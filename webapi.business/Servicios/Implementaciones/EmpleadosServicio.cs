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
    public class EmpleadosServicio : IEmpleadosServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmpleadosServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Empleados>> ListarTodos()
        {
            return await _unitOfWork.EmpleadosRepositorio.ListarTodos();
        }
    }
}
