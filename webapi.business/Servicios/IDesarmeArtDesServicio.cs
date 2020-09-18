using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IDesarmeArtDesServicio
    {
        Task<IEnumerable<DesarmeArtDes>> ListarTodos();
        Task<DesarmeArtDes> ObtenerPorVehiculo(int pVehiculosId);
        Task<DesarmeArtDes> ObtenerPorIdConDatos(int pId);
        Task Actualizar(DesarmeArtDes pDesarmeArtDesActualizar, DesarmeArtDes pDesarmeArtDes);
    }
}
