using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DARK_SOUL_III_AutoSave
{
    public partial class ConfigureWindow : Form
    {
        public ConfigureWindow()
        {
            IsEcho = 0;
            InitializeComponent();
            WindowBehavior.ReadINI(this);
            IsEcho = 1;
        }
        Process tempProcess;
        private int IsEcho;
        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowBehavior.SaveConfigure(this) != 0) {
                this.Close();
            }
            
        }

        private void FolderBowerButton_Click(object sender, EventArgs e)
        {
            if (FBD1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                FolderPathTextBox.Text = FBD1.SelectedPath;
            }
        }

        private void TestURLButton_Click(object sender, EventArgs e)
        {
            //及时Process类
            if (tempProcess != null)
            {
                if (tempProcess.HasExited != true)
                {
                    System.Windows.Forms.MessageBox.Show("目标已启动，请勿重新启动");
                }
                else {
                    tempProcess = new Process();
                    tempProcess.StartInfo.FileName = "explorer.exe";
                    tempProcess.StartInfo.Arguments = "\"" + URLTextBox.Text + "\"";
                    tempProcess.Start();
                }
            }
            else {
                tempProcess = new Process();
                tempProcess.StartInfo.FileName = "explorer.exe";
                tempProcess.StartInfo.Arguments = "\"" + URLTextBox.Text + "\"";
                tempProcess.Start();
            }
        }

        private void FileBrowerButton_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePathTextBox.Text = OFD.FileName;
            }
        }

        private void ErrorConfig_CheckedChanged(object sender, EventArgs e)
        {
            if (ErrorConfig.Checked != false&&(IsEcho==1))
            {
                if (System.Windows.Forms.MessageBox.Show("勾选此项的话，如果配置出现问题程序不会出现提示\n这可能会导致存档保存不成功。", "注意", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Cancel)
                {
                    ErrorConfig.Checked = false;
                }

            }
        }

        private void ConfigureWindow_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MainServer.ShowHtmlHelp("Configure", 1);
            e.Cancel = true;
        }
    }
}
