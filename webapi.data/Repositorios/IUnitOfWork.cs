using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace webapi.data.Repositorios
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriasRepositorio CategoriasRepositorio { get; }
        IColoresRepositorio ColoresRepositorio { get; }
        ICompaniasRepositorio CompaniasRepositorio { get; }
        IDepositosRepositorio DepositosRepositorio { get; }
        IEmpleadosRepositorio EmpleadosRepositorio { get; }
        IMarcasChasisRepositorio MarcasChasisRepositorio { get; }
        IMarcasMotorRepositorio MarcasMotorRepositorio { get; }
        IMarcasRepositorio MarcasRepositorio { get; }
        IModelosRepositorio ModelosRepositorio { get; }
        ITiposCombustibleRepositorio TiposCombustibleRepositorio { get; }
        IVehiculosRepositorio VehiculosRepositorio { get; }
        IVehiculosTipoRepositorio VehiculosTipoRepositorio { get; }
        IFormulario04DRepositorio Formulario04DRepositorio { get; }
        IDepositosIslasUbcacionesRepositorio DepositosIslasUbcacionesRepositorio { get; }
        IDepositosIslasMapaRepositorio DepositosIslasMapaRepositorio { get; }
        IArticulosStockRepositorio ArticulosStockRepositorio { get; }
        Task<int> CommitAsync();
    }
}
