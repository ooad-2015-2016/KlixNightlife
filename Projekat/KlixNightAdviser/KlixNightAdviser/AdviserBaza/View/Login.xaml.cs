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
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            if (obj.tip=="vlasnik")
            {
                VlasnikModelView vmv = new VlasnikModelView();
                //trazi u bazi ima li vlasnika
                //predpostavicemo da je login uspio
                //kad login uspije, zapamtimo koji nam je to aktivanVlasnik
                //sad cemo napraviti nekog zamisljenog vlasnika
                //i reci da je on aktivan
                if (vmv.LoginVlasnika(textBlock.Text, textBlock1.Text))
                {
                    this.Frame.Navigate(typeof(PregledVlasnika));
                }
                else
                {
                    //ovdje treba više različitih poruka, ovisno od toga šta nije ok
                    //nema korisnickog imena u bazi
                    //ima ime, ali nema sifra
                    MessageDialog dialog = new MessageDialog("Login nije uspio!");
                    
                    dialog.Commands.Add(new UICommand("OK", new UICommandInvokedHandler(DialogBoxShow)));

                    await dialog.ShowAsync();
                }
               
                //vodi ga na novu formu
                //u kojoj on ima pregled svojih objekata 

                
                
            }
            else if (obj.tip=="korisnik")
            {
                //provjeriti dali ima uopste ovaj korisnik u bazi
                //ukoliko nema, izbaciti poruku da nije username okey 
                //ukoliko ima, a sifra je pogresna, obavjest da je pogresna
                //a ukoliko je i username i sifra tacna, onda se vraca na pocetnu formu
            }
        }
        private void DialogBoxShow(IUICommand c)
        {

            var label = c.Label;
            if (label == "OK")
            {

            }
        }
            
           
            
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            obj.tip = "korisnik";
            this.Frame.Navigate(typeof(Registracija));
            
        }
    }
}
