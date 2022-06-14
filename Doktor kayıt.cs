using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace hastane_randevu_otomasyonu
{
    public partial class Doktor_kayıt : Form
    {
        public Doktor_kayıt()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Doktor_kayıt_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=doktor veri tabanı.mdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into doktorkayıt(Ad,Soyad,Tc_kimlik_no,Telefon_no,Kullanıcı_adı,Sifre,Mail) values('"+ textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt başarılı");
            girişekrani girisekrani = new girişekrani();
            girisekrani.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            girişekrani girisekrani = new girişekrani();
            girisekrani.Show();
            this.Visible = false;
        }
    }
}
