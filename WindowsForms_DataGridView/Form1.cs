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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           Database db = new Database();
        private void Form1_Load(object sender, EventArgs e)
        {
           List<Musteri> liste =  db.MusteriListele();
            dGV_Musteriler.DataSource = liste;
            dGV_Musteriler.Columns[0].Visible = false;
            dGV_Musteriler.Columns["Email"].Visible = false;

            dGV_Musteriler.Columns[1].HeaderText = "Ad";
            dGV_Musteriler.Columns[2].HeaderText ="SoyAd";
            dGV_Musteriler.Columns["Adres"].Width = 300;


        }

        private void dGV_Musteriler_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dGV_Musteriler[0,dGV_Musteriler.CurrentCell.RowIndex].Value ;
         Musteri musteri =    db.MusteriListele().FirstOrDefault(i => i.Id == id);
            MusteriDetay mD=new MusteriDetay(musteri);
            mD.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Musteri> liste = db.MusteriListele();
            dGV_Musteriler.DataSource = liste;
        }
        //kaydı güncelle butonu eklemek


    }
}
