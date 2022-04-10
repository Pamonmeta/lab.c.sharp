using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Zwierze
    {
        private string gatunek;
        private string rodzaj_pozyw;
        private string pochodzenie;

        public string Gatunek
        {
            get { return gatunek; }
            set { gatunek = value; }
        }
        public string Rodzaj_pozyw
        {
            get { return rodzaj_pozyw; }
            set { rodzaj_pozyw = value; }
        }
        public string Pochodzenie
        {
            get { return pochodzenie; }
            set { pochodzenie = value; }
        }

        public Zwierze(string gatunek_, string rodzaj_pozyw_, string pochodzenie_)
        {
            gatunek = gatunek_;
            rodzaj_pozyw = rodzaj_pozyw_;
            pochodzenie = pochodzenie_;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("Gatunek: " + gatunek + ", Zywi sie: " + rodzaj_pozyw + ", Pochodzi: " + pochodzenie);
        }

    }
}
