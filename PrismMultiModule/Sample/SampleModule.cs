using Sample.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Sample
{
    public class SampleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();

            // Simple registration for 
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));

            // Register inside internal MainView
            regionManager.RegisterViewWithRegion("SimpleContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView>("SimpleMainView"); // Custom name!
            containerRegistry.RegisterForNavigation<ViewA>("ViewA");
            containerRegistry.RegisterForNavigation<ViewB>("ViewB");
        }
    }
}