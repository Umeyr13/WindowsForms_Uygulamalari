using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_DataGridView
{
    public partial class MusteriDetay : Form
    {
       // List<Musteri> musteri = new List<Musteri>();
        Musteri Liste;
        public MusteriDetay(Musteri musteri )
        {
            InitializeComponent();
            Liste = musteri;
        }

        private void MusteriDetay_Load(object sender, EventArgs e)
        {
            textisim.Text = Liste.Isim;
            textsoyisim.Text = Liste.SoyIsım;
            textemail.Text = Liste.Email;
            texttelefon.Text = Liste.Telefon;
            textIl.Text = Liste.Il;
            textIlce.Text = Liste.Ilce;
            textAdres.Text = Liste.Adres;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Database db = new Database();
            
           Musteri guncelle = db.MusteriListele().FirstOrDefault(i =>i.Id ==Liste.Id);
            guncelle.Isim = textisim.Text;
            guncelle.SoyIsım = textsoyisim.Text;
            
            
        }
    }
}
