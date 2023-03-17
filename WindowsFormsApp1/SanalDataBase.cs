using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SanalDataBase
    {
        public static List<Kullanici> kullanicilar = new List<Kullanici>();

         static SanalDataBase()
        {
            kullanicilar.Add(new Kullanici() { 
                ID =1
                , Ad= "Umeyr"
                , SoyAd= "Gülçimen"
                , KullaniciAdi="umery"
                , Sifre= "1234"
                , Aciklama="Yönetici Kullaıcı"});

            kullanicilar.Add(new Kullanici()
            {
           ID = 2
          ,Ad = "Misafir"
          ,SoyAd = "Kullanıcı"
          ,KullaniciAdi = "guest"
          ,Sifre = "1"
          ,Aciklama = "Misafir Kullaıcı"
            });
        }
    }
}
