using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class VehiculosRecurso
    {
        public int Id { get; set; }
        public string Patente { get; set; }
        public int Puertas { get; set; }
        public string Descripcion { get; set; }
        public string Chasis { get; set; }
        public string Motor { get; set; }
        public MarcasRecurso Marcas { get; set; }
        public ModeloRecurso Modelos { get; set; }
    }
}
