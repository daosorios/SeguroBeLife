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

namespace BeLife.Vista
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public MainWindow ControladorHome;
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ControladorHome.miFrame.NavigationService.Navigate(ControladorHome.registrarCliente);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ControladorHome.miFrame.NavigationService.Navigate(ControladorHome.contrato);
        }
    }
}
