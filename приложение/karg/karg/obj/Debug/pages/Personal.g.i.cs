﻿#pragma checksum "..\..\..\pages\Personal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1256B8E58EE663F353EF3563FD11D451A848648BD131F6964E5FBF9C04F97A91"
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
using System.Windows.Forms.Integration;
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
    /// Personal
    /// </summary>
    public partial class Personal : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCh;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox choose;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridRegistration;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn sal;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn pos;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\pages\Personal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn c;
        
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
            System.Uri resourceLocater = new System.Uri("/karg;component/pages/personal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\Personal.xaml"
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
            
            #line 17 "..\..\..\pages\Personal.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonDel = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\pages\Personal.xaml"
            this.ButtonDel.Click += new System.Windows.RoutedEventHandler(this.ButtonDel_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonCh = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\pages\Personal.xaml"
            this.ButtonCh.Click += new System.Windows.RoutedEventHandler(this.ButtonCh_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.search = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\pages\Personal.xaml"
            this.search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.choose = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\pages\Personal.xaml"
            this.choose.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.choose_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DataGridRegistration = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.sal = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 8:
            this.pos = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 9:
            this.c = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

