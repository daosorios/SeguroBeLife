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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Home home = new Home();
        public RegistrarCliente registrarCliente = new RegistrarCliente();
        public RegistrarContrato contrato = new RegistrarContrato();
        public MainWindow()
        {
      
            InitializeComponent();
            home.ControladorHome = this; //para llamar la pagina desde otra pagina forma para que todas las pagina se comporten como el main
            registrarCliente.ControladorCliente = this;
            contrato.ControladorContrato = this;
            

            miFrame.NavigationService.Navigate(home);
        }
    }
}
