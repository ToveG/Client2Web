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

            string fullPath = Application.ExecutablePath;
            MessageBox.Show(fullPath);

            string cmdLine = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData[0];
       //     MessageBox.Show(cmdLine);

            HandelUserInput h = new HandelUserInput();
            //    foreach (string s in args)

            //  {
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

        //}


    }
        //w2cservice.w2cService objservice = new w2cservice.w2cService();

        //string word = "true";
        //word = objservice.Hello(word);

        //      Web2ClientServiceReferences.w2cServiceSoapClient client = new Web2ClientServiceReferences.w2cServiceSoapClient();
        //      client.HelloWorld()


    }
}

