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
using KlixNightAdviser.AdviserBaza.ModelView;
using KlixNightAdviser.AdviserBaza.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KlixNightAdviser.AdviserBaza.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodavanjeObjekta : Page
    {
        public DodavanjeObjekta()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            VlasnikModelView vlasnik = new VlasnikModelView();
            var obj = App.Current as App;
            
            Objekat noviObjekat = new Objekat();
            {
                noviObjekat.Naziv = textBox.Text;
                noviObjekat.Vlasnik = obj.aktivanVlasnik;
                noviObjekat.Adresa = textBox1.Text;
                noviObjekat.Mjesto = textBox2.Text;
                noviObjekat.Tip = TipObjekta.Klub; //defaultno, pa cemo mjenjati
            }
            if (vlasnik.DodajObjekat(noviObjekat, obj.aktivanVlasnik))
                this.Frame.Navigate(typeof(PregledVlasnika));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PregledVlasnika));
        }
    }
}
