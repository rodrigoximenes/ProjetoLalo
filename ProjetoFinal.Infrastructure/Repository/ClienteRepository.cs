using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;

namespace ProjetoFinal.Infrastructure.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private LaloContext _context;

        public ClienteRepository(LaloContext context) : base(context)
        {
            _context = context;
        }
    }
}
