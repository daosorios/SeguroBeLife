﻿#pragma checksum "..\..\RegistrarCliente.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68F479902437B400F56E8BDF702225568399DC0A8FB45BA06AE3DD3F463E0FDD"
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
    /// RegistrarCliente
    /// </summary>
    public partial class RegistrarCliente : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtVolverCliente;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxRut;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtBuscarCliente;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxNombres;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxApellidos;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DpFechaNacimiento;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbSexo;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbEstadoCivil;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtRegistrarCliente;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtActualizarCliente;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\RegistrarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtEliminarCliente;
        
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
            System.Uri resourceLocater = new System.Uri("/BeLife.Vista;component/registrarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegistrarCliente.xaml"
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
            this.BtVolverCliente = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\RegistrarCliente.xaml"
            this.BtVolverCliente.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxRut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtBuscarCliente = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.TxNombres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxApellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DpFechaNacimiento = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.CbSexo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.CbEstadoCivil = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.BtRegistrarCliente = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.BtActualizarCliente = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.BtEliminarCliente = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

