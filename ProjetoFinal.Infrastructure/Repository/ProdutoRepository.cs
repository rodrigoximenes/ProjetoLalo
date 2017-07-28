using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;

namespace ProjetoFinal.Infrastructure.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private LaloContext _context;

        public ProdutoRepository(LaloContext context) : base(context)
        {
            _context = context;
        }
    }
}
