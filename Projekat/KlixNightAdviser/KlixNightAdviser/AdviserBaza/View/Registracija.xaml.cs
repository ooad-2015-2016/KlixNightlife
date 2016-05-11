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
        }

        private void OcistiPolja()
        {
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Spol s;          
            if (comboBox.SelectedIndex == 0) s = Spol.Musko;
            else s = Spol.Zensko;    
            var obj = App.Current as App;
            if (obj.tip=="korisnik")
            {
                
                KorisnikModelView dodavanjeKorisnika = new KorisnikModelView();
                dodavanjeKorisnika.DodajKorisnika(textBox4.Text, textBox5.Text, textBox3.Text, textBox.Text, textBox2.Text, s);
                OcistiPolja();
                 
                //NERA: i dodati korisnika u bazu

            }
            else if (obj.tip=="vlasnik")
            {
                VlasnikModelView dodavanjeVlasnika = new VlasnikModelView();
                dodavanjeVlasnika.DodajVlasnika(textBox4.Text, textBox5.Text, textBox3.Text, textBox.Text, textBox2.Text, s);
                OcistiPolja();

            }
            
        }
    }
}
