namespace test_notify
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ButtonHideWindowNotify = new System.Windows.Forms.Button();
            this.TextBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "test";
            this.notifyIcon1.BalloonTipTitle = "test";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "test";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click_1);
            // 
            // ButtonHideWindowNotify
            // 
            this.ButtonHideWindowNotify.Location = new System.Drawing.Point(14, 98);
            this.ButtonHideWindowNotify.Name = "ButtonHideWindowNotify";
            this.ButtonHideWindowNotify.Size = new System.Drawing.Size(215, 48);
            this.ButtonHideWindowNotify.TabIndex = 0;
            this.ButtonHideWindowNotify.Text = "Свернуть программу в область уведомлений ";
            this.ButtonHideWindowNotify.UseVisualStyleBackColor = true;
            this.ButtonHideWindowNotify.Click += new System.EventHandler(this.ButtonHideWindowNotify_Click);
            // 
            // TextBoxInfo
            // 
            this.TextBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.TextBoxInfo.Multiline = true;
            this.TextBoxInfo.Name = "TextBoxInfo";
            this.TextBoxInfo.Size = new System.Drawing.Size(217, 68);
            this.TextBoxInfo.TabIndex = 1;
            this.TextBoxInfo.Text = "Тестовая надпись...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 163);
            this.Controls.Add(this.TextBoxInfo);
            this.Controls.Add(this.ButtonHideWindowNotify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Тест - программа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button ButtonHideWindowNotify;
        private System.Windows.Forms.TextBox TextBoxInfo;
    }
}

