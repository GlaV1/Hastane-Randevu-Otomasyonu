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
    public partial class hastarandevualma : Form
    {
        public hastarandevualma()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Visible = false;
            textBox1.Text = "18.30";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            textBox1.Text="09.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Text = "09.30";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            textBox1.Text = "10.00";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           button4.Visible = false;
            textBox1.Text = "10.30";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            textBox1.Text = "11.00";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            textBox1.Text = "11.30";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            textBox1.Text = "12.00";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            textBox1.Text = "12.30";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            textBox1.Text = "13.00";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            textBox1.Text = "13.30";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            textBox1.Text = "14.00";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            textBox1.Text = "14.30";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            textBox1.Text = "15.00";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            textBox1.Text = "15.30";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            textBox1.Text = "16.00";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            textBox1.Text = "16.30";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
            textBox1.Text = "17.00";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
            textBox1.Text = "17.30";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            textBox1.Text = "18.00";
        }

        private void button21_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("Randevunu Başarıyla Alınmıştır");
           



           
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hastagirisyaptıktansonra hastagirisyaptıktansonra = new hastagirisyaptıktansonra();
            hastagirisyaptıktansonra.Show();
            this.Visible = false;
        }
    }
}
