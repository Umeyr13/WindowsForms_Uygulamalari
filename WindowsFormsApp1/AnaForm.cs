using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AnaForm : Form
    {
        public AnaForm(Kullanici kullanici)
        {
            InitializeComponent();
            textBox1.Text = kullanici.Ad;
            textBox2.Text = kullanici.SoyAd;
            textBox3.Text = kullanici.KullaniciAdi;
            textBox4.Text = kullanici.Sifre;
            textBox5.Text = kullanici.Aciklama;
            bbtn_guncelle.Tag = kullanici.ID;
            int bulunanID = kullanici.ID;
        }

        private void bbtn_guncelle_Click(object sender, EventArgs e)
        {
            int id =(int)bbtn_guncelle.Tag;//int.parse();da olur
            int index = SanalDataBase.kullanicilar.FindIndex(i=> i.ID==id); 
            SanalDataBase.kullanicilar[index].Ad = textBox1.Text;
            SanalDataBase.kullanicilar[index].SoyAd = textBox2.Text;
            SanalDataBase.kullanicilar[index].KullaniciAdi = textBox3.Text;
            SanalDataBase.kullanicilar[index].Sifre = textBox4.Text;
            SanalDataBase.kullanicilar[index].Aciklama = textBox5.Text;
            MessageBox.Show("Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor=Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DialogResult cevap=  MessageBox.Show("Çıkmak istediğinize emin misiniz?","Çıkış",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Close();

            }
            else if (cevap == DialogResult.No)
            {
               
            }
        }
    }
}
