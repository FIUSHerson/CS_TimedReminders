﻿#pragma checksum "..\..\..\..\Pages\Startup.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42592E4BCF995524AE68B6719D7ECCBD26FFC17B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CS_TimedReminders.Pages;
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


namespace CS_TimedReminders.Pages {
    
    
    /// <summary>
    /// Startup
    /// </summary>
    public partial class Startup : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\Pages\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Remove;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Pages\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\Startup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CS_TimedReminders;component/pages/startup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Startup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Pages\Startup.xaml"
            this.Add.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Add_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Remove = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Pages\Startup.xaml"
            this.Remove.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Remove_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Edit = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Pages\Startup.xaml"
            this.Edit.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Edit_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Start = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Pages\Startup.xaml"
            this.Start.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Start_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

