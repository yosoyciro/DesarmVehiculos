using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IModelosServicio
    {
        Task<IEnumerable<Modelos>> ListarTodos();
    }
}
