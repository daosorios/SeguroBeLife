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
    /// Lógica de interacción para RegistrarContrato.xaml
    /// </summary>
    public partial class RegistrarContrato : Page
    {
        public MainWindow ControladorContrato;
        public RegistrarContrato()
        {
            InitializeComponent();
        }

        //boton volver
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ControladorContrato.miFrame.NavigationService.Navigate(ControladorContrato.home);
        }
    }
}
