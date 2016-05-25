using KlixNightAdviser.AdviserBaza.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KlixNightAdviser.AdviserBaza.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PregledObjekta : Page
    {
        public PregledObjekta()
        {
            this.InitializeComponent();
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            Objekat prikazivaniObjekat = (Objekat)obj.objekatPregled;
            textBlock.Text = prikazivaniObjekat.Naziv;
            textBlock1.Text = prikazivaniObjekat.Tip.ToString();
            textBlock2.Text = prikazivaniObjekat.Mjesto;
            if (obj.aktivanKorisnik == null)
                textBox.Visibility = Visibility.Collapsed;
            else textBox.Visibility = Visibility.Visible;
            

        }
    }
}
