using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class OcenaKoncowa : IInfo
    {
        private double wartosc;
        private string data;
        Przedmiot p;

        public double Wartosc
        {
            get { return wartosc; }

        }
        public string Data
        {
            get { return data; }
        }

        public OcenaKoncowa()
        {
            wartosc = 0.0;
            data = "the first of May";
        }

        public OcenaKoncowa(double wartosc_, string data_, Przedmiot p_)
        {
            wartosc = wartosc_;
            data = data_;
            p = p_;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Ocena" + wartosc);
            Console.WriteLine("Data" + data);
            p.WypiszInfo();
        }
    }
}
