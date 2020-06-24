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
    public class MarcasChasisServicio : IMarcasChasisServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarcasChasisServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<core.Modelos.MarcasChasis>> ListarTodos()
        {
            return await _unitOfWork.MarcasChasisRepositorio.ListarTodos();
        }
    }
}
