using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi.data.Repositorios.Implementaciones
{
    public class ArticulosStockRepositorio : Repositorio<ArticulosStock>, IArticulosStockRepositorio
    {
        public ArticulosStockRepositorio(DesarmDatacenterContext context) : base(context) { }

        private DesarmDatacenterContext DesarmDatacenterContext
        {
            get { return context as DesarmDatacenterContext; }
        }

        public async Task<IEnumerable<ArticulosStock>> ObtenerPorVehiculo(int pVehiculosId)
        {
            return await context.ArticulosStock
                .Where(a => a.VEHICULOSID == pVehiculosId)
                .ToListAsync();
        }
        public async Task<IEnumerable<ArticulosStock>> ObtenerPorFormulario04D(int pFormularios04DId)
        {
            return await context.ArticulosStock
                .Where(a => a.FORMULARIO04DID == pFormularios04DId)
                .ToListAsync();
        }

    }
}
