namespace DARK_SOUL_III_AutoSave
{
    partial class ConfigureWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.GPB1 = new System.Windows.Forms.GroupBox();
            this.TestURLButton = new System.Windows.Forms.Button();
            this.FileBrowerButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.LaunchInExeFile = new System.Windows.Forms.RadioButton();
            this.LaunchInURL = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBowerButton = new System.Windows.Forms.Button();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.FBD1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.GPB3 = new System.Windows.Forms.GroupBox();
            this.ErrorConfig = new System.Windows.Forms.CheckBox();
            this.AfterShow = new System.Windows.Forms.CheckBox();
            this.GPB1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GPB3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "确认(&Y)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GPB1
            // 
            this.GPB1.Controls.Add(this.TestURLButton);
            this.GPB1.Controls.Add(this.FileBrowerButton);
            this.GPB1.Controls.Add(this.FilePathTextBox);
            this.GPB1.Controls.Add(this.URLTextBox);
            this.GPB1.Controls.Add(this.LaunchInExeFile);
            this.GPB1.Controls.Add(this.LaunchInURL);
            this.GPB1.Location = new System.Drawing.Point(8, 7);
            this.GPB1.Name = "GPB1";
            this.GPB1.Size = new System.Drawing.Size(474, 127);
            this.GPB1.TabIndex = 1;
            this.GPB1.TabStop = false;
            this.GPB1.Text = "启动";
            // 
            // TestURLButton
            // 
            this.TestURLButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TestURLButton.Location = new System.Drawing.Point(394, 36);
            this.TestURLButton.Name = "TestURLButton";
            this.TestURLButton.Size = new System.Drawing.Size(74, 24);
            this.TestURLButton.TabIndex = 4;
            this.TestURLButton.Text = "测试(&T)";
            this.TestURLButton.UseVisualStyleBackColor = true;
            this.TestURLButton.Click += new System.EventHandler(this.TestURLButton_Click);
            // 
            // FileBrowerButton
            // 
            this.FileBrowerButton.Location = new System.Drawing.Point(394, 96);
            this.FileBrowerButton.Name = "FileBrowerButton";
            this.FileBrowerButton.Size = new System.Drawing.Size(74, 24);
            this.FileBrowerButton.TabIndex = 2;
            this.FileBrowerButton.Text = "浏览(&B)..";
            this.FileBrowerButton.UseVisualStyleBackColor = true;
            this.FileBrowerButton.Click += new System.EventHandler(this.FileBrowerButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(15, 99);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(368, 21);
            this.FilePathTextBox.TabIndex = 3;
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(15, 39);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(368, 21);
            this.URLTextBox.TabIndex = 2;
            // 
            // LaunchInExeFile
            // 
            this.LaunchInExeFile.AutoSize = true;
            this.LaunchInExeFile.Location = new System.Drawing.Point(16, 77);
            this.LaunchInExeFile.Name = "LaunchInExeFile";
            this.LaunchInExeFile.Size = new System.Drawing.Size(119, 16);
            this.LaunchInExeFile.TabIndex = 1;
            this.LaunchInExeFile.TabStop = true;
            this.LaunchInExeFile.Text = "通过执行文件启动";
            this.LaunchInExeFile.UseVisualStyleBackColor = true;
            // 
            // LaunchInURL
            // 
            this.LaunchInURL.AutoSize = true;
            this.LaunchInURL.Checked = true;
            this.LaunchInURL.Location = new System.Drawing.Point(16, 21);
            this.LaunchInURL.Name = "LaunchInURL";
            this.LaunchInURL.Size = new System.Drawing.Size(95, 16);
            this.LaunchInURL.TabIndex = 0;
            this.LaunchInURL.TabStop = true;
            this.LaunchInURL.Text = "通过链接启动";
            this.LaunchInURL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FolderBowerButton);
            this.groupBox1.Controls.Add(this.FolderPathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "存储";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "这决定你的存档备份存放在那里，且这项必须填写";
            // 
            // FolderBowerButton
            // 
            this.FolderBowerButton.Location = new System.Drawing.Point(390, 39);
            this.FolderBowerButton.Name = "FolderBowerButton";
            this.FolderBowerButton.Size = new System.Drawing.Size(74, 24);
            this.FolderBowerButton.TabIndex = 4;
            this.FolderBowerButton.Text = "浏览(&F)..";
            this.FolderBowerButton.UseVisualStyleBackColor = true;
            this.FolderBowerButton.Click += new System.EventHandler(this.FolderBowerButton_Click);
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Location = new System.Drawing.Point(11, 42);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.Size = new System.Drawing.Size(368, 21);
            this.FolderPathTextBox.TabIndex = 5;
            // 
            // FBD1
            // 
            this.FBD1.Description = "选择你要储存的位置:";
            // 
            // OFD
            // 
            this.OFD.Filter = "DARK SOULS III EXE FILE|DarkSoulsIII.exe";
            this.OFD.RestoreDirectory = true;
            this.OFD.Title = "选择启动文件";
            // 
            // GPB3
            // 
            this.GPB3.Controls.Add(this.ErrorConfig);
            this.GPB3.Controls.Add(this.AfterShow);
            this.GPB3.Location = new System.Drawing.Point(11, 220);
            this.GPB3.Name = "GPB3";
            this.GPB3.Size = new System.Drawing.Size(470, 52);
            this.GPB3.TabIndex = 3;
            this.GPB3.TabStop = false;
            this.GPB3.Text = "其它高级选项";
            // 
            // ErrorConfig
            // 
            this.ErrorConfig.AutoSize = true;
            this.ErrorConfig.Location = new System.Drawing.Point(210, 20);
            this.ErrorConfig.Name = "ErrorConfig";
            this.ErrorConfig.Size = new System.Drawing.Size(168, 16);
            this.ErrorConfig.TabIndex = 1;
            this.ErrorConfig.Text = "如果配置出现错误仍然运行";
            this.ErrorConfig.UseVisualStyleBackColor = true;
            this.ErrorConfig.CheckedChanged += new System.EventHandler(this.ErrorConfig_CheckedChanged);
            // 
            // AfterShow
            // 
            this.AfterShow.AutoSize = true;
            this.AfterShow.Location = new System.Drawing.Point(13, 20);
            this.AfterShow.Name = "AfterShow";
            this.AfterShow.Size = new System.Drawing.Size(144, 16);
            this.AfterShow.TabIndex = 0;
            this.AfterShow.Text = "启动后自动最小化窗口";
            this.AfterShow.UseVisualStyleBackColor = true;
            // 
            // ConfigureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 316);
            this.Controls.Add(this.GPB3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GPB1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置设置";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ConfigureWindow_HelpButtonClicked);
            this.GPB1.ResumeLayout(false);
            this.GPB1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GPB3.ResumeLayout(false);
            this.GPB3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GPB1;
        public System.Windows.Forms.RadioButton LaunchInExeFile;
        public System.Windows.Forms.RadioButton LaunchInURL;
        public System.Windows.Forms.TextBox FilePathTextBox;
        public System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button FileBrowerButton;
        private System.Windows.Forms.Button TestURLButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FolderBowerButton;
        public System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.FolderBrowserDialog FBD1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.GroupBox GPB3;
        public System.Windows.Forms.CheckBox AfterShow;
        public System.Windows.Forms.CheckBox ErrorConfig;
    }
}