using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviser
{
    class DefaultPodaci
    {
        public static void Initialize(AdviserDBContext context)
        {
            if (!context.Korisnici.Any())
            {
                Korisnik k = new Korisnik();
                k.ImeIPrezime = "Elza Kalač";
                k.Adresa = "Dragana Kulidžana";
                k.KorisnickoIme = "ekalac1";
                k.EMail = "elzaa_95@hotmail.com";
                k.Spol = Spol.Zensko;


                context.Korisnici.AddRange(k);
                context.SaveChanges();
            }
        }
    }
}
