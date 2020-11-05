using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IArticulosStockServicio
    {
        Task<IEnumerable<ArticulosStock>> ListarTodos();
        Task<IEnumerable<ArticulosStock>> ObtenerPorVehiculo(int pVehiculosId);
        Task<IEnumerable<ArticulosStock>> ObtenerPorFormulario04D(int pFormularios04DId);
    }
}
