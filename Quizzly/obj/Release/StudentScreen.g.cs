﻿#pragma checksum "..\..\StudentScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69A1E70F60F45F46FC517AF1761B7146B628AEEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Quizzly;
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


namespace Quizzly {
    
    
    /// <summary>
    /// StudentScreen
    /// </summary>
    public partial class StudentScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\StudentScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\StudentScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTakeTest;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\StudentScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainArea;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\StudentScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock userName;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\StudentScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewMarks;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\StudentScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewMemos;
        
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
            System.Uri resourceLocater = new System.Uri("/Quizzly;component/studentscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentScreen.xaml"
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
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\StudentScreen.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.BtnLogOut_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnTakeTest = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\StudentScreen.xaml"
            this.btnTakeTest.Click += new System.Windows.RoutedEventHandler(this.BtnTakeTest_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mainArea = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.userName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnViewMarks = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\StudentScreen.xaml"
            this.btnViewMarks.Click += new System.Windows.RoutedEventHandler(this.BtnViewMarks_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnViewMemos = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\StudentScreen.xaml"
            this.btnViewMemos.Click += new System.Windows.RoutedEventHandler(this.BtnViewMemos_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

