using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.core.Modelos
{
    public class DepositosIslasMapa : BaseEntity
    {        
        public int DEPOSITOSISLASUBICACIONESID { get; set; }
        public Byte[] MAPA { get; set; }
    }
}
