using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace webapi.data.Repositorios
{
    public interface IUnitOfWork : IDisposable
    {
        IVehiculosRepositorio VehiculosRepositorio { get; }
        Task Commit();
    }
}
