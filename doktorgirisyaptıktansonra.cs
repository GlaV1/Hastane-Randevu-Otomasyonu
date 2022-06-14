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
    public partial class doktorgirisyaptıktansonra : Form
    {
        public doktorgirisyaptıktansonra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            muayeneolanhastabilgileri muayeneolanhastabilgileri = new muayeneolanhastabilgileri();
            muayeneolanhastabilgileri.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorhastatahlilsonuçları doktortahlilsonucları = new Doktorhastatahlilsonuçları();
            doktortahlilsonucları.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            girişekrani girisekrani1 = new girişekrani();
            girisekrani1.Show();
            this.Visible = false;
        }
    }
}
