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
    public partial class To_Do : Form
    {
        public To_Do()
        {
            InitializeComponent();
        }

        private void textbaslik_Enter(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.MistyRose;

        }

        private void textbaslik_Leave(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.Wheat;

        }

        private void comboDurum_Enter(object sender, EventArgs e)
        {
            ComboBox C = sender as ComboBox;
            C.BackColor = Color.MistyRose;
        }

        private void comboDurum_Leave(object sender, EventArgs e)
        {
            ComboBox C = sender as ComboBox;
            C.BackColor = Color.Wheat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          int sonuc =  DataBase.KayitEkle(new To_Do_Class()
            {   
                id = Guid.NewGuid(),
                baslik = textbaslik.Text,
                aciklama = textAciklama.Text,
                ozetbilgi = textozetbilgisi.Text,
                onemDerecesi = int.Parse(textOnemderecesi.Text),
                durum = comboDurum.SelectedItem.ToString(),
                kayitTarihi = DateTime.Now
            });
            if (sonuc==1)
            {
                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı","Bilgilendirme ",MessageBoxButtons.OK,MessageBoxIcon.Information);
               DialogResult cevap = MessageBox.Show("Yeni Kayıt?", "Bilgilendirme ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap==DialogResult.Yes)
                {
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text= string.Empty;
                        }
                    }
                }else
                {
                    KayitListesi kl;
                    if (Application.OpenForms["KayitListesi"] != null)
                    {
                        kl = (KayitListesi)Application.OpenForms["KayitListesi"];
                        DataGridView dgv = (DataGridView)kl.Controls["dataGridView1"];
                        dgv.DataSource = null;
                        dgv.DataSource = DataBase.to_Do_list_class;
                        kl.Focus();
                    //    DataGridView dgv = (DataGridView)((GroupBox)kl.Controls["dataGridView1"]).Controls["dataGridView1"];
                    //    dgv.DataSource = null;
                    //    dgv.DataSource = DataBase.to_Do_list_class;
                    }
                    else
                    {
                        kl = new KayitListesi();
                        kl.MdiParent = Application.OpenForms["anaform"];         
                        kl.StartPosition = FormStartPosition.CenterScreen;
                        kl.Show();
                    }
                    this.Close();
                }



            }
            else
            {
                
                MessageBox.Show("Kayıt Eklenemedi","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void To_Do_Load(object sender, EventArgs e)
        {

        }
    }
}
