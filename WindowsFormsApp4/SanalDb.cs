using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class SanalDb
    {
        public static List<Urun> urunler = new List<Urun>() 
        {
            new Urun(){ID = 1, UrunAdi = "Şeker Portakalı", Kategori = "Roman", Stok = 50, Yazar ="Jose De Vasconcelos", Aciklama = "2023 basım", UrunResim = @"C:\Users\SABAH YAZILIM\Desktop\ESKİ\user_1.jpg"},
            
            new Urun(){ID = 2, UrunAdi ="2. ürün", Kategori = "2.kategori", Stok = 25, Yazar = "Jose", Aciklama = "Kalmadı", UrunResim = @"C:\Users\SABAH YAZILIM\Desktop\ESKİ\logout-icon.png"}


        
            
        };
    }
}
