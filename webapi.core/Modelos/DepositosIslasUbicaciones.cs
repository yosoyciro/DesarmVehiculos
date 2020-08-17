using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class DepositosIslasUbicaciones : BaseEntity
    {
        public DepositosIslasUbicaciones()
        {
            Vehiculos = new Collection<Vehiculos>();
        }


        public int DEPOSITOSDESARMEID { get; set; }
        public string UBICACION { get; set; }
        public Int16 PRIORIDAD { get; set; }
        public ICollection<Vehiculos>? Vehiculos { get; set; }
    }
}
