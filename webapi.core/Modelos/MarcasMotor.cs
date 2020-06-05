using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class MarcasMotor : BaseEntity
    {
        public MarcasMotor()
        {
            Vehiculos = new Collection<Vehiculos>();
        }
        public string Descripcion { get; set; }
        public ICollection<Vehiculos>? Vehiculos { get; set; }
    }
}