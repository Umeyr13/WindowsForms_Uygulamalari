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

namespace Dosya_Ve_Klasor_Islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DirectoryInfo dı =  Directory.CreateDirectory(@"C:\Users\SABAH YAZILIM\Desktop\Yeni_Bir_Klasör");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Users\SABAH YAZILIM\Desktop\Yeni_Bir_Klasör"))
            {
                Directory.Delete(@"C:\Users\SABAH YAZILIM\Desktop\Yeni_Bir_Klasör");
                //Klasör dolu ise silmeye izin vermez.
              //  Directory.Delete(@"C:\Users\SABAH YAZILIM\Desktop\Yeni_Bir_Klasör",true);
                //içindekiler ile beraber siler
            }
            else
            {
                MessageBox.Show("Bulunamadı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C:\Users\SABAH YAZILIM\Desktop\Yeni_Bir_Klasör",textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream f = File.Create(@"C:\Users\SABAH YAZILIM\Yeni_Bir_Klasör\deneme.txt");
            f.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Move(@"C:\Users\SABAH YAZILIM\Yeni_Bir_Klasör\deneme.txt", @"C:\Users\SABAH YAZILIM\Desktop\taşıdım.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool dosyavarmı = File.Exists(@"C:\Users\SABAH YAZILIM\Desktop\taşıdım.txt");
            if (dosyavarmı)
            {
                File.Delete(@"C:\Users\SABAH YAZILIM\Desktop\taşıdım.txt");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Copy(@"C:\Users\SABAH YAZILIM\Desktop\taşıdım.txt", @"C:\Users\SABAH YAZILIM\Desktop\taşıdım_copy.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\Users\SABAH YAZILIM\Desktop\Yeni Metin Belgesi.txt",textVeriEkle.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
          textVeriEkle.Text=  File.ReadAllText(@"C:\Users\SABAH YAZILIM\Desktop\Yeni Metin Belgesi.txt");
        }
    }
}
