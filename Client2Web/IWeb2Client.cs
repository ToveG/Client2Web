using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2Web
{
    interface IWeb2Client
    {
        void downloadFile(string myArgument);
        void getAssemblyVersion();
    }
}
