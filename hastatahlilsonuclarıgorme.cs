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
    public partial class hastatahlilsonuclarıgorme : Form
    {
        public hastatahlilsonuclarıgorme()
        {
            InitializeComponent();
        }

        private void hastatahlilsonuclarıgorme_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bu kodda sıkıntı vardır. revize edilip tekrar yazılacaktır.
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=doktor tahlil sonucları.accdb");
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select Hasta_Adı,Hasta_Soyadı,Tahlil_Sonucları from doktortahlilsonucları where HastaAdı=@Hasta_Adı  and HastaSoyadı@Hasta_Soyadı and TahlilSonucları=@Tahlil_Sonucları ", baglanti);

            sorgu.Parameters.AddWithValue("Hasta_Adı", textBox1.Text);
            sorgu.Parameters.AddWithValue("@Hasta_Soyadı", textBox2.Text);
            OleDbDataReader dr;
            dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = ("@Tahlil_Sonucları");
            }
        }
    }
}
