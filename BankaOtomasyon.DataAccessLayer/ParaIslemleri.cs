using BankaOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon.DataAccessLayer
{
   public class ParaIslemleri
    {
        Hesaplar hesap;
        HesapIslemleri hesapislem;
        public ParaIslemleri()
        {
            hesap = new Hesaplar();
            hesapislem = new HesapIslemleri();
        }
        public void paracek(decimal cekilecektutar)
        {
            hesap.HesapBakiye -= cekilecektutar;
            hesapislem.HesapGuncelle(hesap);
        }
        public void parayatir(decimal yatirilacaktutar)
        {
            hesap.HesapBakiye += yatirilacaktutar;
            hesapislem.HesapGuncelle(hesap);
        }
        public Hesaplar bakiyesorgula(Hesaplar hesap)
        {
          return  hesapislem.IDHesapGetir(hesap);
        }
    }
}
