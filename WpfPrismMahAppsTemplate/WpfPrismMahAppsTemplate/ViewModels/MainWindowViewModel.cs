using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace WpfPrismMahAppsTemplate.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private string _title = "Kriss Starter App";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;

        public MainWindowViewModel(
            IRegionManager regionManager,
            IDialogService dialogService)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;

            NavigateCommand = new DelegateCommand<string>(Navigate);
            //_logger.Info("MainWindow Start!");
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
            //_logger.Trace($"Navigation to: {uri}");
        }

        #region commands

        public DelegateCommand<string> NavigateCommand { get; set; }

        private DelegateCommand _closeCommand;
        public DelegateCommand CloseCommand =>
            _closeCommand ?? (_closeCommand = new DelegateCommand(ExecuteCloseCommand, CanExecuteCloseCommand));

        void ExecuteCloseCommand()
        {
            App.Current.Shutdown();
        }

        bool CanExecuteCloseCommand()
        {
            return true;
        }

        private DelegateCommand _showAboutDialogCommand;
        public DelegateCommand ShowAboutDialogCommand =>
            _showAboutDialogCommand ?? (_showAboutDialogCommand = new DelegateCommand(ExecuteShowAboutDialogCommand));

        void ExecuteShowAboutDialogCommand()
        {
            _dialogService.ShowDialog("AboutDialog", new DialogParameters(), (res) =>
            {

            });
        }

        #endregion
    }
}
