using ProjetoFinal.Domain.Model;

namespace ProjetoFinal.Domain.Interface.Repository
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Cliente ObterPorCpf(string CPF);
    }
}
