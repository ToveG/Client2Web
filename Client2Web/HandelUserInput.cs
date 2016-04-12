using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;





namespace Client2Web
{
    class HandelUserInput : IWeb2Client
    {
        public object ApplicationDeployment { get; private set; }

        public void respondToUserInput01()
        {
            
           
            Console.WriteLine("Kul att du valde nr1");
        }
        public void respondToUserInput02()
        {
            Console.WriteLine("Det här fungerade ju bra");
            Console.WriteLine("Number 2.");
        }
        public void respondToUserInput03()
        {
            Console.WriteLine("3-it´s a magic number.");
        }
        public void respondToUserInput04()
        {
            Console.WriteLine("Number 4 it is");
        }

        public void getAssemblyVersion()
        {
          string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine("Du använder version: " + assemblyVersion);
        }
            

    }
    
}


