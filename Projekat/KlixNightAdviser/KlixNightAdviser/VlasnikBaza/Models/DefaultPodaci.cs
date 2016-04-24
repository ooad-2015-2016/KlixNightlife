
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.KorisnikBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(VlasnikDBContext context)
        {
            if (!context.Vlasnici.Any())
            {
                context.Vlasnici.AddRange(
                new Vlasnik("Proba", "probno", "sifra", DateTime.Now, "mail", Spol.muski));
                
                context.SaveChanges();
            }
        }
    }
}
