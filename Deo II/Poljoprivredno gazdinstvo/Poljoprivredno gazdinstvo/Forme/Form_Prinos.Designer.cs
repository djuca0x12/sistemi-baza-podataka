namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Prinos
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
            this.dataGridViewPrinos = new System.Windows.Forms.DataGridView();
            this.btnPromeniPodatke = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrinos
            // 
            this.dataGridViewPrinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrinos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPrinos.Name = "dataGridViewPrinos";
            this.dataGridViewPrinos.RowHeadersWidth = 51;
            this.dataGridViewPrinos.RowTemplate.Height = 24;
            this.dataGridViewPrinos.Size = new System.Drawing.Size(802, 515);
            this.dataGridViewPrinos.TabIndex = 0;
            // 
            // btnPromeniPodatke
            // 
            this.btnPromeniPodatke.Location = new System.Drawing.Point(1018, 367);
            this.btnPromeniPodatke.Name = "btnPromeniPodatke";
            this.btnPromeniPodatke.Size = new System.Drawing.Size(220, 42);
            this.btnPromeniPodatke.TabIndex = 1;
            this.btnPromeniPodatke.Text = "Promeni podatke";
            this.btnPromeniPodatke.UseVisualStyleBackColor = true;
            this.btnPromeniPodatke.Click += new System.EventHandler(this.btnPromeniPodatke_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(857, 367);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(126, 42);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi prinos";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnProdaja
            // 
            this.btnProdaja.Location = new System.Drawing.Point(947, 281);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(171, 39);
            this.btnProdaja.TabIndex = 4;
            this.btnProdaja.Text = "Prodaj prinos";
            this.btnProdaja.UseVisualStyleBackColor = true;
            this.btnProdaja.Click += new System.EventHandler(this.btnProdaja_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(975, 445);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(126, 41);
            this.btnZatvori.TabIndex = 5;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnImage
            // 
            this.btnImage.Image = global::Poljoprivredno_gazdinstvo.Properties.Resources.Prinos2_ig_thumbnail_161_161;
            this.btnImage.Location = new System.Drawing.Point(908, 31);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(227, 212);
            this.btnImage.TabIndex = 6;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // Form_Prinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 539);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProdaja);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeniPodatke);
            this.Controls.Add(this.dataGridViewPrinos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prinos";
            this.Text = "Pregled svih proizvedenih prinosa na poljoprivrednom gazdinstvu";
            this.Load += new System.EventHandler(this.Form_Prinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrinos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrinos;
        private System.Windows.Forms.Button btnPromeniPodatke;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnProdaja;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnImage;
    }
}