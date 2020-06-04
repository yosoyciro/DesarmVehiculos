using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using Microsoft.EntityFrameworkCore;

namespace webapi.data.Repositorios.Implementaciones
{
    public class MarcasRepositorio : Repositorio<Marcas>, IMarcasRepositorio
    {
        public MarcasRepositorio(DesarmDatacenterContext context) : base(context) { }

    }
}
