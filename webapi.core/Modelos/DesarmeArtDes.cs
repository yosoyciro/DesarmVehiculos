using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class DesarmeArtDes : BaseEntity
    {
        public int VEHICULOSID { get; set; }
        public int FECHA { get; set; }
        public int? FECHACONFIRMACION { get; set; }
        public string USUARIOCONFIRMACION { get; set; }
        public virtual List<DesarmeArtDesDetalle> DesarmeArtDesDetalle { get; set; }
    }
}
