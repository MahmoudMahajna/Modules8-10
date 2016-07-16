using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dh = new DirectoryHandler(args[0]);
                var files = dh.GetFilesContainString(args[1]);
                print(files);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        private static void print(IEnumerable<FileInfo> list)
        {
            foreach(FileInfo file in list)
            {
                Console.WriteLine($"File Name= {file.Name}, Lenght= {file.Length}");
            }
        }
    }
}
