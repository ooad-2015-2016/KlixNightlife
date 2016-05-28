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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KlixNightAdviser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    enum Greska { PrazanUsername, PrazanPasword, OK}
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
            textBlock2.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            if (obj.tip == "vlasnik")
            {
                VlasnikModelView vmv = new VlasnikModelView();
                //trazi u bazi ima li vlasnika
                //predpostavicemo da je login uspio
                //kad login uspije, zapamtimo koji nam je to aktivanVlasnik
                //sad cemo napraviti nekog zamisljenog vlasnika
                //i reci da je on aktivan
                PovratnaPoruka poruka = vmv.LoginVlasnika(textBox.Text, passwordBox.Password);
                if (poruka==PovratnaPoruka.LoginOK)
                {
                    
                    this.Frame.Navigate(typeof(PregledVlasnika));
                }
                else
                {
                    textBlock2.Text = poruka.ToString();
                }

                //vodi ga na novu formu
                //u kojoj on ima pregled svojih objekata 



            }
            else if (obj.tip == "korisnik")
            {

                KorisnikModelView LoginKorisnika = new KorisnikModelView();
                Greska greska = Validacija();
                if (greska == Greska.OK)
                {
                    PovratnaPoruka p = LoginKorisnika.LoginKorisnika(textBox.Text, passwordBox.Password);
                    if (p == PovratnaPoruka.LoginOK) this.Frame.Navigate(typeof(MainPage));
                    else if (p == PovratnaPoruka.PogresanUsername)
                    {
                        textBlock2.Text = p.ToString();
                    }
                    else if (p == PovratnaPoruka.PogresnaSifra)
                    {
                        textBlock2.Text = p.ToString();
                    }
                }
                else textBlock.Text = greska.ToString();
               
                

            }
        }
        private void DialogBoxShow(IUICommand c)
        {

            var label = c.Label;
            if (label == "OK")
            {

            }
        }

        private Greska Validacija()
        {
            if (textBox.Text == "") return Greska.PrazanUsername;
            else if (passwordBox.Password == "") return Greska.PrazanPasword;
            else return Greska.OK;
        }
            
           
            
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.tip = "korisnik";
            this.Frame.Navigate(typeof(Registracija));
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }

        private void Page_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
