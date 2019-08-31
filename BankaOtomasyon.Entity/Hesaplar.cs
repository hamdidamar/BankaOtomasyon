using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon.Entity
{
   public class Hesaplar
    {
        public int HesapID { get; set; }
        public string HesapNo { get; set; }
        public string HesapSahibi { get; set; }
        public string HesapIBAN { get; set; }
        public string HesapSKT { get; set; }
        public decimal HesapBakiye { get; set; }
        public int HesapSifre { get; set; }
        public int HesapCVV { get; set; }
        public string HesapDetay { get; set; }

    }
}
