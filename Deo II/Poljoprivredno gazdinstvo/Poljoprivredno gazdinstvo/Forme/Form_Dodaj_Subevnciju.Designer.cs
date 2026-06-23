namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Dodaj_Subevnciju
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
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtBrojResenja = new System.Windows.Forms.TextBox();
            this.dateTimePickerPodnosenja = new System.Windows.Forms.DateTimePicker();
            this.numIznos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(235, 283);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(105, 22);
            this.txtKomentar.TabIndex = 35;
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Items.AddRange(new object[] {
            "RSD",
            "EUR"});
            this.cmbValuta.Location = new System.Drawing.Point(235, 229);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(105, 24);
            this.cmbValuta.TabIndex = 34;
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "podsticaj za setvu",
            "subvencija za stocarstvo",
            "ekoloska mera"});
            this.cmbVrsta.Location = new System.Drawing.Point(235, 127);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(105, 24);
            this.cmbVrsta.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "DatumPodnosenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Komentar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Valuta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Iznos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vrsta:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(680, 223);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(86, 34);
            this.btnZatvori.TabIndex = 25;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(523, 223);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(86, 34);
            this.btnSacuvaj.TabIndex = 24;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtBrojResenja
            // 
            this.txtBrojResenja.Location = new System.Drawing.Point(235, 77);
            this.txtBrojResenja.Name = "txtBrojResenja";
            this.txtBrojResenja.Size = new System.Drawing.Size(105, 22);
            this.txtBrojResenja.TabIndex = 22;
            // 
            // dateTimePickerPodnosenja
            // 
            this.dateTimePickerPodnosenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPodnosenja.Location = new System.Drawing.Point(641, 82);
            this.dateTimePickerPodnosenja.Name = "dateTimePickerPodnosenja";
            this.dateTimePickerPodnosenja.Size = new System.Drawing.Size(155, 22);
            this.dateTimePickerPodnosenja.TabIndex = 21;
            // 
            // numIznos
            // 
            this.numIznos.Location = new System.Drawing.Point(235, 175);
            this.numIznos.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numIznos.Name = "numIznos";
            this.numIznos.Size = new System.Drawing.Size(105, 22);
            this.numIznos.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Broj resenja:";
            // 
            // Form_Dodaj_Subevnciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 339);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.cmbValuta);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtBrojResenja);
            this.Controls.Add(this.dateTimePickerPodnosenja);
            this.Controls.Add(this.numIznos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dodaj_Subevnciju";
            this.Text = "Podnesi zahtev za suvencijom";
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtBrojResenja;
        private System.Windows.Forms.DateTimePicker dateTimePickerPodnosenja;
        private System.Windows.Forms.NumericUpDown numIznos;
        private System.Windows.Forms.Label label1;
    }
}