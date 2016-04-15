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
        MessageBox.Show("Kul att du kämpar på iaf.");
        }
        public void respondToUserInput02()
        {
            MessageBox.Show("Number 2.");
        }
        public void respondToUserInput03()
        {
            MessageBox.Show("3-it´s a magic number.");
        }
        public void respondToUserInput04()
        {
            MessageBox.Show("Number 4 it is");
        }

        public void getAssemblyVersion()
        {
          string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MessageBox.Show("Du använder version: " + assemblyVersion);
        }
            
        public void goToApp()
        {

        }

    }
    
}


