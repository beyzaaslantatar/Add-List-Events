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

namespace hafta3sqlgece
{
    public partial class ogrekle : Form
    {
        public ogrekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=gece;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into ogr (OkulNo,IsimSoyisim,CepNo,Bolum,Sinif)" +
                "values (@OkulNo,@IsimSoyisim,@CepNo,@Bolum,@Sinif)";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@OkulNo", textBox1.Text);
            komut.Parameters.AddWithValue("@IsimSoyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@CepNo", textBox3.Text);
            komut.Parameters.AddWithValue("@Bolum", comboBox1.Text);
            komut.Parameters.AddWithValue("@Sinif", comboBox2.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

        }








        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
