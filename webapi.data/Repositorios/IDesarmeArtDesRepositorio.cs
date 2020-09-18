using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;

namespace webapi.data.Repositorios
{
    public interface IDesarmeArtDesRepositorio : IRepositorio<DesarmeArtDes>
    {
        Task<DesarmeArtDes> ObtenerPorVehiculo(int pVehiculosId);
        Task<DesarmeArtDes> ObtenerPorIdConDatos(int pId);
    }
}
