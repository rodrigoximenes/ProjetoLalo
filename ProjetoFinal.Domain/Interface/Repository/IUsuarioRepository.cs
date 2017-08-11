using ProjetoFinal.Domain.Model;

namespace ProjetoFinal.Domain.Interface.Repository
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        bool AutenticaUsuario(string Login, string Senha);
    }
}
