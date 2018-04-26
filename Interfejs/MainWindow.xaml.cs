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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.5);
            this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.5);
            InitializeComponent();
        }

        private void p1Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }

        private void p2Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }

        private void p3Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page3();
        }

        private void Main_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.Height = this.Width * (System.Windows.SystemParameters.PrimaryScreenHeight * 0.5) / (System.Windows.SystemParameters.PrimaryScreenWidth * 0.5);
        }
    }
}
