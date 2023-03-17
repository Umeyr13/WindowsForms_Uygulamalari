using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    public  class Musteriler
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return Ad + " " + SoyAd + " " + Email;
        }

    }

    public  class SanalDb
    {
   
       public static List<Musteriler> S_db = new List<Musteriler>();


    }
}
