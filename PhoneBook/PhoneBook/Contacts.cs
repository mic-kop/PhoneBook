using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contacts
    {
        private List<Person> list = new List<Person>();
        private string pathname;
        private string name;
        private string surname;
        private string strnumber;
        private int number;
        FileOperation file;
        public Contacts(string filename)
        {
            pathname = filename;

            FileOperation file = new FileOperation(filename);
            try
            {
                string[] lines = file.ReadAll();

                //  Person x = new Person(name, surname, number);

                for (int i = 0; i + 3 <= lines.Length; i = i + 3)
                {
                    name = lines[i];
                    surname = lines[i + 1];
                    strnumber = lines[i + 2];
                    number = int.Parse(strnumber);

                    Person x = new Person(name, surname, number);
                    list.Add(x);
                }
                //
                List<Person> SortedList = list.OrderBy(o => o.GetSurname()).ToList();
                list = SortedList;
                
                //
            }
            catch {
                Environment.Exit(0);
            }
        }
        ~Contacts()
        {
            list.Clear();
        }
        public int Add(Person x)
        {
            FileOperation file = new FileOperation(pathname);
            try
            {
                list.Add(x);
                int error = file.Append(x);
                if (error == 1) { return 1; }
                List<Person> SortedList = list.OrderBy(o => o.GetSurname()).ToList();
                list = SortedList;
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public int GetLength()
        {
            return list.Count;
        }
        public int Save()
        {
            try
            {
                file.Rewrite(list);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public int Delete(int index)
        {
            try
            {
                FileOperation file = new FileOperation(pathname);

                list.RemoveAt(index);
                int error = file.Rewrite(list);
                if (error == 1) { return 1; }
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public string GetName(int index)
        {
            return list[index].GetName();
        }
        public string GetSurname(int index)
        {
            return list[index].GetSurname();
        }
        public int GetNumber(int index)
        {
            return list[index].GetNumber();
        }
        public int Find(string text)
        { //return -1 if sth goes wrong
            try
            {
                int index;
                int number;
                try { number = int.Parse(text); }
                catch { number = 0; }
                //////////////////////
                for (int i = 0; i <= GetLength(); i++)
                {
                    index = list[i].GetName().IndexOf(text, 0);
                    if (index != -1)
                    {
                        index = i;
                        return index;
                    }
                    index = list[i].GetSurname().IndexOf(text, 0);
                    if (index != -1)
                    {
                        index = i;
                        return index;
                    }
                    index = list[i].GetNumber().ToString().IndexOf(text, 0);
                    if (index != -1)
                    {
                        index = i;
                        return index;
                    }
                }
                return -1;
                /////////////////////
            }
            catch
            {
                return -1;
            }
        }
    }
}
