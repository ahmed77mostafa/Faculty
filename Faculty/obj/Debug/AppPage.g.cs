﻿#pragma checksum "..\..\AppPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F7420FF2B239F4697165A8B5F6357068C7DCBC40DA3F16AEAA739DC431283E9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Faculty;
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


namespace Faculty {
    
    
    /// <summary>
    /// AppPage
    /// </summary>
    public partial class AppPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\AppPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AppPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name_textbox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AppPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address_textbox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AppPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Age_textbox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AppPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Department_textbox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AppPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Data_button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AppPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/Faculty;component/apppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AppPage.xaml"
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
            this.DG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            
            #line 17 "..\..\AppPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Name_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Address_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Age_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Department_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Data_button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AppPage.xaml"
            this.Data_button.Click += new System.Windows.RoutedEventHandler(this.Data_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Save_Button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AppPage.xaml"
            this.Save_Button.Click += new System.Windows.RoutedEventHandler(this.Save_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

