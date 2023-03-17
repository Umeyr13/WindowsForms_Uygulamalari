namespace WindowsFormsApp2
{
    partial class kayıtbilgisi
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
            this.Txt_Telefon = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_SoyAd = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoyAd = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Telefon
            // 
            this.Txt_Telefon.Enabled = false;
            this.Txt_Telefon.Location = new System.Drawing.Point(121, 90);
            this.Txt_Telefon.Name = "Txt_Telefon";
            this.Txt_Telefon.Size = new System.Drawing.Size(202, 22);
            this.Txt_Telefon.TabIndex = 21;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Enabled = false;
            this.Txt_Email.Location = new System.Drawing.Point(121, 62);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(202, 22);
            this.Txt_Email.TabIndex = 20;
            // 
            // Txt_SoyAd
            // 
            this.Txt_SoyAd.Enabled = false;
            this.Txt_SoyAd.Location = new System.Drawing.Point(121, 34);
            this.Txt_SoyAd.Name = "Txt_SoyAd";
            this.Txt_SoyAd.Size = new System.Drawing.Size(202, 22);
            this.Txt_SoyAd.TabIndex = 19;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Enabled = false;
            this.txt_Ad.Location = new System.Drawing.Point(121, 6);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(202, 22);
            this.txt_Ad.TabIndex = 18;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 93);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 26;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Şifre";
            // 
            // lblSoyAd
            // 
            this.lblSoyAd.AutoSize = true;
            this.lblSoyAd.Location = new System.Drawing.Point(12, 37);
            this.lblSoyAd.Name = "lblSoyAd";
            this.lblSoyAd.Size = new System.Drawing.Size(51, 16);
            this.lblSoyAd.TabIndex = 23;
            this.lblSoyAd.Text = "Soy Ad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 22;
            this.lblAd.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Soy Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayıtbilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Telefon);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_SoyAd);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSoyAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kayıtbilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayıtbilgisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Telefon;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_SoyAd;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoyAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}