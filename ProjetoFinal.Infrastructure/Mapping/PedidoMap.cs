using ProjetoFinal.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFinal.Infrastructure.Mapping
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.DataEntrega).HasColumnName("DataEntrega");
            Property(x => x.DataSolicitacao).HasColumnName("DataSolicitacao");
            Property(x => x.EnderecoEntrega).HasColumnName("EnderecoEntrega");
            Property(x => x.TipoEntrega).HasColumnName("TipoEntrega");

            Ignore(x => x.Itens);
            Ignore(x => x.Atendente);
            Ignore(x => x.Cliente);

            ToTable("Pedido");
        }
    }
}
