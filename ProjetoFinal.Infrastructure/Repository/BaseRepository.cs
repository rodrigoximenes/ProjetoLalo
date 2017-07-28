using System;
using System.Collections.ObjectModel;
using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Infrastructure.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private LaloContext _context;

        public BaseRepository(LaloContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(int id)
        {
            //try
            //{
            //    return _context.Set<TEntity>().Find(id);
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return null;
        }

        public ICollection<TEntity> FindAll()
        {

            //    try
            //    {
            //        return _context.Set<TEntity>().ToList();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }

            return null;
        }


        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
