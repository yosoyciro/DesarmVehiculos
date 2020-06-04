using System;
using System.Collections.Generic;
using System.Text;
using webapi.data.Repositorios;
using webapi.core.Modelos;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
