﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7AEBEF321054819B3A6637571921985B7ED701E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BardPerformConverter;
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


namespace BardPerformConverter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl TabControl;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab_notes;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_input;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_error;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox default_delay;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab_timing;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_timing;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_current_note;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_delay;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab_output;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_output;
        
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
            System.Uri resourceLocater = new System.Uri("/BardPerformConverter;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.TabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.tab_notes = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.text_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 14 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Clear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 15 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.switch_Timing);
            
            #line default
            #line hidden
            return;
            case 6:
            this.text_error = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.default_delay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tab_timing = ((System.Windows.Controls.TabItem)(target));
            return;
            case 9:
            this.grid_timing = ((System.Windows.Controls.Grid)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.grid_timing.KeyDown += new System.Windows.Input.KeyEventHandler(this.key_press);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.grid_timing.Loaded += new System.Windows.RoutedEventHandler(this.grid_timing_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 23 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.switch_Notes);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 24 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.switch_Output);
            
            #line default
            #line hidden
            return;
            case 12:
            this.text_current_note = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.text_delay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.tab_output = ((System.Windows.Controls.TabItem)(target));
            return;
            case 15:
            this.text_output = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            
            #line 33 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.reset);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
