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
    public partial class muayeneolanhastabilgileri : Form
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        
        public muayeneolanhastabilgileri()
        {
            InitializeComponent();
        }

        void kisilistele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=muayeneolanhast bilgileri.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT * FROM muayeneolanhastabilgileri",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into muayeneolanhastabilgileri (Adı,Soyadı,Anne_Adı,Baba_Adı,Doğum_Yeri,Doğum_Tarihi,Tc_Kimlik_No) values (@Adı,@Soyadı,@Anne_Adı,@Baba_Adı,@Doğum_Yeri,@Doğum_Tarihi,@Tc_Kimlik_No)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Adı",textBox1.Text);
            komut.Parameters.AddWithValue("@Soyadı", textBox2.Text);
            komut.Parameters.AddWithValue("@Anne_Adı", textBox3.Text);
            komut.Parameters.AddWithValue("@Baba_Adı", textBox4.Text);
            komut.Parameters.AddWithValue("@Doğum_Yeri", textBox5.Text);
            komut.Parameters.AddWithValue("@Doğum_Tarihi", textBox6.Text);
            komut.Parameters.AddWithValue("@Tc_Kimlik_No", textBox8.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisilistele();
            MessageBox.Show("kayıt başarıyla eklenmiştir");
        }

        private void muayeneolanhastabilgileri_Load(object sender, EventArgs e)
        {
            kisilistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktorgirisyaptıktansonra doktorgirisyaptiktansonra1 = new doktorgirisyaptıktansonra();
            doktorgirisyaptiktansonra1.Show();
            this.Visible = false;
        }
    }
}
