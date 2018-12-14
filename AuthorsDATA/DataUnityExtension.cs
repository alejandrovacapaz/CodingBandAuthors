using AuthorsDATA.InterfaceRepository;
using AuthorsDATA.Repository;
using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace AuthorsDATA
{
    public class DataUnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterInstance(new AutoresEntities(), new PerResolveLifetimeManager());
            Container.RegisterType<ICommonRepository, CommonRepository>();
        }
    }
}
