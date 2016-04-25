using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlixNightAdviser.ObjekatBaza.Models
{

    class Objekat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Vlasnik Vlasnik { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string TipObjekta { get; set; }
        public int Zvezdice { get; set; }
        public List<Ocjena> ListaOcjena { get; set; }
        public List<Komentar> ListaKomentara { get; set; }
        public string Mjesto { get; set; }
   

        public Objekat(Vlasnik vlasnik, string naziv, string adresa, string tipObjekta, int zvezdice, List<Ocjena> listaOcjena, List<Komentar> listaKomentara, string mjesto) 
        {
            Vlasnik = vlasnik;
            Naziv = naziv;
            Adresa= adresa;
            TipObjekta = tipObjekta;
            ListaOcjena = listaOcjena;
            ListaKomentara = listaKomentara;
            Mjesto = mjesto;

        }
    }
}
