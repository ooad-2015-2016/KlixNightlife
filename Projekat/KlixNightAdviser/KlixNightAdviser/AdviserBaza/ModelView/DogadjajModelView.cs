using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviser.AdviserBaza.ModelView
{
   public class DogadjajModelView
    {
        public bool DodajDogađaj(string nazivDogađaja, DateTime datum, DateTime vrijeme, Objekat objekat)
        {
            Dogadjaj događaj = new Dogadjaj();
            {
                događaj.Naziv = nazivDogađaja;
                događaj.Datum = datum.Date;
                događaj.Vrijeme = vrijeme;
                događaj.Objekat = objekat;
                događaj.ObjekatId = objekat.Id;
                događaj.Tip = TipDogađaja.Svirka;
            }
            var context = new AdviserDBContext();
            context.Dogadjaji.AddRange(događaj);
            context.SaveChanges();
            return true;
        }
    }
}
