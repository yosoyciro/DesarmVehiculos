using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class ArticulosStockRecurso
    {
        public int ID { get; set; }
        public int ARTICULOSID { get; set; }
        public ArticulosRecurso Articulos { get; set; }
        public string CODIGOBARRA { get; set; }
        public byte ESCOMUN { get; set; }
        //public VehiculosRecurso Vehiculos { get; set; }
    }
}
