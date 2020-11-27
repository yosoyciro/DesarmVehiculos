using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace webapi.data.Repositorios
{
    public interface IRemitosRepositorio : IRepositorio<Remitos>
    {
        Task<Remitos> ObtenerPorIdConDetalle(int pRemitosId);
        Task<Remitos> ObtenerPorIdConDetalleYAuditoria(int pRemitosId);
        Task<IEnumerable<Remitos>> ObtenerPorFechas(int pFechaDesde, int pFechaHasta);
        Task<Remitos> AgregarAsync(Remitos pRemito);
    }
}
