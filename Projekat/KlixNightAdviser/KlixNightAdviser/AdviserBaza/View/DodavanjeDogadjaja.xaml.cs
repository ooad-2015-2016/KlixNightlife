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
using KlixNightAdviser.AdviserBaza.View;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KlixNightAdviser.AdviserBaza.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodavanjeDogadjaja : Page
    {
        public DodavanjeDogadjaja()
        {
            this.InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //dodatiDogađaj
            var obj = App.Current as App;
            DogadjajModelView dodavanjeDogađaja = new DogadjajModelView();
            DateTime datum = datePicker.Date.Value.Date;
            int sati = timePicker.Time.Hours;
            int minute = timePicker.Time.Minutes;
            DateTime vrijeme = new DateTime();
            string vrijemeS = Convert.ToString(sati);
            vrijemeS += ":" + Convert.ToString(minute);
            vrijeme = Convert.ToDateTime(vrijeme);
           
            

            dodavanjeDogađaja.DodajDogađaj(textBox.Text, datum, vrijeme, obj.objekatPregled);
            this.Frame.Navigate(typeof(UredjivanjeObjekta));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //provjeriti ima li sta uneseno, al ...
            this.Frame.Navigate(typeof(UredjivanjeObjekta));
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UredjivanjeObjekta));
        }
    }
}
