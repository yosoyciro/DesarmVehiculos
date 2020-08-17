using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;
using System.Linq.Expressions;

namespace webapi.data.Repositorios.Implementaciones
{
    public class DepositosIslasUbicacionesRepositorio : Repositorio<DepositosIslasUbicaciones>, IDepositosIslasUbcacionesRepositorio
    {
        public DepositosIslasUbicacionesRepositorio(DesarmDatacenterContext context) : base(context) { }



        private DesarmDatacenterContext DesarmDatacenterContext
        {
            get { return context as DesarmDatacenterContext; }
        }

        public async Task<IEnumerable<DepositosIslasUbicaciones>> ListarUbicacionesLibres()
        {
            //Linq para obtener la isla libre de acuerdo a la info de vehiculos
            var ubicacionesAsignadas = context.Vehiculos
                .Where(v => v.DepositosIslasUbicacionesId != 0)
                .Select(v => v.DepositosIslasUbicacionesId);

            return await context.DepositosIslasUbicaciones
                .Where(u => !ubicacionesAsignadas.Contains(u.Id) && u.Id != 0)
                .OrderBy(x => x.PRIORIDAD)
                .ToListAsync();
        }

        public async Task<DepositosIslasUbicaciones> ObtenerUbicacionesLibres()
        {
            try
            {
                //Linq para obtener la isla libre de acuerdo a la info de vehiculos
                var ubicacionesAsignadas = context.Vehiculos
                    .Where(v => v.DepositosIslasUbicacionesId != 0)
                    .Select(v => v.DepositosIslasUbicacionesId);

                return await context.DepositosIslasUbicaciones
                    .Where(u => !ubicacionesAsignadas.Contains(u.Id) && u.Id != 0)
                    .OrderBy(x => x.PRIORIDAD)
                    .Take(1)
                    .SingleAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
