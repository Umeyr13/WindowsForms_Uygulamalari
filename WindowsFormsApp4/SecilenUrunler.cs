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
    public partial class SecilenUrunler : Form
    {
        private List<Urun> Liste;
        public SecilenUrunler(List<Urun> secilenUrunler)
        {

            InitializeComponent();
            Liste = secilenUrunler;//buraya gelen değerlere aşağıda ki metotta ulaşa bilmek için evrensel bir değişkene gelen urunleri gönderdik.
        }

        private void SecilenUrunler_Load(object sender, EventArgs e)
        {
            foreach (var item in Liste)//Listeyi burda kullanıdık. Urunleri almış olduk.
            {
                Button btn = new Button();
                btn.Name = item.ID.ToString();
                btn.Size = new System.Drawing.Size(130,30);
                btn.Text = item.UrunAdi;
                btn.UseVisualStyleBackColor = true;
                btn.Tag=item;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }



          /*this.button1.Location = new System.Drawing.Point(526, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);*/
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (sender as Button);
            Urun U = b.Tag as Urun;


          Form f1 =  Application.OpenForms["Form1"];
            GroupBox g1 = (GroupBox)f1.Controls["groupBox1"];
            g1.Controls["text_Ad"].Text = U.UrunAdi;
            g1.Controls["textKategori"].Text = U.Kategori;
            g1.Controls["textStok"].Text = U.Stok.ToString();
            g1.Controls["textYazar"].Text = U.Yazar;
            g1.Controls["textAciklama"].Text = U.Aciklama;
            ((PictureBox)g1.Controls["pictureBox1"]).Image=Image.FromFile(U.UrunResim);

          
        }
    }
}
