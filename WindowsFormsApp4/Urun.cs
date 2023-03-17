using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Urun
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public string UrunResim { get; set; }
        public int Stok { get; set; }
        public string Yazar { get; set; }
        public string Aciklama { get; set; }
        //***13 deki kodu açtık bu da olur.
        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
