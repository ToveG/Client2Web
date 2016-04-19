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
            myAppPath appPath = new myAppPath();

            string fullPath = Application.ExecutablePath;

            regKey.createNewRegistryKey(fullPath);
            regKey.disableProtocolPrompt();

            string shortcutName = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Programs), "\\", "Formpipe AB", "\\", "PCF", ".appref-ms");
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

            // MessageBox.Show("Din installation är nu klar.");
        }
    }
}
