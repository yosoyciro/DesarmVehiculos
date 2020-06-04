using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace webapi.data.Repositorios.Implementaciones
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DesarmDatacenterContext _databaseContext;
        private VehiculosRepositorio _vehiculosRepositorio;
        

        public UnitOfWork(DesarmDatacenterContext databaseContext)
        { _databaseContext = databaseContext; }

        public IVehiculosRepositorio VehiculosRepositorio => _vehiculosRepositorio = _vehiculosRepositorio ?? new VehiculosRepositorio(_databaseContext); 
        

        public async Task Commit()
        {
            await _databaseContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _databaseContext.Dispose();
        }
    }
}
