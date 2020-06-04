using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class Modelos : BaseEntity
    {
        public Modelos()
        {
            Vehiculos = new Collection<Vehiculos>();
        }
        public string Descripcion { get; set; }
        public ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
