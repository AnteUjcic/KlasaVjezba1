using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOPKlaseIObjekti
{
    class Stablo
    {
        bool opadajuListovi;

        public Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }

        public bool GetSetListoviToPadajuOrNePadaju { get; set; }


    }
}
