namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Krmno_Bilje
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
            this.dgvKrmnoBilje = new System.Windows.Forms.DataGridView();
            this.btnProdajKrmnoBilje = new System.Windows.Forms.Button();
            this.btnObrisiKrmnoBilje = new System.Windows.Forms.Button();
            this.btnIzmeniKrmnoBilje = new System.Windows.Forms.Button();
            this.btnDodajKrmnoBilje = new System.Windows.Forms.Button();
            this.btnSubvencija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrmnoBilje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKrmnoBilje
            // 
            this.dgvKrmnoBilje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKrmnoBilje.Location = new System.Drawing.Point(41, 75);
            this.dgvKrmnoBilje.Name = "dgvKrmnoBilje";
            this.dgvKrmnoBilje.ReadOnly = true;
            this.dgvKrmnoBilje.RowHeadersWidth = 51;
            this.dgvKrmnoBilje.RowTemplate.Height = 24;
            this.dgvKrmnoBilje.Size = new System.Drawing.Size(1178, 308);
            this.dgvKrmnoBilje.TabIndex = 15;
            // 
            // btnProdajKrmnoBilje
            // 
            this.btnProdajKrmnoBilje.Location = new System.Drawing.Point(1268, 296);
            this.btnProdajKrmnoBilje.Name = "btnProdajKrmnoBilje";
            this.btnProdajKrmnoBilje.Size = new System.Drawing.Size(154, 41);
            this.btnProdajKrmnoBilje.TabIndex = 14;
            this.btnProdajKrmnoBilje.Text = "Proizvedi prinos";
            this.btnProdajKrmnoBilje.UseVisualStyleBackColor = true;
            this.btnProdajKrmnoBilje.Click += new System.EventHandler(this.btnProdajKrmnoBilje_Click);
            // 
            // btnObrisiKrmnoBilje
            // 
            this.btnObrisiKrmnoBilje.Location = new System.Drawing.Point(1268, 207);
            this.btnObrisiKrmnoBilje.Name = "btnObrisiKrmnoBilje";
            this.btnObrisiKrmnoBilje.Size = new System.Drawing.Size(154, 41);
            this.btnObrisiKrmnoBilje.TabIndex = 13;
            this.btnObrisiKrmnoBilje.Text = "Obriši krmno bilje";
            this.btnObrisiKrmnoBilje.UseVisualStyleBackColor = true;
            this.btnObrisiKrmnoBilje.Click += new System.EventHandler(this.btnObrisiKrmnoBilje_Click);
            // 
            // btnIzmeniKrmnoBilje
            // 
            this.btnIzmeniKrmnoBilje.Location = new System.Drawing.Point(1268, 118);
            this.btnIzmeniKrmnoBilje.Name = "btnIzmeniKrmnoBilje";
            this.btnIzmeniKrmnoBilje.Size = new System.Drawing.Size(154, 41);
            this.btnIzmeniKrmnoBilje.TabIndex = 12;
            this.btnIzmeniKrmnoBilje.Text = "Izmeni krmno bilje";
            this.btnIzmeniKrmnoBilje.UseVisualStyleBackColor = true;
            this.btnIzmeniKrmnoBilje.Click += new System.EventHandler(this.btnIzmeniKrmnoBilje_Click);
            // 
            // btnDodajKrmnoBilje
            // 
            this.btnDodajKrmnoBilje.Location = new System.Drawing.Point(1268, 29);
            this.btnDodajKrmnoBilje.Name = "btnDodajKrmnoBilje";
            this.btnDodajKrmnoBilje.Size = new System.Drawing.Size(154, 41);
            this.btnDodajKrmnoBilje.TabIndex = 11;
            this.btnDodajKrmnoBilje.Text = "Dodaj krmno bilje";
            this.btnDodajKrmnoBilje.UseVisualStyleBackColor = true;
            this.btnDodajKrmnoBilje.Click += new System.EventHandler(this.btnDodajKrmnoBilje_Click);
            // 
            // btnSubvencija
            // 
            this.btnSubvencija.Location = new System.Drawing.Point(1268, 372);
            this.btnSubvencija.Name = "btnSubvencija";
            this.btnSubvencija.Size = new System.Drawing.Size(154, 54);
            this.btnSubvencija.TabIndex = 16;
            this.btnSubvencija.Text = "Podnesi zahtev za dobijanje subvencije";
            this.btnSubvencija.UseVisualStyleBackColor = true;
            this.btnSubvencija.Click += new System.EventHandler(this.btnSubvencija_Click);
            // 
            // Form_Krmno_Bilje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 450);
            this.Controls.Add(this.btnSubvencija);
            this.Controls.Add(this.dgvKrmnoBilje);
            this.Controls.Add(this.btnProdajKrmnoBilje);
            this.Controls.Add(this.btnObrisiKrmnoBilje);
            this.Controls.Add(this.btnIzmeniKrmnoBilje);
            this.Controls.Add(this.btnDodajKrmnoBilje);
            this.Name = "Form_Krmno_Bilje";
            this.Text = "Krmno bilje";
            this.Load += new System.EventHandler(this.Form_Krmno_Bilje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrmnoBilje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKrmnoBilje;
        private System.Windows.Forms.Button btnProdajKrmnoBilje;
        private System.Windows.Forms.Button btnObrisiKrmnoBilje;
        private System.Windows.Forms.Button btnIzmeniKrmnoBilje;
        private System.Windows.Forms.Button btnDodajKrmnoBilje;
        private System.Windows.Forms.Button btnSubvencija;
    }
}