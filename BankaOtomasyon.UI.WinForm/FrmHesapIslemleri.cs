using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaOtomasyon.Entity;
using BankaOtomasyon.DataAccessLayer;

namespace BankaOtomasyon.UI.WinForm
{
    public partial class FrmHesapIslemleri : Form
    {
        public FrmHesapIslemleri()
        {
            InitializeComponent();
        }
        Hesaplar hesap = new Hesaplar();
        HesapIslemleri hesapislem = new HesapIslemleri();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            hesap.HesapNo = txt_hesapno.Text;
            hesap.HesapSahibi = txt_hesapsahibi.Text;
            hesap.HesapIBAN = txt_hesapiban.Text;
            hesap.HesapSKT = txt_hesapskt.Text;
            hesap.HesapBakiye = decimal.Parse(txt_hesapbakiye.Text);
            hesap.HesapSifre = int.Parse(txt_hesapsifre.Text);
            hesap.HesapCVV = int.Parse(txt_hesapcvv.Text);
            hesap.HesapDetay = txt_hesapdetay.Text;
            try
            {
                hesapislem.HesapEkle(hesap);
                MessageBox.Show("Hesap Başarı İle Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                grd_hesaplar.DataSource = hesapislem.HesapGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            hesap.HesapNo = txt_hesapno.Text;
            try
            {
                hesapislem.HesapSil(hesap);
                MessageBox.Show("Hesap Başarı İle Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grd_hesaplar.DataSource = hesapislem.HesapGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            hesap.HesapID = int.Parse(txt_hesapid.Text);
            hesap.HesapNo = txt_hesapno.Text;
            hesap.HesapSahibi = txt_hesapsahibi.Text;
            hesap.HesapIBAN = txt_hesapiban.Text;
            hesap.HesapSKT = txt_hesapskt.Text;
            hesap.HesapBakiye = decimal.Parse(txt_hesapbakiye.Text);
            hesap.HesapSifre = int.Parse(txt_hesapsifre.Text);
            hesap.HesapCVV = int.Parse(txt_hesapcvv.Text);
            hesap.HesapDetay = txt_hesapdetay.Text;
            try
            {
                hesapislem.HesapGuncelle(hesap);
                MessageBox.Show("Hesap Başarı İle Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grd_hesaplar.DataSource = hesapislem.HesapGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FrmHesapIslemleri_Load(object sender, EventArgs e)
        {
            grd_hesaplar.DataSource = hesapislem.HesapGetir();
        }
    }
}
