using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Baslangic
{
    public partial class Form1 : Form
    {
        public Form1() //Form1 in ctor u
        {
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            Form2 frm2 = new Form2(isim);
            frm2.Show();
            //frm2.Visible = false;
            Visible = false;   

        }
    }
}
