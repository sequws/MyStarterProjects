using ControlzEx.Theming;
using Net6PrismMahAppsTemplate.Views;
using Prism.Ioc;
using Prism.Regions;
using System.Threading;
using System.Windows;

namespace Net6PrismMahAppsTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var lang = Net6PrismMahAppsTemplate.Properties.Settings.Default.AppLanguage;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl-PL");

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<DemoView>("DemoView");

            // Set view in region 
            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(DemoView));
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Set the application theme to Dark.Green
            //ThemeManager.Current.ChangeTheme(this, "Dark.Green");
            ThemeManager.Current.ChangeTheme(this, "Light.Green");
        }
    }
}
