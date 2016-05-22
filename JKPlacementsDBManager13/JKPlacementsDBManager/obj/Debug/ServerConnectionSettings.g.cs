﻿#pragma checksum "..\..\ServerConnectionSettings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AD92855275096FB98D7525A58DFA2C68"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace JKPlacementsDBManager {
    
    
    /// <summary>
    /// ServerConnectionSettings
    /// </summary>
    public partial class ServerConnectionSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serverField;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox databaseField;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uidField;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordField;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox portField;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConnTestButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveSettingsButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ServerConnectionSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/JKPlacementsDBManager;component/serverconnectionsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ServerConnectionSettings.xaml"
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
            
            #line 4 "..\..\ServerConnectionSettings.xaml"
            ((JKPlacementsDBManager.ServerConnectionSettings)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.serverField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.databaseField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.uidField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.passwordField = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.portField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ConnTestButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ServerConnectionSettings.xaml"
            this.ConnTestButton.Click += new System.Windows.RoutedEventHandler(this.ConnTestButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SaveSettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ServerConnectionSettings.xaml"
            this.SaveSettingsButton.Click += new System.Windows.RoutedEventHandler(this.SaveSettingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\ServerConnectionSettings.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
