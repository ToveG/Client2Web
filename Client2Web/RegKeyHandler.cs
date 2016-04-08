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
        public void createNewRegistryKey()
        {
            RegistryKey mainKey = createKey("client2web");
            RegistryKey IconKey = mainKey.CreateSubKey("DefaultIcon");
            RegistryKey ShellKey = mainKey.CreateSubKey("Shell");
            RegistryKey OpenKey = ShellKey.CreateSubKey("Open");
            RegistryKey CommandKey = OpenKey.CreateSubKey("Command");

            openKey(mainKey, "client2web");
            addValueToKey(mainKey, "", "URL: client2web Protocol");
            addValueToKey(mainKey, "URL Protocol", "");
            openKey(IconKey, "client2web\\DefaultIcon");
            addValueToKey(IconKey, "", "Client2Web.exe.deploy,1");
            openKey(ShellKey, "client2web\\Shell");
            addValueToKey(ShellKey, "", "open");
            openKey(OpenKey, "client2web\\Shell\\Open");
            addValueToKey(OpenKey, "", "");
            openKey(CommandKey, "client2web\\Shell\\Open\\Command");
            addValueToKey(CommandKey, "", "\"C:\\Users\\Administrator\\Source\\Client2Web Project\\Client2Web\\Client2Web\\bin\\Debug\\Client2Web.exe\" \"%1\"");

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


        public void addValueToKey(RegistryKey keyName, string value1, string value2)
        {
            keyName.SetValue(value1, value2, RegistryValueKind.String);
        }

        public void openKey(RegistryKey keyName, string valueOfKey)
        {
            keyName.OpenSubKey(valueOfKey, true);
        }


       

    }
}

