using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Infrastructure.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>  where TEntity: class
    {
        private LaloContext _context;

        public BaseRepository(LaloContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Find(id);

            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public TEntity Find(int id)
        {
            try
            {
                return _context.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ICollection<TEntity> FindAll()
        {
            try
            {
                return _context.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity _entityAdd, int _entityRemove)
        {
            Add(_entityAdd);
            Delete(_entityRemove);
            _context.SaveChanges();
        }
    }
}
