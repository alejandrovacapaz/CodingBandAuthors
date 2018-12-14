using AuthorsDATA;
using AuthorsService.InterfaceService;
using AuthorsService.Service;
using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace AuthorsService
{
    public class ServiceUnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.AddNewExtension<DataUnityExtension>();
            Container.RegisterType<ICommonService, CommonService>();
        }
    }
}
