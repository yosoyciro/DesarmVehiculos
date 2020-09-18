using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi.data.Repositorios.Implementaciones
{
    public class DesarmeArtDesRepositorio : Repositorio<DesarmeArtDes>, IDesarmeArtDesRepositorio
    {
        public DesarmeArtDesRepositorio(DesarmDatacenterContext context) : base(context) { }
        private DesarmDatacenterContext DesarmDatacenterContext
        {
            get { return context as DesarmDatacenterContext; }
        }

        public async Task<DesarmeArtDes> ObtenerPorIdConDatos(int pId)
        {
            return await context.Set<DesarmeArtDes>()
                .Include(d => d.DesarmeArtDesDetalle)
                .SingleOrDefaultAsync(d => d.Id == pId);
        }

        public async Task<DesarmeArtDes> ObtenerPorVehiculo(int pVehiculosId)
        {
            return await context.DesarmeArtDes
                .Include(d => d.DesarmeArtDesDetalle)
                    .ThenInclude(dd => dd.ArticulosDescarte)
                .Where(d => d.VEHICULOSID == pVehiculosId)
                .SingleOrDefaultAsync();            
        }
    }
}
