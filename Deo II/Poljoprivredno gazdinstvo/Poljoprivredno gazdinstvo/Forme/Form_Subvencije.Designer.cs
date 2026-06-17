namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Subvencije
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(897, 481);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(1045, 469);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(101, 49);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(1045, 277);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(101, 49);
            this.btnPromeni.TabIndex = 3;
            this.btnPromeni.Text = "Promeni podatke";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1045, 373);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(101, 49);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnImage
            // 
            this.btnImage.Image = global::Poljoprivredno_gazdinstvo.Properties.Resources.Subvencija1_ig_thumbnail_161_161;
            this.btnImage.Location = new System.Drawing.Point(987, 35);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(207, 200);
            this.btnImage.TabIndex = 1;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // Form_Subvencije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 573);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Subvencije";
            this.Text = "Form_Subvencije";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnImage;
    }
}