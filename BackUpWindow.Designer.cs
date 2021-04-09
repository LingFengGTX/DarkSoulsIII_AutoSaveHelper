namespace DARK_SOUL_III_AutoSave
{
    partial class BackUpWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackUpList = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DelSelected = new System.Windows.Forms.Button();
            this.OutBackUpButton = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ClearAllBack = new System.Windows.Forms.Button();
            this.ImportBack = new System.Windows.Forms.Button();
            this.RecordThis = new System.Windows.Forms.Button();
            this.GBP = new System.Windows.Forms.GroupBox();
            this.InfoLabel = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SaveNow = new System.Windows.Forms.Button();
            this.GBP.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackUpList
            // 
            this.BackUpList.FormattingEnabled = true;
            this.BackUpList.ItemHeight = 12;
            this.BackUpList.Location = new System.Drawing.Point(8, 17);
            this.BackUpList.Name = "BackUpList";
            this.BackUpList.ScrollAlwaysVisible = true;
            this.BackUpList.Size = new System.Drawing.Size(275, 220);
            this.BackUpList.TabIndex = 0;
            this.BackUpList.SelectedIndexChanged += new System.EventHandler(this.BackUpList_SelectedIndexChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(289, 301);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "关闭(&Q)";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DelSelected
            // 
            this.DelSelected.Location = new System.Drawing.Point(289, 17);
            this.DelSelected.Name = "DelSelected";
            this.DelSelected.Size = new System.Drawing.Size(87, 25);
            this.DelSelected.TabIndex = 2;
            this.DelSelected.Text = "删除所选(&D)";
            this.DelSelected.UseVisualStyleBackColor = true;
            this.DelSelected.Click += new System.EventHandler(this.DelSelected_Click);
            // 
            // OutBackUpButton
            // 
            this.OutBackUpButton.Location = new System.Drawing.Point(289, 49);
            this.OutBackUpButton.Name = "OutBackUpButton";
            this.OutBackUpButton.Size = new System.Drawing.Size(87, 25);
            this.OutBackUpButton.TabIndex = 3;
            this.OutBackUpButton.Text = "导出所选(&O)";
            this.OutBackUpButton.UseVisualStyleBackColor = true;
            this.OutBackUpButton.Click += new System.EventHandler(this.OutBackUpButton_Click);
            // 
            // SFD
            // 
            this.SFD.Filter = "DARK SOUL III 存档备份文件|*.back";
            this.SFD.Title = "选择你要保存的位置:";
            // 
            // ClearAllBack
            // 
            this.ClearAllBack.Location = new System.Drawing.Point(289, 83);
            this.ClearAllBack.Name = "ClearAllBack";
            this.ClearAllBack.Size = new System.Drawing.Size(87, 25);
            this.ClearAllBack.TabIndex = 4;
            this.ClearAllBack.Text = "清空所有(&C)";
            this.ClearAllBack.UseVisualStyleBackColor = true;
            this.ClearAllBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImportBack
            // 
            this.ImportBack.Location = new System.Drawing.Point(290, 177);
            this.ImportBack.Name = "ImportBack";
            this.ImportBack.Size = new System.Drawing.Size(87, 25);
            this.ImportBack.TabIndex = 5;
            this.ImportBack.Text = "使用外部(&I)";
            this.ImportBack.UseVisualStyleBackColor = true;
            this.ImportBack.Click += new System.EventHandler(this.ImportBack_Click);
            // 
            // RecordThis
            // 
            this.RecordThis.Location = new System.Drawing.Point(290, 146);
            this.RecordThis.Name = "RecordThis";
            this.RecordThis.Size = new System.Drawing.Size(87, 25);
            this.RecordThis.TabIndex = 6;
            this.RecordThis.Text = "还原所选(&R)";
            this.RecordThis.UseVisualStyleBackColor = true;
            this.RecordThis.Click += new System.EventHandler(this.RecordThis_Click);
            // 
            // GBP
            // 
            this.GBP.Controls.Add(this.InfoLabel);
            this.GBP.Location = new System.Drawing.Point(9, 243);
            this.GBP.Name = "GBP";
            this.GBP.Size = new System.Drawing.Size(274, 88);
            this.GBP.TabIndex = 7;
            this.GBP.TabStop = false;
            this.GBP.Text = "信息";
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(6, 14);
            this.InfoLabel.Multiline = true;
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.ReadOnly = true;
            this.InfoLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoLabel.Size = new System.Drawing.Size(262, 69);
            this.InfoLabel.TabIndex = 0;
            // 
            // OFD
            // 
            this.OFD.Filter = "DARK SOULS III Back up File|*.back";
            this.OFD.Title = "选择 Dark Souls III 备份文件:";
            // 
            // SaveNow
            // 
            this.SaveNow.Location = new System.Drawing.Point(290, 207);
            this.SaveNow.Name = "SaveNow";
            this.SaveNow.Size = new System.Drawing.Size(87, 25);
            this.SaveNow.TabIndex = 8;
            this.SaveNow.Text = "储存现在(&N)";
            this.SaveNow.UseVisualStyleBackColor = true;
            this.SaveNow.Click += new System.EventHandler(this.SaveNow_Click);
            // 
            // BackUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 337);
            this.Controls.Add(this.SaveNow);
            this.Controls.Add(this.GBP);
            this.Controls.Add(this.RecordThis);
            this.Controls.Add(this.ImportBack);
            this.Controls.Add(this.ClearAllBack);
            this.Controls.Add(this.OutBackUpButton);
            this.Controls.Add(this.DelSelected);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackUpList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackUpWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "备份管理";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.BackUpWindow_HelpButtonClicked);
            this.GBP.ResumeLayout(false);
            this.GBP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox BackUpList;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DelSelected;
        private System.Windows.Forms.Button OutBackUpButton;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button ClearAllBack;
        private System.Windows.Forms.Button ImportBack;
        private System.Windows.Forms.Button RecordThis;
        private System.Windows.Forms.GroupBox GBP;
        private System.Windows.Forms.TextBox InfoLabel;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button SaveNow;
    }
}