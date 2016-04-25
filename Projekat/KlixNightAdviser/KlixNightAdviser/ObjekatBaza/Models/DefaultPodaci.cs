
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.ObjekatBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(ObjekatDbContext context)
        {
            if (!context.Objekat.Any())
            {
              //  context.Objekat.AddRange(
            //    new Objekat('22', "Naziv", "Adresa", "TipObjekta", 5, Ocjene1, "Komentari", "Mjesto"));

                context.SaveChanges();
            }
        }
    }
}
