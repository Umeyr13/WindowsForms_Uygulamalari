using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void bbtn_Ekle_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Yeni müşteri eklemek istediğinize emin misiniz? ","Yeni Müşteri",   MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Musteri_Ekle();
                bildirim1 = new NotifyIcon();
                bildirim1.BalloonTipText="Toplam müşteri kaydı:"+SanalDb.S_db.Count.ToString();
                bildirim1.BalloonTipTitle = "Müşteri Adeti";
                bildirim1.Visible = true;
                bildirim1.Icon = SystemIcons.Information;
                bildirim1.ShowBalloonTip(2000);

                EkranTemizle();
                lstMüsteriler.DataSource = SanalDb.S_db.ToList();
            }

        }
        private void EkranTemizle()
        {
            //button eklendiğinde this.controls.Add(); gibi birşey oluşur.
            //foreach (Control item in this.Controls)
            //{
                
            //    foreach (Control item2 in item.Controls) //groupBox1.Controls buda oldu.
            //    {
            //        if (item2 is TextBox)
            //        {
            //            item2.Text = String.Empty;
            //        }
            //        MessageBox.Show(item2.Name);
            //    }
            //}
            //txt_Ad.Text = String.Empty;
            //Txt_SoyAd.Text = String.Empty;
            //Txt_Email.Text = String.Empty;
            //Txt_Telefon.Text = String.Empty;
          ((GroupBox) this.Controls["groupBox1"]).Controls["txt_Ad"].Text = string.Empty; //bu da olur.
            //groupBox1 in controllerinin textbox ında text ı boşalt.

        }
        
        private void Musteri_Ekle()
        {
            Musteriler M = new Musteriler()
            {
                ID = Guid.NewGuid(),//Örnek Guid kodu// {26F08806-0D29-46E9-8A13-F894DF576CEF}
   
                Ad = txt_Ad.Text,
                SoyAd = Txt_SoyAd.Text,
                Email = Txt_Email.Text,
                Telefon = Txt_Telefon.Text                 
            };
            
            SanalDb.S_db.Add(M);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıtbilgisi kayıtbilgisi = new kayıtbilgisi();
            ((TextBox)kayıtbilgisi.Controls["txt_Ad"]).Text = txt_Ad.Text;
            ((TextBox)kayıtbilgisi.Controls["Txt_SoyAd"]).Text = Txt_SoyAd.Text;
            ((TextBox)kayıtbilgisi.Controls["Txt_Email"]).Text = Txt_Email.Text;
            ((TextBox)kayıtbilgisi.Controls["Txt_Telefon"]).Text = Txt_Telefon.Text;



            kayıtbilgisi.ShowDialog();
        }
    }
}
