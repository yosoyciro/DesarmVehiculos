using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class DesarmeArtDesDetalle : BaseEntity
    {
        public int DESARMEARTDESID { get; set; }
        public int ARTICULOSDESCARTEID { get; set; }
        public Int16 CANTIDAD { get; set; }
        public DesarmeArtDes DesarmeArtDes { get; set; }
        public ArticulosDescarte ArticulosDescarte { get; set; }
    }
}
