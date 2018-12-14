using AuthorsDATA.InterfaceRepository;
using AuthorsDATA.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AuthorsDATA
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<ICommonRepository, CommonRepository>();
        }
    }
}