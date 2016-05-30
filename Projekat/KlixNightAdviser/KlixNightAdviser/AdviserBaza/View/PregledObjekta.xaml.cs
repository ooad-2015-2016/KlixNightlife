using KlixNightAdviser.AdviserBaza.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using KlixNightAdviser.AdviserBaza.ModelView;

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
            var obj = App.Current as App;
            KomentarModelView kmv = new KomentarModelView();
            listBox.ItemsSource = kmv.KomentariObjekta(obj.objekatPregled);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var context = new AdviserDBContext();
            
            var obj = App.Current as App;
            Objekat prikazivaniObjekat = (Objekat)obj.objekatPregled;
            textBlock.Text = prikazivaniObjekat.Naziv;
            textBlock1.Text = prikazivaniObjekat.Tip.ToString();
            textBlock2.Text = prikazivaniObjekat.Mjesto;
            if (obj.aktivanKorisnik == null)
            {
                textBox.Visibility = Visibility.Collapsed;
                button1.Visibility = Visibility.Collapsed;
            }
                
            else
            {
                textBox.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Visible;
            }
            KomentarModelView kmv = new KomentarModelView();
            listBox.ItemsSource = kmv.KomentariObjekta(obj.objekatPregled);
            //ebi ga




        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            KomentarModelView komentar = new KomentarModelView();
            komentar.DodajKomentar(obj.objekatPregled, obj.aktivanKorisnik, textBox.Text);
            KomentarModelView kmv = new KomentarModelView();
            listBox.ItemsSource = kmv.KomentariObjekta(obj.objekatPregled);
        }
    }
}
