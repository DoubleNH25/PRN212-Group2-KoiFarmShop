﻿#pragma checksum "..\..\..\..\AdminManager\ManageShippingWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203449AAE7CC0472402DB846E0FBF4D58ADCA185"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KoiFarmShop.AdminManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace KoiFarmShop.AdminManager {
    
    
    /// <summary>
    /// ManageShippingWindow
    /// </summary>
    public partial class ManageShippingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvShippingData;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEmployee;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbOrderId;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KoiFarmShop;component/adminmanager/manageshippingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((KoiFarmShop.AdminManager.ManageShippingWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 31 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 32 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnProduct_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSupplier_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 34 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnKoiBreeds_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 35 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 36 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnOrderDetail_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 37 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnShipping_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 38 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lvShippingData = ((System.Windows.Controls.ListView)(target));
            
            #line 48 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            this.lvShippingData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvShippingData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cmbEmployee = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.cmbOrderId = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            
            #line 73 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 74 "..\..\..\..\AdminManager\ManageShippingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

