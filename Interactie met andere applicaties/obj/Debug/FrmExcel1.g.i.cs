﻿#pragma checksum "..\..\FrmExcel1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC865BE3480FB8E77FFA873E6398589F27747652CF58AA76F09058ECECA88936"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Interactie_met_andere_applicaties;
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


namespace Interactie_met_andere_applicaties {
    
    
    /// <summary>
    /// FrmExcel1
    /// </summary>
    public partial class FrmExcel1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\FrmExcel1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBedrag;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\FrmExcel1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTermijn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\FrmExcel1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPercentage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\FrmExcel1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTeBetalen;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\FrmExcel1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBereken;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FrmExcel1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSluiten;
        
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
            System.Uri resourceLocater = new System.Uri("/Interactie met andere applicaties;component/frmexcel1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FrmExcel1.xaml"
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
            this.txtBedrag = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTermijn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPercentage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtTeBetalen = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnBereken = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\FrmExcel1.xaml"
            this.btnBereken.Click += new System.Windows.RoutedEventHandler(this.btnBereken_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSluiten = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\FrmExcel1.xaml"
            this.btnSluiten.Click += new System.Windows.RoutedEventHandler(this.btnSluiten_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

