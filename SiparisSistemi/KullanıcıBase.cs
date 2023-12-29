using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisSistemi
{
     public abstract class KullanıcıBase
    {
        public int KullanıcıID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public int Yas { get; set; }
        public string Telefon { get; set; }
    }
}
