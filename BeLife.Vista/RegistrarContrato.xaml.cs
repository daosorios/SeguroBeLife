
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
            CargarContrato();
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
            DpFechaCreacion.SelectedDate = DateTime.Today;
            DpFechaInicioVig.SelectedDate = DateTime.Today;
            DpFechaFInVig.SelectedDate = DateTime.Today;
            ChBVigencia.IsChecked = false;
            ChBDeclaracionSalud.IsChecked = false;
            TxPrimaAnual.Text = string.Empty;
            TxPrimaMensual.Text = string.Empty;
            TxObservaciones.Text = string.Empty;
            CbCodigoPlan.SelectedIndex = 0;
            NContrato.Content = "";
            CargarContrato();

            //bloquear los datos
            TxRutCliente.IsEnabled = true;
            DpFechaCreacion.IsEnabled = true;
            DpFechaFInVig.IsEnabled = true;
            TxPrimaAnual.IsEnabled = true;
            TxPrimaMensual.IsEnabled = true;
            ChBDeclaracionSalud.IsEnabled = true;
            CbCodigoPlan.IsEnabled = true;
            
        }

        //cargar el combobox 
        private void CargarContrato()
        {
            //Carga todas los contratos */
            Plan plan = new Plan();
            CbCodigoPlan.ItemsSource = plan.ReadAllPlan();

            /* Configura los datos en el ComboBOx */
            CbCodigoPlan.DisplayMemberPath = "IdPlan"; //Propiedad para mostrar
            CbCodigoPlan.SelectedValuePath = "IdPlan"; //Propiedad con el valor a rescatar

            CbCodigoPlan.SelectedIndex = 0; //Posiciona en el primer registro

        }

        private void BtCrearContrato_Click(object sender, RoutedEventArgs e)
        {
            //boton crear contrato en UI
            Contrato contrato = new Contrato();


            contrato.RutCliente = TxRutCliente.Text;
            contrato.FechaCreacion = (DateTime)DpFechaCreacion.SelectedDate;
            contrato.FechaInicioVigencia = (DateTime)DpFechaInicioVig.SelectedDate;
            //el fin de la vigencia se calcula cin el inicio mas 1 año
            contrato.FechaFinVigencia = ((DateTime)DpFechaInicioVig.SelectedDate).AddYears(1);
            contrato.PrimaMensual = Convert.ToDouble(TxPrimaMensual.Text);
            contrato.PrimaAnual = Convert.ToDouble(TxPrimaAnual.Text);
            contrato.CodigoPlan = CbCodigoPlan.SelectedValue.ToString();        
            contrato.Observaciones = TxObservaciones.Text;

            if (ChBDeclaracionSalud.IsChecked == true)
            {
                contrato.Vigente = true;
            }

            else
            {
                contrato.Vigente = false;
            }

            if (ChBDeclaracionSalud.IsChecked == true)
            {
                contrato.DeclaracionSalud = true;
            }
            else
            {
                contrato.DeclaracionSalud = false;
            }

            contrato.Numero = Convert.ToDateTime((DateTime.Now)).ToString("yyyyMMddhhmmss");

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

        private void BtBuscarContrato_Click(object sender, RoutedEventArgs e)
        {
            Contrato con = new Contrato()
            {
                RutCliente = TxRutCliente.Text
            };

            if (con.ReadContrato())
            {
                NContrato.Content = con.Numero;
                DpFechaCreacion.SelectedDate = con.FechaCreacion;
                DpFechaInicioVig.SelectedDate = con.FechaInicioVigencia;
                DpFechaFInVig.SelectedDate = con.FechaFinVigencia;
                TxPrimaMensual.Text = con.PrimaMensual.ToString();
                TxPrimaAnual.Text = con.PrimaAnual.ToString();
                CbCodigoPlan.SelectedValue = con.CodigoPlan;
                TxObservaciones.Text = con.Observaciones;

                //Checkbox de vigencia
                if (con.Vigente == true)
                {
                    ChBVigencia.IsChecked = true;
                }
                else
                {
                    ChBVigencia.IsChecked = false;
                }

                //Checkbox de decaracion salud
                if (con.DeclaracionSalud == true)
                {
                    ChBDeclaracionSalud.IsChecked = true;
                }
                else
                {
                    ChBDeclaracionSalud.IsChecked = false;
                }

                //bloquear los datos
                TxRutCliente.IsEnabled = false;
                DpFechaCreacion.IsEnabled = false;
                DpFechaFInVig.IsEnabled = false;
                TxPrimaAnual.IsEnabled = false;
                TxPrimaMensual.IsEnabled = false;
                ChBDeclaracionSalud.IsEnabled = false;

                MessageBox.Show("Contrato leído", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Contrato no pudo ser leído", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        

        ///Tengo que bloquear todos los datos solo dejar el observaciones***
        private void BtActualizarContrato_Click(object sender, RoutedEventArgs e)
        {
            //actualizar  
            Contrato contrato = new Contrato();
            contrato.Numero = NContrato.Content.ToString();
            contrato.RutCliente = TxRutCliente.Text;
            contrato.FechaCreacion = (DateTime)DpFechaCreacion.SelectedDate;
            contrato.FechaInicioVigencia = (DateTime)DpFechaInicioVig.SelectedDate;
            contrato.FechaFinVigencia = (DateTime)DpFechaFInVig.SelectedDate;
            contrato.PrimaMensual = Convert.ToDouble(TxPrimaMensual.Text);
            contrato.PrimaAnual = Convert.ToDouble(TxPrimaAnual.Text);
            contrato.CodigoPlan = CbCodigoPlan.SelectedValue.ToString();
            //contrato.CodigoPlan = "VID05";
            contrato.Observaciones = TxObservaciones.Text;


            if (ChBVigencia.IsChecked == true)
            {
                contrato.Vigente = true;
            }
            else
            {
                contrato.Vigente = false;
            }

            if (ChBDeclaracionSalud.IsChecked == true)
            {
                contrato.DeclaracionSalud = true;
            }
            else
            {
                contrato.DeclaracionSalud = false;
            }



            if (contrato.UpdateContrato())
            {
                MessageBox.Show("Contrato Actualizado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Contrato no pudo ser registrado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtLimpiarCliente_Click(object sender, RoutedEventArgs e)
        {
            LimpiarControles();
        }

        private void BtTerminarContrato_Click(object sender, RoutedEventArgs e)
        {
            Contrato contrato = new Contrato();
            contrato.Numero = NContrato.Content.ToString();
            contrato.RutCliente = TxRutCliente.Text;
            contrato.FechaCreacion = (DateTime)DpFechaCreacion.SelectedDate;
            contrato.FechaInicioVigencia = (DateTime)DpFechaInicioVig.SelectedDate;
            contrato.FechaFinVigencia = (DateTime)DpFechaFInVig.SelectedDate;
            contrato.PrimaMensual = Convert.ToDouble(TxPrimaMensual.Text);
            contrato.PrimaAnual = Convert.ToDouble(TxPrimaAnual.Text);
            contrato.CodigoPlan = CbCodigoPlan.SelectedValue.ToString();
            //contrato.CodigoPlan = "VID05";
            contrato.Observaciones = TxObservaciones.Text;

            if (ChBVigencia.IsChecked == true)
            {
                contrato.Vigente = false;
            }
            else
            {
                contrato.Vigente = false;
            }
            if (ChBDeclaracionSalud.IsChecked == true)
            {
                contrato.DeclaracionSalud = true;
            }
            else
            {
                contrato.DeclaracionSalud = false;
            }

            if (contrato.DeleteContrato())
            {
                MessageBox.Show("Contrato Terminado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Contrato no puede ser terminado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
