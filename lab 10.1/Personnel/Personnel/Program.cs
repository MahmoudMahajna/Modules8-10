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
       /**
       * You are not handling exceptions at all, which is expected at this point in the course.
       * Consider this:
       * https://msdn.microsoft.com/en-us/library/ms164917.aspx
       */

        /**Bug: you are not disposing of the string reader
        * Consider this:
        * https://msdn.microsoft.com/en-us/library/3bwa4xa9(v=vs.110).aspx
        */
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
            foreach (var line in list)
            {
                Console.WriteLine(line);
            }
        }
    }
}
