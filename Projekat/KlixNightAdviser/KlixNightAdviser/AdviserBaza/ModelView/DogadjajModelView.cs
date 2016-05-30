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
        public List<Dogadjaj> VratiSveDogađaje()
        {
            var context = new AdviserDBContext();
            List<Dogadjaj> sviDogađaji = context.Dogadjaji.ToList();
            return sviDogađaji;
        }
        public List<Dogadjaj> VratiDogađajeObjekta(Objekat objekat)
        {
            List<Dogadjaj> sviDogađaji = VratiSveDogađaje();
            List<Dogadjaj> događajiObjekta = new List<Dogadjaj>();
            for (int i = 0; i < sviDogađaji.Count(); i++)
            {
                if (sviDogađaji[i].ObjekatId == objekat.Id)
                    događajiObjekta.Add(sviDogađaji[i]);
            }
            return događajiObjekta;
        }
    }
}
