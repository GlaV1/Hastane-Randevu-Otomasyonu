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
    public partial class hastakayıt : Form
    {
        
        public hastakayıt()
        {
            InitializeComponent();
        }

        private void hastakayıt_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Database1.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Tablo1(Ad,Soyad,Tc_Kimlik_No,Telefon_Numarası,Mail,Doğum_yılı,Kullanıcı_Adı,Sifre) values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", baglanti);
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
