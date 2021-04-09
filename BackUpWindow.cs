using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DARK_SOUL_III_AutoSave
{
    public partial class BackUpWindow : Form
    {
        public BackUpWindow()
        {
            InitializeComponent();
            SaveFloder = APIClass.GetINIValueString("Configure", "SaveFolder", ".\\AppSettings.ini");
            WindowBehavior.RreshList(this);
        }
        private string SaveFloder;
        private DateTime EditorTime;
        private void DelSelected_Click(object sender, EventArgs e)
        {
            if (BackUpList.SelectedItems.Count != 0)
            {
                if (BackUpList.SelectedIndex != -1)
                {
                    if (MessageBox.Show("是否要删除所选项?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        File.Delete(SaveFloder + "\\" + BackUpList.SelectedItem.ToString());
                        BackUpList.Items.RemoveAt(BackUpList.SelectedIndex);
                    }
                }
                
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutBackUpButton_Click(object sender, EventArgs e)
        {
            if (BackUpList.SelectedItems.Count != 0)
            {
                if (BackUpList.SelectedIndex != -1)
                {
                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(SaveFloder + "\\" + BackUpList.SelectedItem.ToString(), SFD.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("你至少应该选择一项。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("你至少应该选择一项。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BackUpList.Items.Count != 0)
            {
                if (MessageBox.Show("是否要清空当前所有备份?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    foreach (object i in BackUpList.Items)
                    {
                        File.Delete(SaveFloder + "\\" + i);
                    }
                    BackUpList.Items.Clear();
                }
            }
        }

        private void BackUpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BackUpList.Items.Count != 0)
            {
                if (BackUpList.SelectedIndex != -1)
                {
                    EditorTime = File.GetLastWriteTime(SaveFloder + "\\" + BackUpList.SelectedItem.ToString());
                    this.InfoLabel.Text = BackUpList.SelectedItem.ToString() +"(修改日期:"+EditorTime.ToString("yyyy年MM月dd日HH时mm分ss秒")+")";
                }
                else {
                    this.InfoLabel.Text = "最新修改日期";
                }
                
            }
            else {
                this.InfoLabel.Text = "最新修改日期";
            }
       }

        private void ImportBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("使用外部文件时请确保是本程序生成，否则无法保证备份文件内容。", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (OFD.ShowDialog() == DialogResult.OK) {
                    MainServer.ReBackUp(OFD.FileName);
                }
                else
                {
                    MessageBox.Show("没有选择文件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void RecordThis_Click(object sender, EventArgs e)
        {
            if (BackUpList.Items.Count != 0)
            {
                if (BackUpList.SelectedIndex != -1)
                {
                    if (MessageBox.Show("是否要还原此备份?\n" + SaveFloder + "\\" + BackUpList.SelectedItem.ToString(), "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        MainServer.ReBackUp(SaveFloder + "\\" + BackUpList.SelectedItem.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("你至少应该选择一项。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("你至少应该选择一项。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveNow_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(MainServer.DASK_SOULS_FOLDER + "\\DarkSoulsIII") == false)
            {
                MessageBox.Show("请检查你的电脑是否安装了 Dark Souls III，或者至少运行一遍。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MainServer.SaveBackUp() == 0)
                {
                    MessageBox.Show("未知原因，保存失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                WindowBehavior.RreshList(this);
            }
        }

        private void BackUpWindow_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MainServer.ShowHtmlHelp("BackupList", 1);
            e.Cancel = true;
        }
    }
}
