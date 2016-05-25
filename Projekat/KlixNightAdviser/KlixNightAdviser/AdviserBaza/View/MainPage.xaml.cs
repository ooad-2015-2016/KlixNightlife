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
using KlixNightAdviser.AdviserBaza.Model;
using KlixNightAdviser.AdviserBaza.View;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KlixNightAdviser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>


    public sealed partial class MainPage : Page
    {
        //za svaki slucaj da imamo hardkodirano
        public List<Objekat> objekti = new List<Objekat>();

        public MainPage()
        {
            this.InitializeComponent();
            {
                Objekat novi = new Objekat();
                novi.Naziv = "Libris";
                novi.Mjesto = "Baščaršija";
                novi.Tip = TipObjekta.Nargilhana;
                objekti.Add(novi);
            }


            {
                Objekat novi = new Objekat();
                novi.Naziv = "Park Prinčeva";
                novi.Mjesto = "Stari Grad";
                novi.Tip = TipObjekta.Restoran;
                objekti.Add(novi);
            }

            {
                Objekat novi = new Objekat();
                novi.Naziv = "Coloseum Club";
                novi.Mjesto = "Skenderija";
                novi.Tip = TipObjekta.Klub;
                objekti.Add(novi);
            }

            {
                Objekat novi = new Objekat();
                novi.Naziv = "Libris";
                novi.Mjesto = "Baščaršija";
                novi.Tip = TipObjekta.Nargilhana;
                objekti.Add(novi);
            }

            {
                Objekat novi = new Objekat();
                novi.Naziv = "Park Prinčeva";
                novi.Mjesto = "Stari Grad";
                novi.Tip = TipObjekta.Restoran;
                objekti.Add(novi);
            }

            {
                Objekat novi = new Objekat();
                novi.Naziv = "Coloseum Club";
                novi.Mjesto = "Skenderija";
                novi.Tip = TipObjekta.Klub;
                objekti.Add(novi);
            }
            //dodati u bazu, za ne daj boze :)
            // da ne kucamo na casu 

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
            if (label == "Da")
            {
                this.Frame.Navigate(typeof(Login));
            }
            else if (label == "Ne")
            {
                this.Frame.Navigate(typeof(Registracija));
            }
            else
            {

            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.tip = "korisnik";
            this.Frame.Navigate(typeof(Login));

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //sad lafo povucemo iz baze objekte sa najboljim ocjenama, ili plaćene, ili sta već
            //skontaćemo 
            List<Button> lista = new List<Button>();
            lista.Add(button2);
            lista.Add(button3);
            lista.Add(button4);
            lista.Add(button5);
            lista.Add(button6);
            lista.Add(button7);
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Content = objekti[i].Naziv;
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.objekatPregled = objekti[0];
            this.Frame.Navigate(typeof(PregledObjekta));
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.objekatPregled = objekti[5];
            this.Frame.Navigate(typeof(PregledObjekta));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.objekatPregled = objekti[1];
            this.Frame.Navigate(typeof(PregledObjekta));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.objekatPregled = objekti[2];
            this.Frame.Navigate(typeof(PregledObjekta));
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.objekatPregled = objekti[3];
            this.Frame.Navigate(typeof(PregledObjekta));
            
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.objekatPregled = objekti[4];
            this.Frame.Navigate(typeof(PregledObjekta));
        }
    }
}
