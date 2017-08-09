using ProjetoFinal.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFinal.Infrastructure.Mapping
{
    class ItemMap : EntityTypeConfiguration<Item>
    {
        public ItemMap()
        {
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.IdProduto).HasColumnName("IdProduto");
            Property(x => x.IdPedido).HasColumnName("IdPedido");
            Property(x => x.PrecoUnitario).HasColumnName("PrecoUnitario");
            Property(x => x.QuantidadeSolicitada).HasColumnName("QuantidadeSolicitada");

            ToTable("Item");
        }
    }
}
