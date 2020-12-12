using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class RemitosRecurso
    {
        public int ID { get; set; }
        public int FECHA { get; set; }
        public int DEPOSITOSIDORIGEN { get; set; }
        public int DEPOSITOSIDDESTINO { get; set; }
        public string ESTADO { get; set; }
        public int HORA { get; set; }
        public ICollection<RemitosDetalleRecurso> RemitosDetalles { get; set; }
        public ICollection<RemitosAuditoriaRecurso> RemitosAuditorias { get; set; }
    }
}
