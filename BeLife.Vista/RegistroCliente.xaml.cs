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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class RegistroCliente : Page
    {
        public MainWindow ControladorCliente;//creando objeto controlador para que se comporte como el main
        
        public RegistroCliente()
        {
            InitializeComponent();
            Limpiar();
        }


        private void CargarSexo()
        {
            /* Carga todas los cliente */
            Sexo sexo = new Sexo();
            CbSexo.ItemsSource = sexo.ReadAllSexo();

            /* Configura los datos en el ComboBOx */
            CbSexo.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbSexo.SelectedValuePath = "Descripcion"; //Propiedad con el valor a rescatar

            CbSexo.SelectedIndex = 0; //Posiciona en el primer registro

        }

        private void CargarEstado()
        {
            /* Carga todas los cliente */
            Estado estado = new Estado();
            CbEstadoCivil.ItemsSource = estado.ReadAllEstado();

            /* Configura los datos en el ComboBOx */
            CbEstadoCivil.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbEstadoCivil.SelectedValuePath = "Descripcion"; //Propiedad con el valor a rescatar

            CbEstadoCivil.SelectedIndex = 0; //Posiciona en el primer registro

        }

        private void Limpiar()
        {
            
            TxRut.Text = string.Empty;
            TxNombres.Text = string.Empty;
            TxApellidos.Text = string.Empty;
            DpFechaNacimiento.SelectedDate = DateTime.Today;
            CbSexo.SelectedIndex = 0;
            CbEstadoCivil.SelectedIndex = 0;

            CargarSexo();
            CargarEstado();
            //CargarCliente();

        }

        //boton registrar cliente listo no tocar 
        private void BtRegistrarCliente_Click(object sender, RoutedEventArgs e)
        {
            
            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text,
                Nombres = TxNombres.Text,
                Apellidos = TxApellidos.Text,
                FechaNacimiento = DateTime.Today,
                IdSexo = CbSexo.SelectedValue.ToString(),
                IdEstadoCivil = CbEstadoCivil.SelectedValue.ToString()
            };

            
            if (cli.Create())
            {
                MessageBox.Show("Cliente registrado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Cliente no pudo ser registrado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            //Bucar si el cliente esta registrado
            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text
            };

            if (cli.Read())
            {
                TxNombres.Text = cli.Nombres;
                TxApellidos.Text = cli.Apellidos;
                DpFechaNacimiento.SelectedDate = cli.FechaNacimiento;
                CbSexo.SelectedValue = cli.IdSexo;
                CbEstadoCivil.SelectedValue = cli.IdEstadoCivil;


                MessageBox.Show("Cliente leído", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente no pudo ser leído", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtActualizarCliente_Click(object sender, RoutedEventArgs e)
        {
            //actualizar datos del cliente
            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text,
                Nombres = TxNombres.Text,
                Apellidos = TxApellidos.Text,
                FechaNacimiento = DpFechaNacimiento.SelectedDate.Value,
                IdSexo = CbSexo.SelectedValue.ToString(),
                IdEstadoCivil = CbEstadoCivil.SelectedValue.ToString()

            };

            if (cli.Update())
            {
                MessageBox.Show("Cliente Actualizado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Clienteo no pudo ser registrado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            //eliminar al cliente 
            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text
            };
            if (cli.Delete())
            {
                MessageBox.Show("Cliente eliminado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();

            }
            else
            {
                MessageBox.Show("Cliente no pudo ser eliminado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtVolverCliente_Click(object sender, RoutedEventArgs e)
        {
            CargarEstado();
            ControladorCliente.miFrame.NavigationService.Navigate(ControladorCliente.home);
        }

        private void BtLimpiarCliente_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }



        

    }
}
