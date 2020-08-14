using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IDepositosIslasMapaServicio
    {
        Task<IEnumerable<DepositosIslasMapa>> ListarTodos();
        Task<IEnumerable<DepositosIslasMapa>> ObtenerPorId(int pId);
    }
}