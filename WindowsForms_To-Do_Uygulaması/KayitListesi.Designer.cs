namespace WindowsForms_To_Do_Uygulaması
{
    partial class KayitListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_IptalEdildi = new System.Windows.Forms.Button();
            this.btn_Ertelendi = new System.Windows.Forms.Button();
            this.btnBeklemede = new System.Windows.Forms.Button();
            this.btn_tamamlandı = new System.Windows.Forms.Button();
            this.toDoClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(226, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_IptalEdildi);
            this.groupBox1.Controls.Add(this.btn_Ertelendi);
            this.groupBox1.Controls.Add(this.btnBeklemede);
            this.groupBox1.Controls.Add(this.btn_tamamlandı);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal Edildi",
            "Ertelendi"});
            this.comboBox1.Location = new System.Drawing.Point(6, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 37);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_IptalEdildi
            // 
            this.btn_IptalEdildi.Location = new System.Drawing.Point(6, 165);
            this.btn_IptalEdildi.Name = "btn_IptalEdildi";
            this.btn_IptalEdildi.Size = new System.Drawing.Size(182, 53);
            this.btn_IptalEdildi.TabIndex = 0;
            this.btn_IptalEdildi.Text = "İptal Edildi";
            this.btn_IptalEdildi.UseVisualStyleBackColor = true;
            this.btn_IptalEdildi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Ertelendi
            // 
            this.btn_Ertelendi.Location = new System.Drawing.Point(6, 224);
            this.btn_Ertelendi.Name = "btn_Ertelendi";
            this.btn_Ertelendi.Size = new System.Drawing.Size(182, 53);
            this.btn_Ertelendi.TabIndex = 0;
            this.btn_Ertelendi.Text = "Ertelendi";
            this.btn_Ertelendi.UseVisualStyleBackColor = true;
            this.btn_Ertelendi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBeklemede
            // 
            this.btnBeklemede.Location = new System.Drawing.Point(6, 106);
            this.btnBeklemede.Name = "btnBeklemede";
            this.btnBeklemede.Size = new System.Drawing.Size(182, 53);
            this.btnBeklemede.TabIndex = 0;
            this.btnBeklemede.Text = "Beklemede";
            this.btnBeklemede.UseVisualStyleBackColor = true;
            this.btnBeklemede.Click += new System.EventHandler(this.btnBeklemede_Click);
            // 
            // btn_tamamlandı
            // 
            this.btn_tamamlandı.Location = new System.Drawing.Point(6, 47);
            this.btn_tamamlandı.Name = "btn_tamamlandı";
            this.btn_tamamlandı.Size = new System.Drawing.Size(182, 53);
            this.btn_tamamlandı.TabIndex = 0;
            this.btn_tamamlandı.Text = "Tamamlandı";
            this.btn_tamamlandı.UseVisualStyleBackColor = true;
            this.btn_tamamlandı.Click += new System.EventHandler(this.btn_tamamlandı_Click);
            // 
            // toDoClassBindingSource
            // 
            this.toDoClassBindingSource.DataSource = typeof(WindowsForms_To_Do_Uygulaması.To_Do_Class);
            // 
            // KayitListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "KayitListesi";
            this.Text = "KayitListesi";
            this.Load += new System.EventHandler(this.KayitListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toDoClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ertelendi;
        private System.Windows.Forms.Button btnBeklemede;
        private System.Windows.Forms.Button btn_tamamlandı;
        private System.Windows.Forms.Button btn_IptalEdildi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource toDoClassBindingSource;
    }
}