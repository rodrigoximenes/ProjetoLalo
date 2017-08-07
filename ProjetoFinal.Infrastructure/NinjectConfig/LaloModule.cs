using ProjetoFinal.Infrastructure.Context;
using Ninject.Modules;
using ProjetoFinal.Infrastructure.Repository;
using ProjetoFinal.Domain.Interface.Repository;

namespace ProjetoFinal.Infrastructure.NinjectConfig
{
    public class LaloModule : NinjectModule
    {
        public override void Load()
        {
            //Contexto
            Bind<LaloContext>().ToSelf().InTransientScope();

            //Repositorio
            this.Bind<IUsuarioRepository>().To<UsuarioRepository>();
            this.Bind<IProdutoRepository>().To<ProdutoRepository>();
            this.Bind<IPedidoRepository>().To<PedidoRepository>();
            this.Bind<IClienteRepository>().To<ClienteRepository>();

            this.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
        }
    }
}
