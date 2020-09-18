using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class DesarmeArtDesDetalleRecurso
    {
        public int ID { get; set; }
        public int DESARMEARTDESID { get; set; }
        public int ARTICULOSDESCARTEID { get; set; }
        public int CANTIDAD { get; set; }
        public ArticulosDescarteRecurso ArticulosDescarte { get; set; }
    }
}
