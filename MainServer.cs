using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace DARK_SOUL_III_AutoSave
{
    class MainServer
    {
        public static string DASK_SOULS_FOLDER;
        private static string CheckFile;
        private static Process LaunchRARProgramme = new Process();
        private static string SaveFolder;
        private static int IsStar=0;
        public static int ReBackUp(string Target) {
            if (IsStar == 1 && LaunchRARProgramme.HasExited == false )
            {
                MessageBox.Show("当前有其它任务正在进行，请稍后。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            LaunchRARProgramme.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            LaunchRARProgramme.StartInfo.CreateNoWindow = true;
            LaunchRARProgramme.StartInfo.FileName = ".\\bin\\UnRAR.exe";
            LaunchRARProgramme.StartInfo.Arguments = "x -y \"" + Target + "\" \"" + DASK_SOULS_FOLDER + "\"";
            LaunchRARProgramme.Start();
            while (LaunchRARProgramme.HasExited == false)
            {
                Application.DoEvents();
            }
            IsStar = 1;
            MessageBox.Show("已还原备份。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        public static int SaveBackUp(){
            if (IsStar==1&&LaunchRARProgramme.HasExited == false) {
                MessageBox.Show("当前有其它任务正在进行，请稍后。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            SaveFolder = APIClass.GetINIValueString("Configure", "SaveFolder", ".\\AppSettings.ini");
            string TargetFileName = "DarkSoulsIII.BackupFile."+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+ ".back";
            LaunchRARProgramme.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            LaunchRARProgramme.StartInfo.CreateNoWindow = true;
            TargetFileName = SaveFolder + "\\" + TargetFileName;
            LaunchRARProgramme.StartInfo.FileName = ".\\bin\\RAR.exe";
            CheckFile = TargetFileName;
            LaunchRARProgramme.StartInfo.Arguments = "a -s -r -ep1 -m5 \"" + TargetFileName + "\" \"" + DASK_SOULS_FOLDER + "\\DarkSoulsIII\"";
            LaunchRARProgramme.Start();
            while (LaunchRARProgramme.HasExited == false) {
                Application.DoEvents();
            }
            IsStar = 1;
            if (CheckRaRFile() == false) {
                return 0;
            }
            return 1;
        }

        public static void StartGame(){
            if (APIClass.GetINIValueInt("Configure", "LaunchType", ".\\AppSettings.ini") == 0)
            {
                APIClass.LaunchProgramme("explorer.exe \"" + APIClass.GetINIValueString("Configure", "TargetURL", ".\\AppSettings.ini")+"\"");
            }
            else
            {
                APIClass.LaunchProgramme(APIClass.GetINIValueString("Configure", "TargetFile", ".\\AppSettings.ini"));
            }
        
        }
        public static bool ShowError() {
            if (APIClass.GetINIValueInt("Configure", "NoTip", ".\\AppSettings.ini") == 1)
            {
                return true;
            }
            else{
                return false;
            }
        
        }
        public static bool CheckRaRFile() {
            if (File.Exists(CheckFile) == true)
            {
                return true;
            }
            else {
                return false;
            }
        
        }
        public static void WriteDefaultConfigure() {
            APIClass.WriteINIValueString("Configure", "LaunchType", "0", ".\\AppSettings.ini");
            APIClass.WriteINIValueString("Configure", "LaunchClose", "1", ".\\AppSettings.ini");
            APIClass.WriteINIValueString("Configure", "NoTip", "0", ".\\AppSettings.ini");
            APIClass.WriteINIValueString("Configure", "TargetFile", "Your Dark Souls III Application File.", ".\\AppSettings.ini");
            APIClass.WriteINIValueString("Configure", "TargetURL", "Your Dark Souls III Steam Link.", ".\\AppSettings.ini");
            APIClass.WriteINIValueString("Configure", "SaveFolder", "!!! Your Saves'Path !!!", ".\\AppSettings.ini");
            APIClass.WriteINIValueString("Configure", "UseFirst", "1", ".\\AppSettings.ini");
        }

        public static void ShowHtmlHelp(string HelpFile,int type) {
            if (type == 0)
            {
                HelpWindow window = new HelpWindow(HelpFile);
                window.ShowDialog();
            }
            else {
                APIClass.LaunchProgramme("explorer.exe \""+Application.StartupPath+"\\Help\\"+HelpFile+".html\"");
            }
        
            
        }
    }
}
