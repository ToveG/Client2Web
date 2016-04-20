using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2WebInstaller
{
    class RegKeyHandler
    {
        public string keyName { get; set; }
        public string valueName { get; set; }
        public string value { get; set; }
        public bool true_or_false { get; set; }
        public string appPath { get; set; }
        public string regKeyName { get; set; }
        public string regKeyValueName { get; set; }
        public bool doItExists { get; set; }
        public RegistryKey keysName { get; set; }


        public bool doRegKeyExist()
        {
            //regKeyName = @"HKEY_CLASSES_ROOT\client2web";
            regKeyName = @"HKEY_CURRENT_USER\Software\Classes\client2web";
            regKeyValueName = "URL Protocol";
            if (Registry.GetValue(regKeyName, regKeyValueName, null) == null)
            {
                return false;
            }
            else return true;
        }

        public void setCommandValue(string path)
        {
            appPath = path;
            true_or_false = cntrCommandValue();
            if (true_or_false != true)
            {
                Registry.SetValue(keyName, valueName, "\"" + appPath + "\" \"" + "%1\"");
            }
        }
        public bool cntrCommandValue()
        {
            value = getCommandValue();
            if (value != appPath)
            {
                return false;
            }
            else return true;
        }

        public string getCommandValue()
        {
            keyName = @"HKEY_CURRENT_USER\Software\Classes\client2web\Shell\Open\Command";
            //keyName = @"HKEY_CLASSES_ROOT\client2web\Shell\Open\Command";
            valueName = "";
            value = Registry.GetValue(keyName, valueName, null).ToString();
            return value;
        }


        public void createNewRegistryKey(string path)
        {
            doItExists = doRegKeyExist();
            if (doItExists == false)
            {
                RegistryKey client = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Classes\client2web");
                RegistryKey IconKey = client.CreateSubKey("DefaultIcon");
                RegistryKey ShellKey = client.CreateSubKey("Shell");
                RegistryKey OpenKey = ShellKey.CreateSubKey("Open");
                RegistryKey CommandKey = OpenKey.CreateSubKey("Command");
                //RegistryKey mainKey = createKey("client2web");
                //RegistryKey IconKey = mainKey.CreateSubKey("DefaultIcon");
                //RegistryKey ShellKey = mainKey.CreateSubKey("Shell");
                //RegistryKey OpenKey = ShellKey.CreateSubKey("Open");
                //RegistryKey CommandKey = OpenKey.CreateSubKey("Command");

                openKey(client, "client2web");
                addStringValueToKey(client, "", "URL: client2web Protocol");
                addStringValueToKey(client, "URL Protocol", "");
                openKey(IconKey, "client2web\\DefaultIcon");
                addStringValueToKey(IconKey, "", "Client2Web.exe.deploy,1");
                openKey(ShellKey, "client2web\\Shell");
                addStringValueToKey(ShellKey, "", "open");
                openKey(OpenKey, "client2web\\Shell\\Open");
                addStringValueToKey(OpenKey, "", "");
                openKey(CommandKey, "client2web\\Shell\\Open\\Command");
                addStringValueToKey(CommandKey, "", "\"" + path + "\" \"" + "%1\"");

                //                openKey(mainKey, "client2web");
                //addStringValueToKey(mainKey, "", "URL: client2web Protocol");
                //addStringValueToKey(mainKey, "URL Protocol", "");
                //openKey(IconKey, "client2web\\DefaultIcon");
                //addStringValueToKey(IconKey, "", "Client2Web.exe.deploy,1");
                //openKey(ShellKey, "client2web\\Shell");
                //addStringValueToKey(ShellKey, "", "open");
                //openKey(OpenKey, "client2web\\Shell\\Open");
                //addStringValueToKey(OpenKey, "", "");
                //openKey(CommandKey, "client2web\\Shell\\Open\\Command");
                //addStringValueToKey(CommandKey, "", "\"" + path + "\" \"" + "%1\"");

                //mainKey.Close();
                client.Close();
                IconKey.Close();
                ShellKey.Close();
                OpenKey.Close();
                CommandKey.Close();
            }
            else { setCommandValue(path); }
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


        public void disableProtocolPrompt()
        {
            RegistryKey c2w = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\ProtocolExecute\client2web");
            addStringValueToKey(c2w, "", "");
            addDWORDValueToKey(c2w, "WarnOnOpen", 0);
        }
    }
}
