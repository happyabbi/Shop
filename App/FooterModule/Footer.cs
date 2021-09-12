using FooterModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FooterModule
{
    public class Footer : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("FooterRegion", typeof(ViewFooter));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}