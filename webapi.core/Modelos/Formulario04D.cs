using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class Formulario04D : BaseEntity
    {        
        public int NUMERO04D { get; set; }        
        public byte? ANULADO { get; set; }
        public int? FECHAIMPRESION { get; set; }
        public byte CONFIRMADO { get; set; }
        public byte ESCOMUN { get; set; }
        public int NROLEGAJO { get; set; }
        public int? FECHAENTREGA { get; set; }
        public string? OBSERVACIONES { get; set; }
        public int? DEPOSITOSDESARMEID { get; set; }
        public byte? DESARMECONFIRMADO { get; set; }

        public int VEHICULOSID { get; set; }
        public Vehiculos Vehiculos { get; set; }
    }
}
