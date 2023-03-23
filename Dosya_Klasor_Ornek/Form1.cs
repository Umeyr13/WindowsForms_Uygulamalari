using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Klasor_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            List<Personel> list = new List<Personel>();
            database db = new database();
        private void button_Liste_Click(object sender, EventArgs e)
        {

          list = db.personel_getir(100);
            list_Personel.DataSource = list;
           
        }

        private void button_Prsl_Kaydet_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < db.people.Count; i++)
            //{
            // string dosyaismi = db.people[i].ulke;
            //Directory.CreateDirectory(@"C:\Users\SABAH YAZILIM\Desktop\Ulkeler\" + dosyaismi);
            //Directory.CreateDirectory(@"C:\Users\SABAH YAZILIM\Desktop\Ulkeler\"+dosyaismi+@"\"+db.people[i].isim+db.people[i].soyisim);
            //}
           
            DirectoryInfo klasoradi;
            for (int i = 0; i < list_Personel.Items.Count; i++)
            {//\Users\SABAH YAZILIM\Desktop
                if (!Directory.Exists(@"C:\Ulkeler\"+list[i].ulke))//biz kontrol ediyoruz varsa başka oluşturma diye. Ama bu kod zaten aynı dosyadan sadece bir tane oluşturuyor. Sormak lazım...
                {
                    Directory.CreateDirectory(@"C:\\Ulkeler\" + list[i].ulke);
                }
                if (!Directory.Exists(@"C:\Ulkeler\" + list[i].ulke + @"\" + list[i].isim + list[i].soyisim))
                {
                   Directory.CreateDirectory(@"C:\Ulkeler\" + list[i].ulke + @"\" + list[i].isim + list[i].soyisim);
                }
                if (!Directory.Exists(@"C:\Ulkeler\" + list[i].ulke + @"\" + list[i].isim + list[i].soyisim+@"\Bilgiler.txt"))
                {
                    File.Create(@"C:\Ulkeler\" + list[i].ulke + @"\" + list[i].isim + list[i].soyisim + @"\Bilgiler.txt").Close();
                    
                }
                File.AppendAllText(@"C:\Ulkeler\" + list[i].ulke + @"\" + list[i].isim + list[i].soyisim + @"\Bilgiler.txt", list[i].email + list[i].firmaAdi);
   
            }

        }
    }
}
