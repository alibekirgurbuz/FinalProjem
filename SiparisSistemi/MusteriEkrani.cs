using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SiparisSistemi
{
    public partial class MusteriEkrani : Form, IMusteriIslemleri
    {
        private int toplamTutar = 0;

        public MusteriEkrani()
        {
            InitializeComponent();

            HesaplaButton.Click += HesaplaButton_Click;
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox12.CheckedChanged += CheckBox_CheckedChanged;
            checkBox10.CheckedChanged += CheckBox_CheckedChanged;
            checkBox11.CheckedChanged += CheckBox_CheckedChanged;
            checkBox17.CheckedChanged += CheckBox_CheckedChanged;
            checkBox18.CheckedChanged += CheckBox_CheckedChanged;
        }
        private void HesaplaButton_Click(object sender, EventArgs e)
        {
            label9.Text = toplamTutar.ToString() + " TL";
            ListeGüncelle();
        }
        public void AdGoster(string ad)
        {
            labelAD.Text = "Hoşgeldin, " + ad;
        }
        public void ListeGüncelle()
        {

            listBox1.Items.Clear();

            if (checkBox1.Checked)
                listBox1.Items.Add("Burger S Seçildi");
            if (checkBox2.Checked)
                listBox1.Items.Add("Burger M Seçildi");
            if (checkBox3.Checked)
                listBox1.Items.Add("Burger L Seçildi");
            if (checkBox12.Checked)
                listBox1.Items.Add("Kola Seçildi");
            if (checkBox11.Checked)
                listBox1.Items.Add("Fanta Seçildi");
            if (checkBox10.Checked)
                listBox1.Items.Add("Sprite Seçildi");
            if (checkBox18.Checked)
                listBox1.Items.Add("Patates Seçildi");
            if (checkBox17.Checked)
                listBox1.Items.Add("Tatlı Seçildi");

        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ListeGüncelle();
            System.Windows.Forms.CheckBox checkBox = sender as System.Windows.Forms.CheckBox;

            if (checkBox != null && checkBox.Tag != null && int.TryParse(checkBox.Tag.ToString(), out int labelValue))
            {
                if (checkBox.Checked)
                {
                    toplamTutar += labelValue;
                }
                else
                {
                    toplamTutar -= labelValue;
                }
            }
        }
        private void MusteriEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Odeme odeme = new Odeme();
            odeme.Show();
            odeme.SetLabelText(label9.Text);
            odeme.FormClosed += ChildFormClosed;
            this.Hide();
        }
        private void ChildFormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        public void updateListView(string odemeBilgisi)
        {
            throw new NotImplementedException();
        }
    }
}
