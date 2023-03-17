using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.ComponentModel; Bunu Ekledik  Attribute
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_To_Do_Uygulaması
{
    public class To_Do_Class
    {
        
        public Guid id { get; set; }
        [DisplayName("Başlık")]
        public string baslik { get; set; }
        [DisplayName("Özet Bilgi")]
        public string ozetbilgi { get; set; }
        [DisplayName("Açıklama")]
        public string aciklama { get; set; }
        [DisplayName("Önem Derecesi")]
        public int onemDerecesi { get; set; }
        [DisplayName ("Durum")]
        public string durum { get; set; }
        public DateTime kayitTarihi { get; set; }
    }
}
