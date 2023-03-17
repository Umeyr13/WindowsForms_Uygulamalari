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
    public partial class KayitListesi : Form
    {
        public KayitListesi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void KayitListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.to_Do_list_class;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_tamamlandı_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.to_Do_list_class.Where(i=> i.durum == "Tamamlandı").ToList();
        }

        private void btnBeklemede_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.to_Do_list_class.Where((i)=>i.durum =="Beklemede").ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
