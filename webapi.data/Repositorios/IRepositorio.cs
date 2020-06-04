using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;

namespace webapi.data.Repositorios
{
    public interface IRepositorio<T> where T : BaseEntity
    {
        IEnumerable<T> ListarTodos();
        T ObtenerPorId(int id);
        void Agregar(T entity);
        void Actualizar(T entity);
        void Borrar(int id);
    }
}
