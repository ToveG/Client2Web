using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2Web
{
    class myPath
    {
        string filename = "Client2Web.exe";
        public string fullPath { get; set; }

        public string GetFullPathForApp()
        {
            fullPath = Path.Combine(ApplicationDeployment.CurrentDeployment.DataDirectory, filename);
            return fullPath;
        }
    }
}
