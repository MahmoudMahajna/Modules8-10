using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndPrintFile(Directory.GetCurrentDirectory() + @"\..\..\names.txt");
        }
        static void ReadAndPrintFile(string url)
        {
            StreamReader sr = new StreamReader(url);
            var list = new List<string>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                list.Add(line);
            }
            PrintList(list);
        }

        private static void PrintList(List<string> list)
        {
            foreach(var line in list)
            {
                Console.WriteLine(line);
            }
        }
    }
}
