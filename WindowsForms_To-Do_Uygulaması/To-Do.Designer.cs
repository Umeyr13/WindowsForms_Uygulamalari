namespace WindowsForms_To_Do_Uygulaması
{
    partial class To_Do
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textozetbilgisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textOnemderecesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // textbaslik
            // 
            this.textbaslik.Location = new System.Drawing.Point(207, 12);
            this.textbaslik.Name = "textbaslik";
            this.textbaslik.Size = new System.Drawing.Size(212, 36);
            this.textbaslik.TabIndex = 0;
            this.textbaslik.Enter += new System.EventHandler(this.textbaslik_Enter);
            this.textbaslik.Leave += new System.EventHandler(this.textbaslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Özet Bilgisi";
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(207, 156);
            this.textAciklama.Multiline = true;
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(212, 93);
            this.textAciklama.TabIndex = 2;
            this.textAciklama.Enter += new System.EventHandler(this.textbaslik_Enter);
            this.textAciklama.Leave += new System.EventHandler(this.textbaslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // textozetbilgisi
            // 
            this.textozetbilgisi.Location = new System.Drawing.Point(207, 57);
            this.textozetbilgisi.Multiline = true;
            this.textozetbilgisi.Name = "textozetbilgisi";
            this.textozetbilgisi.Size = new System.Drawing.Size(212, 93);
            this.textozetbilgisi.TabIndex = 1;
            this.textozetbilgisi.Enter += new System.EventHandler(this.textbaslik_Enter);
            this.textozetbilgisi.Leave += new System.EventHandler(this.textbaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi";
            // 
            // textOnemderecesi
            // 
            this.textOnemderecesi.Location = new System.Drawing.Point(207, 254);
            this.textOnemderecesi.Name = "textOnemderecesi";
            this.textOnemderecesi.Size = new System.Drawing.Size(212, 36);
            this.textOnemderecesi.TabIndex = 3;
            this.textOnemderecesi.Enter += new System.EventHandler(this.textbaslik_Enter);
            this.textOnemderecesi.Leave += new System.EventHandler(this.textbaslik_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durumu";
            // 
            // comboDurum
            // 
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal Edildi",
            "Ertelendi"});
            this.comboDurum.Location = new System.Drawing.Point(207, 296);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(212, 37);
            this.comboDurum.TabIndex = 4;
            this.comboDurum.Enter += new System.EventHandler(this.comboDurum_Enter);
            this.comboDurum.Leave += new System.EventHandler(this.comboDurum_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // To_Do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textOnemderecesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textozetbilgisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbaslik);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "To_Do";
            this.Text = "To_Do";
            this.Load += new System.EventHandler(this.To_Do_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textozetbilgisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textOnemderecesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Button button1;
    }
}