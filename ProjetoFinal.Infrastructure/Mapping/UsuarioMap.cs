using ProjetoFinal.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFinal.Infrastructure.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Nome).HasColumnName("Nome");
            Property(x => x.Perfil).HasColumnName("Perfil");
            Property(x => x.Senha).HasColumnName("Senha");

            ToTable("Usuario");
        }
    }
}
