using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class DesarmeArtDesRecurso
    {
        public int ID { get; set; }
        public int VEHICULOSID { get; set; }
        public int FECHA { get; set; }
        public int FECHACONFIRMACION { get; set; }
        public string USUARIOCONFIRMACION { get; set; }
        public List<DesarmeArtDesDetalleRecurso> DesarmeArtDesDetalle { get; set; }
    }
}
