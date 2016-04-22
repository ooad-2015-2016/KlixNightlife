
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.KorisnikBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(KorisnikDBContext context)
        {
            if (!context.Korisnici.Any())
            {
                context.Korisnici.AddRange(
                new Korisnik("Proba", "probno", "sifra", DateTime.Now, "mail", Spol.muski));
                
                context.SaveChanges();
            }
        }
    }
}
