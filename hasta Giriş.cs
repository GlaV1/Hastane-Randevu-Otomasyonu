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
    public partial class hasta_Giriş : Form
    {
        public hasta_Giriş()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Database1.accdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select Kullanıcı_Adı,Sifre from Tablo1 where Kullanıcı_Adı=@Kullanıcı_Adı and Sifre=@Sifre", baglanti);
                sorgu.Parameters.AddWithValue("@Kullanıcı_Adı", textBox1.Text);
                sorgu.Parameters.AddWithValue("@Sifre", textBox2.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("giriş başarılı ana sayfaya yönlendirliyorsunuz");
                    hastagirisyaptıktansonra hastagirisyaotiktansonra = new hastagirisyaptıktansonra();
                    hastagirisyaotiktansonra.Show();
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
