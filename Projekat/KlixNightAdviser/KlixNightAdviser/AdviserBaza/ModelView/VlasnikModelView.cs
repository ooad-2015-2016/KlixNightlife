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
        public bool DodajObjekat(Objekat objekt, Vlasnik vlasnik)
        {
            var context = new AdviserDBContext();
            objekt.VlasnikId = vlasnik.Id;
            //pa kad doda galeriju, stavicemo neku drugu vrijednost
            objekt.GalerijaId = 1;
            context.Objekti.AddRange(objekt);
            context.SaveChanges();
            return true;

        }

        private bool DodajVlasnikaUBazu(Vlasnik vlasnik)
        {
            

            var context = new AdviserDBContext();
            
            context.Vlasnici.AddRange(vlasnik);
            context.SaveChanges();

            return true;
        }
        public PovratnaPoruka LoginVlasnika (string korisnicko_ime, string sifra)
        {
            var context = new AdviserDBContext();

            List<Vlasnik> listaVlasnika = context.Vlasnici.ToList();


            //kad login uspije, zapamtimo koji nam je to aktivanVlasnik
            //sad cemo napraviti nekog zamisljenog vlasnika
            //i reci da je on aktivan
            for (int i = 0; i < listaVlasnika.Count; i++)
                if (listaVlasnika[i].KorisnickoIme == korisnicko_ime)
                {
                    if (listaVlasnika[i].Sifra == sifra)
                    {
                        var obj = App.Current as App;
                        obj.aktivanVlasnik = listaVlasnika[i];
                        return PovratnaPoruka.LoginOK;
                    }
                        
                    else return PovratnaPoruka.PogresnaSifra;
                }
            return PovratnaPoruka.PogresanUsername;                       
        }

        public bool ObrisiObjekat(Objekat objekt)
        {
            var context = new AdviserDBContext();       
            context.RemoveRange(objekt);
            context.SaveChanges();
            return true;
        }

    }
}
