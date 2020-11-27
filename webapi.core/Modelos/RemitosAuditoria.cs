using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class RemitosAuditoria : BaseEntity
    {
        public int REMITOSID { get; set; }
        public Remitos Remito { get; set; }
        public int FECHA { get; set; }
        public int HORA { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO { get; set; }
    }
}
