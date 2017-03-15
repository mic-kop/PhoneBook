using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person
    {
        public Person(string textname, string textsurname, int numberint)
        {
            name = textname;
            surname = textsurname;
            number = numberint;
        }
        private string name;
        private string surname;
        private int number;
        public string GetName() { return name; }
        public string GetSurname() { return surname; }
        public int GetNumber() { return number; }
    }
}
