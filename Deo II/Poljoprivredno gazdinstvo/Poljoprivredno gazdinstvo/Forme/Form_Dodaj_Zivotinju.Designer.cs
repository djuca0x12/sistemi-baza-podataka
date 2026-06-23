namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Dodaj_Zivotinju
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
            this.txtBrojUha = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtRasa = new System.Windows.Forms.TextBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.cbxPol = new System.Windows.Forms.ComboBox();
            this.numBrojJedinki = new System.Windows.Forms.NumericUpDown();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumUlaska = new System.Windows.Forms.DateTimePicker();
            this.numTezina = new System.Windows.Forms.NumericUpDown();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblBrojUha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Zatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojJedinki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTezina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajZivotinju
            // 
            this.btnDodajZivotinju.Location = new System.Drawing.Point(170, 427);
            this.btnDodajZivotinju.Name = "btnDodajZivotinju";
            this.btnDodajZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnDodajZivotinju.TabIndex = 1;
            this.btnDodajZivotinju.Text = "Dodaj životinju";
            this.btnDodajZivotinju.UseVisualStyleBackColor = true;
            this.btnDodajZivotinju.Click += new System.EventHandler(this.btnDodajZivotinju_Click);
            // 
            // txtBrojUha
            // 
            this.txtBrojUha.Location = new System.Drawing.Point(157, 62);
            this.txtBrojUha.Name = "txtBrojUha";
            this.txtBrojUha.Size = new System.Drawing.Size(100, 22);
            this.txtBrojUha.TabIndex = 2;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(157, 142);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(100, 22);
            this.txtVrsta.TabIndex = 3;
            // 
            // txtRasa
            // 
            this.txtRasa.Location = new System.Drawing.Point(157, 284);
            this.txtRasa.Name = "txtRasa";
            this.txtRasa.Size = new System.Drawing.Size(100, 22);
            this.txtRasa.TabIndex = 4;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(157, 353);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(100, 22);
            this.txtKomentar.TabIndex = 5;
            // 
            // cbxPol
            // 
            this.cbxPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPol.FormattingEnabled = true;
            this.cbxPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cbxPol.Location = new System.Drawing.Point(157, 214);
            this.cbxPol.Name = "cbxPol";
            this.cbxPol.Size = new System.Drawing.Size(121, 24);
            this.cbxPol.TabIndex = 6;
            // 
            // numBrojJedinki
            // 
            this.numBrojJedinki.Location = new System.Drawing.Point(532, 62);
            this.numBrojJedinki.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBrojJedinki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrojJedinki.Name = "numBrojJedinki";
            this.numBrojJedinki.Size = new System.Drawing.Size(120, 22);
            this.numBrojJedinki.TabIndex = 7;
            this.numBrojJedinki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(532, 141);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(120, 22);
            this.dtpDatumRodjenja.TabIndex = 8;
            // 
            // dtpDatumUlaska
            // 
            this.dtpDatumUlaska.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumUlaska.Location = new System.Drawing.Point(532, 213);
            this.dtpDatumUlaska.Name = "dtpDatumUlaska";
            this.dtpDatumUlaska.Size = new System.Drawing.Size(120, 22);
            this.dtpDatumUlaska.TabIndex = 9;
            // 
            // numTezina
            // 
            this.numTezina.DecimalPlaces = 2;
            this.numTezina.Location = new System.Drawing.Point(532, 285);
            this.numTezina.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTezina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTezina.Name = "numTezina";
            this.numTezina.Size = new System.Drawing.Size(120, 22);
            this.numTezina.TabIndex = 10;
            this.numTezina.ThousandsSeparator = true;
            this.numTezina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "aktivna",
            "na lecenju"});
            this.cbxStatus.Location = new System.Drawing.Point(531, 344);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxStatus.TabIndex = 11;
            // 
            // lblBrojUha
            // 
            this.lblBrojUha.AutoSize = true;
            this.lblBrojUha.Location = new System.Drawing.Point(13, 67);
            this.lblBrojUha.Name = "lblBrojUha";
            this.lblBrojUha.Size = new System.Drawing.Size(59, 16);
            this.lblBrojUha.TabIndex = 13;
            this.lblBrojUha.Text = "Broj uha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rasa:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(8, 353);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(67, 16);
            this.lblKomentar.TabIndex = 17;
            this.lblKomentar.Text = "Komentar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Broj jedinki:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(366, 142);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(98, 16);
            this.lblDatumRodjenja.TabIndex = 19;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Datum ulaska:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Težina:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status:";
            // 
            // Zatvori
            // 
            this.Zatvori.Location = new System.Drawing.Point(404, 427);
            this.Zatvori.Name = "Zatvori";
            this.Zatvori.Size = new System.Drawing.Size(154, 41);
            this.Zatvori.TabIndex = 23;
            this.Zatvori.Text = "Zatvori";
            this.Zatvori.UseVisualStyleBackColor = true;
            this.Zatvori.Click += new System.EventHandler(this.Zatvori_Click);
            // 
            // Form_Dodaj_Zivotinju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 494);
            this.Controls.Add(this.Zatvori);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBrojUha);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.numTezina);
            this.Controls.Add(this.dtpDatumUlaska);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.numBrojJedinki);
            this.Controls.Add(this.cbxPol);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.txtRasa);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtBrojUha);
            this.Controls.Add(this.btnDodajZivotinju);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dodaj_Zivotinju";
            this.Text = "Dodaj životinje";
            ((System.ComponentModel.ISupportInitialize)(this.numBrojJedinki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTezina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZivotinju;
        private System.Windows.Forms.TextBox txtBrojUha;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtRasa;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.ComboBox cbxPol;
        private System.Windows.Forms.NumericUpDown numBrojJedinki;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtpDatumUlaska;
        private System.Windows.Forms.NumericUpDown numTezina;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblBrojUha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Zatvori;
    }
}