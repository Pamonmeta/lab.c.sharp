using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium4
{
    class Person
    {
        public int Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        static int _id = 101;

        public Person(string Firstname_, string Lastname_, int Age_)
        {
            Firstname = Firstname_;
            Lastname = Lastname_;
            Age = Age_;

            Id = _id++;
        }

        public override string ToString() => $"{Firstname} {Lastname}. Wiek: {Age}. ID: {Id};";
    }
}
