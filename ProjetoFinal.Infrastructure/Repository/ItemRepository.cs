using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;

namespace ProjetoFinal.Infrastructure.Repository
{
    class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        private LaloContext _context;

        public ItemRepository(LaloContext context) : base(context)
        {
            _context = context;
        }
    }
}
