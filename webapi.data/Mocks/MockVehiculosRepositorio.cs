using System;
using System.Collections.Generic;
using System.Text;
using webapi.data.Repositorios;
using webapi.core.Modelos;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace webapi.data.Mocks
{
    public class MockVehiculosRepositorio : IVehiculosRepositorio
    {
        private List<Vehiculos> _vehiculosLista;

        public MockVehiculosRepositorio()
        {
            _vehiculosLista = new List<Vehiculos>();
            {
                //new Vehiculos() { Vehiculosid = 1, Patente = "OCA606" };
                //new Vehiculos() { Vehiculosid = 1, Patente = "KHE732" };
            }
        }

        public void Actualizar(Vehiculos entity)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Vehiculos entity)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Vehiculos> ObtenerPorPatente(string pPatente)
        {
            throw new NotImplementedException();
        }

        public Vehiculos ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehiculos> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Vehiculos> ObtenerPorIdConDatos(int pId)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Vehiculos>> IRepositorio<Vehiculos>.ListarTodos()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Vehiculos>> IVehiculosRepositorio.ObtenerPorPatente(string pPatente)
        {
            throw new NotImplementedException();
        }

        Task<Vehiculos> IVehiculosRepositorio.ObtenerPorIdConDatos(int pId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehiculos>> ObtenerPorMarca(int pMarcasId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehiculos>> ObtenerPorMarcaModelo(int pMarcasId, int pModelosId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehiculos> Buscar(Expression<Func<Vehiculos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        ValueTask<Vehiculos> IRepositorio<Vehiculos>.ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Vehiculos> BuscarUno(Expression<Func<Vehiculos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Vehiculos>> IRepositorio<Vehiculos>.Buscar(Expression<Func<Vehiculos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehiculos>> BuscarVehiculos(Expression<Func<Vehiculos, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
