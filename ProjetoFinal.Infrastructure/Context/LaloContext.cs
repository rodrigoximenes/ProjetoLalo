namespace ProjetoFinal.Infrastructure.Context
{
    using Domain.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LaloContext : DbContext
    {

        public DbSet<Produto> produtos { get; set; }
        // Your context has been configured to use a 'LaloContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ProjetoFinal.Infrastructure.Context.LaloContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LaloContext' 
        // connection string in the application configuration file.
        public LaloContext()
            : base("name=LaloContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}