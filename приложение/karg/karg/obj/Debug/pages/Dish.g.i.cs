﻿#pragma checksum "..\..\..\pages\Dish.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C88E6ECA1B9A83B8A1B78B535D036DE813F81D071AF42B9F8C2733FE4CAD879F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using karg.pages;


namespace karg.pages {
    
    
    /// <summary>
    /// Dish
    /// </summary>
    public partial class Dish : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\pages\Dish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\pages\Dish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\pages\Dish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCh;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\pages\Dish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\pages\Dish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox choose;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\pages\Dish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridRegistration;
        
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
            System.Uri resourceLocater = new System.Uri("/karg;component/pages/dish.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\Dish.xaml"
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
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\pages\Dish.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonDel = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\pages\Dish.xaml"
            this.ButtonDel.Click += new System.Windows.RoutedEventHandler(this.ButtonDel_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonCh = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\pages\Dish.xaml"
            this.ButtonCh.Click += new System.Windows.RoutedEventHandler(this.ButtonCh_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.search = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\pages\Dish.xaml"
            this.search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.choose = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\pages\Dish.xaml"
            this.choose.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.choose_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DataGridRegistration = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

