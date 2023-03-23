using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONveCSV_Dosyalar
{
    public class Personel
    {
        public Guid guid { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public override string ToString()
        {
            return isim+" - " + soyisim+"\t\t\t - " + email +"\t\t\t - "+ telefon;
        }

    }
}
