
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
    /// Lógica de interacción para RegistrarContrato.xaml
    /// </summary>
    public partial class RegistrarContrato : Page
    {
        public MainWindow ControladorContrato;
        public RegistrarContrato()
        {
            InitializeComponent();
            LimpiarControles();
        }

        private void BtVolverContrato_Click(object sender, RoutedEventArgs e)
        {
            //boton volver de Ui
            ControladorContrato.miFrame.NavigationService.Navigate(ControladorContrato.home);
        }

        private void LimpiarControles()
        {
            //limpiar controles de UI
            TxRutCliente.Text = string.Empty;
            DpFechaInicioVig.SelectedDate = DateTime.Today;
            DpFechaFInVig.SelectedDate = DateTime.Today;
            ChBVigencia.IsChecked = false;
            ChBDeclaracionSalud.IsChecked = false;
            TxPrimaAnual.Text = string.Empty;
            TxPrimaMensual.Text = string.Empty;
            TxObservaciones.Text = string.Empty;

            CargarContrato();

        }

        //cargar el combobox 
        private void CargarContrato()
        {
            //Carga todas los contratos */
            Plan plan = new Plan();
            CbCodigoPlan.ItemsSource = plan.ReadAllPlan();            

            /* Configura los datos en el ComboBOx */
            CbCodigoPlan.DisplayMemberPath = "Nombre"; //Propiedad para mostrar
            CbCodigoPlan.SelectedValuePath = "Nombre"; //Propiedad con el valor a rescatar

            CbCodigoPlan.SelectedIndex = 0; //Posiciona en el primer registro

        }

        private void BtCrearContrato_Click(object sender, RoutedEventArgs e)
        {
            //boton crear contrato en UI
            Contrato contrato = new Contrato()
            {
                Numero = DateTime.Now.ToString("yyyyMMddHHmm"),
                FechaCreacion = DateTime.Today,
                RutCliente = TxRutCliente.Text,
                CodigoPlan = CbCodigoPlan.SelectedValue.ToString(),
                FechaInicioVigencia = DateTime.Today,
                FechaFinVigencia = DateTime.Today,
                Vigente = true,
                DeclaracionSalud = true,
                PrimaAnual = 0,
                PrimaMensual = 0,
                Observaciones = "sdfdsf"


                //BORRAR DESPUES EJMEPLO
                //Termino = DateTime.Today,
                //RutCliente = txtRutCliente.Text,
                //IdTipoEvento = (int)ComboTipoEvento.SelectedValue,
                //IdModalidad = ComboModalidad.SelectedValue.ToString(),
                //FechaHoraInicio = DateTime.Parse(fecha + Hora),
                //FechaHoraTermino = DateTime.Parse(fechat + Horat),
                //Asistentes = int.Parse(txtAsistentes.Text),
                //PersonalAdicional = Convert.ToInt32(ComboAdicional.SelectedValue),
                //Realizado = (bool)checkRealizado.IsChecked,
                //ValorTotalContrato = 1,
                //Observaciones = txtObservaciones.Text


            };

            if (contrato.CreateContrato())
            {
                MessageBox.Show("Contrato registrado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Contrato no pudo ser registrado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
