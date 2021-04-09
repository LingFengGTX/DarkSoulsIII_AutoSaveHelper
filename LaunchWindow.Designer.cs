namespace DARK_SOUL_III_AutoSave
{
    partial class LaunchWindow
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
            this.ProcessBar = new System.Windows.Forms.ProgressBar();
            this.ShowTextInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcessBar
            // 
            this.ProcessBar.Location = new System.Drawing.Point(0, 30);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Size = new System.Drawing.Size(405, 29);
            this.ProcessBar.TabIndex = 0;
            // 
            // ShowTextInfo
            // 
            this.ShowTextInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowTextInfo.Location = new System.Drawing.Point(2, 1);
            this.ShowTextInfo.Name = "ShowTextInfo";
            this.ShowTextInfo.Size = new System.Drawing.Size(402, 29);
            this.ShowTextInfo.TabIndex = 1;
            this.ShowTextInfo.Text = "测试文本";
            this.ShowTextInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LaunchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 60);
            this.ControlBox = false;
            this.Controls.Add(this.ShowTextInfo);
            this.Controls.Add(this.ProcessBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LaunchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正在启动...";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar ProcessBar;
        public System.Windows.Forms.Label ShowTextInfo;
    }
}