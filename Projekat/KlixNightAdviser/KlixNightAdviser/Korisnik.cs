using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser
{
    public enum Spol { muski, zenski};
    class Korisnik : Gost
    {
        public Korisnik(string imePrezime, string korisnickoIme, string lozinka, DateTime datumRodjenja, string mail, Spol s) : base(korisnickoIme)
        {
            Naziv = imePrezime;
            Lozinka = lozinka;
            DatumRođenja = datumRodjenja;
            eMail = mail;
            DatumRegistracije = DateTime.Now;
            spol = s;
            
        }
        string Naziv { get; set; }
        DateTime DatumRođenja { get; }
        string Lozinka;
        string eMail { get; set; }
        DateTime DatumRegistracije { get; }
        Spol spol;



    }
}
