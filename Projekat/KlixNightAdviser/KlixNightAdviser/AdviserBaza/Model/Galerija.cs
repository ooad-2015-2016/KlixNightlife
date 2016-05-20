using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    public class Galerija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        ICollection<byte[]> Slike { get; set; }

        public virtual Clanak Clanak { get; set; }

        public virtual Objekat Objekat { get; set; }
    }
}
