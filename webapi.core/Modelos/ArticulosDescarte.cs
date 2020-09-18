using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class ArticulosDescarte : BaseEntity
    {
        public string DESCRIPCION { get; set; }
        public byte ACTIVO { get; set; }
        public virtual List<DesarmeArtDesDetalle> DesarmeArtDesDetalle { get; set; }
    }
}
