using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi.data.Repositorios.Implementaciones
{
    public class ArticulosDescarteRepositorio : Repositorio<ArticulosDescarte> , IArticulosDescarteRepositorio
    {
        public ArticulosDescarteRepositorio(DesarmDatacenterContext context) : base(context) { }
        private DesarmDatacenterContext DesarmDatacenterContext
        {
            get { return context as DesarmDatacenterContext; }
        }
    }
}
