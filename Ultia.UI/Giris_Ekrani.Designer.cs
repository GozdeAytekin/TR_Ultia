namespace Ultia.UI
{
    partial class Giris_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Ekrani));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.rbtnGirisYap = new Ultia.UI.Butonlar.GirisYapButonYeni();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(434, 159);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.MaxLength = 16;
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(188, 21);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSifre.Location = new System.Drawing.Point(434, 215);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(188, 19);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // rbtnGirisYap
            // 
            this.rbtnGirisYap.BackColor = System.Drawing.Color.SteelBlue;
            this.rbtnGirisYap.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.rbtnGirisYap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnGirisYap.BorderRadius = 8;
            this.rbtnGirisYap.BorderSize = 0;
            this.rbtnGirisYap.FlatAppearance.BorderSize = 0;
            this.rbtnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnGirisYap.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.rbtnGirisYap.ForeColor = System.Drawing.Color.White;
            this.rbtnGirisYap.Location = new System.Drawing.Point(406, 248);
            this.rbtnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnGirisYap.Name = "rbtnGirisYap";
            this.rbtnGirisYap.Size = new System.Drawing.Size(216, 26);
            this.rbtnGirisYap.TabIndex = 7;
            this.rbtnGirisYap.Text = "LOGİN";
            this.rbtnGirisYap.TextColor = System.Drawing.Color.White;
            this.rbtnGirisYap.UseVisualStyleBackColor = false;
            this.rbtnGirisYap.Click += new System.EventHandler(this.girisYapButonYeni1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Giris_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 378);
            this.Controls.Add(this.rbtnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("High Tower Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Giris_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private Butonlar.GirisYapButonYeni rbtnGirisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}