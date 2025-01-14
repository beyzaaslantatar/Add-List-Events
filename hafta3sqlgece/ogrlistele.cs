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
    public partial class ogrlistele : Form
    {
        public ogrlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=gece;Integrated Security=True");
        private void Listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ogr", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "ogrtab");
            dataGridView1.DataSource = ds.Tables["ogrtab"];
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From ogr Where OkulNo=@OkulNo";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@OkulNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            baglan.Open();

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt silindi.");
          
            baglan.Close();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "update ogr set IsimSoyisim=@IsimSoyisim, CepNo=@CepNo, Bolum=@Bolum, @Sinif=Sinif where OkulNo=@OkulNo";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@OkulNo", textBox1.Text);
            komut.Parameters.AddWithValue("@IsimSoyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@CepNo", textBox3.Text);
            komut.Parameters.AddWithValue("@Bolum", comboBox1.Text);
            komut.Parameters.AddWithValue("@Sinif", comboBox2.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Güncelleme gerçekleşti.");
            listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();*/
        }
    }
}
