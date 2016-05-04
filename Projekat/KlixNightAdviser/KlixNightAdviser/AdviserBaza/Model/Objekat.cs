using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    class Objekat
    {
        public int ObjekatId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public TipObjekta Tip { get; set; }
        public ICollection<int> Ocjene { get; set; }
        public int KomentarId { get; set; }
        public ICollection<Komentar> Komentari { get; set; }
        public int VlasnikId { get; set; }
        public Vlasnik Vlasnik { get; set; }
        public string Mjesto { get; set; }
    }
}
