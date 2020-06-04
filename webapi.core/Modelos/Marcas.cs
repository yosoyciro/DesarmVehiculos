﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace webapi.core.Modelos
{
    public class Marcas : BaseEntity
    {
        public Marcas()
        {
            Vehiculos = new Collection<Vehiculos>();
        }
        public string Descripcion { get; set; }
        public ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
