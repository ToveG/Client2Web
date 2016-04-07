using Client2Web.Web2ClientServiceReferences;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
            Console.ReadKey();

            RegKeyHandler regKey = new RegKeyHandler();

            string keyName = @"HKEY_CLASSES_ROOT\client2web";
            string valueName = "URL Protocol";
            if (Registry.GetValue(keyName, valueName, null) == null)
            {
                regKey.createNewRegistryKey();
            }
            else
            {
                Console.WriteLine("Du har redan rätt registernyckel.");
                Console.ReadKey();
            }


           
        
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

                 

              //      Web2ClientServiceReferences.w2cServiceSoapClient client = new Web2ClientServiceReferences.w2cServiceSoapClient();
              //      client.HelloWorld()

                }

                Console.ReadKey();
            }


    }



    }
}

