using System;
using System.Collections.Generic;
using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;
using System.Linq;

namespace ProjetoFinal.Infrastructure.Repository
{
    class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        private LaloContext _context;

        public ItemRepository(LaloContext context) : base(context)
        {
            _context = context;
        }

        public IList<Item> ListarItensPorIdPedido(int idPedido)
        {
            return _context.Item.Where(x => x.IdPedido == idPedido).ToList();
        }
    }
}
