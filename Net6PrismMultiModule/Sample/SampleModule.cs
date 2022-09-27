using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Sample.Views;

namespace Sample
{
    public class SampleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();

            // Register inside internal MainView
            regionManager.RegisterViewWithRegion("SampleContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainViewSample>("MainViewSample");
            containerRegistry.RegisterForNavigation<ViewA>("ViewA");
            containerRegistry.RegisterForNavigation<ViewB>("ViewB");
        }
    }
}