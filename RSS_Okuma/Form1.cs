using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSS_Okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           XDocument veri = XDocument.Load(text_URL.Text);        
           List<XElement> kayitlar = veri.Descendants("item").ToList();
            List<Haber>haberler = new List<Haber>();

            foreach (XElement item in kayitlar)
            {
                Haber hbr = new Haber();
                hbr.Baslik = item.Element("title").Value;
                hbr.Link = item.Element("link").Value;
                hbr.Aciklama = item.Element("description").Value;
                haberler.Add(hbr);
            }
           list_Haber.DataSource = haberler;
        }

        private void list_Haber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Haber haber = list_Haber.SelectedItem as Haber;
            webBrowser1.DocumentText = haber.Aciklama;
            
        }
    }
}
