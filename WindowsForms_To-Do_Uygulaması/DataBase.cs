using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_To_Do_Uygulaması
{
    public static class DataBase
    {
        public static List<Kullanici> kullanicilar = new List<Kullanici>();
        public static List<To_Do_Class> to_Do_list_class = new List<To_Do_Class>();
        static DataBase()
        {
            kullanicilar.Add(new Kullanici(){ id = Guid.NewGuid(), kullaniciAdi="umeyr", sifre = "1334"});
        }
        public static int KayitEkle(To_Do_Class item)
        {
            try
            {
                to_Do_list_class.Add(item);
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }

    }
}
