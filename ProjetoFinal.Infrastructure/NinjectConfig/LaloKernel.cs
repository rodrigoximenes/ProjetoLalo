using Ninject;

namespace ProjetoFinal.Infrastructure.NinjectConfig
{
    public static class LaloKernel
    {
        private readonly static IKernel _kernel = new StandardKernel(new LaloModule());

        public static TEntity GetInstance<TEntity>()
        {
            return _kernel.Get<TEntity>();
        }
    }
}
