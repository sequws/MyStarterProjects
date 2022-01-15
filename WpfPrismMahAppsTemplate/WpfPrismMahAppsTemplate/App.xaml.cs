using WpfPrismMahAppsTemplate.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using ControlzEx.Theming;
using System.Threading;
using Prism.Regions;

namespace WpfPrismMahAppsTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var lang = WpfPrismMahAppsTemplate.Properties.Settings.Default.AppLanguage;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<DemoView1>("Demo1View");

            // Set view in region 
            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(DemoView1));
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Set the application theme to Dark.Green
            //ThemeManager.Current.ChangeTheme(this, "Dark.Green");
        }
    }
}
