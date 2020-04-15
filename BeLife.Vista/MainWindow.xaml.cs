using BeLife.Negocio;
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
        public RegistroCliente registrarCliente = new RegistroCliente();
        public RegistrarContrato registrarcontrato = new RegistrarContrato();
        public ListadoCliente listadoCliente = new ListadoCliente();
        public ListadoContrato listadoContrato = new ListadoContrato();
        public MainWindow()
        {
            InitializeComponent();
            home.ControladorHome = this; //para llamar la pagina desde otra pagina forma para que todas las pagina se comporten como el main
            registrarCliente.ControladorCliente = this;
            registrarcontrato.ControladorContrato = this;
            listadoCliente.ControladorListadoCliente = this;
            listadoContrato.ControladorListadoContrato = this;

            miFrame.NavigationService.Navigate(home);

            CargarSexo();
        }



        private void CargarSexo()
        {
            /* Carga todas los cliente */
            Sexo sexo = new Sexo();

        }
    }}
