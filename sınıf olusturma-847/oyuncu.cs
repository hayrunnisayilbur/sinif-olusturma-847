using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_olusturma_847
{
    internal class oyuncu
    {
        public string Id {  get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Posta { get; set; }
        public double Puan { get; set; }
        public DateTime KayitTarih { get; set; }
        public bool Aktif { get; set; }

    }
}
