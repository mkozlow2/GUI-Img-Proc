using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interfejs
{
    /// <summary>
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void txtPar1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double par;
            if (!double.TryParse(txtPar1.Text, out par))
            {
                lblAlert.Foreground = Brushes.Red;
                lblAlert.Content = "Podana nieprawidłowa wartość";
            }
            else
            {
                lblAlert.Foreground = Brushes.Black;
                lblAlert.Content = null;
            }

        }

        private void txtPar2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double par;
            if (!double.TryParse(txtPar1.Text, out par))
            {
                lblAlert.Foreground = Brushes.Red;
                lblAlert.Content = "Podana nieprawidłowa wartość";
            }
            else
            {
                lblAlert.Foreground = Brushes.Black;
                lblAlert.Content = null;
            }
        }
    }
}
