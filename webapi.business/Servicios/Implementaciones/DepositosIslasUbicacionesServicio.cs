using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using webapi.data.Repositorios;
using webapi.data.Repositorios.Implementaciones;
using webapi.data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace webapi.business.Servicios.Implementaciones
{
    public class DepositosIslasUbicacionesServicio : IDepositosIslasUbicacionesServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepositosIslasUbicacionesServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        public async Task<IEnumerable<DepositosIslasUbicaciones>> ListarTodos()
        {
            return await _unitOfWork.DepositosIslasUbcacionesRepositorio.ListarTodos();
        }

        public async Task<IEnumerable<DepositosIslasUbicaciones>> ListarUbicacionesLibres()
        {
            return await _unitOfWork.DepositosIslasUbcacionesRepositorio.ListarUbicacionesLibres();
        }

        public async Task<DepositosIslasUbicaciones> ObtenerLibrePorPrioridad()
        {
            return await _unitOfWork.DepositosIslasUbcacionesRepositorio.ObtenerUbicacionesLibres();
        }

        public async Task<DepositosIslasUbicaciones> ObtenerPorId(int pId)
        {
            return await _unitOfWork.DepositosIslasUbcacionesRepositorio.ObtenerPorId(pId);
        }        
    }
}
