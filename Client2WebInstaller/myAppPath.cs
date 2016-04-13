using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2WebInstaller
{
    class myAppPath
    {
        string filename = "Binaries\\Client2Web.exe";
        public string fullPath { get; set; }

        public string GetFullPathForApp()
        {
            fullPath = Path.Combine(ApplicationDeployment.CurrentDeployment.DataDirectory, filename);
            return fullPath;
        }
    }
}
