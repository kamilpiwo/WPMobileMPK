﻿#pragma checksum "c:\users\kamil\documents\visual studio 2013\Projects\PhoneApp4\PhoneApp4\Rozklad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A10BE994F03E2DE0B4AF0C93E07996E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp4 {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button Button_Autobus;
        
        internal System.Windows.Controls.Button Button_Tramwaje;
        
        internal System.Windows.Controls.Button trasa;
        
        internal System.Windows.Controls.Button rozkalad;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp4;component/Rozklad.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Button_Autobus = ((System.Windows.Controls.Button)(this.FindName("Button_Autobus")));
            this.Button_Tramwaje = ((System.Windows.Controls.Button)(this.FindName("Button_Tramwaje")));
            this.trasa = ((System.Windows.Controls.Button)(this.FindName("trasa")));
            this.rozkalad = ((System.Windows.Controls.Button)(this.FindName("rozkalad")));
        }
    }
}
