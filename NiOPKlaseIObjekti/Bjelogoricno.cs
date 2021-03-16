using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOPKlaseIObjekti
{
    class Bjelogoricno : Stablo
    {
        public Bjelogoricno(bool opadajuListovi) : base(opadajuListovi)
        {
        }
        public bool GetSetBjelogoricno { get; set; }
        public void Hrast(bool opadajuListovi)
        {
            Console.WriteLine("Ne opadaju listovi");


        }
    }
}
