﻿#pragma checksum "..\..\..\pages\Add_adress.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D04CD0AD1F764DE13A7B931173511944CD50C317FDC694C7D031A8944E0ECFE"
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
    /// Add_adress
    /// </summary>
    public partial class Add_adress : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox country;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox street;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox house;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox flat;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox idp;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox idc;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSave;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pages\Add_adress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBack;
        
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
            System.Uri resourceLocater = new System.Uri("/karg;component/pages/add_adress.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\Add_adress.xaml"
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
            this.country = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\pages\Add_adress.xaml"
            this.country.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.country_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\pages\Add_adress.xaml"
            this.country.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.country_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.city = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\pages\Add_adress.xaml"
            this.city.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.city_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\pages\Add_adress.xaml"
            this.city.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.city_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.street = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\pages\Add_adress.xaml"
            this.street.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.street_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\pages\Add_adress.xaml"
            this.street.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.street_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.house = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\pages\Add_adress.xaml"
            this.house.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.house_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.flat = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\pages\Add_adress.xaml"
            this.flat.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.apartament_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.idp = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\pages\Add_adress.xaml"
            this.idp.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.idp_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.idc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\pages\Add_adress.xaml"
            this.idc.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.idc_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonSave = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\pages\Add_adress.xaml"
            this.ButtonSave.Click += new System.Windows.RoutedEventHandler(this.ButtonSave_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonBack = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\pages\Add_adress.xaml"
            this.ButtonBack.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

