using SeguroBeLife;
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
            CargarPlan();
        }

        private void CargarPlan()
        {
            throw new NotImplementedException();
        }


        //boton volver
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ControladorContrato.miFrame.NavigationService.Navigate(ControladorContrato.home);
        }

        private void BtCrearContrato_Click(object sender, RoutedEventArgs e)
        {
            //Contrato contrato = new Contrato()
            //{
            //    RutCliente = TxRutCliente.Text,
            //    CodigoPlan = CbCodigoPlan.Text,
            //    FechaInicioVigencia = DateTime.Today,
            //    FechaFinVigencia = DateTime.Today,
            //    Vigente = ChBVigencia.IsChecked.GetValueOrDefault(),
            //    DeclaracionSalud = ChBDeclaracionSalud.IsChecked.GetValueOrDefault(),
            //    PrimaAnual = Convert.ToDouble(TxPrimaAnual),
            //    PrimaMensual = Convert.ToDouble(TxPrimaAnual),


            //};

            //Console.WriteLine(cli.ToString());
            //if (cli.Create())
            //{
            //    MessageBox.Show("Cliente registrado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            //    Limpiar();
            //}
            //else
            //{
            //    MessageBox.Show("Cliente no pudo ser registrado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            //}
        }
    }
}
