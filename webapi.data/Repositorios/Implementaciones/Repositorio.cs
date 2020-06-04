using System;
using System.Collections.Generic;
using System.Text;
using webapi.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
        public IEnumerable<T> ListarTodos()
        {
            return entities.AsEnumerable();
        }

        public T ObtenerPorId(int id)
        {
            try
            {
                return entities
                    .SingleOrDefault(s => s.Id == id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        public void Agregar(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            try
            {
                entities.Add(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void Actualizar(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            context.SaveChanges();
        }
        public void Borrar(int id)
        {
            if (id == 0) throw new ArgumentNullException("entity");

            T entity = entities.SingleOrDefault(s => s.Id == id);
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
