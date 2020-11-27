using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class RemitosDetalle : BaseEntity
    {
        public int REMITOSID { get; set; }
        public Remitos Remito { get; set; }
        public int ARTICULOSSTOCKID { get; set; }
        public ArticulosStock ArticulosStock { get; set; }
    }
}
