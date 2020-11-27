using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class ArticulosStock : BaseEntity
    {
        public ArticulosStock()
        {
            Vehiculos = new Vehiculos();
            Articulos = new Articulos();
            RemitosDetalles = new Collection<RemitosDetalle>();
        }

        public int ARTICULOSID { get; set; }
        public Articulos Articulos { get; set; }
        public int FORMULARIO04DID { get; set; }
        public int VEHICULOSID { get; set; }
        public string CODIGOBARRA { get; set; }
        public byte ESCOMUN { get; set; }
        public Vehiculos Vehiculos { get; set; }
        public ICollection<RemitosDetalle> RemitosDetalles { get; set; }

    }
}
