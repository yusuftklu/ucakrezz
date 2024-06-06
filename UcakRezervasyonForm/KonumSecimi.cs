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

namespace UcakRezervasyonForm
{
    public partial class KonumSecimi : Form
    {
        public static int konumNoTo;
        public static int konumNoFrom;
        public KonumSecimi()
        {
            InitializeComponent();
        }

        private void KonumSecimi_Load(object sender, EventArgs e)
        {

            DuzenleyiciMethodlar duzenleyici = new DuzenleyiciMethodlar();
            duzenleyici.KonumListeleyici(ref listBoxForChoice, Login.konumlar);

        }

        private void btnKalkis_Click(object sender, EventArgs e)
        {
            konumNoFrom = Convert.ToInt32(Kalkis.Text);
            if (konumNoFrom < 0 || konumNoFrom > Login.konumlar.Count)
            {
                lblKalkis.Text = "Listede olmayan bir seçim yaptınız!";
                lblKalkis.BackColor = Color.Red;
            }
            else
            {
                if (Login.konumlar[konumNoFrom - 1].KapaliMi)
                {
                    lblKalkis.Text = "Kapalı olan bir konum seçtiniz!";
                    lblKalkis.BackColor = Color.Red;
                }
                else
                {
                    lblKalkis.Text = "Secim başarılı";
                    lblKalkis.BackColor = Color.Green;
                    Varis.Visible = true;
                    btnVaris.Visible = true;
                }

            }
        }

        private void btnVaris_Click(object sender, EventArgs e)
        {
            konumNoTo = Convert.ToInt32(Varis.Text);
            if (konumNoTo < 0 || konumNoTo > Login.konumlar.Count)
            {
                lblVaris.Text = "Listede olmayan bir seçim yaptınız!";
                lblVaris.BackColor = Color.Red;
            }
            else
            {
                if (Login.konumlar[konumNoTo - 1].KapaliMi)
                {
                    lblVaris.Text = "Kapalı olan bir konum seçtiniz!";
                    lblVaris.BackColor = Color.Red;
                }
                else
                {
                    lblVaris.Text = "Secim başarılı";
                    lblVaris.BackColor = Color.Green;
                    lblDevam.Visible = true;
                    btnDevam.Visible = true;
                }

            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            Rota rota = new Rota();
            rota.ShowDialog();
        }
    }

}
