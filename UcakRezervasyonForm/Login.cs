using System.Runtime.InteropServices;
using System.Text.Json;
using UcakRezervasyonForm.Methods;
using UcakRezervasyonForm.Models;

namespace UcakRezervasyonForm
{
    public partial class Login : Form
    {
        public static List<Lokasyon> konumlar = new List<Lokasyon>();
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listele_Click(object sender, EventArgs e)
        {
            DosyadanOkuma okuyucu = new DosyadanOkuma();
           // List<Lokasyon> konumlar = new List<Lokasyon>();
            konumlar = okuyucu.KonumlariOku();
           DuzenleyiciMethodlar duzenleyici = new DuzenleyiciMethodlar();
            duzenleyici.KonumListeleyici(ref listBox2,konumlar);
            label2.Text = "Seçim ekranýna gitmek için devam butonuna basýnýz";
            BtnNext.Visible = true;
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            KonumSecimi konumSecimi = new KonumSecimi();
            konumSecimi.ShowDialog();
        }
    }
}
