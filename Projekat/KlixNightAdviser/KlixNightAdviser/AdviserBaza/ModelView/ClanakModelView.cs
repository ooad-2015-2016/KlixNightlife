using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviser.AdviserBaza.ModelView
{
    class ClanakModelView
    {
        public void DodajClanak()
        {

        }
        public List<Clanak> VratiSveClanke()
        {
            var context = new AdviserDBContext();
            return context.Clanci.ToList();

        }
    }
}
