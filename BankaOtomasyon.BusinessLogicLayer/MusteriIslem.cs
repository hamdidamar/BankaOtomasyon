using BankaOtomasyon.DataAccessLayer;
using BankaOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon.BusinessLogicLayer
{
   public class MusteriIslem
    {
        MusteriIslemleri musteriislem;
        public MusteriIslem()
        {
            musteriislem = new MusteriIslemleri();
        }
        public void MusteriEkle(Musteriler musteri)
        {
            musteriislem.MusteriEkle(musteri);
        }
        public void MusteriSil(Musteriler musteri)
        {
            musteriislem.MusteriSil(musteri);
        }
        public void MusteriGuncelle(Musteriler musteri)
        {
            musteriislem.MusteriGuncelle(musteri);
        }
        public DataTable MusteriGetir()
        {
            return musteriislem.MusteriGetir();
        }
    }
}
