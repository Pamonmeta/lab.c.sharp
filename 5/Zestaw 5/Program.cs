using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            wydzial Wimii = new wydzial();

            Przedmiot p1 = new Przedmiot("PO", "Informatyka", "iinformatyka", 4, 60);
            Przedmiot p2 = new Przedmiot("SO", "Informatyka", "iinformatyka", 4, 70);
            Przedmiot p3 = new Przedmiot("IO", "Informatyka", "iinformatyka", 4, 70);
            Przedmiot p4 = new Przedmiot("PN", "Informatyka", "iinformatyka", 4, 70);
            Przedmiot p5 = new Przedmiot("PP", "Informatyka", "iinformatyka", 4, 60);
            Przedmiot p6 = new Przedmiot("GKiW", "Informatyka", "iinformatyka", 4, 60);

            Wimii.DodajPrzedmiot(p1);
            Wimii.DodajPrzedmiot(p2);
            Wimii.DodajPrzedmiot(p3);
            Wimii.DodajPrzedmiot(p4);
            Wimii.DodajPrzedmiot(p5);
            Wimii.DodajPrzedmiot(p6);
            Wimii.InfoPrzedmioty();

            Wimii.DodajJednostke("KISI", "Ul. Dabrowskiego 69, 42-218 Czestochowa");
            Wimii.InfoJednostki(false);

            Student s1 = new Student("Snizhko", "Yurii", "09/12/1999", "WIMiI", "Informatyka", 2, 8, 132602);
            Wimii.DodajStudenta(s1);
            Wimii.InfoStudenci(false);
            Wimii.UsunStudenta(132629);

            Wimii.DodajOcene(132602, p1, 5, "01/06/21");
            Wimii.DodajOcene(132602, p2, 5, "02/06/21");
            Wimii.DodajOcene(132602, p3, 5, "03/06/21");
            Wimii.DodajOcene(132602, p4, 5, "04/06/21");
            Wimii.DodajOcene(132602, p5, 5, "05/06/21");
            Wimii.DodajOcene(132602, p6, 5, "06/06/21");

            Wimii.InfoStudenci(true);

            Console.ReadKey();
        }
    }
}
