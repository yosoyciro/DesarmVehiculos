using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using Microsoft.EntityFrameworkCore;

namespace webapi.data.Repositorios.Implementaciones
{
    public class VehiculosRepositorio : Repositorio<Vehiculos>, IVehiculosRepositorio
    {
        public VehiculosRepositorio(DesarmDatacenterContext context) : base(context) { }
        public async Task<Vehiculos> ObtenerPorPatente(string pPatente)
        {
            return await context.Vehiculos
                .Include(v => v.Marcas)
                .Include(v => v.Modelos)
                .Include(v => v.TiposCombustible)
                .SingleOrDefaultAsync(vehiculo => vehiculo.Patente == pPatente);
        }

        public Task<Vehiculos> ObtenerPorIdConDatos(int pId)
        {
            throw new NotImplementedException();
        }

        private DesarmDatacenterContext DesarmDatacenterContext
        {
            get { return context as DesarmDatacenterContext; }
        }
    }
}
