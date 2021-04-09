using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace DARK_SOUL_III_AutoSave
{
    class APIClass
    {
        [DllImport("kernel32.dll")]
        private static extern int WinExec(string lpAppPath, int windowStyle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault,StringBuilder lpReturnedString, uint nSize, string lpFileName);
    
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int lpDefault,string lpFileName);

        public static int GetINIValueInt(string lpAppName, string lpKeyName, string lpFileName) { 
            return (int)GetPrivateProfileInt(lpAppName,lpKeyName,0,lpFileName);
        }

        public static void WriteINIValueString(string lpAppName, string lpKeyName, string lpString,string lpFileName)
        { 
            WritePrivateProfileString(lpAppName,lpKeyName,lpString,lpFileName);
        }

        public static string GetINIValueString(string lpAppName, string lpKeyName, string lpFileName) {
            StringBuilder lpReturnedString = new StringBuilder(255);
            GetPrivateProfileString(lpAppName,lpKeyName,"None",lpReturnedString,255,lpFileName);

            return lpReturnedString.ToString();
        }

        public static void LaunchProgramme(string AppLocation) {
            WinExec(AppLocation,5);
        }
    }
}
