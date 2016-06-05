using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAplikacija.Models
{
    public class Objekat
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Mjesto { get; set; }

        public int VlasnikId { get; set; }

        public virtual Vlasnik Vlasnik { get; set; }

    }
}