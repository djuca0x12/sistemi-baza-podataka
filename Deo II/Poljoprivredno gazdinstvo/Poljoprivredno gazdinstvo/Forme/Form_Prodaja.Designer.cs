namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Prodaja
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
            this.dataGridViewProdaja = new System.Windows.Forms.DataGridView();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdaja
            // 
            this.dataGridViewProdaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdaja.Location = new System.Drawing.Point(36, 35);
            this.dataGridViewProdaja.Name = "dataGridViewProdaja";
            this.dataGridViewProdaja.RowHeadersWidth = 51;
            this.dataGridViewProdaja.RowTemplate.Height = 24;
            this.dataGridViewProdaja.Size = new System.Drawing.Size(935, 458);
            this.dataGridViewProdaja.TabIndex = 0;
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(1071, 273);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(127, 60);
            this.btnPromeni.TabIndex = 1;
            this.btnPromeni.Text = "Promeni podatke o prodaji";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1071, 363);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(127, 57);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi podatak o prodaji";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(1071, 445);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(127, 52);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImage.Image = global::Poljoprivredno_gazdinstvo.Properties.Resources.Prodaja_ig_thumbnail_161_161;
            this.btnImage.Location = new System.Drawing.Point(1004, 26);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(258, 216);
            this.btnImage.TabIndex = 4;
            this.btnImage.UseVisualStyleBackColor = false;
            // 
            // Form_Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 524);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.dataGridViewProdaja);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Prodaja";
            this.Text = "Form_Prodaja";
            this.Load += new System.EventHandler(this.Form_Prodaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdaja;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnImage;
    }
}