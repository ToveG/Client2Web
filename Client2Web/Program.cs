using Client2Web.Web2ClientServiceReferences;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Client2Web
{
    class Program
    {
        static void Main(string[] args)
        {
            RegKeyHandler regKey = new RegKeyHandler();
            myAppPath appPath = new myAppPath();

            //Set the registrykey so that the warning prompt do not show in ie. 
            regKey.doNotOpenWarningPromptInExplorer();

            string fullPath = appPath.GetFullPathForApp();

            //checks if the registrykey for protocol exists. 
            //if not, it will create a new one
            string keyName = @"HKEY_CLASSES_ROOT\client2web";
            string valueName = "URL Protocol";
            if (Registry.GetValue(keyName, valueName, null) == null)
            {
                regKey.createNewRegistryKey(fullPath);
            }
            
            //handels the user inputs from web2client. 
            HandelUserInput h = new HandelUserInput();
            foreach (string s in args)
            {
                if (s == "client2web:01")
                {
                    h.respondToUserInput01();
                }
                else if (s == "client2web:02")
                {
                    h.respondToUserInput02();
                }
                else if (s == "client2web:03")
                {
                    h.respondToUserInput03();
                }
                else if (s == "client2web:04")
                {
                    h.respondToUserInput04();
                }
                else if (s == "client2web:05")
                {
                    h.getAssemblyVersion();

         

                }

                Console.ReadKey();
            }


    }
        //      Web2ClientServiceReferences.w2cServiceSoapClient client = new Web2ClientServiceReferences.w2cServiceSoapClient();
        //      client.HelloWorld()


    }
}

