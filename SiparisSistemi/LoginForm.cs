using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SiparisSistemi
{
    public partial class LoginForm : Form
    {
        private List<Kullanici> kullaniciListesi = new List<Kullanici>();

        public LoginForm()
        {
            InitializeComponent();

            kullaniciListesi.Add(new Kullanici { Ad = "Admin", Soyad = "Admin", Eposta = "admin", Sifre = "admin" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Eposta = txtEposta.Text,
                Sifre = txtSifre.Text
            };

            kullaniciListesi.Add(yeniKullanici);

            MessageBox.Show("Kayýt baþarýyla tamamlandý.");
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eposta = txtLoginEposta.Text;
            string sifre = txtLoginSifre.Text;

            Kullanici girisYapanKullanici = kullaniciListesi.Find(k => k.Eposta == eposta);

            if (girisYapanKullanici != null)
            {
                if (girisYapanKullanici.Sifre == sifre)
                {
                    int yetki = comboBox1.SelectedIndex + 1;

                    switch (yetki)
                    {
                        case 1:
                            AdminEkrani adminForm = new AdminEkrani();
                            adminForm.Show();
                            adminForm.FormClosed += ChildFormClosed;
                            this.Hide();
                            break;

                        case 2:
                            CalisanEkrani calisanForm = new CalisanEkrani();
                            calisanForm.Show();
                            calisanForm.FormClosed += ChildFormClosed;
                            this.Hide();
                            break;

                        case 3:
                            MusteriEkrani musteriForm = new MusteriEkrani();
                            musteriForm.Show();
                            musteriForm.FormClosed += ChildFormClosed;
                            this.Hide();
                            break;

                        default:
                            MessageBox.Show("Geçersiz yetki seçimi");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Þifre hatalý. Lütfen þifrenizi kontrol edin.");
                }
            }
            else
            {
                MessageBox.Show("Kullanýcý bulunamadý. Lütfen e-posta adresinizi kontrol edin.");
            }
        }

        private void ChildFormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEposta.Clear();
            txtSifre.Clear();
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
