namespace WindowsForms_To_Do_Uygulaması
{
    partial class anaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupIslemler = new System.Windows.Forms.GroupBox();
            this.buttonkapat = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.button_Yenikayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelzaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupIslemler);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 653);
            this.panel1.TabIndex = 1;
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.buttonkapat);
            this.groupIslemler.Controls.Add(this.buttonListele);
            this.groupIslemler.Controls.Add(this.button_Yenikayit);
            this.groupIslemler.Enabled = false;
            this.groupIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupIslemler.Location = new System.Drawing.Point(6, 259);
            this.groupIslemler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupIslemler.Size = new System.Drawing.Size(220, 288);
            this.groupIslemler.TabIndex = 1;
            this.groupIslemler.TabStop = false;
            this.groupIslemler.Text = "İşlemler";
            // 
            // buttonkapat
            // 
            this.buttonkapat.Location = new System.Drawing.Point(17, 196);
            this.buttonkapat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonkapat.Name = "buttonkapat";
            this.buttonkapat.Size = new System.Drawing.Size(197, 65);
            this.buttonkapat.TabIndex = 2;
            this.buttonkapat.Text = "Uygulama Sonlandır";
            this.buttonkapat.UseVisualStyleBackColor = true;
            this.buttonkapat.Click += new System.EventHandler(this.buttonkapat_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(17, 121);
            this.buttonListele.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(191, 65);
            this.buttonListele.TabIndex = 1;
            this.buttonListele.Text = "Kayıt Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // button_Yenikayit
            // 
            this.button_Yenikayit.Location = new System.Drawing.Point(17, 45);
            this.button_Yenikayit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button_Yenikayit.Name = "button_Yenikayit";
            this.button_Yenikayit.Size = new System.Drawing.Size(191, 65);
            this.button_Yenikayit.TabIndex = 0;
            this.button_Yenikayit.Text = "Yeni Kayıt";
            this.button_Yenikayit.UseVisualStyleBackColor = true;
            this.button_Yenikayit.Click += new System.EventHandler(this.button_Yenikayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelzaman
            // 
            this.labelzaman.AutoSize = true;
            this.labelzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelzaman.Location = new System.Drawing.Point(1404, 1088);
            this.labelzaman.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelzaman.Name = "labelzaman";
            this.labelzaman.Size = new System.Drawing.Size(230, 26);
            this.labelzaman.TabIndex = 2;
            this.labelzaman.Text = "dd.MM.yyyy hh:mm:ss";
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.labelzaman);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yapılacaklar Listesi";
            this.Load += new System.EventHandler(this.anaform_Load);
            this.panel1.ResumeLayout(false);
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupIslemler;
        private System.Windows.Forms.Button button_Yenikayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonkapat;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Label labelzaman;
        private System.Windows.Forms.Timer timer1;
    }
}

