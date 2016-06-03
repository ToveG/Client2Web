
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2WebInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            RegKeyHandler regKey = new RegKeyHandler();

            // gets the path to the application that is running
            // and adds that to the commandline in the registry. 
            string fullPath = Application.ExecutablePath;
            regKey.createNewRegistryKey(fullPath);

            //disbable warningdialogs in IE and edge. 
            regKey.disableProtocolPrompt();

            // send argruments in args to client2web if it exists,
            // else run setup.exe and install client2web
            string shortcutName = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Programs), "\\", "Formpipe AB", "\\", "Client2Web", ".appref-ms");
            if (File.Exists(shortcutName))
            {
                string arguments = "";
                foreach (var arg in args)
                {
                    arguments += arg + "&";
                }
                Process.Start(shortcutName, arguments);
            }
            else
            {
                fullPath = Path.Combine(ApplicationDeployment.CurrentDeployment.DataDirectory, "Binaries", "setup.exe");
                Process.Start(fullPath);
            }
        }
    }
}

