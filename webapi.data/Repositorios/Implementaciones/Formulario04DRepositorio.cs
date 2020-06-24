using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace webapi.data.Repositorios.Implementaciones
{
    public class Formulario04DRepositorio : Repositorio<Formulario04D>, IFormulario04DRepositorio
    {
        public Formulario04DRepositorio(DesarmDatacenterContext context) : base(context) { }



        private DesarmDatacenterContext DesarmDatacenterContext
        {
            get { return context as DesarmDatacenterContext; }
        }

        public async Task<Formulario04D> ObtenerPorVehiculo(int pVehiculosId)
        {
            return await context.Formulario04D
                .SingleOrDefaultAsync(f => f.VEHICULOSID == pVehiculosId);
        }
    }
}
