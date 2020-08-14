using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class DepositosIslasMapaRecursos
    {
        public int DEPOSITOSISLASMAPAID { get; set; }
        public int DEPOSITOSISLASUBICACIONESID { get; set; }
        public Byte[] MAPA { get; set; }
    }
}
