using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.Mapping;
using System.Data.Entity;

namespace ProjetoFinal.Infrastructure.Context
{
    public class LaloContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        //public DbSet<Item> Item { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        //public DbSet<Endereco> Endereco { get; set; }
        //public DbSet<Estoque> Estoque { get; set; }
        //public DbSet<Pedido> Pedido { get; set; }

        public LaloContext() : base("LaloContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}