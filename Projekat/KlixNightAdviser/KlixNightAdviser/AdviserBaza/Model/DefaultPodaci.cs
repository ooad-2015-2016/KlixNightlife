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
            var korisnik = new Korisnik {
                Ime = "Elza Kalac",
                Adresa = "Dragana Kulidžana",
                BrojTelefona = "066020564",
                KorisnickoIme = "ekalac1",
                EMail = "elzaa_95@hotmail.com",
                Spol = Spol.Zensko,
                Sifra = "sifra"
            };
            var vlasnik = new Vlasnik {
                Ime = "Alem Luckin",
                Spol = Spol.Musko,
                Sifra = "sifra"
            };
            var objekat = new Objekat {
                Naziv = "Devetka",
                Tip = TipObjekta.Bistro,
                Mjesto = "Doglodi",
                Vlasnik = vlasnik
            };
            var dogadjaj = new Dogadjaj {
                Naziv = "Poker Night",
                Objekat = objekat,
                Tip = TipDogađaja.Ostalo,
                Datum = DateTime.Today,
                Vrijeme = DateTime.Now
            };
            var clanak = new Clanak {
                Naslov = "Sve top, gori"
            };
            var komentar = new Komentar {
                
                Korisnik = korisnik,
                Objekat = objekat,
                TekstKomentara = "Odlican bistro",
                Clanak = clanak
            };

            if (!context.Korisnici.Any())
            {
                context.Korisnici.AddRange(korisnik);
                context.SaveChanges();
            }
            if (!context.Vlasnici.Any())
            {
                context.Vlasnici.AddRange(vlasnik);
                context.SaveChanges();
            }
            //if (!context.Objekti.Any())
            //{
            //    context.Objekti.AddRange(objekat);
            //    context.SaveChanges();
            //}

            if (!context.Dogadjaji.Any())
            {
                context.Dogadjaji.Add(dogadjaj);
                context.SaveChanges();
            }
            if (!context.Clanci.Any())
            {
                context.Clanci.AddRange(clanak);
                context.SaveChanges();
            }
            //if (!context.Komentari.Any())
            //{
            //    context.Komentari.Add(komentar);
            //    context.SaveChanges();
            //}

        }
    }
}
