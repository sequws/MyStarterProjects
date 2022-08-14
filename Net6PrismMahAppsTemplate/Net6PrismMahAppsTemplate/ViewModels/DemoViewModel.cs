using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Net6PrismMahAppsTemplate.ViewModels
{
    public class DemoViewModel : BindableBase
    {
        private string info = "Hello from DemoView";
        public string Info
        {
            get { return info; }
            set { SetProperty(ref info, value); }
        }

        public DemoViewModel()
        {

        }
    }
}
