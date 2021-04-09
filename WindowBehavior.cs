using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
namespace DARK_SOUL_III_AutoSave
{
    class WindowBehavior
    {
        public static void RreshList(BackUpWindow Target) {
            Target.BackUpList.Items.Clear();
            string[] FileGroup = Directory.GetFiles(APIClass.GetINIValueString("Configure", "SaveFolder", ".\\AppSettings.ini"), "*.back");
            string objectText;
            foreach (string FileName in FileGroup) {
                objectText = FileName.Substring(FileName.LastIndexOf('\\')+1);
                Target.BackUpList.Items.Add(objectText);
            }
        }
        private static void DelayTask(int million){
			Stopwatch watch=new Stopwatch();
			watch.Start();
			while(watch.ElapsedMilliseconds < million){
				Thread.Sleep(50);
				Application.DoEvents();
			}
			watch.Stop();
		 }
        public static int SaveConfigure(ConfigureWindow Target)
        {
            APIClass.WriteINIValueString("Configure", "UseFirst", "0", ".\\AppSettings.ini");
            if (Target.LaunchInExeFile.Checked == true)
            {

                if (File.Exists(Target.FilePathTextBox.Text) == false)
                {
                    MessageBox.Show("所选择的执行文件不存在请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            else if (Target.LaunchInURL.Checked == true)
            {

                if (Target.URLTextBox.Text == "")
                {
                    MessageBox.Show("链接内容为空,请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            else
            {

                return 0;
            }

            if (Directory.Exists(Target.FolderPathTextBox.Text) == false)
            {
                MessageBox.Show("存档存储的文件夹有问题,请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            ///写入配置.
            {
                if (Target.LaunchInExeFile.Checked == true) {
                    APIClass.WriteINIValueString("Configure", "LaunchType", "1", ".\\AppSettings.ini");
                }

                if (Target.LaunchInURL.Checked == true) {
                    APIClass.WriteINIValueString("Configure", "LaunchType", "0", ".\\AppSettings.ini");
                }

                APIClass.WriteINIValueString("Configure", "TargetFile", Target.FilePathTextBox.Text, ".\\AppSettings.ini");
                APIClass.WriteINIValueString("Configure", "TargetURL", Target.URLTextBox.Text, ".\\AppSettings.ini");
                APIClass.WriteINIValueString("Configure", "SaveFolder", Target.FolderPathTextBox.Text, ".\\AppSettings.ini");

                if (Target.AfterShow.Checked == true)
                {
                    APIClass.WriteINIValueString("Configure", "LaunchClose","1", ".\\AppSettings.ini");
                }
                else {
                    APIClass.WriteINIValueString("Configure", "LaunchClose", "0", ".\\AppSettings.ini");
                }

                if (Target.ErrorConfig.Checked == true)
                {
                    APIClass.WriteINIValueString("Configure", "NoTip", "1", ".\\AppSettings.ini");
                }
                else
                {
                    APIClass.WriteINIValueString("Configure", "NoTip", "0", ".\\AppSettings.ini");
                }
            }

            return 1;
        }
        public static void ReadINI(ConfigureWindow Target) {
            if (APIClass.GetINIValueInt("Configure", "LaunchClose", ".\\AppSettings.ini") == 1)
            {
                Target.AfterShow.Checked = true;
            }
            else {
                Target.AfterShow.Checked = false;
            }

            if (APIClass.GetINIValueInt("Configure", "NoTip", ".\\AppSettings.ini") == 1)
            {
                Target.ErrorConfig.Checked = true;
            }
            else {
                Target.ErrorConfig.Checked = false;
            }

            if (APIClass.GetINIValueInt("Configure", "LaunchType", ".\\AppSettings.ini") == 1)
            {
                Target.LaunchInExeFile.Checked = true;
            }
            else {
                Target.LaunchInURL.Checked = true;
            }

            Target.FilePathTextBox.Text = APIClass.GetINIValueString("Configure", "TargetFile",".\\AppSettings.ini");
            Target.FolderPathTextBox.Text = APIClass.GetINIValueString("Configure", "SaveFolder",".\\AppSettings.ini");
            Target.URLTextBox.Text = APIClass.GetINIValueString("Configure", "TargetURL",".\\AppSettings.ini");
        }

        public static int LaunchGame(LaunchWindow Target) {
            Target.Show();
            Target.ProcessBar.Value = 20;
            Target.ShowTextInfo.Text = "正在检查设置中...";
            DelayTask(1000);
            if (Directory.Exists(MainServer.DASK_SOULS_FOLDER + "\\DarkSoulsIII") == false)
            {
                if (MainServer.ShowError() == true)
                {
                    MainServer.StartGame();
                    Target.Close();
                    return 2;
                }
                else
                {
                    MessageBox.Show("请检查你的电脑是否安装了 Dark Souls III，或者至少运行一遍。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Target.Close();
                    return 0;
                }
            
            }
            if(Directory.Exists(APIClass.GetINIValueString("Configure", "SaveFolder",".\\AppSettings.ini"))==false){
                if (MainServer.ShowError() == true)
                {
                    MainServer.StartGame();
                    Target.Close();
                    return 2;
                }
                else {
                    MessageBox.Show("存档的文件夹有问题，请转到 配置 页面重新设置", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Target.Close();
                    return 0;
                }
                
            }

            if (APIClass.GetINIValueInt("Configure", "LaunchType", ".\\AppSettings.ini") == 1)
            {
                if (File.Exists(APIClass.GetINIValueString("Configure", "TargetFile", ".\\AppSettings.ini")) == false)
                {
                    MessageBox.Show("执行文件不存在，请转到 配置 页面重新设置", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Target.Close();
                    return 0;
                }
            }
            Target.ProcessBar.Value = 40;
            DelayTask(1000);
            Target.ShowTextInfo.Text = "正在储存存档中...";
            MainServer.SaveBackUp();
            Target.ProcessBar.Value = 80;
            DelayTask(1000);
            Target.ShowTextInfo.Text = "检查是否保存成功...";
            if (MainServer.CheckRaRFile() == false) {
                if (MainServer.ShowError() == true)
                {
                    MainServer.StartGame();
                    Target.Close();
                    return 2;
                }
                else
                {
                    MessageBox.Show("因为未知原因，存档文件保存失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Target.Close();
                    return 0;
                }
            
            }
            Target.ProcessBar.Value = 100;
            DelayTask(1000);
            Target.ShowTextInfo.Text = "完成，准备运行。";
            MainServer.StartGame();
            Target.Close();
            return 1;
        }
    }
}
