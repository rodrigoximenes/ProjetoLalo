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
        private Usuario _usuarioLogado;

        public UsuarioRepository(LaloContext context) : base(context)
        {
            _context = context;
        }

        public Usuario AutenticaUsuario(string Login, string Senha)
        {
            _usuarioLogado = _context.Usuario.Where(x => x.Nome.ToLower() == Login.ToLower()
            && x.Senha.ToLower() == Senha.ToLower()).SingleOrDefault();
            return _usuarioLogado;
        }

        public Usuario ObterUsuarioLogado()
        {
            return _usuarioLogado;
        }
    }
}
