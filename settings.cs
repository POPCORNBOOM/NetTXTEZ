using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetTXTEZ
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            tog_filewrite.Checked = Properties.Settings.Default.tog_conti;
            t_maxtry.Text = Properties.Settings.Default.maxtry.ToString();
        }

        private void b_savesettings_Click(object sender, EventArgs e)
        {
            bool haserror = false;

            try
            {
                Properties.Settings.Default.maxtry = int.Parse(t_maxtry.Text);

            }
            catch(FormatException)
            {
                haserror = true;
            }

            if (haserror)
                MessageBox.Show("请输入整数");
            else
            {
                Properties.Settings.Default.Save();
                this.Close();
            }
            
        }

        private void tog_filewrite_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.tog_conti = tog_filewrite.Checked;
            if (tog_filewrite.Checked)
                skinLabel3.Text = "写入文件时将会在原来的内容后继续写";
            else
                skinLabel3.Text = "写入文件时将会清除源文件内容并重新开始写";
        }
    }
}
