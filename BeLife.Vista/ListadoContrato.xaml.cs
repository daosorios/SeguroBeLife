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
    /// Lógica de interacción para ListadoContrato.xaml
    /// </summary>
    public partial class ListadoContrato : Page
    {
        public MainWindow ControladorListadoContrato;//creando objeto controlador para que se comporte como el main

        public ListadoContrato()
        {
            InitializeComponent();
            CargarContrato();
        }

        private void Limpiar()
        {

            TxRutFiltroContrato.Text = string.Empty;
            TxNumFiltroContrato.Text = string.Empty;
            TxFiltroNumPoliza.Text = string.Empty;
            TxBuscarNumContrato.Text = string.Empty;      

        }

        private void BtVolverListadoContrato_Click(object sender, RoutedEventArgs e)
        {
            CargarContrato();
            ControladorListadoContrato.miFrame.NavigationService.Navigate(ControladorListadoContrato.home);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BFiltro();
        }
        public void BFiltro()
        {
            Contrato con = new Contrato();
            DGListadoContrato.ItemsSource = con.ReadS(TxNumFiltroContrato.Text, TxRutFiltroContrato.Text, TxFiltroNumPoliza.Text);
        }//contrato, rut, poli

        
        private void CargarContrato()
        {
            /* Carga todos los Empleados */
            Contrato contrato = new Contrato();
            DGListadoContrato.ItemsSource = contrato.ReadAll();
        }



        private void BtListaBuscarContrato_Click(object sender, RoutedEventArgs e)
        {
            SFiltro();
        }
        public void SFiltro()//small filtro
        {
            Contrato con = new Contrato();
            DGListadoContrato.ItemsSource = con.ReadF(TxBuscarNumContrato.Text);
        }

        private void BtRefreshListadoContrato_Click(object sender, RoutedEventArgs e)
        {
            CargarContrato();
            Limpiar();
        }
    }

}

