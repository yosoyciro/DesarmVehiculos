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
    public class DesarmeArtDesDetalleServicio : IDesarmeArtDesDetalleServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public DesarmeArtDesDetalleServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DesarmeArtDesDetalle>> ListarTodos()
        {
            return await _unitOfWork.DesarmeArtDesDetalleRepositorio.ListarTodos();
        }
    }
}
