﻿#pragma checksum "..\..\ChangeExtensionUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88E78F78DE00F575E347156F3EADDBE0B6ECD520C4E7B7E83D003C6DD20524D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI01_BatchRename_Project;
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


namespace GUI01_BatchRename_Project {
    
    
    /// <summary>
    /// ChangeExtensionUC
    /// </summary>
    public partial class ChangeExtensionUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ChangeExtensionUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewExtensionTextbox;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI01_BatchRename_Project;component/changeextensionuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChangeExtensionUC.xaml"
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
            this.NewExtensionTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\ChangeExtensionUC.xaml"
            this.NewExtensionTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NewExtensionTextbox_TextChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\ChangeExtensionUC.xaml"
            this.NewExtensionTextbox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.NewExtensionTextbox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\ChangeExtensionUC.xaml"
            this.NewExtensionTextbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NewExtensionTextbox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
