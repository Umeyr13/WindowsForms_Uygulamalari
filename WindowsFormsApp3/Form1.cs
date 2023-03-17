using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_uret_Click(object sender, EventArgs e)
        {

            int mayın1, mayın2, mayın3, mayın4, mayın5;
            Random random = new Random();
            mayın1 = random.Next(1,10);
            mayın2 = random.Next(11,20);
            mayın3 = random.Next(21,30);
            mayın4 = random.Next(31,40);
            mayın5 = random.Next(41,50);

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Enabled = true;

            for (int i = 1; i < 51; i++)
            {
                Button btn = new Button();

                if (i == mayın1 || i == mayın2 || i == mayın3 || i == mayın4 || i == mayın5)
                {
                    btn.Tag = true;
                }else btn.Tag = false;

                
                btn.Name = "btn"+i;
                btn.Size = new System.Drawing.Size(40,40);
                btn.Text = i.ToString();
                btn.UseVisualStyleBackColor = true;
                btn.Click += btn_Click;
               flowLayoutPanel1.Controls.Add(btn);
            }

            //this.btn_uret.Location = new System.Drawing.Point(47, 34);
            //this.btn_uret.Name = "btn_uret";
            //this.btn_uret.Size = new System.Drawing.Size(196, 68);
            //this.btn_uret.TabIndex = 0;
            //this.btn_uret.Text = "Uret";
            //this.btn_uret.UseVisualStyleBackColor = true;
            //this.btn_uret.Click += new System.EventHandler(this.btn_uret_Click);

        }

            int sayac=0;
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bool mayin = (bool)btn.Tag;
            if (mayin)
            {
                btn.BackColor = Color.Red;
               DialogResult cevap =  MessageBox.Show("Kaybbettiniz..","Oyun  Bitti",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (cevap == DialogResult.Yes)
                {
                    label2.Text ="0";
                    sayac = 0;
                    flowLayoutPanel1.Enabled = false;
                }
                
            }else 
             { 
                btn.BackColor = Color.Green;
                sayac++;
                label2.Text = sayac.ToString();
             }
           // MessageBox.Show("Tıklandı " + btn.Text);
        }
    }
}
