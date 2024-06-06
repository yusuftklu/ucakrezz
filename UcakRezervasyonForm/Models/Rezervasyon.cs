using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakRezervasyonForm.Interfaces;

namespace UcakRezervasyonForm.Models
{
    public class Rezervasyon : IRezervasyon
    {
        public Musteri Musteri { get; set; }
        public Ucus Ucus { get; set; }
        public int KoltukNo { get; set; }
    }
}
