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
            //sad nešto uraditi, al to treba sa icollection
            //ili sta već
        }

        private bool DodajVlasnikaUBazu(Vlasnik vlasnik)
        {
            //dodaš sad
            //i ako je uspjesno, vrati true, ako ne false
            //za sad predpostavimo da je true

            var context = new AdviserDBContext();
            
            context.Vlasnici.AddRange(vlasnik);
            context.SaveChanges();

            return true;
        }
    }
}
