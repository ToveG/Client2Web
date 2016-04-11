using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2Web
{
    class RegKeyHandler
    {
        public void doNotOpenWarningPromptInExplorer()
        {
           RegistryKey c2w = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\ProtocolExecute\client2web");
           addStringValueToKey(c2w, "", "");
           addDWORDValueToKey(c2w, "WarnOnOpen", 0);
            
        }
        public void createNewRegistryKey()
        {
            RegistryKey mainKey = createKey("client2web");
            RegistryKey IconKey = mainKey.CreateSubKey("DefaultIcon");
            RegistryKey ShellKey = mainKey.CreateSubKey("Shell");
            RegistryKey OpenKey = ShellKey.CreateSubKey("Open");
            RegistryKey CommandKey = OpenKey.CreateSubKey("Command");

            openKey(mainKey, "client2web");
            addStringValueToKey(mainKey, "", "URL: client2web Protocol");
            addStringValueToKey(mainKey, "URL Protocol", "");
            openKey(IconKey, "client2web\\DefaultIcon");
            addStringValueToKey(IconKey, "", "Client2Web.exe.deploy,1");
            openKey(ShellKey, "client2web\\Shell");
            addStringValueToKey(ShellKey, "", "open");
            openKey(OpenKey, "client2web\\Shell\\Open");
            addStringValueToKey(OpenKey, "", "");
            openKey(CommandKey, "client2web\\Shell\\Open\\Command");
            addStringValueToKey(CommandKey, "", "\"C:\\Users\\Administrator\\Desktop\\Client2Web\\Client2Web\\bin\\Debug\\Client2Web.exe\" \"%1\"");

            mainKey.Close();
            IconKey.Close();
            ShellKey.Close();
            OpenKey.Close();
            CommandKey.Close();

        }
        public RegistryKey createKey(string keyValue)
        {
            RegistryKey keyName = Registry.ClassesRoot.CreateSubKey(keyValue);

            return keyName;
        }


        public void addDWORDValueToKey(RegistryKey keyName, string value1, int value2)
        {
            keyName.SetValue(value1, value2, RegistryValueKind.DWord);
        }

        public void addStringValueToKey(RegistryKey keyName, string value1, string value2)
        {
            keyName.SetValue(value1, value2, RegistryValueKind.String);
        }
        public void openKey(RegistryKey keyName, string valueOfKey)
        {
            keyName.OpenSubKey(valueOfKey, true);
        }


   







       

    }
}

