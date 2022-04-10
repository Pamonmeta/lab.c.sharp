using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class Przedmiot : IInfo
    {
        private string nazwa;
        private string kierunek;
        private string specjalnosc;
        private int semestr;
        private int ilGodzin;

        public string Nazwa
        {
            get { return nazwa; }

        }
        public string Kierunek
        {
            get { return kierunek; }
        }
        public string Specjalnosc
        {
            get { return specjalnosc; }
        }
        public int Semestr
        {
            get { return semestr; }
        }
        public int IlGodzin
        {
            get { return ilGodzin; }
        }

        public Przedmiot()
        {
            nazwa = "Porgram_Obj";
            kierunek = "WIMiI";
            specjalnosc = "Informatyka";
            semestr = 0;
            ilGodzin = 0;
        }

        public Przedmiot(string nazwa_, string kierunek_, string specjalnosc_, int semestr_, int ilGodzin_)
        {
            nazwa = nazwa_;
            kierunek = kierunek_;
            specjalnosc = specjalnosc_;
            semestr = semestr_;
            ilGodzin = ilGodzin_;
        }
        public void WypiszInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Nazwa przedmiotu:" + nazwa);
            Console.WriteLine("Kierunek:" + kierunek);
            Console.WriteLine("Specjalnosc:" + specjalnosc);
            Console.WriteLine("Semestr:" + semestr);
            Console.WriteLine("Ilosc godzin:" + ilGodzin);
        }
    }
}
