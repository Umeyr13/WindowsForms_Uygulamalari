using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_To_Do_Uygulaması
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void textKullaniciAdi_Enter(object sender, EventArgs e)
        {
           TextBox T = sender as TextBox;
            T.BackColor = Color.MistyRose;
        }

        private void textKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = SystemColors.Window;
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            //Kullanici k = (Kullanici)(DataBase.kullanicilar.Where(i => i.kullaniciAdi == textKullaniciAdi.Text && i.sifre == textSifre.Text));
            if (!string.IsNullOrEmpty(textKullaniciAdi.Text)&& !string.IsNullOrEmpty(textSifre.Text))
            {
                Kullanici k = DataBase.kullanicilar.FirstOrDefault(i => i.kullaniciAdi == textKullaniciAdi.Text && i.sifre == textSifre.Text);
                if (k!=null)
                {
                   Form f = Application.OpenForms["anaform"];
                    (f.Controls["panel1"].Controls["groupIslemler"]).Enabled=true;//ana formun içindeki panelin içindeki grupbox ın aktifliğini değiştirdik .d
                    this.Close();
                   


                }else MessageBox.Show("Kullanıcı adı/şifre hatalı...");
            }else MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
