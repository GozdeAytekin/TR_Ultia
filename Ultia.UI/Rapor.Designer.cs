namespace Ultia.UI
{
    partial class Rapor
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
            this.lstRapor = new System.Windows.Forms.ListView();
            this.kayitNumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urununGuncelFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbtnRaporla = new Ultia.UI.RJControls.RoundButton();
            this.dtrRapor = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstRapor
            // 
            this.lstRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kayitNumarasi,
            this.Barkod,
            this.urunTipi,
            this.urununGuncelFiyati,
            this.markasi,
            this.modeli});
            this.lstRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstRapor.GridLines = true;
            this.lstRapor.HideSelection = false;
            this.lstRapor.Location = new System.Drawing.Point(86, 83);
            this.lstRapor.Margin = new System.Windows.Forms.Padding(2);
            this.lstRapor.Name = "lstRapor";
            this.lstRapor.Size = new System.Drawing.Size(628, 284);
            this.lstRapor.TabIndex = 2;
            this.lstRapor.UseCompatibleStateImageBehavior = false;
            this.lstRapor.View = System.Windows.Forms.View.Details;
            this.lstRapor.Visible = false;
            // 
            // kayitNumarasi
            // 
            this.kayitNumarasi.Text = "Kayıt Numarası";
            this.kayitNumarasi.Width = 118;
            // 
            // Barkod
            // 
            this.Barkod.Text = "Barkod";
            this.Barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Barkod.Width = 77;
            // 
            // urunTipi
            // 
            this.urunTipi.Text = "Ürün Tipi";
            this.urunTipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunTipi.Width = 78;
            // 
            // urununGuncelFiyati
            // 
            this.urununGuncelFiyati.Text = "Ürünün Güncel Fiyatı";
            this.urununGuncelFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urununGuncelFiyati.Width = 160;
            // 
            // markasi
            // 
            this.markasi.Text = "Markası";
            this.markasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.markasi.Width = 71;
            // 
            // modeli
            // 
            this.modeli.Text = "Modeli";
            this.modeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modeli.Width = 125;
            // 
            // rbtnRaporla
            // 
            this.rbtnRaporla.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnRaporla.ButtonColor = System.Drawing.Color.Black;
            this.rbtnRaporla.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRaporla.Location = new System.Drawing.Point(329, 51);
            this.rbtnRaporla.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnRaporla.Name = "rbtnRaporla";
            this.rbtnRaporla.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtnRaporla.OnHoverButtonColor = System.Drawing.Color.Peru;
            this.rbtnRaporla.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rbtnRaporla.Size = new System.Drawing.Size(82, 28);
            this.rbtnRaporla.TabIndex = 3;
            this.rbtnRaporla.Text = "Raporla";
            this.rbtnRaporla.TextColor = System.Drawing.Color.White;
            this.rbtnRaporla.UseVisualStyleBackColor = true;
            this.rbtnRaporla.Click += new System.EventHandler(this.rbtnRaporla_Click);
            // 
            // dtrRapor
            // 
            this.dtrRapor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtrRapor.Location = new System.Drawing.Point(273, 27);
            this.dtrRapor.Margin = new System.Windows.Forms.Padding(2);
            this.dtrRapor.Name = "dtrRapor";
            this.dtrRapor.Size = new System.Drawing.Size(194, 20);
            this.dtrRapor.TabIndex = 13;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtrRapor);
            this.Controls.Add(this.rbtnRaporla);
            this.Controls.Add(this.lstRapor);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstRapor;
        private System.Windows.Forms.ColumnHeader kayitNumarasi;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader urunTipi;
        private System.Windows.Forms.ColumnHeader urununGuncelFiyati;
        private System.Windows.Forms.ColumnHeader markasi;
        private System.Windows.Forms.ColumnHeader modeli;
        private RJControls.RoundButton rbtnRaporla;
        private System.Windows.Forms.DateTimePicker dtrRapor;
    }
}