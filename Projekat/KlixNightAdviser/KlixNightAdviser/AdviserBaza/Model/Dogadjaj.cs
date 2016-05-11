using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    public class Dogadjaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Vrijeme { get; set; }
        public int ObjekatId { get; set; }
        public Objekat Objekat { get; set; }
        public TipDogađaja Tip { get; set; }
        public byte[] Slika { get; set; }
    }
}
