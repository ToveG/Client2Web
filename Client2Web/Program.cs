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
            MessageBox.Show("Please debug me, because Im crashing");


            ApplicationDeployment updateCheck = ApplicationDeployment.CurrentDeployment;
            UpdateCheckInfo info = updateCheck.CheckForDetailedUpdate();

            if (info.UpdateAvailable)
            {

                updateCheck.Update();
                MessageBox.Show("En ny version fanns tillgänglig och din applikation har nu uppdaterats");
                return;
            }
            ////Application.Restart();

            string fullPath = Application.ExecutablePath;
            //  MessageBox.Show(fullPath);

            // string cmdLine = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData[0];
            // MessageBox.Show(cmdLine);

            var cmdLine = "";


            var aa = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
            if (aa != null && aa.Length > 0)
            {
                cmdLine = aa[0];
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
                else if (cmdLine == "client2web:06&")
                {
                    h.goToApp();
                }
            //    else if (cmdLine == "client2web:07&")
            //{
            //    ApplicationDeployment updateCheck2 = ApplicationDeployment.CurrentDeployment;
            //    UpdateCheckInfo info2 = updateCheck.CheckForDetailedUpdate();

            //    if (info.UpdateAvailable)
            //    {

            //        updateCheck2.Update();
            //        MessageBox.Show("En ny version fanns tillgänglig och din applikation har nu uppdaterats");
            //        return;
            //    }
            }

        //}

      



        //w2cservice.w2cService objservice = new w2cservice.w2cService();

        //string word = "true";
        //objservice 

        //      Web2ClientServiceReferences.w2cServiceSoapClient client = new Web2ClientServiceReferences.w2cServiceSoapClient();
        //client.HelloWorld()
    }
   


    }
//  }

