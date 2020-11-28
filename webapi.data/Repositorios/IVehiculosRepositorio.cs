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
        Task<Vehiculos> ObtenerPorPatenteConArticulosStock(string pPatente);
        Task<Vehiculos> ObtenerPorIdConDatos(int pId);
        Task<IEnumerable<Vehiculos>> ObtenerPorMarca(int pMarcasId);
        Task<IEnumerable<Vehiculos>> ObtenerPorMarcaModelo(int pMarcasId, int pModelosId);
        Task<Vehiculos> AgregarAsync(Vehiculos pVehiculo);
        //Task<IEnumerable<Vehiculos>> BuscarVehiculos(Expression<Func<Vehiculos, bool>> predicate);
        //Task<IEnumerable<Vehiculos>> BuscarPorLegajo(int pLegajo);
        Task<IEnumerable<Vehiculos>> BuscarVehiculosMultiple(int pDepositosIslasUbicacionesId, string pPatente, int pMarcasId, int pModelosId, int pMostrarCompactados, string pNroChasis, int pLegajo, int pDepositosId);
    }
}
