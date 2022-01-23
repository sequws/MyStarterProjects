using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsViewCtrl.Controllers;
using WinFormsViewCtrl.Views;

namespace WinFormsViewCtrl
{
    public partial class Form1 : Form
    {
        ViewController viewController;

        public Form1()
        {
            InitializeComponent();

            viewController = new ViewController(pnlContent);

            viewController.RegisterView("ViewA", new ViewA());
            viewController.RegisterView("ViewB", new ViewB());
        }

        private void btnViewA_Click(object sender, EventArgs e)
        {
            viewController.ShowView("ViewA");
        }

        private void btnViewB_Click(object sender, EventArgs e)
        {
            viewController.ShowView("ViewB");
        }
    }
}
