using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaOtomasyon.DataAccessLayer;
using BankaOtomasyon.Entity;
using System.Data;

namespace BankaOtomasyon.BusinessLogicLayer
{
    public class HesapIslem
    {
        HesapIslemleri hesapislem;
        public HesapIslem()
        {
            hesapislem = new HesapIslemleri();
             
        }
        public void HesapEkle(Hesaplar hesap)
        {
             hesapislem.HesapEkle(hesap);
        }
        public void HesapSil(Hesaplar hesap)
        {
            hesapislem.HesapSil(hesap);
        }
        public void HesapGuncelle(Hesaplar hesap)
        {
            hesapislem.HesapGuncelle(hesap);
        }
        public DataTable HesapGetir()
        {
            return hesapislem.HesapGetir();
        }
        public Hesaplar IDHesapGetir(Hesaplar hesap)
        {
            return hesapislem.IDHesapGetir(hesap);
        }
    }
}
