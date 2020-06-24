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
    public class VehiculosTipoServicio : IVehiculosTipoServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehiculosTipoServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<VehiculosTipo>> ListarTodos()
        {
            return await _unitOfWork.VehiculosTipoRepositorio.ListarTodos();
        }
    }
}
