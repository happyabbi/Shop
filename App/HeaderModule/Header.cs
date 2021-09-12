using HeaderModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HeaderModule
{
    public class Header : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("HeaderRegion", typeof(ViewHeader));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}