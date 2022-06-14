using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_randevu_otomasyonu
{
    public partial class girişekrani : Form
    {


        public girişekrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            hastakayıt hastakayit = new hastakayıt();
            girişekrani girisekran = new girişekrani();
            MessageBox.Show("Hasta Kayıt Ekranına Yönlendiriliyorsunuz");
            hastakayit.Show();
            this.Visible = false;
           
           
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            hasta_Giriş hastagiris = new hasta_Giriş();
            girişekrani girisekran = new girişekrani();
            MessageBox.Show("Giriş Ekranına Yönlendiriliyorsunuz");
            hastagiris.Show();
            this.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doktor_kayıt doktorkayit = new Doktor_kayıt();
            MessageBox.Show("Doktor Kayıt Ekranına Yönlendiriliyorsunuz");
            doktorkayit.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doktor_Giriş doktorgiris = new Doktor_Giriş();
            MessageBox.Show("Doktor Giriş Ekranına Yönlendiriliyorsunuz");
            doktorgiris.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("çıkmak istediğinize emin misiniz?","Çıkış İşlemi",MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}
