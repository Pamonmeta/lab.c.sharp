using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class Student:Osoba
    {
        private string kierunek;
        private string specjalnosc;
        private int rok;
        private int grupa;
        private int nrIndeksu;
        List<OcenaKoncowa> ocenyKoncowe = new List<OcenaKoncowa>();

        public string Kierunek
        {
            get { return kierunek; }
        }

        public string Specjalnosc
        {
            get { return specjalnosc; }
        }
        public int Rok
        {
            get { return rok; }
        }
        public int Grupa
        {
            get { return grupa; }
        }
        public int NrIndeksu
        {
            get { return nrIndeksu; }
        }

        public Student()
        {
            kierunek = "Informatyka";
            specjalnosc = "iinformatyka";
            rok = 0;
            grupa = 0;
            nrIndeksu = 0;
        }

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, string kierunek_, string specjalnosc_, int rok_, int grupa_, int nrIndeksu_) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            kierunek = kierunek_;
            specjalnosc = specjalnosc_;
            rok = rok_;
            grupa = grupa_;
            nrIndeksu = nrIndeksu_;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine();
            base.WypiszInfo();
            Console.WriteLine("Kierunek:" + kierunek);
            Console.WriteLine("Specjalnosc:" + specjalnosc);
            Console.WriteLine("Rok studiów:" + rok);
            Console.WriteLine("Grupa lab:" + grupa);
            Console.WriteLine("Numer indeksu:" + nrIndeksu);
        }

        public void InfoOceny()
        {
            for (int i = 0; i < ocenyKoncowe.Count; i++)
            {
                ocenyKoncowe[i].WypiszInfo();
            }
        }
        public bool DodajOceny(Przedmiot p, double ocena, string data)
        {
            OcenaKoncowa o = new OcenaKoncowa(ocena, data, p);
            ocenyKoncowe.Add(o);
            return true;
        } 
    }
}
