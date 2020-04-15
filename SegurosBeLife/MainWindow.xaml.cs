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

using BeLife.Negocio;


namespace SegurosBeLife
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            Limpiar();
          
        

        }

        private void CargarSexo()
        {
            /* Carga todas los cliente */
            Plan sexo = new Plan();
            CBsexo.ItemsSource = sexo.ReadAllPlan();

            /* Configura los datos en el ComboBOx */
            CBsexo.DisplayMemberPath = "Nombre"; //Propiedad para mostrar
            CBsexo.SelectedValuePath = "Nombre"; //Propiedad con el valor a rescatar

            CBsexo.SelectedIndex = 0; //Posiciona en el primer registro

        }

        private void CargarEstado()
        {
            /* Carga todas los cliente */
            Estado estado = new Estado();
            CBestadocivil.ItemsSource = estado.ReadAllEstado();

            /* Configura los datos en el ComboBOx */
            CBestadocivil.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CBestadocivil.SelectedValuePath = "Descripcion"; //Propiedad con el valor a rescatar

            CBestadocivil.SelectedIndex = 0; //Posiciona en el primer registro

         }

        private void Limpiar()
        {
            /*Limpiar controles de wpf*/
            TBrut.Text = string.Empty;
            TBnombre.Text = string.Empty;
            TBapellido.Text = string.Empty;
            DGfechanacimiento.SelectedDate = DateTime.Today;
            CBsexo.SelectedIndex = 0;
            CBestadocivil.SelectedIndex = 0;

            CargarSexo();
            CargarEstado();
            CargarCliente();
                
        }



        private void CargarCliente()
        {
            //cargar los empleados en la data grid 
            Cliente clientes = new Cliente();
            DGlista.ItemsSource = clientes.ReadAll();
        }


        private void BTregistrar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente()
            {
                RutCliente = TBrut.Text,
                Nombres = TBnombre.Text,
                Apellidos = TBapellido.Text,
                FechaNacimiento = DateTime.Today,
                IdSexo = CBsexo.SelectedValue.ToString(),
                IdEstadoCivil = CBestadocivil.SelectedValue.ToString()
            };
            
                Console.WriteLine(cli.ToString());
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


        private void BTbuscar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente()
            {
                RutCliente = TBrut.Text
            };

            if (cli.Read())
            {
                TBnombre.Text = cli.Nombres;
                TBapellido.Text = cli.Apellidos;
                DGfechanacimiento.SelectedDate = cli.FechaNacimiento;
                CBsexo.SelectedValue = cli.IdSexo;
                CBestadocivil.SelectedValue = cli.IdEstadoCivil;


                MessageBox.Show("Cliente leído", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente no pudo ser leído", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BTactualizar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente()
            {
                RutCliente = TBrut.Text,
                Nombres = TBnombre.Text,
                Apellidos = TBapellido.Text,
                FechaNacimiento = DGfechanacimiento.SelectedDate.Value,
                IdSexo = CBsexo.SelectedValue.ToString(),
                IdEstadoCivil = CBestadocivil.SelectedValue.ToString()

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

        private void BTeliminar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente()
            {
                RutCliente = TBrut.Text
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

        private void CBsexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
