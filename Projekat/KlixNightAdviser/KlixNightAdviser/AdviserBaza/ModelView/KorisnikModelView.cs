using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviser.AdviserBaza.ModelView
{
    public enum PovratnaPoruka { LoginOK, PogresnaSifra, PogresanUsername}
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

            context.Korisnici.AddRange(korisnik);
            context.SaveChanges();

            return true; 
        }
        public PovratnaPoruka LoginKorisnika(string korisnicko_ime, string sifra)
        {
            var context = new AdviserDBContext();
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            listaKorisnika = (List<Korisnik>)context.Korisnici.ToList();
            for (int i=0; i<listaKorisnika.Count; i++)
                if (listaKorisnika[i].KorisnickoIme==korisnicko_ime)
                {
                    if (listaKorisnika[i].Sifra == sifra) 
                            {
                        var obj = App.Current as App;
                        obj.aktivanKorisnik= listaKorisnika[i];
                        return PovratnaPoruka.LoginOK;
                    }
                            
                    else return PovratnaPoruka.PogresnaSifra;
                }
            return PovratnaPoruka.PogresanUsername;
        }
        public void DodajKomentar(Objekat objekat, Korisnik korisnik, string tekstKomentara)
        {

        }

        
    }
}
