using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci5
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
("Data Source=DESKTOP-B2541I7\\SQLEXPRESS;Initial Catalog=okul5;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from kullanici,notlarim where " +
                "kullanici.id=notlarim.kid And notlarim.kid=" + Form1.idnumber;

            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                label5.Text = dr["gorsel"].ToString();
                label6.Text = dr["nesne"].ToString();
                label7.Text = dr["web"].ToString();
                label8.Text = dr["ist"].ToString();
            }
            //Bu kısmı yazmayın
            //cmd.CommandText = "Select * from kullanici Join notlarim 
            //on kullanici.id=notlarim.kid where notlarim.kid=" + Form1.idnumber;
            con.Close();
            this.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
        }
    }
}
