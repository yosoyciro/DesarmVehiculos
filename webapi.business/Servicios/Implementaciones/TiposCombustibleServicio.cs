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
    public class TiposCombustibleServicio : ITiposCombustibleServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public TiposCombustibleServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TiposCombustible>> ListarTodos()
        {
            return await _unitOfWork.TiposCombustibleRepositorio.ListarTodos();
        }
    }
}
