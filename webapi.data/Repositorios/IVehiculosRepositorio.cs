using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;

namespace webapi.data.Repositorios
{
    public interface IVehiculosRepositorio : IRepositorio<Vehiculos>
    {
        Task<Vehiculos> ObtenerPorPatente(string pPatente);

        Task<Vehiculos> ObtenerPorIdConDatos(int pId);
        
    }
}
