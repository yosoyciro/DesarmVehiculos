using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IDepositosIslasUbicacionesServicio
    {
        Task<IEnumerable<DepositosIslasUbicaciones>> ListarTodos();
        Task<DepositosIslasUbicaciones> ObtenerPorId(int pId);
        Task<DepositosIslasUbicaciones> ObtenerLibrePorPrioridad();
        Task<IEnumerable<DepositosIslasUbicaciones>> ListarUbicacionesLibres();
    }
}
