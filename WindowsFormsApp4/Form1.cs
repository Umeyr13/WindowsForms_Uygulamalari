using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cmb_urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            object nesne = cmb_urunler.SelectedItem;
            if (nesne is Urun)
            {
                Urun u1 = (Urun)nesne;
                text_ad.Text = u1.UrunAdi;
                textKategori.Text = u1.Kategori;
                textStok.Text = u1.Stok.ToString();
                textYazar.Text = u1.Yazar;
                textAciklama.Text = u1.Aciklama;
                pictureBox1.Image = Image.FromFile(u1.UrunResim);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                text_ad.Text = string.Empty;
                textKategori.Text = string.Empty ;
                textStok.Text = string.Empty ;
                textYazar.Text = string.Empty ;
                textAciklama.Text = string .Empty ;
                pictureBox1.Image = null;


            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboboxDoldur();
            // ListboxDoldur();
            foreach (Urun item in SanalDb.urunler)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void ComboboxDoldur()
        {
            cmb_urunler.SelectedIndex = 0;
           // cmb_urunler.DisplayMember = "UrunAdi";//database ile aynı isim olmalı
            cmb_urunler.DataSource = SanalDb.urunler.ToList();
            
            //foreach (var item in SanalDb.urunler)
            //{
            //    cmb_urunler.Items.Add(item);
            //}
        }
        private void ListboxDoldur()
        {
            listUrunler.DisplayMember = "ID";//tostring i override etMEYİP BU YÖNTEM DE KULLANILABİLİR **13
            listUrunler.ValueMember = "ID";//Bunu ekranda göstermez ama kendi tutar. value member
            listUrunler.DataSource = SanalDb.urunler;//.ToList();

            //2. YOl
            //foreach (var item in SanalDb.urunler)
            //{
            //    listUrunler.Items.Add(item);
            //}

        }

        private void listUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
           int adet =  listUrunler.SelectedItems.Count;
            if (adet == 1)
            {
                Urun u = listUrunler.SelectedItem as Urun;
                text_ad.Text = u.UrunAdi;
                textKategori.Text = u.Kategori;
                textAciklama.Text = u.Aciklama;
               // pictureBox1.Image=u.UrunResim;

            }else if (adet >1)
            {
                List<Urun> secilenurun = new List<Urun>();
                foreach (Urun item in listUrunler.SelectedItems)
                {
                    secilenurun.Add(item);
                }
                SecilenUrunler sf = new SecilenUrunler(secilenurun);
                sf.ShowDialog();

            }
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        //  //MessageBox.Show(SanalDb.urunler[1].UrunResim);
        //  Image.FromFile(SanalDb.urunler[1].UrunResim);
        //OpenFileDialog a=new OpenFileDialog();
        //    a.
        //  PictureBox pictureBox = new PictureBox();
        //    pictureBox.Image = pictureBox1.Image;
            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                Urun u = (Urun)checkedListBox1.Items[e.Index];
                text_ad.Text = u.UrunAdi;
                textKategori.Text = u.Kategori;
                textStok.Text = u.Yazar;
                textAciklama.Text = u.Aciklama;
                pictureBox1.Image = Image.FromFile(u.UrunResim);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i!=e.Index)
                {
                    checkedListBox1.SetItemChecked(i,false);
                }
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
