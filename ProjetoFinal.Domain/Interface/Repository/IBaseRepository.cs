using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjetoFinal.Domain.Interface.Repository
{
    public interface IBaseRepository <TEntity>
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        TEntity Find(int id);

        ICollection<TEntity> FindAll();
    }
}
