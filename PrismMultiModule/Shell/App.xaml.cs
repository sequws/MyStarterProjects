using Shell.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using System.Threading;
using Shell.ViewModels;


namespace Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var lang = Shell.Properties.Settings.Default.AppLanguage;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<View1>("View1"); // register in MainWindow with region
            containerRegistry.RegisterDialog<AboutDialog, AboutDialogViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Sample.SampleModule>();
        }
    }
}
