using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviser.AdviserBaza.ModelView
{
    class KorisnikModelView
    {
        public void DodajKorisnika(string ime, string adresa, string brojt, string korisnickoIme, string email, Spol s, string sifra)
        {
            Korisnik noviKorisnik = new Korisnik();
            noviKorisnik.Ime = ime;
            noviKorisnik.Adresa = adresa;
            noviKorisnik.BrojTelefona = brojt;
            noviKorisnik.KorisnickoIme = korisnickoIme;
            noviKorisnik.Spol = s;
            noviKorisnik.DatumRegistracije = DateTime.Now;
            noviKorisnik.Sifra = sifra;

            var provjeriUnosKorisnika = DodajKorisnikaUBazu(noviKorisnik);
            //moras prvo provjeriti 
            //ima li vec takvo korisnicno ime u bazi
            if (provjeriUnosKorisnika)
            {
                // 
            }
            else
            {
                //
            }
           
        }

        private bool DodajKorisnikaUBazu(Korisnik korisnik)
        {
            var context = new AdviserDBContext();

            context.AddRange(korisnik);
            context.SaveChanges();

            return true; 
        }
        public bool LoginKorisnika(string korisnicko_ime, string sifra)
        {
            return true;
        }
    }
}
