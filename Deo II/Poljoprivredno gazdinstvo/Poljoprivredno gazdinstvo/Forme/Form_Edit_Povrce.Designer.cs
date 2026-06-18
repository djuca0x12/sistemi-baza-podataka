namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Edit_Povrce
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
            this.btnIzmeniPovrce = new System.Windows.Forms.Button();
            this.cbxTipPovrca = new System.Windows.Forms.ComboBox();
            this.numBrojSetviGodisnje = new System.Windows.Forms.NumericUpDown();
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
            this.txtZastitneMere = new System.Windows.Forms.TextBox();
            this.cbxNacinGajenja = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSetviGodisnje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmeniPovrce
            // 
            this.btnIzmeniPovrce.Location = new System.Drawing.Point(592, 281);
            this.btnIzmeniPovrce.Name = "btnIzmeniPovrce";
            this.btnIzmeniPovrce.Size = new System.Drawing.Size(154, 41);
            this.btnIzmeniPovrce.TabIndex = 90;
            this.btnIzmeniPovrce.Text = "Izmeni povrće";
            this.btnIzmeniPovrce.UseVisualStyleBackColor = true;
            this.btnIzmeniPovrce.Click += new System.EventHandler(this.btnIzmeniPovrce_Click);
            // 
            // cbxTipPovrca
            // 
            this.cbxTipPovrca.FormattingEnabled = true;
            this.cbxTipPovrca.Items.AddRange(new object[] {
            "korenasto",
            "lisnato",
            "plodovito"});
            this.cbxTipPovrca.Location = new System.Drawing.Point(596, 171);
            this.cbxTipPovrca.Name = "cbxTipPovrca";
            this.cbxTipPovrca.Size = new System.Drawing.Size(150, 24);
            this.cbxTipPovrca.TabIndex = 89;
            // 
            // numBrojSetviGodisnje
            // 
            this.numBrojSetviGodisnje.Location = new System.Drawing.Point(596, 40);
            this.numBrojSetviGodisnje.Name = "numBrojSetviGodisnje";
            this.numBrojSetviGodisnje.Size = new System.Drawing.Size(150, 22);
            this.numBrojSetviGodisnje.TabIndex = 86;
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
            this.cbxStatus.TabIndex = 85;
            // 
            // dtpDatumZetveStvarni
            // 
            this.dtpDatumZetveStvarni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZetveStvarni.Location = new System.Drawing.Point(200, 301);
            this.dtpDatumZetveStvarni.Name = "dtpDatumZetveStvarni";
            this.dtpDatumZetveStvarni.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumZetveStvarni.TabIndex = 84;
            // 
            // dtpDatumZetvePlanirani
            // 
            this.dtpDatumZetvePlanirani.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZetvePlanirani.Location = new System.Drawing.Point(200, 258);
            this.dtpDatumZetvePlanirani.Name = "dtpDatumZetvePlanirani";
            this.dtpDatumZetvePlanirani.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumZetvePlanirani.TabIndex = 83;
            // 
            // dtpDatumSetve
            // 
            this.dtpDatumSetve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumSetve.Location = new System.Drawing.Point(200, 215);
            this.dtpDatumSetve.Name = "dtpDatumSetve";
            this.dtpDatumSetve.Size = new System.Drawing.Size(150, 22);
            this.dtpDatumSetve.TabIndex = 82;
            // 
            // numPovrsina
            // 
            this.numPovrsina.Location = new System.Drawing.Point(200, 129);
            this.numPovrsina.Name = "numPovrsina";
            this.numPovrsina.Size = new System.Drawing.Size(150, 22);
            this.numPovrsina.TabIndex = 81;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(200, 389);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(150, 22);
            this.txtKomentar.TabIndex = 80;
            // 
            // txtKvalitetZemljista
            // 
            this.txtKvalitetZemljista.Location = new System.Drawing.Point(200, 172);
            this.txtKvalitetZemljista.Name = "txtKvalitetZemljista";
            this.txtKvalitetZemljista.Size = new System.Drawing.Size(150, 22);
            this.txtKvalitetZemljista.TabIndex = 79;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(200, 82);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(150, 22);
            this.txtLokacija.TabIndex = 78;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(200, 39);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(150, 22);
            this.txtNaziv.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 394);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 16);
            this.label18.TabIndex = 76;
            this.label18.Text = "Komentar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 75;
            this.label13.Text = "Tip:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 74;
            this.label12.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 73;
            this.label11.Text = "Stvarni datum žetve:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "Planirani datum žetve:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 71;
            this.label9.Text = "Zaštitne mere:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "Način gajenja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Broj setvi godišnje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Datum setve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Kvalitet zemljišta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Površina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Lokacija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Naziv:";
            // 
            // txtZastitneMere
            // 
            this.txtZastitneMere.Location = new System.Drawing.Point(596, 82);
            this.txtZastitneMere.Name = "txtZastitneMere";
            this.txtZastitneMere.Size = new System.Drawing.Size(150, 22);
            this.txtZastitneMere.TabIndex = 91;
            // 
            // cbxNacinGajenja
            // 
            this.cbxNacinGajenja.FormattingEnabled = true;
            this.cbxNacinGajenja.Items.AddRange(new object[] {
            "na otvorenom",
            "plastenik"});
            this.cbxNacinGajenja.Location = new System.Drawing.Point(596, 128);
            this.cbxNacinGajenja.Name = "cbxNacinGajenja";
            this.cbxNacinGajenja.Size = new System.Drawing.Size(150, 24);
            this.cbxNacinGajenja.TabIndex = 92;
            // 
            // Form_Edit_Povrce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxNacinGajenja);
            this.Controls.Add(this.txtZastitneMere);
            this.Controls.Add(this.btnIzmeniPovrce);
            this.Controls.Add(this.cbxTipPovrca);
            this.Controls.Add(this.numBrojSetviGodisnje);
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
            this.Name = "Form_Edit_Povrce";
            this.Text = "Izmeni povrće";
            this.Load += new System.EventHandler(this.Form_Edit_Povrce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSetviGodisnje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIzmeniPovrce;
        private System.Windows.Forms.ComboBox cbxTipPovrca;
        private System.Windows.Forms.NumericUpDown numBrojSetviGodisnje;
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
        private System.Windows.Forms.TextBox txtZastitneMere;
        private System.Windows.Forms.ComboBox cbxNacinGajenja;
    }
}