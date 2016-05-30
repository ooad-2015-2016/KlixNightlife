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
using KlixNightAdviser.AdviserBaza.View;
using KlixNightAdviser.AdviserBaza.Model;
using KlixNightAdviser.AdviserBaza.ModelView;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KlixNightAdviser.AdviserBaza.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UredjivanjeObjekta : Page
    {
        bool promjena;

        public UredjivanjeObjekta()
        {
            this.InitializeComponent();
            var obj = App.Current as App;
            Objekat promjenjiviObjekt = obj.objekatPregled;

            textBox.Text = promjenjiviObjekt.Naziv;
            textBox2.Text = promjenjiviObjekt.Adresa;
            textBox3.Text = promjenjiviObjekt.Mjesto;
            promjena = false;
            //ovo ne bi smjelo ovdje, al eto
            //treba prebaciti u modelview
            DogadjajModelView dogadjaji = new DogadjajModelView();
            listBox.ItemsSource = dogadjaji.VratiDogađajeObjekta(obj.objekatPregled);
            ClanakModelView clanak = new ClanakModelView();
            listBox1.ItemsSource = clanak.VratiSveClanke();

        }

        private void textBox_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            promjena = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (promjena)
            {
                //ovdje bi trebao messagebox, al otom potom
                textBlock1.Text = "Imate nespašene promjene!";
            }
            else this.Frame.Navigate(typeof(PregledVlasnika));

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            promjena = true;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            promjena = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           if (promjena)
            {
                var obj = App.Current as App;
                VlasnikModelView brisanjeObjekta = new VlasnikModelView();
                brisanjeObjekta.ObrisiObjekat(obj.objekatPregled);
                Objekat novi = new Objekat();
                {
                    novi.Naziv = textBox.Text;
                    novi.Adresa = textBox2.Text;
                    novi.Mjesto = textBox3.Text;
                    novi.Vlasnik = obj.aktivanVlasnik;
                    novi.VlasnikId = obj.aktivanVlasnik.Id;
                    novi.GalerijaId = 1;
                }
                brisanjeObjekta.DodajObjekat(novi, obj.aktivanVlasnik);
            }
            
            this.Frame.Navigate(typeof(PregledVlasnika));
            
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeDogadjaja));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeClanka));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //treba pitati jeste li sigurni, al sad za sad
            VlasnikModelView vmv = new VlasnikModelView();
            var obj = App.Current as App;
            vmv.ObrisiObjekat(obj.objekatPregled);
            Frame.Navigate(typeof(PregledVlasnika));
        }
    }
}
