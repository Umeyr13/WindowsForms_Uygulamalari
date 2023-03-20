using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONveCSV_Dosyalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Personel> list = new List<Personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Personel p = new Personel   ();
                p.guid = Guid.NewGuid ();
                p.isim = FakeData.NameData.GetFirstName();
                p.soyisim = FakeData.NameData.GetSurname();
                p.email = p.isim+"."+p.soyisim+ "@"+ FakeData.NetworkData.GetDomain();
                p.telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                list.Add (p);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\JSON\\"))
            {
                Directory.CreateDirectory("C:\\JSON\\");
            }
            string veri = Newtonsoft.Json.JsonConvert.SerializeObject(list);

            File.WriteAllText("C:\\JSON\\Personeller.json",veri);

        }
        private void button2_Click(object sender, EventArgs e)
        {
          string veri=  File.ReadAllText("C:\\JSON\\Personeller.json");
          List<Personel> personeller =   Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(veri);
            listBox1.DataSource = personeller;
            //listBox1.DisplayMember = "isim"; tek bir kolon gösterir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
           StreamWriter dosya = new StreamWriter("C:\\CSV\\personeller.csv");

           CsvWriter csv = new CsvWriter(dosya,CultureInfo.InvariantCulture);
            csv.WriteHeader(typeof(Personel));
           
                csv.WriteRecords(list);
                dosya.Close();
        }
    }
}
