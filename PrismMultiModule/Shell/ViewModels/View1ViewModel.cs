using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shell.ViewModels
{
    public class View1ViewModel : BindableBase
    {
        public string Info { get; set; } = "Info from View1";


        public View1ViewModel()
        {

        }
    }
}
