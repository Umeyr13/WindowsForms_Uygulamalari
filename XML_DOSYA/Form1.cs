using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XML_DOSYA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter("C:\\XML\\Personeller.xml", UTF8Encoding.UTF8);
            xmlTextWriter.WriteComment("Xml İşlmeleri");
            xmlTextWriter.WriteStartElement("personeller");

            xmlTextWriter.WriteStartElement("Personel");
            xmlTextWriter.WriteAttributeString("ID", "10");
            xmlTextWriter.WriteElementString("Isim", "Elif");
            xmlTextWriter.WriteElementString("Soyisim", "Cengiz");
            xmlTextWriter.WriteEndElement();

            xmlTextWriter.WriteStartElement("Personel");
            xmlTextWriter.WriteAttributeString("ID", "20");
            xmlTextWriter.WriteElementString("Isim", "Umeyr");
            xmlTextWriter.WriteElementString("Soyisim", "Gülçimen");
            xmlTextWriter.WriteEndElement();

            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlReader xmlReader = XmlReader.Create("C:\\XML\\Personeller.xml");

            while (xmlReader.Read())
            {
                string dugum = xmlReader.Name.ToString();
                string deger = xmlReader.Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument xmldosya =
                 new XDocument(
                 new XDeclaration("1.0", "UTF-8", "yes")
                , new XElement("Personeller"
                , new XComment("Personel bilgileri")

                , new XElement("Personel", new XAttribute("ID", "1")
                , new XElement("İsim", "Soyİsim")
                , new XElement("Soyisim", "Cengiz")
                ),

                new XElement("Personel", new XAttribute("ID", "2")
                , new XElement("İsim", "Umeyr"),
                new XElement("Soyisim", "Gülçimen")
                )
                )
                );

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Ogrenci> Ogr = new List<Ogrenci>();
            for (int i = 0; i < 100; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Id = Guid.NewGuid();
                o.Isım = FakeData.NameData.GetFirstName();
                o.Soyisim = FakeData.NameData.GetSurname();
                o.OgrenciNo = FakeData.NumberData.GetNumber(100, 500);
                Ogr.Add(o);
            }

            XDocument xmldosya = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Ogrenciler", Ogr.Select(i => new XElement("Ogrenci", new XAttribute("ID", i.Id), new XElement("İsim", i.Isım), new XElement("Soyisim", i.Soyisim), new XElement("Numara", i.OgrenciNo)))));

            xmldosya.Save("C:\\XML\\Ogrenciler.xml");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            XDocument dosya = XDocument.Load("C:\\XML\\Ogrenciler.xml");

            List<XElement> elementlist = dosya.Descendants("Ogrenci").ToList();
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            foreach (XElement item in elementlist)
            {
                Ogrenci o = new Ogrenci();
                o.Isım = item.Element("İsim").Value;
                o.Soyisim = item.Element("Soyisim").Value;
                o.OgrenciNo = int.Parse(item.Element("Numara").Value);
                ogrenciler.Add(o);
            }
            listBox1.DataSource = ogrenciler;
        }
    }
}
