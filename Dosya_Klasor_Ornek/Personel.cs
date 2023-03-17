using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosya_Klasor_Ornek
{
    public class Personel
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string firmaAdi { get; set; }
        public string ulke { get; set; }
        public override string ToString()
        {

            return isim+" "+soyisim+"-"+ulke;
        }

    }
}
