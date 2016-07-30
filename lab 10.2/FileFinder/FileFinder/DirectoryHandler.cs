using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class DirectoryHandler
    {
       private  DirectoryInfo _directoryInfo;
       private FileInfo[] _directoryFiles;

       public DirectoryHandler(string url)
        {
            _directoryInfo = new DirectoryInfo(url);
            _directoryFiles = _directoryInfo.GetFiles();
        }
        public List<FileInfo> GetFilesContainString(string str)
        {
            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo file in _directoryFiles)
            {
                /**Bug: you are not disposing of the stream reader
             * Consider this:
             * https://msdn.microsoft.com/en-us/library/3bwa4xa9(v=vs.110).aspx
             */

                //I changed the variable name so that you will see its type clearly
                //Always know exactly what you are doing
                StreamReader fileReader = file.OpenText();
                var fileText = fileReader.ReadToEnd();
                if (fileText.Contains(str))
                    files.Add(file);
            }
            return files;
        }


    }
}
