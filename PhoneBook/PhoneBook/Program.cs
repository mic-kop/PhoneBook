using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
/*
 * 16 marca 2017 deadline
Projekt w c#
Konsola lub okienka
Funkcjonalnosc ma byc:
-dodawanie kontaktow
-usuwanie kontaktu
-wyswietlanie wszystkich kontaktow
-wyszukiwanie kontaktow(po nazwie, czastkowej tzn "mil" znajdzie "Milen")
(Najlepiej dynamicznie w sensie wpisanie jednego znaku odswieza wyniki)
Opcjonalnie
-eksport kontaktow do jakiegos " standardowego" formatu (takie co potem mozna zaimportowac do tel czy cos)
Gl hf, clutch or kick
 */
namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Window());

            Interface Show = new Interface(); // start view
            Contacts x = new Contacts("contacts");
            int error;
            Show.StartText();

            //  FileOperation Contactse = new FileOperation("contacts");
            while (true)
            {
                Show.Menu();

                string keyStr;
                int keyInt;
                do
                {
                    try
                    {
                        Console.Write("your choice: ");
                        keyStr = Console.ReadLine();
                        keyInt = Int32.Parse(keyStr);
                    }
                    catch
                    {
                        Console.Write("Sorry, incorrect choice\r\n");
                        keyInt = 0;
                    }
                } while (keyInt == 0);
                Console.Write("_________________________________________\r\n");

                switch (keyInt)
                {
                    case 1: //show list of contacts
                        int length = x.GetLength();
                        for (int i = 0; i < length; i++)
                        {
                            Console.Write(i + 1 + "\t" + x.GetName(i) + " " + x.GetSurname(i) + "\r\n");
                            Console.Write("\t" + x.GetNumber(i) + "\r\n");
                        }
                        Console.Write("_________________________________________\r\n");
                        break;
                    case 2: // find contact
                        Console.Write("Search: ");
                        string text = Console.ReadLine();
                        int a = x.Find(text);
                        if (a >= 0)
                        {
                            Console.Write("_________________________________________\r\n");
                            Console.Write(a + 1 + "\t" + x.GetName(a) + " " + x.GetSurname(a) + "\r\n");
                            Console.Write("\t" + x.GetNumber(a) + "\r\n");
                        }
                        else { Console.Write("Not found \r\n"); }

                        break;
                    case 3: //new contact
                        Console.Write("New contact\r\n");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        if (name.Length == 0)
                        {
                            Console.Write("Sorry, incorrect name\r\n");
                            break;
                        }
                        Console.Write("Surname: ");
                        string surname = Console.ReadLine();
                        if (surname.Length == 0)
                        {
                            Console.Write("Sorry, incorrect surname\r\n");
                            break;
                        }
                        Console.Write("Number (only 9 numbers): ");
                        string number = Console.ReadLine();

                        if (number.Length > 9 || number.Length < 1 || int.Parse(number) < 0)
                        {
                            Console.Write("Sorry, incorrect number\r\n");
                        }
                        else
                        {
                            Person newPerson = new Person(name, surname, int.Parse(number));
                            error = x.Add(newPerson);
                            if (error == 1)
                            {
                                Console.Write("Sorry, add a new contact failed\r\n");
                            }
                            else
                            {
                                Console.Write("Successfully added a new contact\r\n");
                            }
                        }
                        break;
                    case 4://delete

                        Console.Write("Remove contact number: ");
                        int index = int.Parse(Console.ReadLine());
                        error = x.Delete(index - 1);
                        if (error == 1)
                        {
                            Console.Write("Sorry, removing a contact failed\r\n");
                        }
                        else
                        {
                            Console.Write("Successfully removed a contact\r\n");
                        }
                        break;
                    default:
                        Console.Write("SEE ");
                        System.Threading.Thread.Sleep(500);
                        Console.Write("YOU ");
                        System.Threading.Thread.Sleep(500);
                        Console.Write("SOON");
                        System.Threading.Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
