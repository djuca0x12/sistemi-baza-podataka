namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Dodaj_Prodaju
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxJedinicaMere = new System.Windows.Forms.ComboBox();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.cBoxTipPlacanja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojFakture = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Kupac:";
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(588, 181);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(143, 22);
            this.txtKupac.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Datum:";
            // 
            // dateDatum
            // 
            this.dateDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDatum.Location = new System.Drawing.Point(588, 118);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(143, 22);
            this.dateDatum.TabIndex = 33;
            // 
            // numKolicina
            // 
            this.numKolicina.DecimalPlaces = 2;
            this.numKolicina.Location = new System.Drawing.Point(588, 60);
            this.numKolicina.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(143, 22);
            this.numKolicina.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kolicina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Jedinica mere:";
            // 
            // cBoxJedinicaMere
            // 
            this.cBoxJedinicaMere.FormattingEnabled = true;
            this.cBoxJedinicaMere.Items.AddRange(new object[] {
            "kg",
            "g",
            "t",
            "l",
            "komad"});
            this.cBoxJedinicaMere.Location = new System.Drawing.Point(260, 233);
            this.cBoxJedinicaMere.Name = "cBoxJedinicaMere";
            this.cBoxJedinicaMere.Size = new System.Drawing.Size(121, 24);
            this.cBoxJedinicaMere.TabIndex = 29;
            // 
            // numCena
            // 
            this.numCena.DecimalPlaces = 2;
            this.numCena.Location = new System.Drawing.Point(260, 287);
            this.numCena.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(120, 22);
            this.numCena.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cena po jedinici:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Komentar:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(261, 180);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(120, 22);
            this.txtKomentar.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tip placanja:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(623, 278);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(118, 38);
            this.btnZatvori.TabIndex = 23;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // cBoxTipPlacanja
            // 
            this.cBoxTipPlacanja.FormattingEnabled = true;
            this.cBoxTipPlacanja.Items.AddRange(new object[] {
            "gotovina",
            "kartica"});
            this.cBoxTipPlacanja.Location = new System.Drawing.Point(261, 114);
            this.cBoxTipPlacanja.Name = "cBoxTipPlacanja";
            this.cBoxTipPlacanja.Size = new System.Drawing.Size(121, 24);
            this.cBoxTipPlacanja.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Broj fakture:";
            // 
            // txtBrojFakture
            // 
            this.txtBrojFakture.Location = new System.Drawing.Point(260, 56);
            this.txtBrojFakture.Name = "txtBrojFakture";
            this.txtBrojFakture.Size = new System.Drawing.Size(120, 22);
            this.txtBrojFakture.TabIndex = 20;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(475, 278);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(115, 38);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // Form_Dodaj_Prodaju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 373);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxJedinicaMere);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.cBoxTipPlacanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojFakture);
            this.Controls.Add(this.btnSacuvaj);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dodaj_Prodaju";
            this.Text = "Form_Dodaj_Prodaju";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxJedinicaMere;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox cBoxTipPlacanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojFakture;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}