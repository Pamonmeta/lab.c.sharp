using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*--------------------------zad 1---------------------------------*/
            Console.WriteLine("Zoo");
            Dyrekcja dyrektor = new Dyrekcja();

            Opiekuny o1 = new Opiekuny("Tymek", "Romanov");
            dyrektor.DodajOpiekuna(o1);
  
            Opiekuny o2 = new Opiekuny("Michal", "Kuc");
            dyrektor.DodajOpiekuna(o2);

            Zwierze z1 = new Zwierze("Gołąb", "nasiona", "centrum miasta");
            dyrektor.DodajNowegoZwierza(1, z1);

            Zwierze z2 = new Zwierze("Gołąb", "nasiona", "centrum miasta");
            dyrektor.DodajNowegoZwierza(2, z2);

            dyrektor.WypiszOpiekunow();
            dyrektor.WypiszKlatki();
            

            Console.ReadKey();


        }
    }
}
