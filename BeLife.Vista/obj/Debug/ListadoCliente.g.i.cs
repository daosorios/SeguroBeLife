﻿#pragma checksum "..\..\ListadoCliente.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7D343A0C129197558A6FD9512FB45A43D91C5F083E6D8037F2654C45D0A912AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using BeLife.Vista;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BeLife.Vista {
    
    
    /// <summary>
    /// ListadoCliente
    /// </summary>
    public partial class ListadoCliente : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtVolverListadoCliente;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtIrCLiente;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxBuscarRutCliente;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtListaBuscarCliente;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGlistadoClientes;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxFiltrarRut;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbFiltrarSexo;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbFiltrarEstadoCivil;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\ListadoCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtFiltroListadoCliente;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BeLife.Vista;component/listadocliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListadoCliente.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtVolverListadoCliente = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ListadoCliente.xaml"
            this.BtVolverListadoCliente.Click += new System.Windows.RoutedEventHandler(this.BtVolverListadoCliente_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtIrCLiente = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.TxBuscarRutCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtListaBuscarCliente = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.DGlistadoClientes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.TxFiltrarRut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CbFiltrarSexo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.CbFiltrarEstadoCivil = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.BtFiltroListadoCliente = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

