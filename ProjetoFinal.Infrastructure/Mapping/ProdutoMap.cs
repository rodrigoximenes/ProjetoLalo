using ProjetoFinal.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFinal.Infrastructure.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Nome).HasColumnName("Nome");
            Property(x => x.Quantidade).HasColumnName("Quantidade");
            Property(x => x.PrecoUnitario).HasColumnName("PrecoUnitario");

            ToTable("Produtos");
        }
    }
}
