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
            var context = new AdviserDBContext();
            List<Dogadjaj> sviDogađaji = context.Dogadjaji.ToList();
            List<Dogadjaj> događajiObjekta = new List<Dogadjaj>();
            for (int i = 0; i < sviDogađaji.Count(); i++)
            {
                if (sviDogađaji[i].ObjekatId == obj.objekatPregled.Id)
                    događajiObjekta.Add(sviDogađaji[i]);
            }
            listBox.ItemsSource = događajiObjekta;

            listBox1.ItemsSource= context.Clanci.ToList();

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
            this.Frame.Navigate(typeof(PregledVlasnika));
            
            
        }
    }
}
