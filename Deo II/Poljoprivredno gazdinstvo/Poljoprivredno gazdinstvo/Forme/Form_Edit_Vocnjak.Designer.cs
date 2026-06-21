namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Edit_Vocnjak
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
            this.dtpDatumRezidbe = new System.Windows.Forms.DateTimePicker();
            this.txtRodniCiklus = new System.Windows.Forms.TextBox();
            this.txtSorta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzmeniVocnjak = new System.Windows.Forms.Button();
            this.numBrojStabala = new System.Windows.Forms.NumericUpDown();
            this.numGodinaSadnje = new System.Windows.Forms.NumericUpDown();
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
            this.label13 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numBrojStabala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaSadnje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatumRezidbe
            // 
            this.dtpDatumRezidbe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRezidbe.Location = new System.Drawing.Point(596, 172);
            this.dtpDatumRezidbe.Name = "dtpDatumRezidbe";
            this.dtpDatumRezidbe.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumRezidbe.TabIndex = 121;
            // 
            // txtRodniCiklus
            // 
            this.txtRodniCiklus.Location = new System.Drawing.Point(596, 218);
            this.txtRodniCiklus.Name = "txtRodniCiklus";
            this.txtRodniCiklus.Size = new System.Drawing.Size(150, 22);
            this.txtRodniCiklus.TabIndex = 120;
            // 
            // txtSorta
            // 
            this.txtSorta.Location = new System.Drawing.Point(596, 130);
            this.txtSorta.Name = "txtSorta";
            this.txtSorta.Size = new System.Drawing.Size(150, 22);
            this.txtSorta.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 118;
            this.label3.Text = "Rodni ciklus:";
            // 
            // btnIzmeniVocnjak
            // 
            this.btnIzmeniVocnjak.Location = new System.Drawing.Point(592, 281);
            this.btnIzmeniVocnjak.Name = "btnIzmeniVocnjak";
            this.btnIzmeniVocnjak.Size = new System.Drawing.Size(154, 41);
            this.btnIzmeniVocnjak.TabIndex = 117;
            this.btnIzmeniVocnjak.Text = "Izmeni voćnjak";
            this.btnIzmeniVocnjak.UseVisualStyleBackColor = true;
            this.btnIzmeniVocnjak.Click += new System.EventHandler(this.btnIzmeniVocnjak_Click);
            // 
            // numBrojStabala
            // 
            this.numBrojStabala.Location = new System.Drawing.Point(596, 83);
            this.numBrojStabala.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBrojStabala.Name = "numBrojStabala";
            this.numBrojStabala.Size = new System.Drawing.Size(150, 22);
            this.numBrojStabala.TabIndex = 116;
            // 
            // numGodinaSadnje
            // 
            this.numGodinaSadnje.Location = new System.Drawing.Point(596, 40);
            this.numGodinaSadnje.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numGodinaSadnje.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numGodinaSadnje.Name = "numGodinaSadnje";
            this.numGodinaSadnje.Size = new System.Drawing.Size(150, 22);
            this.numGodinaSadnje.TabIndex = 115;
            this.numGodinaSadnje.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "u toku",
            "zavrseno",
            "otkazano"});
            this.cbxStatus.Location = new System.Drawing.Point(200, 344);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(150, 24);
            this.cbxStatus.TabIndex = 114;
            // 
            // dtpDatumZetveStvarni
            // 
            this.dtpDatumZetveStvarni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZetveStvarni.Location = new System.Drawing.Point(200, 301);
            this.dtpDatumZetveStvarni.Name = "dtpDatumZetveStvarni";
            this.dtpDatumZetveStvarni.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumZetveStvarni.TabIndex = 113;
            // 
            // dtpDatumZetvePlanirani
            // 
            this.dtpDatumZetvePlanirani.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZetvePlanirani.Location = new System.Drawing.Point(200, 258);
            this.dtpDatumZetvePlanirani.Name = "dtpDatumZetvePlanirani";
            this.dtpDatumZetvePlanirani.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumZetvePlanirani.TabIndex = 112;
            // 
            // dtpDatumSetve
            // 
            this.dtpDatumSetve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumSetve.Location = new System.Drawing.Point(200, 215);
            this.dtpDatumSetve.Name = "dtpDatumSetve";
            this.dtpDatumSetve.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumSetve.TabIndex = 111;
            // 
            // numPovrsina
            // 
            this.numPovrsina.Location = new System.Drawing.Point(200, 129);
            this.numPovrsina.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPovrsina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPovrsina.Name = "numPovrsina";
            this.numPovrsina.Size = new System.Drawing.Size(150, 22);
            this.numPovrsina.TabIndex = 110;
            this.numPovrsina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(200, 389);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(150, 22);
            this.txtKomentar.TabIndex = 109;
            // 
            // txtKvalitetZemljista
            // 
            this.txtKvalitetZemljista.Location = new System.Drawing.Point(200, 172);
            this.txtKvalitetZemljista.Name = "txtKvalitetZemljista";
            this.txtKvalitetZemljista.Size = new System.Drawing.Size(150, 22);
            this.txtKvalitetZemljista.TabIndex = 108;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(200, 82);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(150, 22);
            this.txtLokacija.TabIndex = 107;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(200, 39);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(150, 22);
            this.txtNaziv.TabIndex = 106;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 394);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 16);
            this.label18.TabIndex = 105;
            this.label18.Text = "Komentar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 104;
            this.label13.Text = "Datum rezidbe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 103;
            this.label12.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "Stvarni datum žetve:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "Planirani datum žetve:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 100;
            this.label9.Text = "Broj stabala:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "Sorta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 98;
            this.label7.Text = "Godina sadnje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 97;
            this.label6.Text = "Datum setve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 96;
            this.label5.Text = "Kvalitet zemljišta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 95;
            this.label4.Text = "Površina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Lokacija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Naziv:";
            // 
            // Form_Edit_Vocnjak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDatumRezidbe);
            this.Controls.Add(this.txtRodniCiklus);
            this.Controls.Add(this.txtSorta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzmeniVocnjak);
            this.Controls.Add(this.numBrojStabala);
            this.Controls.Add(this.numGodinaSadnje);
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
            this.Controls.Add(this.label13);
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
            this.Name = "Form_Edit_Vocnjak";
            this.Text = "Form_Edit_Vocnjak";
            this.Load += new System.EventHandler(this.Form_Edit_Vocnjak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBrojStabala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaSadnje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumRezidbe;
        private System.Windows.Forms.TextBox txtRodniCiklus;
        private System.Windows.Forms.TextBox txtSorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzmeniVocnjak;
        private System.Windows.Forms.NumericUpDown numBrojStabala;
        private System.Windows.Forms.NumericUpDown numGodinaSadnje;
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
        private System.Windows.Forms.Label label13;
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
    }
}