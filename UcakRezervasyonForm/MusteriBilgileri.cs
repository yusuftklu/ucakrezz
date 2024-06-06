using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakRezervasyonForm.Models;
using UcakRezervasyonKonsol.Methods;

namespace UcakRezervasyonForm
{
    public partial class MusteriBilgileri : Form
    {
        Musteri musteri = new Musteri();
        Rezervasyon rezervasyon = new Rezervasyon();
        DosyayaYazma yazici = new DosyayaYazma(); 
        Random random = new Random();
        public MusteriBilgileri()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" || txtSoyad.Text != "" || txtCins.Text != "" || txtYas.Text != "" || txtEngel.Text != "")
            {
                musteri.Ad = txtAd.Text;
                musteri.Soyad = txtSoyad.Text;
                musteri.Cinsiyet = txtCins.Text;
                musteri.Yas = Convert.ToInt32(txtYas.Text);
                musteri.YasliMi = musteri.Yas > 65 ? true : false;
                musteri.EngelliMi = txtEngel.Text == "E" ? true : false;

                yazici.MusteriKaydet(musteri);
                rezervasyon.Musteri = musteri;
                rezervasyon.Ucus =Rota.ucuslar[Rota.rotaNumber];
                rezervasyon.KoltukNo = random.Next(1, Rota.secilenUcak.KoltukKapasitesi);
                yazici.RezervasyonKaydet(rezervasyon);
                lblUyarı.Text = "Rezervasyonunuz başarıyla gerçekleşmiştir \n Koltuk Numaranız : " + rezervasyon.KoltukNo;
                lblUyarı.BackColor = Color.Green;
                Kaydet.BackColor = Color.Green;
            }
            else
            {
                lblUyarı.Text = "Eksik bilgi girdiniz kontrol ediniz !!!";
                lblUyarı.BackColor = Color.Red;
                Kaydet.BackColor = Color.Red;
            }
        }
    }
}
