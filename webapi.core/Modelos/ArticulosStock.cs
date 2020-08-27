using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class ArticulosStock : BaseEntity
    {
        public ArticulosStock()
        {
            Vehiculos = new Vehiculos();
        }

        public int ARTICULOSID { get; set; }
        public int VEHICULOSID { get; set; }
        public string CODIGOBARRA { get; set; }
        public byte ESCOMUN { get; set; }
        public Vehiculos Vehiculos { get; set; }
    }
}
