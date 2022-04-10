using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class Jednostka
    {
        private string nazwa;
        private string adres;
        List<Wykladowca> wykladowcy = new List<Wykladowca>();

        public string Nazwa
        {
            get { return nazwa; }
        }
        public string Adres
        {
            get { return adres; }
        }

        public Jednostka(string nazwa_, string adres_)
        {
            nazwa = nazwa_;
            adres = adres_;
        }

        public void DodajWykladowce(Wykladowca w)
        {
            wykladowcy.Add(w);
        }

        public bool UsunWykladowce(Wykladowca w)
        {
            for (int i = 0; i < wykladowcy.Count; i++)
            {
                if (wykladowcy[i] == w)
                {
                    wykladowcy.RemoveAt(i);
                    Console.WriteLine("Poprawnie usunieto");
                    return true;
                }

            }
            Console.WriteLine("Nie znaleziono wykladowcy");
            return false;
        }
        public bool UsunWykladowce(string imie, string nazwisko)
        {
            for (int i = 0; i < wykladowcy.Count; i++)
            {
                Wykladowca w = wykladowcy[i];
                if (w.Imie == imie && w.Nazwisko == nazwisko)
                {
                    wykladowcy.RemoveAt(i);
                    Console.WriteLine("Poprawnie usunieto");
                    return true;
                }
            }
            Console.WriteLine("Nie znaleziono wykladowcy");
            return false;


        }
        public void InfoWykladowcy()
        {
            for (int i = 0; i < wykladowcy.Count; i++)
            {
                wykladowcy[i].WypiszInfo();
            }
        }
        public void WypiszInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Nazwa jednostki:" + nazwa);
            Console.WriteLine("Adres:" + adres);
        }


    }
}
