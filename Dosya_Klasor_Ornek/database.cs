using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosya_Klasor_Ornek
{
    public class database
    {
        public List<Personel> people = new List<Personel>();
        public List<Personel> personel_getir(int adet)
        {
            for (int i = 0; i < adet; i++)
            {
                Personel p = new Personel   ();
                p.id = i+1;
                p.isim = FakeData.NameData.GetFirstName();
                p.soyisim = FakeData.NameData.GetSurname();
                p.firmaAdi = FakeData.NetworkData.GetDomain();
                p.email = p.isim+"."+p.soyisim+"@"+p.firmaAdi;
                p.ulke =FakeData.PlaceData.GetCountry();
                people.Add(p);
            }

            return people;
        }
    }
}
