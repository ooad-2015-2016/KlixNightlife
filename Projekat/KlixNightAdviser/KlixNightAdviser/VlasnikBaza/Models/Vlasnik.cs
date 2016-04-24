using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser
{
    public enum Spol { muski, zenski};
    class Vlasnik : Gost
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int VlasnikId { get; set; }
       public string zatrebace { get; set; }
       public string Naziv { get; set; }
       public DateTime DatumRodjenja { get; set; }
       public string Lozinka { get; set; }
       public string EMail { get; set; }
       public Spol Spol {get; set;}

        public Vlasnik(string imePrezime, string korisnickoIme, string lozinka, DateTime datumRodjenja, string mail, Spol spol) : base(korisnickoIme)
        {
            Naziv = imePrezime;
            Lozinka = lozinka;
            DatumRodjenja = datumRodjenja;
            EMail = mail;
            Spol = spol;
        }
      



    }
}
