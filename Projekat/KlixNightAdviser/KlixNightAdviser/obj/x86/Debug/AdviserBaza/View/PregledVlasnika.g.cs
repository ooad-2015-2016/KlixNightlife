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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\..\AdviserBaza\View\PregledVlasnika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\..\AdviserBaza\View\PregledVlasnika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\..\AdviserBaza\View\PregledVlasnika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button_Click_1;
                    #line default
                }
                break;
            case 5:
                {
                    this.listBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 15 "..\..\..\..\AdviserBaza\View\PregledVlasnika.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.listBox).SelectionChanged += this.listBox_SelectionChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\..\AdviserBaza\View\PregledVlasnika.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button2).Click += this.button2_Click;
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

