using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_6
{
    class Person
    {
        private string imie;
        private string nazwisko;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public Person(string imie_, string nazwisko_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }
        public virtual void WypiszInfoPerson()
        {
            Console.WriteLine("Imie: " + imie + " " + ", Nazwisko: " + nazwisko);
        }
    }
}
