using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tests
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tests.Forms.FormStatus stat = new Tests.Forms.FormStatus();
            stat.ShowDialog();
        }
    }
}
