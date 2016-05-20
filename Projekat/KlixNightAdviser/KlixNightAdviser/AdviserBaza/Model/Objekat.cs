using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    public class Objekat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public TipObjekta Tip { get; set; }
        public ICollection<int> Ocjene { get; set; }
        public ICollection<Komentar> Komentari { get; set; }
        public int VlasnikId { get; set; }
        public Vlasnik Vlasnik { get; set; }
        public string Mjesto { get; set; }
        public int GalerijaId { get; set; }
        public Galerija Galerija { get; set; }
        public int DogadjajId { get; set; }
        public Dogadjaj Dogadjaj { get; set; }
        //ovdje treba biti lista događaja, popravi to :)
    }
}
