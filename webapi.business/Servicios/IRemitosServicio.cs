using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IRemitosServicio
    {
        Task<Remitos> ObtenerPorIdConDetalle(int pRemitosId);
        Task<Remitos> ObtenerPorIdConDetalleYAuditoria(int pRemitosId);
        Task<IEnumerable<Remitos>> ObtenerPorFechas(int pFechaDesde, int pFechaHasta);
        Task<Remitos> AgregarAsync(Remitos pRemito);
    }
}
