﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.AdviserBaza.Model
{
    public class Komentar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public string TekstKomentara { get; set; }
        public int ObjekatId { get; set; }
        public Objekat Objekat { get; set; }
        public int ClanakId { get; set; }
        public Clanak Clanak { get; set; }
    }
}
