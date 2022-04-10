using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Opiekuny : Person
    {
        private List<Klatka> osobneKlatki = new List<Klatka>();
        public Opiekuny(string imie_, string nazwisko_) : base(imie_, nazwisko_)
        {

        }
        public void SprzatanieKlatki()
        {
            for (int i = 0; i < osobneKlatki.Count; i++)
            {
                osobneKlatki[i].Sprzatanie();
            }
        }
        public void DodajKlatke(Klatka k)
        {
            osobneKlatki.Add(k);
        }
        public override void WypiszInfoPerson()
        {
            base.WypiszInfoPerson();
            for (int i = 0; i < osobneKlatki.Count; i++)
            {
                Console.Write("Klatka o numerze " + osobneKlatki[i].Nrklatki + " ");
            }
            Console.WriteLine();
        }
    }
}
