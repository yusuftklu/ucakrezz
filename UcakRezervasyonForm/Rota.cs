using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakRezervasyonForm.Methods;
using UcakRezervasyonForm.Models;

namespace UcakRezervasyonForm
{
    public partial class Rota : Form
    {
        public static List<Ucak> ucaklar = new List<Ucak>();
        public static List<Ucus> ucuslar = new List<Ucus>();
        public static Ucak secilenUcak = new Ucak();
        public static int rotaNumber;
        public Rota()
        {
            InitializeComponent();
        }

        private void Rota_Load(object sender, EventArgs e)
        {
            DosyadanOkuma okuyucu = new DosyadanOkuma();
            ucuslar = okuyucu.UcuslariOku();
            ucaklar = okuyucu.UcaklariOku();
            DuzenleyiciMethodlar duzenleyici = new DuzenleyiciMethodlar();
            duzenleyici.RotaListeleyici(ref listBoxUcus, ucaklar, ucuslar,ref secilenUcak);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {

            rotaNumber = Convert.ToInt32(rotaNo.Text);
            if (rotaNumber < 1 || rotaNumber > listBoxUcus.Items.Count)
            {
                lblSonuc.Text = "Listede olmayan bir seçim yaptınız!";
                lblSonuc.BackColor = Color.Red;
                btnDevam.Visible = false;
            }
            else
            {
                lblSonuc.Text = "Secim başarılı bir sonraki aşamaya geçmek için devam butonuna basınız";
                lblSonuc.BackColor = Color.Green;
                btnDevam.Visible = true;
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            MusteriBilgileri musteriBilgileri = new MusteriBilgileri();
            musteriBilgileri.ShowDialog();
        }
    }
}
