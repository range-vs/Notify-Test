using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_notify
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonHideWindowNotify_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.Text = TextBoxInfo.Text;
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }
    }
}
