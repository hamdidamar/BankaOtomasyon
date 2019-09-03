using BankaOtomasyon.DataAccessLayer;
using BankaOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon.BusinessLogicLayer
{
   public class DigerIslem
    {
        DigerIslemler digerislem;
        public DigerIslem()
        {
            digerislem = new DigerIslemler();
        }
        public void HavaleYap(Musteriler musteri, Hesaplar hesap)
        {
            digerislem.HavaleYap(musteri,hesap);
        }
        public void EFTYap(Musteriler musteri, Hesaplar hesap)
        {
            digerislem.EFTYap(musteri, hesap);
        }
        public void FaturaOde(Musteriler musteri, Hesaplar hesap)
        {
            digerislem.FaturaOde(musteri, hesap);
        }
        public void TLYukle(Musteriler musteri, Hesaplar hesap)
        {
            digerislem.TLYukle(musteri, hesap);
        }
        public void BorcOde(Musteriler musteri, Hesaplar hesap)
        {
            digerislem.BorcOde(musteri, hesap);
        }
    }

}
