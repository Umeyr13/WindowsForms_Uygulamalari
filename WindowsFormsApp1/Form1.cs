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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txt_Kullaniciadi.Text;
            string sifre = txt_Sifre.Text;
           Kullanici bulunankullanici= SanalDataBase.kullanicilar.Find(i=> i.KullaniciAdi== kullaniciadi && i.Sifre == sifre);

            if (bulunankullanici != null)
            {
                AnaForm af = new AnaForm(bulunankullanici);
                 af.ShowDialog();//Açılan pencere kapanmadan diğerine tıklanmaz.
                //af.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txt_Sifre.BackColor = Color.Red;
                txt_Kullaniciadi.BackColor = Color.Red;
            }
        }

        private void txt_Kullaniciadi_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
            //txt_Kullaniciadi.BackColor = Color.Yellow;
        }

        private void txt_Kullaniciadi_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
            /* Hepsinde TEk Tek yazmak yerine metot oluşturduk*/
           /*  Her textbox ın event in den bu metodu seç!!   */

            //txt_Kullaniciadi.BackColor = Color.White;
        }

        private void txt_Sifre_Enter(object sender, EventArgs e)
        {
           // txt_Sifre.BackColor = Color.Yellow;
            
        }

        private void txt_Sifre_Leave(object sender, EventArgs e)
        {
          //  txt_Sifre.BackColor= Color.White;
        }
    }
}
