<<<<<<< Updated upstream
﻿#pragma checksum "..\..\ListadoContrato.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8C57036EE533089333653236A1A2AFEDCB95A5F1C956EF2894C67B7613E5583"
=======
﻿#pragma checksum "..\..\ListadoContrato.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54D2A899D29BA38CA2D9F8A03A4AB2736BC23C52"
>>>>>>> Stashed changes
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
        
        
        #line 49 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtIrContrato;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxBuscarNumContrato;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtListaBuscarContrato;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGListadoContrato;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxNumFiltroContrato;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxRutFiltroContrato;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\ListadoContrato.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxFiltroNumPoliza;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\ListadoContrato.xaml"
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
            this.BtIrContrato = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.TxBuscarNumContrato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtListaBuscarContrato = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.DGListadoContrato = ((System.Windows.Controls.DataGrid)(target));
            
            #line 69 "..\..\ListadoContrato.xaml"
            this.DGListadoContrato.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxNumFiltroContrato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxRutFiltroContrato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxFiltroNumPoliza = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BtFiltroContrato = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\ListadoContrato.xaml"
            this.BtFiltroContrato.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

