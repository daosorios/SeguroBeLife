﻿using BeLife.Negocio;
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
    /// Lógica de interacción para ListadoCliente.xaml
    /// </summary>
    public partial class ListadoCliente : Page
    {
        public MainWindow ControladorListadoCliente;//creando objeto controlador para que se comporte como el main

        public ListadoCliente()
        {
            InitializeComponent();
            CargarCliente();

        }

        public void CargarCliente()
        {
            //cargar los empleados en la data grid 
            Cliente clientes = new Cliente();        

            DGlistadoClientes.ItemsSource = clientes.ReadAll();
           
        }

        private void BtVolverListadoCliente_Click(object sender, RoutedEventArgs e)
        {
            ControladorListadoCliente.miFrame.NavigationService.Navigate(ControladorListadoCliente.home);
        }

        private void DGlistadoClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
