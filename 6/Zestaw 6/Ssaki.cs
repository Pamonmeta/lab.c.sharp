using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Ssaki:Zwierze
    {
        private string nat_srodowisko;

        public string Nat_srodowisko
        {
            get { return nat_srodowisko; }
            set { nat_srodowisko = value; }
        }
        public Ssaki(string nat_srodowisko_, string gatunek_, string rodzaj_pozyw_, string pochodzenie_) : base(gatunek_, rodzaj_pozyw_, pochodzenie_)
        {
            nat_srodowisko = nat_srodowisko_;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Naturalne srodowisko :" + nat_srodowisko);
        }
    }
}
