using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KlixNightAdviser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    

    public sealed partial class MainPage : Page
    {
        public int proba = new int();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
                obj.tip = "vlasnik";

            MessageDialog dialog = new MessageDialog("Jeste li registovani?");
            dialog.Commands.Add(new UICommand("Da", new UICommandInvokedHandler(DialogBoxShow)));
            dialog.Commands.Add(new UICommand("Ne", new UICommandInvokedHandler(DialogBoxShow)));
            dialog.Commands.Add(new UICommand("Cancel", new UICommandInvokedHandler(DialogBoxShow)));

            await dialog.ShowAsync();

            
           

        }
        private void DialogBoxShow(IUICommand c)
        {
            var obj = App.Current as App;
            obj.tip = "vlasnik";
            var label = c.Label;
            if (label=="Da")
            {
                this.Frame.Navigate(typeof(Login));
            }
            else if (label=="Ne")
            {
                this.Frame.Navigate(typeof(Registracija));
            }
            else
            {
               
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
            
        }

      
    }
}
