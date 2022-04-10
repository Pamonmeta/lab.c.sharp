using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Gady:Zwierze
    {
        private bool jadowitosc;

        public bool Jadowitosc
        {
            get { return jadowitosc; }
            set { jadowitosc = value; }
        }

        public Gady(bool jadowitosc_, string gatunek_, string rodzaj_pozyw_, string pochodzenie_) : base(gatunek_, rodzaj_pozyw_, pochodzenie_)
        {
            jadowitosc = jadowitosc_;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Jadowitosc" + jadowitosc);
        }

    }
}
