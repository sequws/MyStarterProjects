using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample.ViewModels
{
    public class MainViewSampleViewModel : BindableBase
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; set; }

        public MainViewSampleViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);

            logger.Info("SampleModule started");
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("SampleContentRegion", uri);
        }
    }
}
