namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Proizvode
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
            this.dataGridViewProizvode = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProizvode
            // 
            this.dataGridViewProizvode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProizvode.Location = new System.Drawing.Point(25, 29);
            this.dataGridViewProizvode.Name = "dataGridViewProizvode";
            this.dataGridViewProizvode.RowHeadersWidth = 51;
            this.dataGridViewProizvode.RowTemplate.Height = 24;
            this.dataGridViewProizvode.Size = new System.Drawing.Size(891, 409);
            this.dataGridViewProizvode.TabIndex = 1;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(1032, 278);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(114, 51);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1032, 166);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(114, 52);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form_Proizvode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dataGridViewProizvode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Proizvode";
            this.Text = "Form_Proizvode";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProizvode;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnObrisi;
    }
}