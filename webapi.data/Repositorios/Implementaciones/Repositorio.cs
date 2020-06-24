using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace webapi.data.Repositorios.Implementaciones
{
    public class Repositorio<T> : IRepositorio<T> where T : BaseEntity
    {
        protected readonly DesarmDatacenterContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repositorio(DesarmDatacenterContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<T> BuscarUno(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().SingleOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> ListarTodos()
        {
            return await entities.ToListAsync();
        }

        public ValueTask<T> ObtenerPorId(int id)
        {
            return context.Set<T>().FindAsync(id);
        }
    }
}
