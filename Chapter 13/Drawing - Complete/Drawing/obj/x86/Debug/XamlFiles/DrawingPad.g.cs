﻿#pragma checksum "D:\Dev\Projects\CSharpProjects\Books\Microsoft Visual CSharp Step by Step 10th Edition\VCSBS\Chapter 13\Drawing - Complete\Drawing\XamlFiles\DrawingPad.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E2F72F757BFDF2F8D8F630704CD7EAFCEE95EC8DF9B3FE9B446507FCD5B80F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drawing
{
    partial class DrawingPad : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // XamlFiles\DrawingPad.xaml line 21
                {
                    this.drawingCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.drawingCanvas).Tapped += this.drawingCanvas_Tapped;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.drawingCanvas).RightTapped += this.drawingCanvas_RightTapped;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
