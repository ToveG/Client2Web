using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2Web
{
    class myAppPath
    {
        string filename = "Client2Web.exe";
        public string fullPath { get; set; }
       
        public string GetFullPathForApp()
        {
            fullPath = Path.GetFullPath(filename);
            return fullPath;
        }

        //string fileName = "Client2Web.exe";
        //string fullPath;

        //fullPath = Path.GetFullPath(fileName);
        //    Console.WriteLine("GetFullPath('{0}') returns '{1}'",
        //    fileName, fullPath);

        
    }
}
