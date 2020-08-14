using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class DepositosIslasUbicaciones : BaseEntity
    {
        public int DEPOSITOSDESARMEID { get; set; }
        public string UBICACION { get; set; }
        public Int16 PRIORIDAD { get; set; }
    }
}
