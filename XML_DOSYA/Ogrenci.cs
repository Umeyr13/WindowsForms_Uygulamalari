using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_DOSYA
{
    public class Ogrenci
    {
        public Guid Id { get; set; }
        public string Isım { get; set; }
        public string Soyisim { get; set; }
        public int OgrenciNo { get; set; }

        public override string ToString()
        {
            return Isım +" "+ Soyisim +" "+ OgrenciNo;
        }
    }
}
