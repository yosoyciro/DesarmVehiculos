using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class DepositosIslasUbicacionesRecurso
    {
        public int Id { get; set; }
        public int DEPOSITOSDESARMEID { get; set; }
        public string UBICACION { get; set; }
        public int PRIORIDAD { get; set; }
    }
}
