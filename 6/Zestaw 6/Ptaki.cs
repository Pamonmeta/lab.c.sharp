using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Ptaki : Zwierze
    {
        private double rozpietosc;
        private double wytrzymalosc;

        public double Rozpietosc
        {
            get { return rozpietosc; }
            set { rozpietosc = value; }
        }
        public double Wytrzymalosc
        {
            get { return wytrzymalosc; }
            set { wytrzymalosc = value; }
        }
        public Ptaki(double rozpietosc_, double wytrzymalosc_, string gatunek_, string rodzaj_pozyw_, string pochodzenie_) : base(gatunek_, rodzaj_pozyw_, pochodzenie_)
        {
            rozpietosc = rozpietosc_;
            wytrzymalosc = wytrzymalosc_;
        }

        public void LotBezOdpocz(double rozpietosc_, double wytrzymalosc_)
        {
            double wynik = 0.0;
            wynik = rozpietosc_ * wytrzymalosc_;
            Console.WriteLine("Lot ptaka jest rowny" + wynik);
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rozpietosc skrzydel = " + rozpietosc + "Wytrzymalosc =" + wytrzymalosc);
        }
    }
}
