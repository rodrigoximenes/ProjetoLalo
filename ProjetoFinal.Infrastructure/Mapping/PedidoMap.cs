using ProjetoFinal.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFinal.Infrastructure.Mapping
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Atendente).HasColumnName("Atendente");
            Property(x => x.Cliente).HasColumnName("Cliente");
            Property(x => x.DataEntrega).HasColumnName("DataEntrega");
            Property(x => x.DataSolicitacao).HasColumnName("DataSolicitacao");
            Property(x => x.EnderecoEntrega).HasColumnName("EnderecoEntrega");
            Property(x => x.Itens).HasColumnName("Itens");
            Property(x => x.TipoEntrega).HasColumnName("TipoEntrega");

            ToTable("Pedido");
        }
    }
}
