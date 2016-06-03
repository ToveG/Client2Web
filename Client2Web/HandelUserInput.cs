using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.IO;

    

namespace Client2Web
{
    class HandelUserInput : IWeb2Client
    {
        w2c_service.w2cService service = new w2c_service.w2cService();
        DocumentManagementService.DocumentManagementService documentService = new DocumentManagementService.DocumentManagementService();
 
        public object ApplicationDeployment { get; private set; }

        public string trimString(string stringToTrim)
        {
            string myString = stringToTrim;
            myString = myString.Substring(19);
            char[] MyChar = { '&'};
            string result = myString.TrimEnd(MyChar);
            return result;
        }

        public void downloadFile(string myArgument)
        {
            string docName = trimString(myArgument);
            string fileName = docName.Replace("{", " ");

            string filePath = @"C:\Client2Web\" + fileName;

            MemoryStream objstreaminput = new MemoryStream();
            FileStream objfilestream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);

            int len = (int)documentService.downloadDocumentLen(filePath.Remove(0, filePath.LastIndexOf("\\") + 1));
            Byte[] mybytearray = new Byte[len];
            mybytearray = documentService.downloadDocument(filePath.Remove(0, filePath.LastIndexOf("\\") + 1));
            objfilestream.Write(mybytearray, 0, len);
            objfilestream.Close();

            const string message = "Vill du ladda ner filen?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
        }

        public void getAssemblyVersion()
        {
          string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
          MessageBox.Show("Du använder version: " + assemblyVersion);
        }

        //set application-id to db via webService    
        public void registrateApplication(string myArguments)
        {
            var applicationId = trimString(myArguments);

            service.setUserId(applicationId);
        }
      }
    
}


