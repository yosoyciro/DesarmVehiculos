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
    public class DesarmeArtDesServicio : IDesarmeArtDesServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public DesarmeArtDesServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DesarmeArtDes>> ListarTodos()
        {
            return await _unitOfWork.DesarmeArtDesRepositorio.ListarTodos();
        }

        public async Task<DesarmeArtDes> ObtenerPorIdConDatos(int pId)
        {
            return await _unitOfWork.DesarmeArtDesRepositorio.ObtenerPorIdConDatos(pId);
        }

        public async Task<DesarmeArtDes> ObtenerPorVehiculo(int pVehiculosId)
        {
            return await _unitOfWork.DesarmeArtDesRepositorio.ObtenerPorVehiculo(pVehiculosId);
        }

        public async Task Actualizar(DesarmeArtDes pDesarmeArtDesActualizar, DesarmeArtDes pDesarmeArtDes)
        {
            try
            {
                pDesarmeArtDesActualizar.FECHACONFIRMACION = pDesarmeArtDes.FECHACONFIRMACION;
                pDesarmeArtDesActualizar.USUARIOCONFIRMACION = pDesarmeArtDes.USUARIOCONFIRMACION;
                pDesarmeArtDesActualizar.DesarmeArtDesDetalle = pDesarmeArtDes.DesarmeArtDesDetalle;

                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
