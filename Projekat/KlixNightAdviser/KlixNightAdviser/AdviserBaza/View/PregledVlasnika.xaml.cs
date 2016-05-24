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
        public PregledVlasnika()
        {
            this.InitializeComponent();
            var obj = App.Current as App;
            textBlock.Text = "Dobrodošli " + obj.aktivanVlasnik.Ime;
            listBox.ItemsSource = obj.aktivanVlasnik.Objekti;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //sad su ovdje objekti
            //i kad se pritisne na neki
            //onda se otvara forma koja prikazuje podatke o tom objektu, i može se mjenjati, ili obrisati
            //al to kad malo popunim bazu i dodam objekata
            // pa da se može vidjeti da li radi
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

            listBox.ItemsSource = context.Objekti.ToList();
        }
    }
}
