﻿#pragma checksum "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E8D0B98AFD49339ED36113928B99B24B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PNCreator.Modules.Main.PNObjectProperties;
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


namespace PNCreator.Modules.Main.PNObjectProperties {
    
    
    /// <summary>
    /// TransitionPropertiesPanel
    /// </summary>
    public partial class TransitionPropertiesPanel : PNCreator.Modules.Main.PNObjectProperties.FormulaPropertiesPanel, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock valueLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox valueTB;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button guardFormulaBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/PNCreator;component/modules/main/pnobjectproperties/transitionpropertiespanel.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml"
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
            this.valueLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.valueTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml"
            this.valueTB.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.ValueChangedTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 29 "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FormulaButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.guardFormulaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\Modules\Main\PNObjectProperties\TransitionPropertiesPanel.xaml"
            this.guardFormulaBtn.Click += new System.Windows.RoutedEventHandler(this.FormulaButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

