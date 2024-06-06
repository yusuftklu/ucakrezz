using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakRezervasyonForm.Models;

namespace UcakRezervasyonForm.Methods
{
    public class DuzenleyiciMethodlar
    {
        public void KonumListeleyici(ref ListBox listBox,List<Lokasyon> konumlar)
        {
            String konumString = "";
            foreach (var item in konumlar)
            {
                konumString =
                    (item.LokasyonNo.ToString() + ", "
                    + item.Ulke + ", "
                    + item.Sehir + ", "
                    + item.Havaalani + ", "
                    + item.KapaliMi.ToString());
                listBox.Items.Add(konumString);
            }
        }
        public void RotaListeleyici(ref ListBox listBox, List<Ucak> ucaklar, List<Ucus> ucuslar, ref Ucak ucak)
        {
            int kalanKoltuk;
            
            foreach (var item in ucuslar)
            {
                if (item.Nereden == KonumSecimi.konumNoFrom && item.Nereye == KonumSecimi.konumNoTo)
                {
                    string txtForListBox = ("Uçuş Numarası: " + item.UcusNo);
                    ucak = ucaklar.FirstOrDefault(u => u.SeriNo == item.UcakSeriNo);
                    txtForListBox += ", Uçak Modeli: " + ucak.Model;
                    kalanKoltuk = ucaklar.FirstOrDefault(u => u.SeriNo == item.UcakSeriNo).KoltukKapasitesi - item.RezerveYolcuSayisi;
                    txtForListBox += (", Kalan Koltuk: " + kalanKoltuk);
                    txtForListBox += (", Ucuş tarihi: " + item.UcusTarihi);
                    listBox.Items.Add(txtForListBox);
                }
            }
        }
    }
}
