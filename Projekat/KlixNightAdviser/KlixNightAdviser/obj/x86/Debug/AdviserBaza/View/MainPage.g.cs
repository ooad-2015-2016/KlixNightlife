namespace KlixNightAdviser
{
    partial class MainPage : 
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
                    #line 8 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
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
                    #line 14 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button2).Click += this.button2_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.button3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button3).Click += this.button3_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.button4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button4).Click += this.button4_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.button5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button5).Click += this.button5_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.button6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button6).Click += this.button6_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.button7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button7).Click += this.button7_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.button8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button8).Click += this.button8_Click_1;
                    ((global::Windows.UI.Xaml.Controls.Button)this.button8).Click += this.button8_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.button9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\..\AdviserBaza\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button9).Click += this.button9_Click;
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

