using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_DataGridView
{
    internal class Database
    {
        public static List<Musteri> musteriler = new List<Musteri>();
        
        public List<Musteri> MusteriListele()
        {
            for (int i = 1; i < 1001; i++)
            {
                Musteri M = new Musteri();
                M.Id = 1000+i;
                M.Isim = FakeData.NameData.GetFirstName();
                M.SoyIsım = FakeData.NameData.GetSurname();
                M.Email = FakeData.NetworkData.GetEmail(M.Isim,M.SoyIsım);
                M.Telefon = FakeData.PhoneNumberData.GetUsPhoneNumber();
                M.Il = FakeData.PlaceData.GetCity();
                M.Ilce = FakeData.PlaceData.GetState();
                M.Adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(M);
                
                
            }


            return musteriler;
        }



    }
}
