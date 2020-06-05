using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class TiposCombustible : BaseEntity
    {
        public TiposCombustible()        
        {
            Vehiculos = new Collection<Vehiculos>();
        }
        
        public string DESCRIPCION { get; set; }
        public ICollection<Vehiculos>? Vehiculos { get; set; }
    }
}
