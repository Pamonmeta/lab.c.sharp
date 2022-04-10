using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_5
{
    class wydzial
    {
        List<Przedmiot> przedmioty = new List<Przedmiot>();
        List<Student> studenci = new List<Student>();
        List<Jednostka> jednostki = new List<Jednostka>();

        public void DodajJednostke(string nazwa, string adres)
        {
            Jednostka j = new Jednostka(nazwa, adres);
            jednostki.Add(j);
        }
        public void DodajPrzedmiot(Przedmiot p)
        {
            przedmioty.Add(p);
        }
        public void DodajStudenta(Student s)
        {
            studenci.Add(s);
        }
        public bool DodajWykladowce(Wykladowca w, string nazwaJednostki)
        {
            for (int i = 0; i < jednostki.Count; i++)
            {
                if (jednostki[i].Nazwa == nazwaJednostki)
                {
                    jednostki[i].DodajWykladowce(w);
                    return true;
                }
            }
            return false;

        }

        public void InfoStudenci(bool infoOceny)
        {
            for (int i = 0; i < studenci.Count; i++)
            {
                studenci[i].WypiszInfo();
                if (infoOceny == true)
                {
                    studenci[i].InfoOceny();
                }
            }
        }
        public void InfoJednostki(bool infoWykladowcy)
        {
            for (int i = 0; i < jednostki.Count; i++)
            {
                jednostki[i].WypiszInfo();
                if (infoWykladowcy == true)
                {
                    jednostki[i].InfoWykladowcy();
                }
            }
        }
        public void InfoPrzedmioty()
        {
            for (int i = 0; i < przedmioty.Count; i++)
            {
                przedmioty[i].WypiszInfo();
            }
        }
        public bool DodajOcene(int nrIndeksu, Przedmiot p, double ocena, string data)
        {
            for (int i = 0; i < studenci.Count; i++)
            {
                if (studenci[i].NrIndeksu == nrIndeksu)
                {
                    studenci[i].DodajOceny(p, ocena, data);
                    return true;
                }

            }
            return false;


        }
        public bool UsunStudenta(int nrIndeksu)
        {
            for (int i = 0; i < studenci.Count; i++)
            {
                if (studenci[i].NrIndeksu == nrIndeksu)
                {
                    studenci.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }
        public bool PrzeniesWykladowce(Wykladowca w, string obecnaJednostka, string nowaJednostka)
        {
            for (int i = 0; i < jednostki.Count; i++)
            {
                if (jednostki[i].Nazwa == obecnaJednostka)
                {
                    jednostki[i].UsunWykladowce(w);
                }
                if (jednostki[i].Nazwa == nowaJednostka)
                {
                    jednostki[i].DodajWykladowce(w);
                }
                return true;
            }
            return false;
        }
    }
}
