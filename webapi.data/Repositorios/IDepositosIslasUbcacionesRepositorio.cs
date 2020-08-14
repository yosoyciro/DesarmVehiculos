using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace webapi.data.Repositorios
{
    public interface IDepositosIslasUbcacionesRepositorio : IRepositorio<DepositosIslasUbicaciones>
    {
        Task<DepositosIslasUbicaciones> ObtenerUbicacionesLibres();
        Task<IEnumerable<DepositosIslasUbicaciones>> ListarUbicacionesLibres();
    }
}
