using System;

namespace Laboratorium4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*zad 1
            var testList = new Lista<int>
            {
                1,2,3,4,5,6
            };

            int i1 = 0;
            foreach (var elem in testList)
            {
                Console.WriteLine($"{++i1}.{elem}");
            }
            testList.RemoveAt(3);

            i1 = 0;
            foreach (var elem in testList)
            {
                Console.WriteLine($"{++i1}.{elem}");
            }
            */

            /*zad 2*/
            var lista = new Lista<Person>
            {
                new Person("Kamil", "Ratakowski", 12),
                new Person("Alicja", "Nowak", 32),
                new Person("Karolina", "Tycha", 14),
                new Person("Mariusz", "Kowalski", 17),
                new Person("Michal", "Czestosz", 65)
            };

            Console.Write("\nOsoby:\n");
            int i = 0;
            foreach (var elem in lista)
            {
                Console.WriteLine($"{++i}.{elem}");
            }
            Console.WriteLine($"\nIlosz elementow: {lista.Count}");

            lista.RemoveAt(3);

            Console.Write("\nOsoby:\n");
            int j = 0;
            foreach (var elem in lista)
            {
                Console.WriteLine($"{++j}.{elem}");
            }
            Console.WriteLine($"\nIlosz elementow po usunieciu: {lista.Count}");

            Console.Write("\nOsoby pelnoletnie:\n");
            int k = 0;
            foreach (var elem in lista)
            {
                if (elem.Age > 18)
                    Console.WriteLine($"{++k}.{elem}");
            }
            Console.WriteLine($"\nIlosz osob pelnolenich: {k}");

            Console.ReadKey();
        }
    }
}
