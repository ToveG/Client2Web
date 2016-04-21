
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
//            myAppPath appPath = new myAppPath();
           

            string fullPath = Application.ExecutablePath;
            regKey.createNewRegistryKey(fullPath);
            regKey.disableProtocolPrompt();

            //w2c_service.w2cService service = new w2c_service.w2cService();
            //string application_status = "true";
            //service.AddWord(application_status);


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



        }



        }
    }

