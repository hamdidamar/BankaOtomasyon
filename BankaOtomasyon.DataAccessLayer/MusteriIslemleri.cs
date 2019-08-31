using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaOtomasyon.Entity;
using System.Data.SqlClient;
using System.Data;

namespace BankaOtomasyon.DataAccessLayer
{
    public class MusteriIslemleri
    {
        DBHelper dbhelper;
        public MusteriIslemleri()
        {
            dbhelper = new DBHelper();
        }
        public void MusteriEkle(Musteriler musteri)
        {

            string cmdText = string.Format( "INSERT INTO TBL_MUSTERILER (MusteriTC,MusteriAd,MusteriSoyad,MusteriDogumTarihi,MusteriTip,MusteriHesapNo,MusteriTelefon,MusteriIl,MusteriIlce,MusteriAdres) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)");
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.Parameters.AddWithValue("@p1", musteri.MusteriTC);
            cmd.Parameters.AddWithValue("@p2", musteri.MusteriAd);
            cmd.Parameters.AddWithValue("@p3", musteri.MusteriSoyad);
            cmd.Parameters.AddWithValue("@p4", musteri.MusteriDogumTarihi);
            cmd.Parameters.AddWithValue("@p5", musteri.MusteriTip);
            cmd.Parameters.AddWithValue("@p6", musteri.MusteriHesapNo);
            cmd.Parameters.AddWithValue("@p7", musteri.MusteriTelefon);
            cmd.Parameters.AddWithValue("@p8", musteri.MusteriIl);
            cmd.Parameters.AddWithValue("@p9", musteri.MusteriIlce);
            cmd.Parameters.AddWithValue("@p10",musteri.MusteriAdres);
            Console.WriteLine(musteri.MusteriAd, musteri.MusteriSoyad);
            cmd.ExecuteNonQuery();

        }
        public void MusteriSil(Musteriler musteri)
        {
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = "DELETE FROM TBL_MUSTERILER WHERE MusteriTC = @p1";
            cmd.Parameters.AddWithValue("@p1", musteri.MusteriTC);
            cmd.ExecuteNonQuery();
        }
        public void MusteriGuncelle(Musteriler musteri)
        {
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = "UPDATE TBL_MUSTERILER SET MusteriTC = @p1,MusteriAd = @p2,MusteriSoyad = @p3,MusteriDogumTarihi = @p4,MusteriTip = @p5,"
                + "MusteriHesapNo = @p6,MusteriTelefon = @p7,MusteriIl = @p8,MusteriIlce = @p9,MusteriAdres = @p10 WHERE MusteriID = @p11 ";
            cmd.Parameters.AddWithValue("@p1", musteri.MusteriTC);
            cmd.Parameters.AddWithValue("@p2", musteri.MusteriAd);
            cmd.Parameters.AddWithValue("@p3", musteri.MusteriSoyad);
            cmd.Parameters.AddWithValue("@p4", musteri.MusteriDogumTarihi);
            cmd.Parameters.AddWithValue("@p5", musteri.MusteriTip);
            cmd.Parameters.AddWithValue("@p6", musteri.MusteriHesapNo);
            cmd.Parameters.AddWithValue("@p7", musteri.MusteriTelefon);
            cmd.Parameters.AddWithValue("@p8", musteri.MusteriIl);
            cmd.Parameters.AddWithValue("@p9", musteri.MusteriIlce);
            cmd.Parameters.AddWithValue("@p10", musteri.MusteriAdres);
            cmd.Parameters.AddWithValue("@p11", musteri.MusteriID);
            cmd.ExecuteNonQuery();
        }
        public DataTable MusteriGetir()
        {
            Musteriler musteri = new Musteriler();
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM TBL_MUSTERILER ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                musteri.MusteriAd = dt.Rows[0].Field<int>("MusteriID").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriTC").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriAd").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriSoyad").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriDogumTarihi").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriTip").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriHesapNo").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriTelefon").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriIl").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriIlce").ToString();
                musteri.MusteriAd = dt.Rows[0].Field<string>("MusteriAdres").ToString();
            }
            return dt;
        }
    }
}
