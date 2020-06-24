using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class Colores : BaseEntity
    {
        public Colores()
        {
            Vehiculos = new Collection<Vehiculos>();
        }
        public string DESCRIPCION { get; set; }
        public ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
