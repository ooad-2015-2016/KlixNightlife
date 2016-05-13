using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    public class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Sifra { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string KorisnickoIme { get; set; }
        public string EMail { get; set; }
        public Spol Spol { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
    }
}
