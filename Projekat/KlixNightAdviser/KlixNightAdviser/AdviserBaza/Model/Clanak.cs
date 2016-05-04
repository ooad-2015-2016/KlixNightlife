using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    class Clanak
    {
        public int ClanakId { get; set; }
        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public ICollection<Komentar> Komentari { get; set; }
        public ICollection<Ocjena> Ocjene { get; set; }
    }
}
