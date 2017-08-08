using ProjetoFinal.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFinal.Infrastructure.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.NomeCompleto).HasColumnName("NomeCompleto");
            Property(x => x.Endereco).HasColumnName("Endereco");
            Property(x => x.Cpf).HasColumnName("Cpf");
            Property(x => x.Telefone).HasColumnName("Telefone");
            Property(x => x.Email).HasColumnName("Email");

            ToTable("Cliente");
        }
    }
}
