using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class RemitosDetalleRecurso
    {
        public int ID { get; set; }
        public int REMITOSID { get; set; }
        public int ARTICULOSSTOCKID { get; set; }
        public ArticulosStockRecurso ArticulosStock { get; set; }
    }
}
