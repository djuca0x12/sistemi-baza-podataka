namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Zivotinje
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
            this.btnDodajZivotinju = new System.Windows.Forms.Button();
            this.btnIzmeniZivotinju = new System.Windows.Forms.Button();
            this.btnObrisiZivotinju = new System.Windows.Forms.Button();
            this.btnProdajZivotinju = new System.Windows.Forms.Button();
            this.dgvZivotinje = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSubvencije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajZivotinju
            // 
            this.btnDodajZivotinju.Location = new System.Drawing.Point(1457, 33);
            this.btnDodajZivotinju.Name = "btnDodajZivotinju";
            this.btnDodajZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnDodajZivotinju.TabIndex = 1;
            this.btnDodajZivotinju.Text = "Dodaj životinju";
            this.btnDodajZivotinju.UseVisualStyleBackColor = true;
            this.btnDodajZivotinju.Click += new System.EventHandler(this.btnDodajZivotinju_Click);
            // 
            // btnIzmeniZivotinju
            // 
            this.btnIzmeniZivotinju.Location = new System.Drawing.Point(1457, 122);
            this.btnIzmeniZivotinju.Name = "btnIzmeniZivotinju";
            this.btnIzmeniZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnIzmeniZivotinju.TabIndex = 2;
            this.btnIzmeniZivotinju.Text = "Izmeni životinju";
            this.btnIzmeniZivotinju.UseVisualStyleBackColor = true;
            this.btnIzmeniZivotinju.Click += new System.EventHandler(this.btnIzmeniZivotinju_Click);
            // 
            // btnObrisiZivotinju
            // 
            this.btnObrisiZivotinju.Location = new System.Drawing.Point(1457, 208);
            this.btnObrisiZivotinju.Name = "btnObrisiZivotinju";
            this.btnObrisiZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnObrisiZivotinju.TabIndex = 3;
            this.btnObrisiZivotinju.Text = "Obriši životinju";
            this.btnObrisiZivotinju.UseVisualStyleBackColor = true;
            this.btnObrisiZivotinju.Click += new System.EventHandler(this.btnObrisiZivotinju_Click);
            // 
            // btnProdajZivotinju
            // 
            this.btnProdajZivotinju.Location = new System.Drawing.Point(1457, 291);
            this.btnProdajZivotinju.Name = "btnProdajZivotinju";
            this.btnProdajZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnProdajZivotinju.TabIndex = 4;
            this.btnProdajZivotinju.Text = "Proizvedi prinos";
            this.btnProdajZivotinju.UseVisualStyleBackColor = true;
            this.btnProdajZivotinju.Click += new System.EventHandler(this.btnProdajZivotinju_Click);
            // 
            // dgvZivotinje
            // 
            this.dgvZivotinje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinje.Location = new System.Drawing.Point(57, 68);
            this.dgvZivotinje.Name = "dgvZivotinje";
            this.dgvZivotinje.ReadOnly = true;
            this.dgvZivotinje.RowHeadersWidth = 51;
            this.dgvZivotinje.RowTemplate.Height = 24;
            this.dgvZivotinje.Size = new System.Drawing.Size(1342, 308);
            this.dgvZivotinje.TabIndex = 5;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(1457, 456);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(154, 41);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubvencije
            // 
            this.btnSubvencije.Location = new System.Drawing.Point(1457, 372);
            this.btnSubvencije.Name = "btnSubvencije";
            this.btnSubvencije.Size = new System.Drawing.Size(154, 41);
            this.btnSubvencije.TabIndex = 7;
            this.btnSubvencije.Text = "Podnesi zahtev za dobijanje subvencije";
            this.btnSubvencije.UseVisualStyleBackColor = true;
            this.btnSubvencije.Click += new System.EventHandler(this.btnSubvencije_Click);
            // 
            // Form_Zivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 533);
            this.Controls.Add(this.btnSubvencije);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvZivotinje);
            this.Controls.Add(this.btnProdajZivotinju);
            this.Controls.Add(this.btnObrisiZivotinju);
            this.Controls.Add(this.btnIzmeniZivotinju);
            this.Controls.Add(this.btnDodajZivotinju);
            this.Name = "Form_Zivotinje";
            this.Text = "Sve životinje";
            this.Load += new System.EventHandler(this.Form_Zivotinje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZivotinju;
        private System.Windows.Forms.Button btnIzmeniZivotinju;
        private System.Windows.Forms.Button btnObrisiZivotinju;
        private System.Windows.Forms.Button btnProdajZivotinju;
        private System.Windows.Forms.DataGridView dgvZivotinje;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSubvencije;
    }
}