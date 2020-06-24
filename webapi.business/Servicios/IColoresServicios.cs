﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IColoresServicio
    {
        Task<IEnumerable<Colores>> ListarTodos();
    }
}
