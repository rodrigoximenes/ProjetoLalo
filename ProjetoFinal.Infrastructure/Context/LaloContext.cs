using ProjetoFinal.Domain.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoFinal.Infrastructure.Context
{
    public class LaloContext : DbContext
    {

        public DbSet<Produto> produtos { get; set; }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Item> item { get; set; }
        public DbSet<Pedido> pedido { get; set; }
      
        public LaloContext()
            : base("name=LaloContext")
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(x => x.Name == x.ReflectedType.Name + "Id").Configure(x => x.IsKey());

            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}