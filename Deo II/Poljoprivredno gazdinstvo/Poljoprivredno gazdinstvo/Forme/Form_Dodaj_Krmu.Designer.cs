namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Dodaj_Krmu
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
            this.btnDodajKrmnoBilje = new System.Windows.Forms.Button();
            this.numProcenatProteina = new System.Windows.Forms.NumericUpDown();
            this.numBrojKosnjiGodisnje = new System.Windows.Forms.NumericUpDown();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dtpDatumZetveStvarni = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZetvePlanirani = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumSetve = new System.Windows.Forms.DateTimePicker();
            this.numPovrsina = new System.Windows.Forms.NumericUpDown();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.txtKvalitetZemljista = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkZaIshranuStoke = new System.Windows.Forms.CheckBox();
            this.chkZaProdaju = new System.Windows.Forms.CheckBox();
            this.cbxVrstaKrme = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatProteina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojKosnjiGodisnje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajKrmnoBilje
            // 
            this.btnDodajKrmnoBilje.Location = new System.Drawing.Point(641, 262);
            this.btnDodajKrmnoBilje.Name = "btnDodajKrmnoBilje";
            this.btnDodajKrmnoBilje.Size = new System.Drawing.Size(245, 41);
            this.btnDodajKrmnoBilje.TabIndex = 88;
            this.btnDodajKrmnoBilje.Text = "Dodaj krmno bilje";
            this.btnDodajKrmnoBilje.UseVisualStyleBackColor = true;
            this.btnDodajKrmnoBilje.Click += new System.EventHandler(this.btnDodajKrmnoBilje_Click);
            // 
            // numProcenatProteina
            // 
            this.numProcenatProteina.DecimalPlaces = 2;
            this.numProcenatProteina.Location = new System.Drawing.Point(762, 127);
            this.numProcenatProteina.Name = "numProcenatProteina";
            this.numProcenatProteina.Size = new System.Drawing.Size(150, 22);
            this.numProcenatProteina.TabIndex = 86;
            // 
            // numBrojKosnjiGodisnje
            // 
            this.numBrojKosnjiGodisnje.Location = new System.Drawing.Point(762, 83);
            this.numBrojKosnjiGodisnje.Name = "numBrojKosnjiGodisnje";
            this.numBrojKosnjiGodisnje.Size = new System.Drawing.Size(150, 22);
            this.numBrojKosnjiGodisnje.TabIndex = 85;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "u toku",
            "zavrseno",
            "otkazano"});
            this.cbxStatus.Location = new System.Drawing.Point(326, 344);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(150, 24);
            this.cbxStatus.TabIndex = 83;
            // 
            // dtpDatumZetveStvarni
            // 
            this.dtpDatumZetveStvarni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZetveStvarni.Location = new System.Drawing.Point(326, 301);
            this.dtpDatumZetveStvarni.Name = "dtpDatumZetveStvarni";
            this.dtpDatumZetveStvarni.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumZetveStvarni.TabIndex = 82;
            // 
            // dtpDatumZetvePlanirani
            // 
            this.dtpDatumZetvePlanirani.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZetvePlanirani.Location = new System.Drawing.Point(326, 258);
            this.dtpDatumZetvePlanirani.Name = "dtpDatumZetvePlanirani";
            this.dtpDatumZetvePlanirani.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumZetvePlanirani.TabIndex = 81;
            // 
            // dtpDatumSetve
            // 
            this.dtpDatumSetve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumSetve.Location = new System.Drawing.Point(326, 215);
            this.dtpDatumSetve.Name = "dtpDatumSetve";
            this.dtpDatumSetve.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumSetve.TabIndex = 80;
            // 
            // numPovrsina
            // 
            this.numPovrsina.DecimalPlaces = 2;
            this.numPovrsina.Location = new System.Drawing.Point(326, 129);
            this.numPovrsina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPovrsina.Name = "numPovrsina";
            this.numPovrsina.Size = new System.Drawing.Size(150, 22);
            this.numPovrsina.TabIndex = 79;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(326, 389);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(150, 22);
            this.txtKomentar.TabIndex = 78;
            // 
            // txtKvalitetZemljista
            // 
            this.txtKvalitetZemljista.Location = new System.Drawing.Point(326, 172);
            this.txtKvalitetZemljista.Name = "txtKvalitetZemljista";
            this.txtKvalitetZemljista.Size = new System.Drawing.Size(150, 22);
            this.txtKvalitetZemljista.TabIndex = 77;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(326, 82);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(150, 22);
            this.txtLokacija.TabIndex = 76;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(326, 39);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(150, 22);
            this.txtNaziv.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 394);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 16);
            this.label18.TabIndex = 74;
            this.label18.Text = "Komentar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 72;
            this.label12.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 71;
            this.label11.Text = "Stvarni datum žetve:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Planirani datum žetve:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "Broj košnji godišnje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "Procenat proteina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "Vrsta krme:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Datum setve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Kvalitet zemljišta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Površina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Lokacija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Naziv:";
            // 
            // chkZaIshranuStoke
            // 
            this.chkZaIshranuStoke.AutoSize = true;
            this.chkZaIshranuStoke.Location = new System.Drawing.Point(513, 172);
            this.chkZaIshranuStoke.Name = "chkZaIshranuStoke";
            this.chkZaIshranuStoke.Size = new System.Drawing.Size(127, 20);
            this.chkZaIshranuStoke.TabIndex = 89;
            this.chkZaIshranuStoke.Text = "Za ishranu stoke";
            this.chkZaIshranuStoke.UseVisualStyleBackColor = true;
            // 
            // chkZaProdaju
            // 
            this.chkZaProdaju.AutoSize = true;
            this.chkZaProdaju.Location = new System.Drawing.Point(762, 174);
            this.chkZaProdaju.Name = "chkZaProdaju";
            this.chkZaProdaju.Size = new System.Drawing.Size(94, 20);
            this.chkZaProdaju.TabIndex = 90;
            this.chkZaProdaju.Text = "Za prodaju";
            this.chkZaProdaju.UseVisualStyleBackColor = true;
            // 
            // cbxVrstaKrme
            // 
            this.cbxVrstaKrme.FormattingEnabled = true;
            this.cbxVrstaKrme.Items.AddRange(new object[] {
            "detelina",
            "lucerna"});
            this.cbxVrstaKrme.Location = new System.Drawing.Point(762, 38);
            this.cbxVrstaKrme.Name = "cbxVrstaKrme";
            this.cbxVrstaKrme.Size = new System.Drawing.Size(150, 24);
            this.cbxVrstaKrme.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 41);
            this.button1.TabIndex = 92;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Dodaj_Krmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxVrstaKrme);
            this.Controls.Add(this.chkZaProdaju);
            this.Controls.Add(this.chkZaIshranuStoke);
            this.Controls.Add(this.btnDodajKrmnoBilje);
            this.Controls.Add(this.numProcenatProteina);
            this.Controls.Add(this.numBrojKosnjiGodisnje);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.dtpDatumZetveStvarni);
            this.Controls.Add(this.dtpDatumZetvePlanirani);
            this.Controls.Add(this.dtpDatumSetve);
            this.Controls.Add(this.numPovrsina);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.txtKvalitetZemljista);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Dodaj_Krmu";
            this.Text = "Dodaj krmno bilje";
            ((System.ComponentModel.ISupportInitialize)(this.numProcenatProteina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojKosnjiGodisnje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajKrmnoBilje;
        private System.Windows.Forms.NumericUpDown numProcenatProteina;
        private System.Windows.Forms.NumericUpDown numBrojKosnjiGodisnje;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.DateTimePicker dtpDatumZetveStvarni;
        private System.Windows.Forms.DateTimePicker dtpDatumZetvePlanirani;
        private System.Windows.Forms.DateTimePicker dtpDatumSetve;
        private System.Windows.Forms.NumericUpDown numPovrsina;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.TextBox txtKvalitetZemljista;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkZaIshranuStoke;
        private System.Windows.Forms.CheckBox chkZaProdaju;
        private System.Windows.Forms.ComboBox cbxVrstaKrme;
        private System.Windows.Forms.Button button1;
    }
}