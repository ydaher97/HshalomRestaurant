﻿#pragma checksum "..\..\Payment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DC98783561E716A4DA6F0128EB090655D3D49D2A4E8603348A013381BBAEFEDE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HshlomResturant;
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


namespace HshlomResturant {
    
    
    /// <summary>
    /// Payment
    /// </summary>
    public partial class Payment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem c1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem c2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tx1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Xpay;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bpay;
        
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
            System.Uri resourceLocater = new System.Uri("/HshlomResturant;component/payment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Payment.xaml"
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
            this.ComboB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\Payment.xaml"
            this.ComboB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.c1 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 3:
            this.c2 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.tx1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Xpay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Bpay = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Payment.xaml"
            this.Bpay.Click += new System.Windows.RoutedEventHandler(this.Bpay_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

