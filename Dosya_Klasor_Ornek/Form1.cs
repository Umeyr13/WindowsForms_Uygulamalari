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
                if (!Directory.Exists(@"C:\Users\SABAH YAZILIM\Desktop\Ulkeler\"+list[i].ulke))
                {
                    File.Create(@"C:\Ulkeler\" + list[i].ulke + @"\" + list[i].isim + list[i].soyisim + @"\Bilgiler.txt").Close();
                    
                }
                File.AppendAllText(@"C:\Ulkeler\" + list[i].ulke + @"\" + list[i].isim + list[i].soyisim + @"\Bilgiler.txt", list[i].email + list[i].firmaAdi);
   
            }

                }                               
            }
            //2. Yöntem dosyaya yazı yazma. Close dan önce yapılır.
            byte[] bytedizi = new UTF8Encoding(true).GetBytes("Buraya yazılan veri byte dizisine dönüşür");
            FileStream fs;
            //fs.Write(bytedizi, 0, bytedizi.Length);
           // fs.Close();
        }

        private void list_Personel_Click(object sender, EventArgs e)
        {
         Personel p = (Personel)list_Personel.SelectedItem;
            textBox1.Text = p.isim;
            textBox2.Text = p.soyisim;
            textBox3.Text = p.email;
            textBox4.Text = p.ulke;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
