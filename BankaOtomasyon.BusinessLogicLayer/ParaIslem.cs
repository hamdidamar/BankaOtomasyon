using BankaOtomasyon.DataAccessLayer;
using BankaOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon.BusinessLogicLayer
{
   public class ParaIslem
    {
        ParaIslemleri paraislem;
        public ParaIslem()
        {
            paraislem = new ParaIslemleri();
        }
        public void ParaCek(decimal cekilecektutar)
        {
            paraislem.ParaCek(cekilecektutar);
        }
        public void ParaYatir(decimal yatirilacaktutar)
        {
            paraislem.ParaYatir(yatirilacaktutar);
        }
        public Hesaplar BakiyeSorgula(Hesaplar hesap)
        {
            return paraislem.BakiyeSorgula(hesap);
        }
    }
}
