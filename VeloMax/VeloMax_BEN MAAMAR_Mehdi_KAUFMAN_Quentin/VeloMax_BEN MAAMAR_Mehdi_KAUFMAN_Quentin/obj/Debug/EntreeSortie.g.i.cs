﻿#pragma checksum "..\..\EntreeSortie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A38B561CC0C31CD515EC3946F3899E221DB2667414D2509F088659D1A16D90B5"
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
    /// EntreeSortie
    /// </summary>
    public partial class EntreeSortie : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\EntreeSortie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Entreprises;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\EntreeSortie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Particuliers;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\EntreeSortie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid IODataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/VeloMax_BEN MAAMAR_Mehdi_KAUFMAN_Quentin;component/entreesortie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EntreeSortie.xaml"
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
            
            #line 12 "..\..\EntreeSortie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Creer);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\EntreeSortie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Commande);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\EntreeSortie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Client);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\EntreeSortie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Fournisseur);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\EntreeSortie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Velo);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\EntreeSortie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Piece);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Entreprises = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\EntreeSortie.xaml"
            this.Entreprises.Checked += new System.Windows.RoutedEventHandler(this.Entreprises_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Particuliers = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\EntreeSortie.xaml"
            this.Particuliers.Checked += new System.Windows.RoutedEventHandler(this.Particuliers_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.IODataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

