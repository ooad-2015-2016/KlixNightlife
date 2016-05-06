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
                context.Korisnici.AddRange(new Korisnik("Elza Kalac", "Dragana Kulidžana", "066020564", "ekalac1", "elzaa_95@hotmail.com", Spol.Zensko));
                context.SaveChanges();
            }
        }
    }
}
