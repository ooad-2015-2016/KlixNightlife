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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //provjeriti dali ima uopste ovaj korisnik u bazi
            //ukoliko nema, izbaciti poruku da nije username okey 
            //ukoliko ima, a sifra je pogresna, obavjest da je pogresna
            //a ukoliko je i username i sifra tacna, onda se vraca na pocetnu formu
            //koja sad vise nema login i ono vlasnik se ugostiteljskog objekta, vec samo ima logout button
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //pokrece se forma registacija 
            // treba dodati da se nekako inicijalizira koji tip treba pokrenuti
            // pitati Cogu 
            
            this.Frame.Navigate(typeof(Registracija), Tip.Korisnik);
            
        }
    }
}
