using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace webapi.data.Repositorios
{
    public interface IRepositorio<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> ListarTodos();
        Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate);
        ValueTask<T> ObtenerPorId(int id);
        Task<T> BuscarUno(Expression<Func<T, bool>> predicate);
        //T ObtenerPorId(int id);
        //Task AgregarAsync(T entity);
        //Task ActualizarAsync(T entity);
        //void Borrar(int id);
    }
}
