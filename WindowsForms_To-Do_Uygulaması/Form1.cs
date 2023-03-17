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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void button_Yenikayit_Click(object sender, EventArgs e)
        {
            To_Do todoform;
            if (Application.OpenForms["To_Do"]!=null)
            {
                todoform = (To_Do)Application.OpenForms["To_Do"] ;
                todoform.Focus();
            }
            else
            {
                todoform = new To_Do();
                todoform.MdiParent = this;
                todoform.StartPosition = FormStartPosition.CenterScreen;
                todoform.Show();
            }

        }

        private void anaform_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            GirisForm girisekranı = new GirisForm();
            girisekranı.MdiParent = this;
            girisekranı.StartPosition = FormStartPosition.CenterScreen;
            girisekranı.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelzaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            KayitListesi kl;
            if (Application.OpenForms["KayitListesi"]!=null)
            {
                kl=(KayitListesi)Application.OpenForms["KayitListesi"];
                kl.Focus();
            }
            else
            {
                kl = new KayitListesi();
                kl.MdiParent = this;
                kl.StartPosition = FormStartPosition.CenterScreen;
                kl.Show();

            }

        }
    }
}
