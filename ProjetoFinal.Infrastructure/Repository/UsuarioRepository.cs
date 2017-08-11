using System;
using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;
using System.Linq;

namespace ProjetoFinal.Infrastructure.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private LaloContext _context;

        public UsuarioRepository(LaloContext context) : base(context)
        {
            _context = context;
        }

        public bool AutenticaUsuario(string Login, string Senha)
        {
            var validaLogin = _context.Usuario.Where(x => x.Nome == Login && x.Senha == Senha).SingleOrDefault() ;

            if (Equals(validaLogin, null)) return false;

            return true;
        }
    }
}
