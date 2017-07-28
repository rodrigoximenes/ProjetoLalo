using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;

namespace ProjetoFinal.Infrastructure.Repository
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private LaloContext _context;

        public PedidoRepository(LaloContext context) : base(context)
        {
            _context = context;
        }
    }
}
