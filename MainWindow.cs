using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DARK_SOUL_III_AutoSave
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (APIClass.GetINIValueInt("Configure", "UseFirst", ".\\AppSettings.ini") == 1)
            {
                Cwindow = new ConfigureWindow();
                Cwindow.ShowDialog();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        private ConfigureWindow Cwindow;
        private void ConfigureButton_Click(object sender, EventArgs e)
        {
            Cwindow = new ConfigureWindow();
            Cwindow.ShowDialog();
        }

        private void BackUpReButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(APIClass.GetINIValueString("Configure", "SaveFolder", ".\\AppSettings.ini")) == false)
            {
                MessageBox.Show("存储文件夹有问题，请转到 配置 检查你的设置。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                BackUpWindow Tempwindow = new BackUpWindow();
                Tempwindow.ShowDialog();
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            LaunchWindow Lwindow = new LaunchWindow();
            this.Enabled = false;
            if (WindowBehavior.LaunchGame(Lwindow) != 0)
            {
                if (APIClass.GetINIValueInt("Configure", "LaunchClose", ".\\AppSettings.ini") == 1) {
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                }
            }
            this.Enabled = true;
        }

        private void 打开本机存档目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(MainServer.DASK_SOULS_FOLDER+"\\DarkSoulsIII") == false)
            {
                MessageBox.Show("请检查你的电脑是否安装了 Dark Souls III，或者至少运行一遍。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                APIClass.LaunchProgramme("explorer.exe \"" + MainServer.DASK_SOULS_FOLDER + "\\DarkSoulsIII" + "\"");
            }
        }

        private void 打开备份存档目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(APIClass.GetINIValueString("Configure", "SaveFolder", ".\\AppSettings.ini")) == false)
            {
                MessageBox.Show("存储文件夹有问题，请转到 配置 检查你的设置。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                APIClass.LaunchProgramme("explorer.exe \"" + APIClass.GetINIValueString("Configure", "SaveFolder", ".\\AppSettings.ini") +"\"");
            }
        }
    }
}
