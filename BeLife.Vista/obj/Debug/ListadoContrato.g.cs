﻿#pragma checksum "..\..\ListadoContrato.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C17F7DB7BF1E701ABCE4A5704AA82FCA82EA6AB5"
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
    /// ListadoContrato
    /// </summary>
    public partial class ListadoContrato : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtVolverListadoContrato;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtIrContrato;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxBuscarNumContrato;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtListaBuscarContrato;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGListadoContrato;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxNumFiltroContrato;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxRutFiltroContrato;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxFiltroNumPoliza;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtFiltroContrato;
        
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
            System.Uri resourceLocater = new System.Uri("/BeLife.Vista;component/listadocontrato.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListadoContrato.xaml"
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
            this.BtVolverListadoContrato = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ListadoContrato.xaml"
            this.BtVolverListadoContrato.Click += new System.Windows.RoutedEventHandler(this.BtVolverListadoContrato_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtIrContrato = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.TxBuscarNumContrato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtListaBuscarContrato = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.DGListadoContrato = ((System.Windows.Controls.DataGrid)(target));
            
            #line 79 "..\..\ListadoContrato.xaml"
            this.DGListadoContrato.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxNumFiltroContrato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxRutFiltroContrato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TxFiltroNumPoliza = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BtFiltroContrato = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\ListadoContrato.xaml"
            this.BtFiltroContrato.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

