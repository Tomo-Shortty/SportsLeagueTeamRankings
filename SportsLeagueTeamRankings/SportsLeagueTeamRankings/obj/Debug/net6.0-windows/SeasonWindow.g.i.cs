﻿#pragma checksum "..\..\..\SeasonWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A6141AAB8F12EA4AB260ADEF9887D3E6CA41EDB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SportsLeagueTeamRankings;
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


namespace SportsLeagueTeamRankings {
    
    
    /// <summary>
    /// SeasonWindow
    /// </summary>
    public partial class SeasonWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\SeasonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ViewSeasonsBackgroundGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\SeasonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelSeasonsButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\SeasonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitSeasonsButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\SeasonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ViewSeasonsGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SportsLeagueTeamRankings;V1.0.0.0;component/seasonwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SeasonWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ViewSeasonsBackgroundGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.CancelSeasonsButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\SeasonWindow.xaml"
            this.CancelSeasonsButton.Click += new System.Windows.RoutedEventHandler(this.CancelSeasonsButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SubmitSeasonsButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\SeasonWindow.xaml"
            this.SubmitSeasonsButton.Click += new System.Windows.RoutedEventHandler(this.SubmitSeasonsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ViewSeasonsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

