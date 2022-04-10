using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class Wykladowca:Osoba
    {
        private string tytulNaukowy;
        private string stanowisko;

        public string TytulNaukowy
        {
            get { return tytulNaukowy; }
        }

        public string Stanowisko
        {
            get { return stanowisko; }
        }

        public Wykladowca()
        {
            tytulNaukowy = "Prof Pcz";
            stanowisko = "Wykladowca";
        }

        public Wykladowca( string tytulNaukowy_, string stanowisko_)
        {
            tytulNaukowy = tytulNaukowy_;
            stanowisko = stanowisko_;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine();
            base.WypiszInfo();
            Console.WriteLine("Tytul naukowy:" + tytulNaukowy);
            Console.WriteLine("Stanowisko:" + stanowisko);
        }
    }

}
