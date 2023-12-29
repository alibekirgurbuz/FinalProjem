using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisSistemi
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        private void Odeme_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void SetLabelText(string text)
        {
            label6.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Radiobutton'lar kontrol ediliyor
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    label7.ForeColor = Color.Green;
                    label7.Text = "Ödeme Başarılı";
                }
                else
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "Bir Ödeme Yöntemi Seçin";
                }
            }
            else
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Kart Bilgilerini Girin";
            }
        }
    }
}
