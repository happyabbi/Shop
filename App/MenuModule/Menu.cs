using MenuModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MenuModule
{
    public class Menu : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MenuRegion", typeof(ViewMenu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}