using ContentModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ContentModule
{
    public class Content : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewContent));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}