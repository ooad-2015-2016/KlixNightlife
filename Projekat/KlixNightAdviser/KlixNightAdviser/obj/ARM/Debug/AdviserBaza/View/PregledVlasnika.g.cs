﻿#pragma checksum "C:\projekat\KlixNightlife\Projekat\KlixNightAdviser\KlixNightAdviser\AdviserBaza\View\PregledVlasnika.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D01914FBAC0ADE83D8DA397BADB0C36"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlixNightAdviser.AdviserBaza.View
{
    partial class PregledVlasnika : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\..\AdviserBaza\View\PregledVlasnika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.listBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 14 "..\..\..\..\AdviserBaza\View\PregledVlasnika.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.listBox).SelectionChanged += this.listBox_SelectionChanged;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

