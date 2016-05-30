using KlixNightAdviser.AdviserBaza.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Data.Json;
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

namespace KlixNightAdviser.AdviserBaza.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WebServis : Page
    {
        public WebServis()
        {
            this.InitializeComponent();

        }

        private void buttonPretrazi_Click(object sender, RoutedEventArgs e)
        {
            getAtributes(textBox1.Text,textBox.Text);
        }
        

        public async Task getAtributes(string naziv ,string token)
        {
            HttpClient httpClient = new HttpClient();
            string uriString = "https://graph.facebook.com/search?q=" + naziv + "&type=place&access_token=" + token;
            string response = await httpClient.GetStringAsync(new Uri(uriString));
            JsonObject value = JsonValue.Parse(response).GetObject();

            var objektiWebServis = new List<ObjekatWebServis>();

            JsonArray jsonObjekti = value.GetNamedArray("data");

            //var objekatWebServis = new ObjekatWebServis();

            string pomocnaZaAdresu = "";

            for (uint i = 0; i < jsonObjekti.Count; i++)
            {
                IJsonValue jsonValue;

                var objekatWebServis = new ObjekatWebServis();

                if (jsonObjekti.GetObjectAt(i).TryGetValue("name", out jsonValue))
                {
                    objekatWebServis.Ime = jsonValue.GetString();
                }

                var location = jsonObjekti.GetObjectAt(i).GetNamedObject("location");

                if (location.GetObject().TryGetValue("street", out jsonValue))
                {
                    pomocnaZaAdresu = jsonValue.GetString();
                }

                if (location.GetObject().TryGetValue("zip", out jsonValue))
                {
                    pomocnaZaAdresu += "\n" + jsonValue.GetString();
                }

                if (location.GetObject().TryGetValue("city", out jsonValue))
                {
                    pomocnaZaAdresu += " " + jsonValue.GetString();
                }

                if (location.GetObject().TryGetValue("country", out jsonValue))
                {
                    pomocnaZaAdresu += "\n" + jsonValue.GetString();
                }

                objekatWebServis.Adresa = pomocnaZaAdresu;

                var id = jsonObjekti.GetObjectAt(i).GetNamedString("id");

                objekatWebServis.Id = id;

                


                objektiWebServis.Add(objekatWebServis);

                if (i == 4 || i == (jsonObjekti.Count - 1))
                    break;

            }

            foreach (var objekatWebServis in objektiWebServis)
            {
                string stringZaId = "https://graph.facebook.com/" + objekatWebServis.Id +"?q=iwatch&access_token=EAACEdEose0cBALNGuduF9LkxjN3G8y0X53ZBSrPTZCcRojiLp4RpSOjoKEo4ALymOnSZB5zlMTgHKoxZBVDd7vTHA6mf6ebpeR1yjUfVR1WZCmefvxtZCHCZCZAWsCWaD9CPJ9uvJGiZBIcX1KXgpY1xx4JEZBcNay367z94yuG0b1lAZDZD";
                string responseZaId = await httpClient.GetStringAsync(new Uri(stringZaId));
                JsonObject valueZaId = JsonValue.Parse(responseZaId).GetObject();

                IJsonValue jsonValue;

                if (valueZaId.GetObject().TryGetValue("likes", out jsonValue))
                {
                    objekatWebServis.BrojLikeova = jsonValue.GetNumber();
                }
                if (valueZaId.GetObject().TryGetValue("checkins", out jsonValue))
                {
                    objekatWebServis.BrojCheckinova = jsonValue.GetNumber();
                }
            }
            

            var ispisi = new List<string>();

            foreach (var objekatWebServis in objektiWebServis)
            {
                ispisi.Add("Naziv: " + objekatWebServis.Ime + "\n" +
                           "Adresa: " + "\n" + objekatWebServis.Adresa + "\n" +
                           "Broj lajkova: " + objekatWebServis.BrojLikeova.ToString() + "\n" +
                           "Broj checkIn-ova: " + objekatWebServis.BrojCheckinova.ToString() + "\n"
                          );
            }

            string ispis = "";

            foreach (var item in ispisi)
                ispis += item + "\n\n";


            textBlock.Text = ispis;

            }


    }
}
