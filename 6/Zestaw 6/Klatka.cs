using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Klatka
    {
        private List<Zwierze> zwierzeta = new List<Zwierze>();
        private int pojemnosc;
        private int nrKlatki;

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set { pojemnosc = value; }
        }
        public int Nrklatki
        {
            get { return nrKlatki; }
            set { nrKlatki = value; }
        }

        public Klatka(int pojemnosc_, int nrKlatki_)
        {
            pojemnosc = pojemnosc_;
            nrKlatki = nrKlatki_;
        }

        public void dodajZwierze(Zwierze z)
        {
            if (zwierzeta.Count < pojemnosc)
            {
                zwierzeta.Add(z);
            }
            else
            {
                Console.WriteLine("Nie ma miejsca");
            }
        }

            public void Sprzatanie()
            {
                Console.WriteLine("Klatka o numerze " + nrKlatki + " zostanie posprzatana ");
            }
            
            public void WypiszInfo()
            {
                Console.WriteLine("Numer klatki: " + nrKlatki + " Pojemnosc klatki " + pojemnosc);
                for (int i = 0; i < zwierzeta.Count; i++)
                {
                    zwierzeta[i].WypiszInfo();
                }
            }
    }
}
