using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class Osoba : IInfo
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

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

        public string DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }

        public Osoba()
        {
            imie = "Yurii";
            nazwisko = "Snizhko";
            dataUrodzenia = "09/12/1999";
        }

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
            {
                imie = "Yurii";
                nazwisko = "Snizhko";
                dataUrodzenia = "09/12/1999";
            }

        public virtual void WypiszInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Imie:" + imie);
            Console.WriteLine("Nazwisko:" + nazwisko);
            Console.WriteLine("Data urodzenia:" + dataUrodzenia);
        }

    }


}

