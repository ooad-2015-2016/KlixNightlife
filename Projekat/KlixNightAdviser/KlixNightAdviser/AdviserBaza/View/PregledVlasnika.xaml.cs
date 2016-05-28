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
using KlixNightAdviser.AdviserBaza.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KlixNightAdviser.AdviserBaza.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PregledVlasnika : Page
    {
        List<Objekat> objektiVlasnika = new List<Objekat>();
        public PregledVlasnika()
        {
            this.InitializeComponent();
            var obj = App.Current as App;
            textBlock.Text = "Dobrodošli " + obj.aktivanVlasnik.Ime;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (listBox.SelectedIndex!=-1)
            {
                var obj = App.Current as App;
                obj.objekatPregled = objektiVlasnika[listBox.SelectedIndex];
                this.Frame.Navigate(typeof(UredjivanjeObjekta));
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeObjekta));
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.aktivanVlasnik = null;
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var context = new AdviserDBContext();
            var obj = App.Current as App;
            List<Objekat> sviObjekti = context.Objekti.ToList();
            
            for (int i=0; i<sviObjekti.Count; i++)
            {
                if (sviObjekti[i].VlasnikId==obj.aktivanVlasnik.Id)
                    objektiVlasnika.Add(sviObjekti[i]);
                    
            }
            listBox.ItemsSource = objektiVlasnika; 
        }
    }
}
