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
            if (!context.Korisnici.Any())
            {
                context.Korisnici.AddRange(korisnik);
                context.SaveChanges();
            }
            var vlasnik = new Vlasnik {
                Ime = "Alem Luckin",
                Spol = Spol.Musko,
                Sifra = "sifra"
            };
            if (!context.Vlasnici.Any())
            {
                context.Vlasnici.AddRange(vlasnik);
                context.SaveChanges();
            }
            var ocjene = new List<int>()
            {
                5,
                4,
                5
            };
            var galerija = new Galerija();
            if (!context.Galerije.Any())
            {
                context.Galerije.Add(galerija);
                context.SaveChanges();
            }

            var clanak = new Clanak {
                Naslov = "Sve top, gori",
                Galerija = galerija,
                Tekst = "Ljubazno osobolje"
            };

            if (!context.Clanci.Any())
            {
                context.Clanci.AddRange(clanak);
                context.SaveChanges();
            }

            var objekat = new Objekat {
                Naziv = "Devetka",
                Tip = TipObjekta.Bistro,
                Vlasnik = vlasnik,
                Adresa = "Doglodi",
                Mjesto = "Doglodi",
                Galerija = galerija
            };
            if (!context.Objekti.Any())
            {
                context.Objekti.Add(objekat);
                context.SaveChanges();
            }
            var dogadjaj = new Dogadjaj {
                Naziv = "Poker Night",
                Objekat = objekat,
                Tip = TipDogađaja.Ostalo,
                Datum = DateTime.Today,
                Vrijeme = DateTime.Now,
            };
            if (!context.Dogadjaji.Any())
            {
                context.Dogadjaji.Add(dogadjaj);
                context.SaveChanges();
            }

            var komentar = new Komentar {

                Korisnik = korisnik,
                Objekat = objekat,
                TekstKomentara = "Odlican bistro",
                Clanak = clanak
            };
            if (!context.Komentari.Any())
            {
                context.Komentari.Add(komentar);
                context.SaveChanges();
            }


        }
    }
}
