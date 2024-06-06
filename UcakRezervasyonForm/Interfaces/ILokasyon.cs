﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonForm.Interfaces
{
    public interface ILokasyon
    {
        public int LokasyonNo { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Havaalani { get; set; }
        public bool KapaliMi { get; set; }

    }
}
