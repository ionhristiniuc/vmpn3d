﻿#pragma checksum "..\..\NumericBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "385E0CF1216ED5B0413C7A655DA51DD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NumericBox.Converters;
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


namespace NumericBox {
    
    
    /// <summary>
    /// NumericBox
    /// </summary>
    public partial class NumericBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\NumericBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup PART_Popup;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\NumericBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PART_IncrementTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\NumericBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PART_NumericTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\NumericBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem PART_MenuItem;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\NumericBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PART_IncreaseButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\NumericBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PART_DecreaseButton;
        
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
            System.Uri resourceLocater = new System.Uri("/NumericBox;component/numericbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NumericBox.xaml"
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
            this.PART_Popup = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 18 "..\..\NumericBox.xaml"
            this.PART_Popup.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.optionsPopup_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PART_IncrementTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\NumericBox.xaml"
            this.PART_IncrementTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.incrementTB_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PART_NumericTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\NumericBox.xaml"
            this.PART_NumericTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.PART_NumericTextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 31 "..\..\NumericBox.xaml"
            this.PART_NumericTextBox.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.numericBox_MouseWheel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PART_MenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\NumericBox.xaml"
            this.PART_MenuItem.Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PART_IncreaseButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\NumericBox.xaml"
            this.PART_IncreaseButton.Click += new System.Windows.RoutedEventHandler(this.increaseBtn_Click);
            
            #line default
            #line hidden
            
            #line 46 "..\..\NumericBox.xaml"
            this.PART_IncreaseButton.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.increaseBtn_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 46 "..\..\NumericBox.xaml"
            this.PART_IncreaseButton.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.increaseBtn_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PART_DecreaseButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\NumericBox.xaml"
            this.PART_DecreaseButton.Click += new System.Windows.RoutedEventHandler(this.decreaseBtn_Click);
            
            #line default
            #line hidden
            
            #line 52 "..\..\NumericBox.xaml"
            this.PART_DecreaseButton.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.decreaseBtn_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 52 "..\..\NumericBox.xaml"
            this.PART_DecreaseButton.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.decreaseBtn_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

