﻿#pragma checksum "..\..\..\Windows\WindowAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2CF15BEF03272E85133682509C7FD1C03EA05B936CCF667D0711481B7FA279BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Pool;
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


namespace Pool {
    
    
    /// <summary>
    /// WindowAdmin
    /// </summary>
    public partial class WindowAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNote;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteNote;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbSearch;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button User;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pool;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Trener;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Group;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Abonement;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridUserList;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Windows\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrmGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Pool;component/windows/windowadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WindowAdmin.xaml"
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
            this.AddNote = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Windows\WindowAdmin.xaml"
            this.AddNote.Click += new System.Windows.RoutedEventHandler(this.AddNote_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeleteNote = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Windows\WindowAdmin.xaml"
            this.DeleteNote.Click += new System.Windows.RoutedEventHandler(this.DeleteNote_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\Windows\WindowAdmin.xaml"
            this.TxbSearch.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TxbSearch_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\Windows\WindowAdmin.xaml"
            this.TxbSearch.SelectionChanged += new System.Windows.RoutedEventHandler(this.TxbSearch_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.User = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Windows\WindowAdmin.xaml"
            this.User.Click += new System.Windows.RoutedEventHandler(this.User_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pool = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Windows\WindowAdmin.xaml"
            this.Pool.Click += new System.Windows.RoutedEventHandler(this.Pool_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Trener = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Windows\WindowAdmin.xaml"
            this.Trener.Click += new System.Windows.RoutedEventHandler(this.Trener_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Group = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\Windows\WindowAdmin.xaml"
            this.Group.Click += new System.Windows.RoutedEventHandler(this.Group_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Abonement = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\Windows\WindowAdmin.xaml"
            this.Abonement.Click += new System.Windows.RoutedEventHandler(this.Abonement_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GridUserList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.FrmGrid = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

