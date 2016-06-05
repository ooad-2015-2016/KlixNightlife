using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAplikacija.Models
{
    public class Vlasnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string EMail { get; set; }

        public ICollection<Objekat> Objekti { get; set; }
    }
}