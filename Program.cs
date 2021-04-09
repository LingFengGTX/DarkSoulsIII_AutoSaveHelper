using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.IO;

namespace DARK_SOUL_III_AutoSave
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool IsStart;
            System.Threading.Mutex CheckInfo = new Mutex(true, Application.ProductName,out IsStart);
            if (IsStart)
            {

                if (args.Length != 0)
                {
                    if (args[0] == "MyFriend")
                    {
                        MessageBox.Show("这个是写给我最好的朋友 归来gvc ^_^", "这是个小彩蛋", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (Environment.Is64BitOperatingSystem == false) { 
                    if(MessageBox.Show("Dark Souls III 需要64位操作系统运行\n如果继续运行本程序会导致打开失败。","注意！",MessageBoxButtons.OKCancel,MessageBoxIcon.Error)==DialogResult.Cancel){
                        Environment.Exit(0);
                    }
                }
                if (File.Exists(".\\AppSettings.ini") == false)
                {
                    MainServer.WriteDefaultConfigure();
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MainServer.DASK_SOULS_FOLDER = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming";
                Application.Run(new MainWindow());
            }
            else {
                MessageBox.Show("已有一个实例已存在。","不能重复运行",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
