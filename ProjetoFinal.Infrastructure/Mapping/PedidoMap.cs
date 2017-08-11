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
            Property(x => x.IdCliente).HasColumnName("IdCliente");
            Property(x => x.IdAtendente).HasColumnName("IdAtendente");

            Ignore(x => x.Itens);
            Ignore(x => x.Atendente);
            Ignore(x => x.Cliente);

            ToTable("Pedido");
        }
    }
}
