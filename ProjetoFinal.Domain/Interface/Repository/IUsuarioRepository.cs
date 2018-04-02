using ProjetoFinal.Domain.Model;

namespace ProjetoFinal.Domain.Interface.Repository
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario AutenticaUsuario(string Login, string Senha);

        Usuario ObterUsuarioLogado();

    }
}
