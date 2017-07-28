using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;

namespace ProjetoFinal.Infrastructure.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private LaloContext _context;

        public UsuarioRepository(LaloContext context) : base(context)
        {
            _context = context;
        }
    }
}
