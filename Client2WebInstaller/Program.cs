
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
            MessageBox.Show("Kommer jag ens hit?!");

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

                MessageBox.Show(arguments); 
                Process.Start(shortcutName, arguments);
            }
            else
            {
                MessageBox.Show("Når jag hit? till setup.exe.");
                fullPath = Path.Combine(ApplicationDeployment.CurrentDeployment.DataDirectory, "Binaries", "setup.exe");

                Process.Start(fullPath);
            }

            // MessageBox.Show("Din installation är nu klar.");


            //w2cservice.w2cService objservice = new w2cservice.w2cService();

            //w2cService2.w2cService client = new w2cService2.w2cService();
            //client.Hello("true");

        }

            //string word = "true";
            //objservice 

            //      Web2ClientServiceReferences.w2cServiceSoapClient client = new Web2ClientServiceReferences.w2cServiceSoapClient();
            //client.HelloWorld()

            //  CallWebService cws = new CallWebService();
          //  cws.call_w2c();

        }
    }
//}
