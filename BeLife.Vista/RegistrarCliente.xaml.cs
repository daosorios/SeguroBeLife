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
    /// Lógica de interacción para RegistrarCliente.xaml
    /// </summary>
    public partial class RegistrarCliente : Page
    {
        public MainWindow ControladorCliente;//creando objeto controlador para que se comporte como el main
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        //Boton volver cliente
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ControladorCliente.miFrame.NavigationService.Navigate(ControladorCliente.home);
        }
    }
}
