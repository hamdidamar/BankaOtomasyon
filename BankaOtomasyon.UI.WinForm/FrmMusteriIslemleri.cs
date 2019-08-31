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
    public partial class FrmMusteriIslemleri : Form
    {
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }
        Musteriler musteri = new Musteriler();
        MusteriIslemleri musteriislem = new MusteriIslemleri();
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            musteri.MusteriTC = txt_musteritc.Text;
            musteri.MusteriAd = txt_musteriad.Text;
            musteri.MusteriSoyad = txt_musterisoyad.Text;
            musteri.MusteriDogumTarihi = txt_musteridogumtarihi.Text;
            musteri.MusteriTip = txt_musteritip.Text;
            musteri.MusteriHesapNo = txt_musterihesapno.Text;
            musteri.MusteriTelefon = txt_musteritelefon.Text;
            musteri.MusteriIl = txt_musteriil.Text;
            musteri.MusteriIlce = txt_musteriilce.Text;
            musteri.MusteriAdres = txt_musteriadres.Text;
            try
            {
                musteriislem.MusteriEkle(musteri);
                MessageBox.Show("Müşteri Başarı İle Eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            musteri.MusteriTC = txt_musteritc.Text;
            try
            {
                musteriislem.MusteriSil(musteri);
                MessageBox.Show("Müşteri Başarı İle Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            musteri.MusteriID = int.Parse(txt_musteriid.Text);
            musteri.MusteriTC = txt_musteritc.Text;
            musteri.MusteriAd = txt_musteriad.Text;
            musteri.MusteriSoyad = txt_musterisoyad.Text;
            musteri.MusteriDogumTarihi = txt_musteridogumtarihi.Text;
            musteri.MusteriTip = txt_musteritip.Text;
            musteri.MusteriHesapNo = txt_musterihesapno.Text;
            musteri.MusteriTelefon = txt_musteritelefon.Text;
            musteri.MusteriIl = txt_musteriil.Text;
            musteri.MusteriIlce = txt_musteriilce.Text;
            musteri.MusteriAdres = txt_musteriadres.Text;
            try
            {
                musteriislem.MusteriGuncelle(musteri);
                MessageBox.Show("Müşteri Başarı İle Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            grd_musteriler.DataSource = musteriislem.MusteriGetir();
        }
    }
}
