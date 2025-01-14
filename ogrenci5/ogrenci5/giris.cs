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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection con = new SqlConnection
("Data Source=DESKTOP-B2541I7\\SQLEXPRESS;Initial Catalog=okul5;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        { //notes.io/wqHGx
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from kullanici where adi='"
                + textBox1.Text + "' And parola='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {

                MessageBox.Show("Giriş Başarılı");
                // Form1 frm= new Form1();
                Form1 frm = (Form1)Application.OpenForms["Form1"];
                Form1.idnumber = (int)dr["id"];
                
                frm.pictureBox1.ImageLocation = "./profile/" + textBox1.Text + ".jpg";
                frm.button4.Hide();
                frm.button5.Show();

                string rolu = dr["rol"].ToString().Trim();
                if (rolu == "ogrenci")
                {
                    frm.panel3.Show();
                    frm.panel3.BringToFront();
                }
                else
                {
                    MessageBox.Show("Tanımlı Rol Bulunamadı");
                }

            }
            else
            {
               MessageBox.Show("Hatalı kullanıcı adı ve şifre");
            }
            con.Close();


            this.Close();
        }
    }
}
