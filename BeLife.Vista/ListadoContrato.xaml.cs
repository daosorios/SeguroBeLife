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
        }

        //boton volver de listado contratos
        private void BtVolverListadoContrato_Click(object sender, RoutedEventArgs e)
        {
            ControladorListadoContrato.miFrame.NavigationService.Navigate(ControladorListadoContrato.home);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }


    }
}
