using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IFormulario04DServicio
    {
        Task<IEnumerable<Formulario04D>> ListarTodos();
        Task<Formulario04D> ObtenerPorVehiculo(int pVehiculosId);
    }
}
