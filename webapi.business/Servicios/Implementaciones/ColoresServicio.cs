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
    public class ColoresServicio : IColoresServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public ColoresServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Colores>> ListarTodos()
        {
            return await _unitOfWork.ColoresRepositorio.ListarTodos();
        }
    }
}
