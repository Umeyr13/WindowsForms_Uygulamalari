using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinası
{
    internal class Islemler
    {
        float Sonuc;

        public float Topla(float s1, float s2)
        {
            Sonuc = s1+s2;
            return Sonuc;
        }
        public float Cikar(float s1, float s2)
        {
            Sonuc = s1-s2;
            return Sonuc;
        }
        public float Bol(float s1, float s2)
        {

            Sonuc = s1/s2;
            return Sonuc;    
        }
        public float Carp(float s1, float s2)
        {
            Sonuc = s1*s2;
            return Sonuc;
        }
    }
}
