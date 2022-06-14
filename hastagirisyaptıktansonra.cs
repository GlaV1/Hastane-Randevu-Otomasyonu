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
    public partial class hastagirisyaptıktansonra : Form
    {
        public hastagirisyaptıktansonra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastatahlilsonuclarıgorme hastatahlilgorm1 = new hastatahlilsonuclarıgorme();
            hastatahlilgorm1.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastarandevualma hastarandevualma = new hastarandevualma();
            hastarandevualma.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            girişekrani girisekrani1 = new girişekrani();
            girisekrani1.Show();
            this.Visible = false;
        }
    }
}
