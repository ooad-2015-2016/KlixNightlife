using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    public class Clanak
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public ICollection<Komentar> Komentari { get; set; }
        public ICollection<int> Ocjene { get; set; }
        public int GalerijaId { get; set; }
        public Galerija Galerija { get; set; }
    }
}
