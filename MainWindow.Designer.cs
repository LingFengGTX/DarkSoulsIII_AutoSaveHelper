namespace DARK_SOUL_III_AutoSave
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.InterfaceBox = new System.Windows.Forms.PictureBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.ConfigureButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackUpReButton = new System.Windows.Forms.Button();
            this.RightMouseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.运行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.打开本机存档目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开备份存档目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.InterfaceBox)).BeginInit();
            this.RightMouseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // InterfaceBox
            // 
            this.InterfaceBox.Image = global::DARK_SOUL_III_AutoSave.Properties.Resources.Interface;
            this.InterfaceBox.Location = new System.Drawing.Point(0, 0);
            this.InterfaceBox.Name = "InterfaceBox";
            this.InterfaceBox.Size = new System.Drawing.Size(220, 160);
            this.InterfaceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InterfaceBox.TabIndex = 0;
            this.InterfaceBox.TabStop = false;
            // 
            // LaunchButton
            // 
            this.LaunchButton.ContextMenuStrip = this.RightMouseMenu;
            this.LaunchButton.Location = new System.Drawing.Point(227, 12);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(97, 28);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "运行游戏(&L)";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // ConfigureButton
            // 
            this.ConfigureButton.Location = new System.Drawing.Point(227, 84);
            this.ConfigureButton.Name = "ConfigureButton";
            this.ConfigureButton.Size = new System.Drawing.Size(97, 28);
            this.ConfigureButton.TabIndex = 2;
            this.ConfigureButton.Text = "配置(&C)";
            this.ConfigureButton.UseVisualStyleBackColor = true;
            this.ConfigureButton.Click += new System.EventHandler(this.ConfigureButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(227, 119);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 28);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "退出(&Q)";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackUpReButton
            // 
            this.BackUpReButton.Location = new System.Drawing.Point(227, 48);
            this.BackUpReButton.Name = "BackUpReButton";
            this.BackUpReButton.Size = new System.Drawing.Size(97, 28);
            this.BackUpReButton.TabIndex = 4;
            this.BackUpReButton.Text = "备份管理(&R)";
            this.BackUpReButton.UseVisualStyleBackColor = true;
            this.BackUpReButton.Click += new System.EventHandler(this.BackUpReButton_Click);
            // 
            // RightMouseMenu
            // 
            this.RightMouseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.运行ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.打开本机存档目录ToolStripMenuItem,
            this.打开备份存档目录ToolStripMenuItem});
            this.RightMouseMenu.Name = "RightMouseMenu";
            this.RightMouseMenu.Size = new System.Drawing.Size(173, 98);
            // 
            // 运行ToolStripMenuItem
            // 
            this.运行ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.运行ToolStripMenuItem.Name = "运行ToolStripMenuItem";
            this.运行ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.运行ToolStripMenuItem.Text = "运行..";
            this.运行ToolStripMenuItem.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // 打开本机存档目录ToolStripMenuItem
            // 
            this.打开本机存档目录ToolStripMenuItem.Name = "打开本机存档目录ToolStripMenuItem";
            this.打开本机存档目录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.打开本机存档目录ToolStripMenuItem.Text = "打开本机存档目录";
            this.打开本机存档目录ToolStripMenuItem.Click += new System.EventHandler(this.打开本机存档目录ToolStripMenuItem_Click);
            // 
            // 打开备份存档目录ToolStripMenuItem
            // 
            this.打开备份存档目录ToolStripMenuItem.Name = "打开备份存档目录ToolStripMenuItem";
            this.打开备份存档目录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.打开备份存档目录ToolStripMenuItem.Text = "打开备份存档目录";
            this.打开备份存档目录ToolStripMenuItem.Click += new System.EventHandler(this.打开备份存档目录ToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 159);
            this.Controls.Add(this.BackUpReButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConfigureButton);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.InterfaceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DARK SOULS III - AutoSave Helper";
            ((System.ComponentModel.ISupportInitialize)(this.InterfaceBox)).EndInit();
            this.RightMouseMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox InterfaceBox;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button ConfigureButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackUpReButton;
        private System.Windows.Forms.ContextMenuStrip RightMouseMenu;
        private System.Windows.Forms.ToolStripMenuItem 运行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开本机存档目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开备份存档目录ToolStripMenuItem;
    }
}

