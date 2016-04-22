using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser
{
    public enum Spol { muski, zenski};
    class Korisnik : Gost
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int KorisnikID { get; set; }
       public string zatrebace { get; set; }
       public string Naziv { get; set; }
       public DateTime DatumRođenja { get; set; }
       public string Lozinka { get; set; }
       public string eMail { get; set; }
       public DateTime DatumRegistracije { get; set; }
       public Spol spol {get; set;}

        public Korisnik(string imePrezime, string korisnickoIme, string lozinka, DateTime datumRodjenja, string mail, Spol s) : base(korisnickoIme)
        {
            Naziv = imePrezime;
            Lozinka = lozinka;
            DatumRođenja = datumRodjenja;
            eMail = mail;
            DatumRegistracije = DateTime.Now;
            spol = s;
            
        }
      



    }
}
