namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Dodaj_Prinos
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
            this.txtTip = new System.Windows.Forms.TextBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.cBoxKvalitet = new System.Windows.Forms.ComboBox();
            this.cBoxJedinica = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(201, 64);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(130, 22);
            this.txtTip.TabIndex = 0;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(201, 124);
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(130, 22);
            this.numKolicina.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolicina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Komentar:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(201, 194);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(130, 22);
            this.txtKomentar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kvalitet proizvoda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jedinica mere:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(430, 55);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(87, 35);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(430, 124);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(87, 36);
            this.btnZatvori.TabIndex = 11;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnImage
            // 
            this.btnImage.Image = global::Poljoprivredno_gazdinstvo.Properties.Resources.Prinos1_ig_thumbnail_161_161;
            this.btnImage.Location = new System.Drawing.Point(382, 194);
            this.btnImage.MinimumSize = new System.Drawing.Size(170, 180);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(209, 211);
            this.btnImage.TabIndex = 12;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // cBoxKvalitet
            // 
            this.cBoxKvalitet.FormattingEnabled = true;
            this.cBoxKvalitet.Items.AddRange(new object[] {
            "I klasa",
            "II klasa",
            "III klasa"});
            this.cBoxKvalitet.Location = new System.Drawing.Point(201, 251);
            this.cBoxKvalitet.Name = "cBoxKvalitet";
            this.cBoxKvalitet.Size = new System.Drawing.Size(130, 24);
            this.cBoxKvalitet.TabIndex = 13;
            // 
            // cBoxJedinica
            // 
            this.cBoxJedinica.FormattingEnabled = true;
            this.cBoxJedinica.Items.AddRange(new object[] {
            "kg",
            "g",
            "t",
            "l",
            "komad"});
            this.cBoxJedinica.Location = new System.Drawing.Point(201, 319);
            this.cBoxJedinica.Name = "cBoxJedinica";
            this.cBoxJedinica.Size = new System.Drawing.Size(130, 24);
            this.cBoxJedinica.TabIndex = 14;
            // 
            // Form_Dodaj_Prinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 452);
            this.Controls.Add(this.cBoxJedinica);
            this.Controls.Add(this.cBoxKvalitet);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.txtTip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dodaj_Prinos";
            this.Text = "Form_Dodaj_Prinos";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ComboBox cBoxKvalitet;
        private System.Windows.Forms.ComboBox cBoxJedinica;
    }
}