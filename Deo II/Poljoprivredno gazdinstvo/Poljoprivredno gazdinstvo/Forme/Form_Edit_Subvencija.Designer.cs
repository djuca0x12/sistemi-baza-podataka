namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Edit_Subvencija
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
            this.label1 = new System.Windows.Forms.Label();
            this.numIznos = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerPodnosenja = new System.Windows.Forms.DateTimePicker();
            this.txtBrojResenja = new System.Windows.Forms.TextBox();
            this.checkBoxDatum = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOdobrenja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj resenja:";
            // 
            // numIznos
            // 
            this.numIznos.Location = new System.Drawing.Point(167, 159);
            this.numIznos.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numIznos.Name = "numIznos";
            this.numIznos.Size = new System.Drawing.Size(105, 22);
            this.numIznos.TabIndex = 1;
            // 
            // dateTimePickerPodnosenja
            // 
            this.dateTimePickerPodnosenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPodnosenja.Location = new System.Drawing.Point(554, 62);
            this.dateTimePickerPodnosenja.Name = "dateTimePickerPodnosenja";
            this.dateTimePickerPodnosenja.Size = new System.Drawing.Size(155, 22);
            this.dateTimePickerPodnosenja.TabIndex = 2;
            // 
            // txtBrojResenja
            // 
            this.txtBrojResenja.Location = new System.Drawing.Point(167, 61);
            this.txtBrojResenja.Name = "txtBrojResenja";
            this.txtBrojResenja.Size = new System.Drawing.Size(105, 22);
            this.txtBrojResenja.TabIndex = 3;
            // 
            // checkBoxDatum
            // 
            this.checkBoxDatum.AutoSize = true;
            this.checkBoxDatum.Location = new System.Drawing.Point(586, 183);
            this.checkBoxDatum.Name = "checkBoxDatum";
            this.checkBoxDatum.Size = new System.Drawing.Size(123, 20);
            this.checkBoxDatum.TabIndex = 4;
            this.checkBoxDatum.Text = "Omoguci datum";
            this.checkBoxDatum.UseVisualStyleBackColor = true;
            this.checkBoxDatum.CheckedChanged += new System.EventHandler(this.checkBoxDatum_CheckedChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(446, 267);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(86, 34);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(603, 267);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(86, 34);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iznos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valuta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Komentar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "DatumPodnosenja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "DatumOdobrenja:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "podsticaj za setvu",
            "subvencija za stocarstvo",
            "ekoloska mera"});
            this.cmbVrsta.Location = new System.Drawing.Point(167, 111);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(105, 24);
            this.cmbVrsta.TabIndex = 14;
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Items.AddRange(new object[] {
            "RSD",
            "EUR"});
            this.cmbValuta.Location = new System.Drawing.Point(167, 213);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(105, 24);
            this.cmbValuta.TabIndex = 15;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(167, 267);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(105, 22);
            this.txtKomentar.TabIndex = 16;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "podneseno",
            "odobreno",
            "odbijeno",
            "isplaceno"});
            this.cmbStatus.Location = new System.Drawing.Point(167, 326);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(105, 24);
            this.cmbStatus.TabIndex = 17;
            // 
            // dateTimePickerOdobrenja
            // 
            this.dateTimePickerOdobrenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOdobrenja.Location = new System.Drawing.Point(554, 132);
            this.dateTimePickerOdobrenja.Name = "dateTimePickerOdobrenja";
            this.dateTimePickerOdobrenja.Size = new System.Drawing.Size(155, 22);
            this.dateTimePickerOdobrenja.TabIndex = 18;
            // 
            // Form_Edit_Subvencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.dateTimePickerOdobrenja);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.cmbValuta);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.checkBoxDatum);
            this.Controls.Add(this.txtBrojResenja);
            this.Controls.Add(this.dateTimePickerPodnosenja);
            this.Controls.Add(this.numIznos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Edit_Subvencija";
            this.Text = "Form_Edit_Subvencija";
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numIznos;
        private System.Windows.Forms.DateTimePicker dateTimePickerPodnosenja;
        private System.Windows.Forms.TextBox txtBrojResenja;
        private System.Windows.Forms.CheckBox checkBoxDatum;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerOdobrenja;
    }
}