using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviser.AdviserBaza.ModelView
{
    class KomentarModelView
    {
        public void DodajKomentar(Objekat objekat, Korisnik korisnik, string tekstKomentara)
        {
            Komentar noviKomentar = new Komentar();
            {
                noviKomentar.KorisnikId = korisnik.Id;
                noviKomentar.ObjekatId = objekat.Id;
                noviKomentar.TekstKomentara = tekstKomentara;
                noviKomentar.ClanakId = 1;
            }
            var context = new AdviserDBContext();
            context.Komentari.AddRange(noviKomentar);
            context.SaveChanges();
        }
        public List<Komentar> SviKomentari()
        {
            var context = new AdviserDBContext();
            context.Dogadjaji.ToList();
          
            return context.Komentari.ToList();
        }
        public List<Komentar> KomentariObjekta(Objekat objekat)
        {
            var context = new AdviserDBContext();
            List<Komentar> sviKomentari = SviKomentari();
            List<Komentar> KomentariObjekta = new List<Komentar>();
            for (int i=0; i<sviKomentari.Count; i++)
            {
                if (sviKomentari[i].ObjekatId == objekat.Id)
                    KomentariObjekta.Add(sviKomentari[i]);
            }
            return KomentariObjekta;
        }
    }
}
