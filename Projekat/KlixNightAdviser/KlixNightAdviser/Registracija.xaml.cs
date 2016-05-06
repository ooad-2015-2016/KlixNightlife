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
    /// </summary>ž
    public enum Tip { Vlasnik, Korisnik }
    public sealed partial class Registracija : Page
    {
        public Tip t;
        public Registracija()
        {

            this.InitializeComponent();
        }
        public Registracija(Tip tp)
        {
       
            this.InitializeComponent();
           // if (tp==Tip.Korisnik) ne prikazuj neke djelove forme
            //  if (tp==Tip.Vlasnik) prikazi ono sto vlasniku treba
            //Dodati jos po nesto za vlasnika, neke informacije
        }
    }
}
