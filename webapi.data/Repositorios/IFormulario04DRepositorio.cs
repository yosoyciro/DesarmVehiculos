using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;

namespace webapi.data.Repositorios
{
    public interface IFormulario04DRepositorio : IRepositorio<Formulario04D>
    {
        Task<Formulario04D> ObtenerPorVehiculo(int pVehiculosId);
    }
}
