using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SiparisSistemi
{
    public partial class CalisanEkrani : Form
    {
        private Kullanici gecerliKullanici;


        public CalisanEkrani()
        {
            InitializeComponent();
        }
        private void CalisanEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }





    }
}
