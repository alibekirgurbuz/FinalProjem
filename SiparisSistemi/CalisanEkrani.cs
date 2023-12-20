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
    public partial class CalisanEkrani : Form
    {
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
