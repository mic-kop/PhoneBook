using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Interface
    {
        public void StartText()
        {
            Console.Write("__________________________________________\r\n");
            Console.Write("\tWELCOME TO THE PROGRAM\r\n");
            Console.Write("\t\tPHONE BOOK\r\n");
            Console.Write("\t\tversion 1.0\r\n");
            Console.Write("\t\tby Mic-Kop\r\n");
            Console.Write("_________________________________________\r\n\r\n");
        }

        public void Menu()
        {
            Console.Write("\t_________________________\r\n");
            Console.Write("\t_ select:\t\t_\r\n");
            Console.Write("\t_ \t\t\t_\r\n");
            Console.Write("\t_ 1: List of contacts\t_\r\n");
            Console.Write("\t_ 2: Find contact\t_\r\n");
            Console.Write("\t_ 3: Add contact\t_\r\n");
            Console.Write("\t_ 4: Remove contact\t_\r\n");
            Console.Write("\t_ 5: Exit\t\t_\r\n");
            Console.Write("\t_________________________\r\n");
        }

    }
}
