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
        public void DodajKorisnika(string ime, string adresa, string brojt, string korisnickoIme, string email, Spol s)
        {
            Korisnik noviKorisnik = new Korisnik();
            noviKorisnik.ImeIPrezime = ime;
            noviKorisnik.Adresa = adresa;
            noviKorisnik.BrojTelefona = brojt;
            noviKorisnik.KorisnickoIme = korisnickoIme;
            noviKorisnik.Spol = s;
            noviKorisnik.DatumRegistracije = DateTime.Now;
        }
    }
}
