using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakRezervasyonForm.Models;
using System.IO;
using System.Text.Json;

namespace UcakRezervasyonForm.Methods
{
    public class DosyadanOkuma
    {
        public List<Ucak> UcaklariOku()
        {
            List<Ucak> ucaklar = new List<Ucak>();

            string filePath = @"C:\Users\enese\source\repos\UcakRezervasyonForm\UcakRezervasyonForm\Datas\Ucaklar.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (StreamReader sr = new StreamReader(fileStream))
            {
                string satir;

                while ((satir = sr.ReadLine()) != null)
                {
                    string[] parcalar = satir.Split(',');
                    Ucak ucak = new Ucak();
                    ucak.Model = parcalar[0].ToString();
                    ucak.SeriNo = parcalar[1].ToString();
                    ucak.BakimTarihi = Convert.ToDateTime(parcalar[2]);
                    ucak.KoltukKapasitesi = Convert.ToInt32(parcalar[3]);

                    ucaklar.Add(ucak);
                }
            }
            return ucaklar;
        }
        public List<Lokasyon> KonumlariOku()
        {
            List<Lokasyon> konumlar = new List<Lokasyon>();

            string filePath = @"C:\Users\enese\source\repos\UcakRezervasyonForm\UcakRezervasyonForm\Datas\Lokasyonlar.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (StreamReader sr = new StreamReader(fileStream))
            {
                string satir;
                satir = sr.ReadLine();
                konumlar = JsonSerializer.Deserialize<List<Lokasyon>>(satir);

            }
            return konumlar;
        }
        public List<Ucus> UcuslariOku()
        {
            List<Ucus> ucuslar = new List<Ucus>();

            string filePath = @"C:\Users\enese\source\repos\UcakRezervasyonForm\UcakRezervasyonForm\Datas\Ucuslar.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (StreamReader sr = new StreamReader(fileStream))
            {
                string satir;

                while ((satir = sr.ReadLine()) != null)
                {
                    string[] parcalar = satir.Split(',');
                    Ucus ucus = new Ucus();
                    ucus.UcusNo = Convert.ToInt32(parcalar[0]);
                    ucus.Nereden = Convert.ToInt32(parcalar[1]);
                    ucus.Nereye = Convert.ToInt32(parcalar[2]);
                    ucus.UcusSuresi = Convert.ToDouble(parcalar[3]);
                    ucus.RezerveYolcuSayisi = Convert.ToInt32(parcalar[4]);
                    ucus.UcakSeriNo = parcalar[5];
                    ucus.UcusTarihi = Convert.ToDateTime(parcalar[6]);
                    ucuslar.Add(ucus);
                }
            }
            return ucuslar;
        }
    }
}