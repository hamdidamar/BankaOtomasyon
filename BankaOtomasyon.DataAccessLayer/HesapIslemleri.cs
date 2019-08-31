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
   public class HesapIslemleri
    {
        DBHelper dbhelper;
        public HesapIslemleri()
        {
            dbhelper = new DBHelper();
        }
        public void HesapEkle(Hesaplar hesap)
        {
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = "INSERT INTO TBL_HESAPLAR(HesapNo,HesapSahibi,HesapIBAN,HesapSKT,HesapBakiye,HesapSifre,HesapCVV,HesapDetay)"
                + "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            cmd.Parameters.AddWithValue("@p1", hesap.HesapNo);
            cmd.Parameters.AddWithValue("@p2", hesap.HesapSahibi);
            cmd.Parameters.AddWithValue("@p3", hesap.HesapIBAN);
            cmd.Parameters.AddWithValue("@p4", hesap.HesapSKT);
            cmd.Parameters.AddWithValue("@p5", hesap.HesapBakiye);
            cmd.Parameters.AddWithValue("@p6", hesap.HesapSifre);
            cmd.Parameters.AddWithValue("@p7", hesap.HesapCVV);
            cmd.Parameters.AddWithValue("@p8", hesap.HesapDetay);
            cmd.ExecuteNonQuery();
        }
        public void HesapSil(Hesaplar hesap)
        {
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = "DELETE FROM TBL_HESAPLAR WHERE HesapNo = @p1";
            cmd.Parameters.AddWithValue("@p1", hesap.HesapNo);
            cmd.ExecuteNonQuery();
        }
        public void HesapGuncelle(Hesaplar hesap)
        {
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = "UPDATE TBL_HESAPLAR SET HesapNo = @p1,HesapSahibi = @p2,HesapIBAN = @p3,HesapSKT = @p4,HesapBakiye = @p5,"
                + "HesapSifre = @p6,HesapCVV = @p7,HesapDetay = @p8 WHERE HesapID = @p9 ";
            cmd.Parameters.AddWithValue("@p1", hesap.HesapNo);
            cmd.Parameters.AddWithValue("@p2", hesap.HesapSahibi);
            cmd.Parameters.AddWithValue("@p3", hesap.HesapIBAN);
            cmd.Parameters.AddWithValue("@p4", hesap.HesapSKT);
            cmd.Parameters.AddWithValue("@p5", hesap.HesapBakiye);
            cmd.Parameters.AddWithValue("@p6", hesap.HesapSifre);
            cmd.Parameters.AddWithValue("@p7", hesap.HesapCVV);
            cmd.Parameters.AddWithValue("@p8", hesap.HesapDetay);
            cmd.Parameters.AddWithValue("@p9", hesap.HesapID);
            cmd.ExecuteNonQuery();
        }
        public DataTable HesapGetir()
        {
            Hesaplar hesap = new Hesaplar();
            SqlCommand cmd = dbhelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM TBL_HESAPLAR ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                hesap.HesapID = dt.Rows[0].Field<int>("HesapID");
                hesap.HesapNo = dt.Rows[0].Field<string>("HesapNo").ToString();
                hesap.HesapSahibi = dt.Rows[0].Field<string>("HesapSahibi").ToString();
                hesap.HesapIBAN = dt.Rows[0].Field<string>("HesapIBAN").ToString();
                hesap.HesapSKT = dt.Rows[0].Field<string>("HesapSKT").ToString();
                hesap.HesapBakiye = dt.Rows[0].Field<decimal>("HesapBakiye");
                hesap.HesapSifre = dt.Rows[0].Field<int>("HesapSifre");
                hesap.HesapCVV = dt.Rows[0].Field<int>("HesapCVV");
                hesap.HesapDetay = dt.Rows[0].Field<string>("HesapDetay").ToString();
                
            }
            return dt;
        }
    }
}
