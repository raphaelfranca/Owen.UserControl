using Microsoft.Practices.Unity;
using Owen.UserControl.Business.Services;
using Owen.UserControl.Contracts.Services;
using Owen.UserControl.Domain.Contracts.Repositories;
using Owen.UserControl.Infraestructure.Data;
using Owen.UserControl.Infraestructure.Repositories;


namespace Owen.UserControl.Startup
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());

            //container.RegisterType<User, User>(new HierarchicalLifetimeManager());
        }
    }
}
