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
    public partial class Doktorhastatahlilsonuçları : Form
    {

        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        public Doktorhastatahlilsonuçları()
        {
            InitializeComponent();
        }
        void kisilistele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=doktor tahlil sonucları.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT * FROM doktortahlilsonucları ", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Doktorhastatahlilsonuçları_Load(object sender, EventArgs e)
        {
            
            kisilistele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into doktortahlilsonucları(Hasta_Adı,Hasta_Soyadı,Tahlil_Sonucları) values(@Hasta_Adı,@Hasta_Soyadı,@Tahlil_Sonucları)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Hasta_Adı", textBox1.Text);
            komut.Parameters.AddWithValue("Hasta_Soyadı", textBox2.Text);
            komut.Parameters.AddWithValue("Tahlil_Sonucları", textBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisilistele();
            MessageBox.Show("Kayıt Sonuçları Başarıyla Eklenmiştir");
            doktorgirisyaptıktansonra doktorgirisyaptıktansonra = new doktorgirisyaptıktansonra();
            doktorgirisyaptıktansonra.Show();
            this.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktorgirisyaptıktansonra doktorgirisyaptiktansonra1 = new doktorgirisyaptıktansonra();
            doktorgirisyaptiktansonra1.Show();
            this.Visible = false;
        }
    }
}
