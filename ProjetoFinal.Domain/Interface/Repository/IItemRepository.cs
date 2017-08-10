using ProjetoFinal.Domain.Model;
using System.Collections.Generic;

namespace ProjetoFinal.Domain.Interface.Repository
{
    public interface IItemRepository : IBaseRepository<Item>
    {
        IList<Item> ListarItensPorIdPedido(int idPedido);
    }
}
