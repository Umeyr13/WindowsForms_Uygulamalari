using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinası
{
    public partial class Form1 : Form
    {
        float s1, s2, sonuc;
        string sayi="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            sayi += "2";
            label_ekran.Text = sayi;
            s1 += float.Parse("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            sayi += "3";
            label_ekran.Text = sayi;
            s1 += float.Parse("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            sayi += "4";
            label_ekran.Text = sayi;
            s1 += float.Parse("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            sayi += "5";
            label_ekran.Text = sayi;
            s1 += float.Parse("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            sayi += "6";
            label_ekran.Text = sayi;
            s1 += float.Parse("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            sayi += "7";
            label_ekran.Text = sayi;
            s1 += float.Parse("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            sayi += "8";
            label_ekran.Text = sayi;
            s1 += float.Parse("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            sayi += "9";
            label_ekran.Text = sayi;
            s1 += float.Parse("9");
        }

        private void button_toplam_Click(object sender, EventArgs e)
        {
            
            sonuc = s1 + s2;
            label1.Text = (s1.ToString() + "+" + s2.ToString() + "=" + sonuc.ToString());
            s2 = s1;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            sayi += "0";
            label_ekran.Text = sayi;
            s1 += float.Parse("0");
        }

       

        private void btn_1_Click(object sender, EventArgs e)
        {   

            sayi += "1";
            label_ekran.Text = sayi;
            s1 += float.Parse("1");
            
        }
    }
}
