using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class Empleados : BaseEntity
    {
        public Empleados()
        {
            Vehiculos = new Collection<Vehiculos>();
        }
        public string Nombre { get; set; }
        public ICollection<Vehiculos>? Vehiculos { get; set; }
    }
}