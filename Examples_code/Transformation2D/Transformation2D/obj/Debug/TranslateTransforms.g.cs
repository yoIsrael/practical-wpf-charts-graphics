﻿#pragma checksum "..\..\TranslateTransforms.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4BF3950C4AABD5F5B0E3E642B1FB9395"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Transformation2D {
    
    
    /// <summary>
    /// TranslateTransforms
    /// </summary>
    public partial class TranslateTransforms : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\TranslateTransforms.xaml"
        internal System.Windows.Shapes.Rectangle rect;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\TranslateTransforms.xaml"
        internal System.Windows.Media.TranslateTransform translate;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\TranslateTransforms.xaml"
        internal System.Windows.Controls.TextBox tbX;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\TranslateTransforms.xaml"
        internal System.Windows.Controls.TextBox tbY;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\TranslateTransforms.xaml"
        internal System.Windows.Shapes.Rectangle rect1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Transformation2D;component/translatetransforms.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TranslateTransforms.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 2:
            this.translate = ((System.Windows.Media.TranslateTransform)(target));
            return;
            case 3:
            this.tbX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.rect1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}