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
using KlixNightAdviser.AdviserBaza.ModelView;
using KlixNightAdviser.AdviserBaza.View;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KlixNightAdviser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>ž
    public enum Tip { Vlasnik, Korisnik }

    public sealed partial class Registracija : Page
    {

        public Registracija()
        {
            this.InitializeComponent();
            textBlock1.Text = "";
        }

        private void OcistiPolja()
        {
            textBox.Text = "";
            passwordBox.Password = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private string Validacija()
        {
            //korisnicko ime ne smije biti prazno, i ne smije biti vec takvo korisničko ime u bazi
            {
                if (textBox.Text == "") return "Korisničko ime ne može biti prazno!";
                var context = new AdviserDBContext();
                List<Korisnik> listaKorisnika = context.Korisnici.ToList();
                for (int i = 0; i < listaKorisnika.Count; i++)
                {
                    if (listaKorisnika[i].KorisnickoIme == textBox.Text) return "Korisničko ime je zauzeto. Izaberite drugo!";
                }

            }
            //za ime i prezime
            {
                string imeIprezime = textBox4.Text;
                if (imeIprezime == "") return "Unesite ime i prezime!";
                else
                {
                    String[] s = imeIprezime.Split(' ');
                    if (s.Length == 1) return "Unesite i ime i prezime";
                    else if (s.Length >= 6) return "Chao Ming Ju Huan, ne zezaj!";
                }
            }
            //sifra 
            {
                if (passwordBox.Password == "")
                    return "Unesite lozinku!";

            }
            //email
            {
                if (!textBox2.Text.Contains("@")) return "Unesite ispravu eMail adresu!";
            }
            //Adresa 
            {
                if (textBox5.Text == "") return "Popunite sva polja!";
            }
            //Broj telefona, trebalo bi i da su samo brojevi, al...
            {
                if (textBox3.Text == "") return "Popunite sva polja!";
            }


            return "OK";
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            string validacija = Validacija();
            if (validacija == "OK")
            {
                Spol s;
                if (comboBox.SelectedIndex == 0) s = Spol.Musko;
                else s = Spol.Zensko;
                var obj = App.Current as App;
                if (obj.tip == "korisnik")
                {

                    KorisnikModelView dodavanjeKorisnika = new KorisnikModelView();
                    dodavanjeKorisnika.DodajKorisnika(textBox4.Text, textBox5.Text, textBox3.Text, textBox.Text, textBox2.Text, s, passwordBox.Password);
                    OcistiPolja();

                    //NERA: i dodati korisnika u bazu
                    this.Frame.Navigate(typeof(Login));

                }
                else if (obj.tip == "vlasnik")
                {
                    VlasnikModelView dodavanjeVlasnika = new VlasnikModelView();
                    dodavanjeVlasnika.DodajVlasnika(textBox4.Text, textBox5.Text, textBox3.Text, textBox.Text, textBox2.Text, s, passwordBox.Password);
                    OcistiPolja();
                    //Dodaj korisnika u bazu

                    this.Frame.Navigate(typeof(Login));

                }

            }
            else
            {
                textBlock1.Text = validacija;
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
    }
}
