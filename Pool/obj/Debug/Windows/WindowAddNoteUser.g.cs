﻿#pragma checksum "..\..\..\Windows\WindowAddNoteUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E426AA7789A719A722F2C1838D4A1E2896DB5811483BF576E7C63328BC787932"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Pool.Windows;
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


namespace Pool.Windows {
    
    
    /// <summary>
    /// WindowAddNoteUser
    /// </summary>
    public partial class WindowAddNoteUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Windows\WindowAddNoteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\WindowAddNoteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbSurname;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\WindowAddNoteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPatronomic;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Windows\WindowAddNoteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPhone;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\WindowAddNoteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbAbonement;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Windows\WindowAddNoteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddNote;
        
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
            System.Uri resourceLocater = new System.Uri("/Pool;component/windows/windowaddnoteuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WindowAddNoteUser.xaml"
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
            this.TxbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxbSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxbPatronomic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxbPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CmbAbonement = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.BtnAddNote = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\Windows\WindowAddNoteUser.xaml"
            this.BtnAddNote.Click += new System.Windows.RoutedEventHandler(this.BtnAddNote_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

