using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class RemitosAuditoriaRecurso
    {
        public int ID { get; set; }
        public int REMITOSID { get; set; }
        public int FECHA { get; set; }
        public int HORA { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO { get; set; }
    }
}
