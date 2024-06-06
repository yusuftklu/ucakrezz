﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonForm.Interfaces
{
    public interface IUcus
    {
        public int UcusNo { get; set; }
        public int Nereden { get; set; }
        public int Nereye { get; set; }
        public double UcusSuresi { get; set; }
        public int RezerveYolcuSayisi { get; set; }
        public string UcakSeriNo { get; set; }
        public DateTime UcusTarihi  { get; set; }

    }
}
