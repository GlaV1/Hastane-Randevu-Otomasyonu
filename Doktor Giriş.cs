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
    public partial class Doktor_Giriş : Form
    {
        public Doktor_Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=doktor veri tabanı.mdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select Kullanıcı_adı,Sifre from doktorkayıt where Kullanıcı_Adı=@Kullanıcı_Adı and Sifre=@Sifre", baglanti);
                sorgu.Parameters.AddWithValue("@Kullanıcı_Adı", textBox1.Text);
                sorgu.Parameters.AddWithValue("@Sifre", textBox2.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı Anasayfaya yönlendirliyorsunuz");
                    doktorgirisyaptıktansonra doktorgirisyaptıktansonra1 = new doktorgirisyaptıktansonra();
                    doktorgirisyaptıktansonra1.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış Lütfen Tekrar Deneyiniz");
                }


            }
            catch
            {
                MessageBox.Show("Lütfen Kullanıcı Adınız ve Şifrenizle Giriş Yapınız");
            }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            girişekrani girisekrani = new girişekrani();
            girisekrani.Show();
            this.Visible = false;
        }
    }
}
