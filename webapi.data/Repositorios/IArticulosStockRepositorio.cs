using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;

namespace webapi.data.Repositorios
{
    public interface IArticulosStockRepositorio : IRepositorio<ArticulosStock>
    {
        Task<IEnumerable<ArticulosStock>> ObtenerPorVehiculo(int pVehiculosId);
        Task<IEnumerable<ArticulosStock>> ObtenerPorFormulario04D(int pFormularios04DId);
    }
}
