using System;
using System.Collections.Generic;
using System.Deployment.Application;
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

            MessageBox.Show("C2wInstaller");
            //ApplicationDeployment updateCheck = ApplicationDeployment.CurrentDeployment;
            //UpdateCheckInfo info = updateCheck.CheckForDetailedUpdate();

            //if (info.UpdateAvailable)
            //{
            //    updateCheck.Update();
            //    MessageBox.Show("uppdaterar");
            //    Application.Restart();
            //}

            RegKeyHandler regKey = new RegKeyHandler();
            myAppPath appPath = new myAppPath();

            string fullPath = appPath.GetFullPathForApp();

            regKey.createNewRegistryKey(fullPath);
            regKey.disableProtocolPrompt();

            MessageBox.Show("Din installation är nu klar.");
        }
    }
}
