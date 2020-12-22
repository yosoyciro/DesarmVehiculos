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
    public class RemitosServicio : IRemitosServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemitosServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Anular(Remitos pRemitoAnular)
        {
            try
            {
                pRemitoAnular.ESTADO = "A";

                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Remitos> AgregarAsync(Remitos pRemito)
        {
            try
            {
                await _unitOfWork.RemitosRepositorio.AgregarAsync(pRemito);
                await _unitOfWork.CommitAsync();

                return pRemito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Remitos>> ObtenerPorFechas(int pFechaDesde, int pFechaHasta)
        {
            return await _unitOfWork.RemitosRepositorio.ObtenerPorFechas(pFechaDesde, pFechaHasta);
        }

        public async Task<Remitos> ObtenerPorIdConDetalle(int pRemitosId)
        {
            return await _unitOfWork.RemitosRepositorio.ObtenerPorIdConDetalle(pRemitosId);
        }

        public async Task<Remitos> ObtenerPorIdConDetalleYAuditoria(int pRemitosId)
        {
            return await _unitOfWork.RemitosRepositorio.ObtenerPorIdConDetalleYAuditoria(pRemitosId);
        }
    }
}
