using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            solpanel.Height = button1.Height;
            solpanel.Top = button1.Top;
        }
        public static int idnumber;
        private void button2_Click(object sender, EventArgs e)
        {
            solpanel.Height = button2.Height;
            solpanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solpanel.Height = button3.Height;
            solpanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Show();
            button5.Hide();
            panel3.Hide();
            pictureBox1.Image = ogrenci5.Properties.Resources.merhab;
        }
    }
}
