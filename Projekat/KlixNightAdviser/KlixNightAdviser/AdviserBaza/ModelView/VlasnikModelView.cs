using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviser.AdviserBaza.ModelView
{
    class VlasnikModelView
    {
        public void DodajVlasnika(string ime, string adresa, string brojt, string korisnickoIme, string email, Spol s, string sifra)
        {
            Vlasnik noviVlasnik = new Vlasnik();
            noviVlasnik.Ime = ime;
            noviVlasnik.KorisnickoIme = korisnickoIme;
            noviVlasnik.EMail = email;
            noviVlasnik.Spol = s;
            noviVlasnik.Sifra = sifra;

            //Dodati još parametara
            bool provjera = DodajVlasnikaUBazu(noviVlasnik);
            if (provjera)
            {
                //ispisati poruku neku ili nešto
            }
            else
            {
                //nije uspio
            }
        }
        public void DodajObjekat(Objekat objekt, Vlasnik vlasnik)
        {
            //dodaj u bazu
            //ja pokusala, al nece
        }

        private bool DodajVlasnikaUBazu(Vlasnik vlasnik)
        {
            

            var context = new AdviserDBContext();
            
            context.Vlasnici.AddRange(vlasnik);
            context.SaveChanges();

            return true;
        }
        public bool LoginVlasnika (string korisničko_ime, string sifra)
        {
            //trazi u bazi ima li vlasnika
            //onda vratiš kog vlasnika koji se registrovao
            //sad za sad predpostavljamo da je login uspio


            //kad login uspije, zapamtimo koji nam je to aktivanVlasnik
            //sad cemo napraviti nekog zamisljenog vlasnika
            //i reci da je on aktivan
            Vlasnik v = new Vlasnik();
            {
                v.Ime = "Default Ime";
                v.EMail = "defaulf@etf.unsa.ba";
                v.DatumRodjenja = DateTime.Now;
                v.KorisnickoIme = "default";
                v.Sifra = "sifra";
                v.Spol = Spol.Musko;
            }
            var obj = App.Current as App;
            obj.aktivanVlasnik = v;



                return true;
        }
    }
}
