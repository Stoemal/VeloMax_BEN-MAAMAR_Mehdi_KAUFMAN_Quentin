﻿#pragma checksum "..\..\MenuPrincipal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C6E3175415ADD1E1A6AFD18D3177B5B5AE4152F5CEB2DC2D3036EABAF9B6A97"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using VeloMax_BEN_MAAMAR_Mehdi_KAUFMAN_Quentin;


namespace VeloMax_BEN_MAAMAR_Mehdi_KAUFMAN_Quentin {
    
    
    /// <summary>
    /// MenuPrincipal
    /// </summary>
    public partial class MenuPrincipal : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement video;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butPlay;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butPause;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butRefresh;
        
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
            System.Uri resourceLocater = new System.Uri("/VeloMax_BEN MAAMAR_Mehdi_KAUFMAN_Quentin;component/menuprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuPrincipal.xaml"
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
            this.video = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 2:
            this.butPlay = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MenuPrincipal.xaml"
            this.butPlay.Click += new System.Windows.RoutedEventHandler(this.play);
            
            #line default
            #line hidden
            return;
            case 3:
            this.butPause = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\MenuPrincipal.xaml"
            this.butPause.Click += new System.Windows.RoutedEventHandler(this.pause);
            
            #line default
            #line hidden
            return;
            case 4:
            this.butRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MenuPrincipal.xaml"
            this.butRefresh.Click += new System.Windows.RoutedEventHandler(this.refresh);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

