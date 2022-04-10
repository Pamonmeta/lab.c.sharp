using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Dyrekcja
    {
        private List<Opiekuny> opiekunowie = new List<Opiekuny>();
        private List<Klatka> klatki = new List<Klatka>();

        public void BudoanieKlatke(Klatka k)
        {
            klatki.Add(k);
        }
        public void DodajOpiekuna(Opiekuny o)
        {
            opiekunowie.Add(o);
        }

        public void DodajNowegoZwierza(int NrKlatki_, Zwierze z)
        {
            for (int i = 0; i < klatki.Count; i++)
            {
                if (klatki[i].Nrklatki == NrKlatki_)
                {
                    klatki[i].dodajZwierze(z);
                }
            }
        }

        public void PowiekszKlatke(int NrKlatki_)
        {
            for (int i = 0; i < klatki.Count; i++)
            {
                if (klatki[i].Nrklatki == NrKlatki_)
                {
                    klatki[i].Pojemnosc++;
                }
            }
        }
        public void WypiszKlatki()
        {
            for (int i = 0; i < klatki.Count; i++)
            {
                klatki[i].WypiszInfo();
            }
        }
        public void WypiszOpiekunow()
        {
            for (int i = 0; i < opiekunowie.Count; i++)
            {
                opiekunowie[i].WypiszInfoPerson();
            }
        }
    }
}
