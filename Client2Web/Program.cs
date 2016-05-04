using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment;
using System.Deployment.Application;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;


namespace Client2Web
{
    class Program
    {
        static void Main(string[] args)
        {

            ApplicationDeployment updateCheck = ApplicationDeployment.CurrentDeployment;
            UpdateCheckInfo info = updateCheck.CheckForDetailedUpdate();

            if (info.UpdateAvailable)
            {
                updateCheck.Update();
                MessageBox.Show("En ny version fanns tillgänglig och din applikation har nu uppdaterats");
                return;
            }


            var cmdLine = "";

            var activation_data = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
            if (activation_data != null && activation_data.Length > 0)
            {
                cmdLine = activation_data[0];
            }




            HandelUserInput h = new HandelUserInput();

            if (cmdLine == "client2web:01&")
            {
                h.respondToUserInput01();
            }
            else if (cmdLine == "client2web:02&")
            {
                h.respondToUserInput02();
            }
            else if (cmdLine == "client2web:03&")
            {
                h.respondToUserInput03();
            }
            else if (cmdLine == "client2web:04&")
            {
                h.respondToUserInput04();
            }
            else if (cmdLine == "client2web:05&")
            {
                h.getAssemblyVersion();
            }

            else if (cmdLine.Contains("aliveId"))
            {
                h.registrateApplication(cmdLine);
            }
        }
    }
}

