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



    }
}

