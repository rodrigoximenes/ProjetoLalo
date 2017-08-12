using System;
using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Context;
using System.Linq;

namespace ProjetoFinal.Infrastructure.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private LaloContext _context;

        public ClienteRepository(LaloContext context) : base(context)
        {
            _context = context;
        }

        public Cliente ObterPorCpf(string CPF)
        {
            return _context.Cliente.Where(x => x.Cpf == CPF).SingleOrDefault();
        }
    }
}
