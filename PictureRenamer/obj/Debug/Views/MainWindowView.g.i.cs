﻿#pragma checksum "..\..\..\Views\MainWindowView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0ED4CCC8FCAD1F49755262E4B9A2846C7F30621F0BE30A3C0C6EB05EE8092F53"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PictureRenamer.Views;
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


namespace PictureRenamer.Views {
    
    
    /// <summary>
    /// MainWindowView
    /// </summary>
    public partial class MainWindowView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\MainWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SetPath;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\MainWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Path;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\MainWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Run;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\MainWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Complete;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\MainWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Log;
        
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
            System.Uri resourceLocater = new System.Uri("/PictureRenamer;component/views/mainwindowview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindowView.xaml"
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
            this.SetPath = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.Path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Run = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Views\MainWindowView.xaml"
            this.Run.Click += new System.Windows.RoutedEventHandler(this.Run_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Complete = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 18 "..\..\..\Views\MainWindowView.xaml"
            this.Complete.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Complete_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Log = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\Views\MainWindowView.xaml"
            this.Log.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Log_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
