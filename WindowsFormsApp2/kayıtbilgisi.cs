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
    public partial class kayıtbilgisi : Form
    {
        public kayıtbilgisi()
        {
            InitializeComponent();

          
          
        }

        private void button1_Click(object sender, EventArgs e)
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
            Form yakalananForm = Application.OpenForms["Form1"];//Uygulamadaki Formları verir.
            /*Form1 e ulaşıp oradaki textbox ları arka planda temizledik arıca form1 deki listeye kayıtları yazdırdık. Bunlar başka bir form da yaptık. :d*/
            foreach (Control item in yakalananForm.Controls)
            {
                foreach (Control item2 in item.Controls)
                {
                    if (item2 is TextBox)
                    {
                        item2.Text = String.Empty;
                    }
                }
            }

            ((ListBox)((GroupBox)yakalananForm.Controls["groupBox2"]).Controls["lstMüsteriler"]).DataSource= SanalDb.S_db.ToList();

        }
    }
}
