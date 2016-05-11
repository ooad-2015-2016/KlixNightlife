using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    class Korisnik : Gost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KorisnikId { get; set; }
        public string ImeIPrezime { get; set; }
        //public DateTime DatumRodjenja { get; set; }
        public string KorisnickoIme { get; set; }
        public string EMail { get; set; }
        public Spol Spol { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        
        //evo, da bude cisto model, samo atributi 

       /* public Korisnik(string ime, string adresa, string brt, string korisnicko, string email, Spol s)
        {
            Ime = ime;

            KorisnickoIme = korisnicko;
            EMail = email;
            Spol = s;
            DatumRegistracije = DateTime.Now;
            Adresa = adresa;
            BrojTelefona = brt;
        } */
    }
}
