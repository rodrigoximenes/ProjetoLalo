using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjetoFinal.Domain.Interface.Repository
{
    public interface IBaseRepository <TEntity>
    {
        void Add(TEntity entity);

        void Delete(int id);

        void Update(TEntity entityAdd, int entityRemove);

        TEntity Find(int id);

        ICollection<TEntity> FindAll();
    }
}
