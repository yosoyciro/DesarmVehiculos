using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IVehiculosServicios
    {
        Task<Vehiculos> ObtenerPorId(int pId);
        Task<Vehiculos> ObtenerPorPatente(string pPatente);
        Task<Vehiculos> Agregar(Vehiculos vehiculo);
        Task Actualizar(Vehiculos pVehiculo);
        Task Borrar(Vehiculos pVehiculo);
    }
}
