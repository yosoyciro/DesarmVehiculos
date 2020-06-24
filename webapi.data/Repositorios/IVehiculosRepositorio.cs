using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace webapi.data.Repositorios
{
    public interface IVehiculosRepositorio : IRepositorio<Vehiculos>
    {
        Task<IEnumerable<Vehiculos>> ObtenerPorPatente(string pPatente);

        Task<Vehiculos> ObtenerPorIdConDatos(int pId);
        Task<IEnumerable<Vehiculos>> ObtenerPorMarca(int pMarcasId);
        Task<IEnumerable<Vehiculos>> ObtenerPorMarcaModelo(int pMarcasId, int pModelosId);
        //Task<Vehiculos> Actualizar(Vehiculos pVehiculo);
        Task<IEnumerable<Vehiculos>> BuscarVehiculos(Expression<Func<Vehiculos, bool>> predicate);
    }
}
