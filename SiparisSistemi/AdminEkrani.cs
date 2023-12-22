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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }
        private void AdminEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            listView2.Columns.Add("AD", 100);
            listView2.Columns.Add("SOYAD", 100);
            listView2.Columns.Add("EPOSTA", 100);
            listView2.Width = 310;
        }
    }
}
