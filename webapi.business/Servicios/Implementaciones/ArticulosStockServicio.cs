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
    public class ArticulosStockServicio : IArticulosStockServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArticulosStockServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<ArticulosStock>> ListarTodos()
        {
            return await _unitOfWork.ArticulosStockRepositorio.ListarTodos();
        }

        public async Task<IEnumerable<ArticulosStock>> ObtenerPorVehiculo(int pVehiculosId)
        {
            return await _unitOfWork.ArticulosStockRepositorio.ObtenerPorVehiculo(pVehiculosId);
        }

        public async Task<IEnumerable<ArticulosStock>> ObtenerPorFormulario04D(int pFormularios04DId)
        {
            return await _unitOfWork.ArticulosStockRepositorio.ObtenerPorVehiculo(pFormularios04DId);
        }
    }
}
