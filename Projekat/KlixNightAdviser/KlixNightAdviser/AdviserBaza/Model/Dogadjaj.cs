using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    class Dogadjaj
    {
        public int DogadjajId { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Vrijeme { get; set; }
        public int ObjekatId { get; set; }
        public Objekat Objekat { get; set; }
        public TipDogađaja Tip { get; set; }
        public byte[] Slika { get; set; }
    }
}
