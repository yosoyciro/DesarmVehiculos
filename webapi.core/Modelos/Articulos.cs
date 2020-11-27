using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class Articulos : BaseEntity
    {
        public string DESCRIPCION { get; set; }
        public ICollection<ArticulosStock> ArticulosStock { get; set; }
    }
}
