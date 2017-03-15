using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class FileOperation
    {
        private string name;
        private string path;
        private TextReader fileReader;
        private TextWriter fileWriter;
        public FileOperation(string filename)
        {
            name = filename;
            path = name + ".txt";

            if (!File.Exists(path))
            {
                fileWriter = File.CreateText(path);
            }
        }
        public int Write(string text)
        {
            using (fileWriter = new System.IO.StreamWriter(path, true))
            {
                fileWriter.WriteLine(text);
            }
            return 0;
        }
        public string[] ReadAll()
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            return lines;
        }
        public int Append(Person x)
        {
            try
            {
                File.AppendAllText(path, x.GetName() + "\r\n");
                File.AppendAllText(path, x.GetSurname() + "\r\n");
                File.AppendAllText(path, x.GetNumber().ToString() + "\r\n");
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public int Rewrite(List<Person> list)
        {
            try
            {
                int length = list.Count;
                File.WriteAllText(path, "");
                for (int i = 0; i < length; i++)
                {
                    File.AppendAllText(path, list[i].GetName() + "\r\n");
                    File.AppendAllText(path, list[i].GetSurname() + "\r\n");
                    File.AppendAllText(path, list[i].GetNumber().ToString() + "\r\n");
                }
                return 0;
            }
            catch
            {
                return 1;
            }
        }
    }
}
